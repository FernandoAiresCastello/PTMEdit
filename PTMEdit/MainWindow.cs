using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTMEdit
{
    public partial class MainWindow : Form
    {
        private readonly string TabSpacesLiteral = new string(' ', 4);
        private readonly string ConfigFile = "config.ini";

        private string FileSystemRoot;
        private string ProgramFile;
        private string PtmExecutablePath;
        private bool FileHasUnsavedChanges;

        public MainWindow()
        {
            InitializeComponent();
            FormClosing += MainWindow_FormClosing;
            LstFiles.ColumnClick += LstFiles_ColumnClick;
            TxtProgram.MaxLength = int.MaxValue;

            TileEditorPanel tileEditor = new TileEditorPanel(TabTool1);
            PaletteEditorPanel palEditor = new PaletteEditorPanel(TabTool2);
            HelpPanel helpPanel = new HelpPanel(TabTool3);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!LoadConfig())
            {
                PtmExecutablePath = null;
                SetFileSystemRoot(null);
                LoadProgram(null);
            }

            StartPosition = FormStartPosition.CenterScreen;
            Show();
        }

        private bool LoadConfig()
        {
            if (!File.Exists(ConfigFile))
                return false;

            var lines = File.ReadAllLines(ConfigFile);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var cfg = line.Trim().Split('=');

                if (cfg.Length != 2)
                {
                    ShowErrorInvalidConfigFile();
                    return false;
                }

                string key = cfg[0].Trim().ToLower();
                string value = cfg[1].Trim();

                if (key.StartsWith('#'))
                    continue;

                if (key == "ptm_exe")
                    PtmExecutablePath = value;
                else if (key == "prg_folder")
                    SetFileSystemRoot(value);
                else if (key == "initial_prg")
                    LoadProgram(value);
                else if (key == "show_file_list")
                    ScFileAndProgEdit.Panel1Collapsed = value != "true";
                else if (key == "show_tools")
                    ScMainAndTools.Panel2Collapsed = value != "true";
                else if (key == "show_editor_toolbar")
                    TxtProgramToolBar.Visible = value == "true";
                else if (key == "window_color")
                    PnlRoot.BackColor = ParseColorRgbHex(value);
                else if (key == "text_color")
                    TxtProgram.ForeColor = ParseColorRgbHex(value);
                else if (key == "back_color")
                    TxtProgram.BackColor = ParseColorRgbHex(value);
                else if (key == "font_size")
                    TxtProgram.Font = new Font(TxtProgram.Font.FontFamily, int.Parse(value));
                else if (key == "font_family")
                    TxtProgram.Font = new Font(value, TxtProgram.Font.Size);
                else if (key == "window_w")
                    Width = int.Parse(value);
                else if (key == "window_h")
                    Height = int.Parse(value);
                else if (key == "window_max")
                    WindowState = value == "true" ? FormWindowState.Maximized : FormWindowState.Normal;
                else
                {
                    ShowErrorInvalidConfigFile();
                    return false;
                }
            }

            return true;
        }

        private Color ParseColorRgbHex(string hex)
        {
            hex = "FF" + hex.Substring(2);
            int color = int.Parse(hex, System.Globalization.NumberStyles.AllowHexSpecifier);
            return Color.FromArgb(color);
        }

        private void ShowErrorInvalidConfigFile()
        {
            MessageBox.Show(this, "Invalid configuration file", 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowErrorPathNotFound(string path)
        {
            MessageBox.Show(this, "The specified path was not found:\n\n" + path, 
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LstFiles_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SelectFileSystemRoot();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnApplicationExit(e);
        }

        private void SetFileSystemRoot(string directoryPath)
        {
            string defaultRoot = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (directoryPath == null)
            {
                directoryPath = defaultRoot;
            }
            else if (!Directory.Exists(directoryPath))
            {
                ShowErrorPathNotFound(directoryPath);
                directoryPath = defaultRoot;
            }

            FileSystemRoot = directoryPath;
            UpdateFileList();
        }

        private void UpdateFileList()
        {
            LstFiles.Items.Clear();
            LstFiles.Columns[0].Text = FileSystemRoot;

            var files = Directory.GetFiles(FileSystemRoot);

            foreach (var filePath in files)
            {
                string file = Path.GetFileName(filePath);
                LstFiles.Items.Add(filePath, file, 1);
            }

            LstFiles.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
        }

        private void OnFileModified(bool unsavedFile)
        {
            Text = "PTMEdit - ";
            
            if (ProgramFile != null)
                Text += ProgramFile;
            else
                Text += "(new file)";
            
            if (unsavedFile)
                Text += " *";

            FileHasUnsavedChanges = unsavedFile;
        }

        private void LoadProgram(string path)
        {
            if (path != null)
            {
                if (File.Exists(path))
                {
                    string program = File.ReadAllText(path);
                    program = program.Replace("\t", TabSpacesLiteral);
                    TxtProgram.Text = program;
                    TxtProgram.Select(0, 0);
                    FindLabels();
                }
                else
                {
                    ShowErrorPathNotFound(path);
                    path = null;
                }
            }

            ProgramFile = path;
            OnFileModified(false);
        }

        private void MenuBtnRun_Click(object sender, EventArgs e)
        {
            SaveAndRunProgram();
        }

        private void SaveAndRunProgram()
        {
            SaveProgram();
            RunProgram();
        }

        private void SaveProgram()
        {
            if (ProgramFile == null)
            {
                SaveProgramAs();
            }
            else
            {
                File.WriteAllText(ProgramFile, TxtProgram.Text);
                OnFileModified(false);
            }
        }

        private void SaveProgramAs()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = FileSystemRoot;
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            
            ProgramFile = dialog.FileName;
            SaveProgram();
            UpdateFileList();
        }

        private void RunProgram()
        {
            if (ProgramFile == null)
                return;

            if (PtmExecutablePath == null)
            {
                MessageBox.Show(this, "The PTM executable path is not defined",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!File.Exists(PtmExecutablePath))
            {
                MessageBox.Show(this, "The specified PTM executable was not found:\n\n" + PtmExecutablePath,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(PtmExecutablePath, $"\"{ProgramFile}\"");
            }
        }

        private void LstFiles_DoubleClick(object sender, EventArgs e)
        {
            if (LstFiles.SelectedItems.Count <= 0)
                return;
            if (ConfirmUnsavedChanges() == DialogResult.Cancel)
                return;

            string file = LstFiles.SelectedItems[0].Text;
            string path = Path.Combine(FileSystemRoot, file);
            
            LoadProgram(path);
            LstFiles.SelectedItems.Clear();
            TxtProgram.Focus();
        }

        private DialogResult ConfirmUnsavedChanges()
        {
            if (!FileHasUnsavedChanges)
                return DialogResult.No;

            DialogResult result = MessageBox.Show("The current file has unsaved changes.\n\nSave now?",
                "Unsaved file", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                SaveProgram();

            return result;
        }

        private void MenuBtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnApplicationExit(FormClosingEventArgs e)
        {
            if (ConfirmUnsavedChanges() == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        private void TxtProgram_TextChanged(object sender, EventArgs e)
        {
            OnFileModified(true);
        }

        private void MenuBtnSave_Click(object sender, EventArgs e)
        {
            SaveProgram();
        }

        private void MenuBtnSaveAs_Click(object sender, EventArgs e)
        {
            SaveProgramAs();
        }

        private void SelectFileSystemRoot()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select program folder";
            dialog.UseDescriptionForTitle = true;
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            SetFileSystemRoot(dialog.SelectedPath);
        }

        private void MenuBtnNew_Click(object sender, EventArgs e)
        {
            if (ConfirmUnsavedChanges() == DialogResult.Cancel)
                return;

            TxtProgram.Clear();
            ProgramFile = null;
            OnFileModified(true);
        }

        private void TxtProgram_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SendKeys.Send(TabSpacesLiteral);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                int lineIx = TxtProgram.GetLineFromCharIndex(TxtProgram.SelectionStart);
                string line = TxtProgram.Lines.Count() > 0 ? TxtProgram.Lines[lineIx] : "";
                int identLen = 0;

                foreach (char ch in line)
                {
                    if (char.IsWhiteSpace(ch))
                        identLen++;
                    else
                        break;
                }

                int firstIx = TxtProgram.GetFirstCharIndexOfCurrentLine();
                int caretIx = TxtProgram.SelectionStart - firstIx;
                if (caretIx >= identLen)
                    SendKeys.Send(new string(' ', identLen));
            }
        }

        private void MenuBtnTglFileList_Click(object sender, EventArgs e)
        {
            ScFileAndProgEdit.Panel1Collapsed = !ScFileAndProgEdit.Panel1Collapsed;
        }

        private void MenuBtnTglTools_Click(object sender, EventArgs e)
        {
            ScMainAndTools.Panel2Collapsed = !ScMainAndTools.Panel2Collapsed;
        }

        private void MenuBtnEditCfg_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", ConfigFile);
        }

        private void BtnSaveRun_Click(object sender, EventArgs e)
        {
            SaveAndRunProgram();
        }

        private struct Subroutine
        {
            public int Line { set; get; }
            public string Label { set; get; }

            public Subroutine(int line, string label)
            {
                Line = line;
                Label = label;
            }

            public override string ToString()
            {
                return Label;
            }
        }

        private void CmbSubroutines_DropDown(object sender, EventArgs e)
        {
            FindLabels();
        }

        private void FindLabels()
        {
            CmbSubroutines.Items.Clear();

            int lineIndex = -1;

            foreach (var src in TxtProgram.Lines)
            {
                lineIndex++;
                string line = src.Trim();
                if (string.IsNullOrEmpty(line))
                    continue;

                if (line.EndsWith(':'))
                {
                    string label = line.Substring(0, line.Length - 1);
                    CmbSubroutines.Items.Add(new Subroutine(lineIndex, label));
                }
            }

            CmbSubroutines.Sorted = true;
        }

        private void CmbSubroutines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbSubroutines.SelectedItem == null)
                return;

            Subroutine sub = (Subroutine)CmbSubroutines.SelectedItem;
            GotoLineNumber(sub.Line);
            TxtProgram.Focus();
        }

        private void GotoLineNumber(int number)
        {
            TxtProgram.HideSelection = false;
            TxtProgram.SelectionStart = TxtProgram.GetFirstCharIndexFromLine(number);
            TxtProgram.SelectionLength = TxtProgram.Lines[number].Length;
            TxtProgram.ScrollToCaret();
        }

        private void TxtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                string text = TxtFind.Text.ToLower();
                if (text.Trim() == string.Empty)
                    return;

                int startIndex = TxtProgram.SelectionStart + TxtProgram.SelectionLength;
                int index = TxtProgram.Text.IndexOf(text, startIndex, StringComparison.InvariantCultureIgnoreCase);
                if (index < 0)
                    return;

                TxtProgram.HideSelection = false;
                TxtProgram.SelectionStart = index;
                TxtProgram.SelectionLength = text.Length;
                TxtProgram.ScrollToCaret();
            }
        }

        private void MenuBtnFontInc_Click(object sender, EventArgs e)
        {
            if (TxtProgram.Font.Size + 1.0f < 64.0f)
                TxtProgram.Font = new Font(TxtProgram.Font.FontFamily, TxtProgram.Font.Size + 1.0f);
        }

        private void MenuBtnFontDec_Click(object sender, EventArgs e)
        {
            if (TxtProgram.Font.Size - 1.0f > 0.0f)
                TxtProgram.Font = new Font(TxtProgram.Font.FontFamily, TxtProgram.Font.Size - 1.0f);
        }

        private void MenuBtnToggleToolBar_Click(object sender, EventArgs e)
        {
            TxtProgramToolBar.Visible = !TxtProgramToolBar.Visible;
        }

        private void MenuBtnGotoLineNr_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void MenuBtnTextFg_Click(object sender, EventArgs e)
        {
            TxtProgram.ForeColor = ShowColorPicker(TxtProgram.ForeColor);
        }

        private void MenuBtnTextBg_Click(object sender, EventArgs e)
        {
            TxtProgram.BackColor = ShowColorPicker(TxtProgram.BackColor);
        }

        private void MenuBtnWindowColor_Click(object sender, EventArgs e)
        {
            PnlRoot.BackColor = ShowColorPicker(PnlRoot.BackColor);
        }

        private Color ShowColorPicker(Color initialColor)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = initialColor;
            if (dialog.ShowDialog() == DialogResult.OK)
                return dialog.Color;

            return initialColor;
        }
    }
}
