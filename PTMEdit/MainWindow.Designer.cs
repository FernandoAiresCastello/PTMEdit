
namespace PTMEdit
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBtnEditCfg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuBtnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnSaveRun = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnTglFileList = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnTglTools = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnToggleToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnFontInc = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnFontDec = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnGotoLineNr = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PnlRoot = new System.Windows.Forms.TableLayoutPanel();
            this.ScMainAndTools = new System.Windows.Forms.SplitContainer();
            this.ScFileAndProgEdit = new System.Windows.Forms.SplitContainer();
            this.LstFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader(0);
            this.FilePanelIcons = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtProgramToolBar = new System.Windows.Forms.ToolStrip();
            this.BtnSaveRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.CmbSubroutines = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.TxtFind = new System.Windows.Forms.ToolStripTextBox();
            this.TxtProgram = new System.Windows.Forms.TextBox();
            this.ToolTabsControl = new System.Windows.Forms.TabControl();
            this.TabTool1 = new System.Windows.Forms.TabPage();
            this.TabTool2 = new System.Windows.Forms.TabPage();
            this.TabTool3 = new System.Windows.Forms.TabPage();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnTextFg = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnTextBg = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnWindowColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.PnlRoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScMainAndTools)).BeginInit();
            this.ScMainAndTools.Panel1.SuspendLayout();
            this.ScMainAndTools.Panel2.SuspendLayout();
            this.ScMainAndTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScFileAndProgEdit)).BeginInit();
            this.ScFileAndProgEdit.Panel1.SuspendLayout();
            this.ScFileAndProgEdit.Panel2.SuspendLayout();
            this.ScFileAndProgEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.TxtProgramToolBar.SuspendLayout();
            this.ToolTabsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.codeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBtnNew,
            this.MenuBtnSave,
            this.MenuBtnSaveAs,
            this.toolStripSeparator1,
            this.MenuBtnEditCfg,
            this.toolStripSeparator2,
            this.MenuBtnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MenuBtnNew
            // 
            this.MenuBtnNew.Image = global::PTMEdit.Properties.Resources.page_white_add;
            this.MenuBtnNew.Name = "MenuBtnNew";
            this.MenuBtnNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuBtnNew.Size = new System.Drawing.Size(193, 22);
            this.MenuBtnNew.Text = "New";
            this.MenuBtnNew.Click += new System.EventHandler(this.MenuBtnNew_Click);
            // 
            // MenuBtnSave
            // 
            this.MenuBtnSave.Image = global::PTMEdit.Properties.Resources.diskette;
            this.MenuBtnSave.Name = "MenuBtnSave";
            this.MenuBtnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuBtnSave.Size = new System.Drawing.Size(193, 22);
            this.MenuBtnSave.Text = "Save";
            this.MenuBtnSave.Click += new System.EventHandler(this.MenuBtnSave_Click);
            // 
            // MenuBtnSaveAs
            // 
            this.MenuBtnSaveAs.Image = global::PTMEdit.Properties.Resources.file_save_as;
            this.MenuBtnSaveAs.Name = "MenuBtnSaveAs";
            this.MenuBtnSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuBtnSaveAs.Size = new System.Drawing.Size(193, 22);
            this.MenuBtnSaveAs.Text = "Save as...";
            this.MenuBtnSaveAs.Click += new System.EventHandler(this.MenuBtnSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // MenuBtnEditCfg
            // 
            this.MenuBtnEditCfg.Image = global::PTMEdit.Properties.Resources.cog_edit;
            this.MenuBtnEditCfg.Name = "MenuBtnEditCfg";
            this.MenuBtnEditCfg.Size = new System.Drawing.Size(193, 22);
            this.MenuBtnEditCfg.Text = "Edit config file";
            this.MenuBtnEditCfg.Click += new System.EventHandler(this.MenuBtnEditCfg_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // MenuBtnExit
            // 
            this.MenuBtnExit.Image = global::PTMEdit.Properties.Resources.cross;
            this.MenuBtnExit.Name = "MenuBtnExit";
            this.MenuBtnExit.Size = new System.Drawing.Size(193, 22);
            this.MenuBtnExit.Text = "Exit";
            this.MenuBtnExit.Click += new System.EventHandler(this.MenuBtnExit_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBtnSaveRun});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // MenuBtnSaveRun
            // 
            this.MenuBtnSaveRun.Image = global::PTMEdit.Properties.Resources.application_go;
            this.MenuBtnSaveRun.Name = "MenuBtnSaveRun";
            this.MenuBtnSaveRun.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MenuBtnSaveRun.Size = new System.Drawing.Size(161, 22);
            this.MenuBtnSaveRun.Text = "Save and run";
            this.MenuBtnSaveRun.Click += new System.EventHandler(this.MenuBtnRun_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBtnTglFileList,
            this.MenuBtnTglTools,
            this.MenuBtnToggleToolBar,
            this.toolStripSeparator4,
            this.fontToolStripMenuItem,
            this.colorsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // MenuBtnTglFileList
            // 
            this.MenuBtnTglFileList.Image = global::PTMEdit.Properties.Resources.page_white_stack;
            this.MenuBtnTglFileList.Name = "MenuBtnTglFileList";
            this.MenuBtnTglFileList.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.MenuBtnTglFileList.Size = new System.Drawing.Size(180, 22);
            this.MenuBtnTglFileList.Text = "Toggle file list";
            this.MenuBtnTglFileList.Click += new System.EventHandler(this.MenuBtnTglFileList_Click);
            // 
            // MenuBtnTglTools
            // 
            this.MenuBtnTglTools.Image = global::PTMEdit.Properties.Resources.setting_tools;
            this.MenuBtnTglTools.Name = "MenuBtnTglTools";
            this.MenuBtnTglTools.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.MenuBtnTglTools.Size = new System.Drawing.Size(180, 22);
            this.MenuBtnTglTools.Text = "Toggle tools";
            this.MenuBtnTglTools.Click += new System.EventHandler(this.MenuBtnTglTools_Click);
            // 
            // MenuBtnToggleToolBar
            // 
            this.MenuBtnToggleToolBar.Image = global::PTMEdit.Properties.Resources.toolbar;
            this.MenuBtnToggleToolBar.Name = "MenuBtnToggleToolBar";
            this.MenuBtnToggleToolBar.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.MenuBtnToggleToolBar.Size = new System.Drawing.Size(180, 22);
            this.MenuBtnToggleToolBar.Text = "Toggle toolbar";
            this.MenuBtnToggleToolBar.Click += new System.EventHandler(this.MenuBtnToggleToolBar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBtnFontInc,
            this.MenuBtnFontDec});
            this.fontToolStripMenuItem.Image = global::PTMEdit.Properties.Resources.font;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // MenuBtnFontInc
            // 
            this.MenuBtnFontInc.Image = global::PTMEdit.Properties.Resources.font_size_decrease;
            this.MenuBtnFontInc.Name = "MenuBtnFontInc";
            this.MenuBtnFontInc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.MenuBtnFontInc.Size = new System.Drawing.Size(206, 22);
            this.MenuBtnFontInc.Text = "Larger";
            this.MenuBtnFontInc.Click += new System.EventHandler(this.MenuBtnFontInc_Click);
            // 
            // MenuBtnFontDec
            // 
            this.MenuBtnFontDec.Image = global::PTMEdit.Properties.Resources.font_size_increase;
            this.MenuBtnFontDec.Name = "MenuBtnFontDec";
            this.MenuBtnFontDec.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.MenuBtnFontDec.Size = new System.Drawing.Size(206, 22);
            this.MenuBtnFontDec.Text = "Smaller";
            this.MenuBtnFontDec.Click += new System.EventHandler(this.MenuBtnFontDec_Click);
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBtnGotoLineNr});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.codeToolStripMenuItem.Text = "Navigation";
            // 
            // MenuBtnGotoLineNr
            // 
            this.MenuBtnGotoLineNr.Image = global::PTMEdit.Properties.Resources.text_list_numbers;
            this.MenuBtnGotoLineNr.Name = "MenuBtnGotoLineNr";
            this.MenuBtnGotoLineNr.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.MenuBtnGotoLineNr.Size = new System.Drawing.Size(212, 22);
            this.MenuBtnGotoLineNr.Text = "Go to line number";
            this.MenuBtnGotoLineNr.Click += new System.EventHandler(this.MenuBtnGotoLineNr_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 660);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1134, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // PnlRoot
            // 
            this.PnlRoot.BackColor = System.Drawing.SystemColors.Control;
            this.PnlRoot.ColumnCount = 1;
            this.PnlRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.125F));
            this.PnlRoot.Controls.Add(this.ScMainAndTools, 0, 1);
            this.PnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlRoot.Location = new System.Drawing.Point(0, 24);
            this.PnlRoot.Margin = new System.Windows.Forms.Padding(0);
            this.PnlRoot.Name = "PnlRoot";
            this.PnlRoot.RowCount = 2;
            this.PnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 427F));
            this.PnlRoot.Size = new System.Drawing.Size(1134, 636);
            this.PnlRoot.TabIndex = 2;
            // 
            // ScMainAndTools
            // 
            this.ScMainAndTools.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.ScMainAndTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScMainAndTools.Location = new System.Drawing.Point(20, 20);
            this.ScMainAndTools.Margin = new System.Windows.Forms.Padding(20);
            this.ScMainAndTools.Name = "ScMainAndTools";
            // 
            // ScMainAndTools.Panel1
            // 
            this.ScMainAndTools.Panel1.Controls.Add(this.ScFileAndProgEdit);
            // 
            // ScMainAndTools.Panel2
            // 
            this.ScMainAndTools.Panel2.Controls.Add(this.ToolTabsControl);
            this.ScMainAndTools.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ScMainAndTools.Size = new System.Drawing.Size(1094, 596);
            this.ScMainAndTools.SplitterDistance = 856;
            this.ScMainAndTools.TabIndex = 1;
            this.ScMainAndTools.TabStop = false;
            // 
            // ScFileAndProgEdit
            // 
            this.ScFileAndProgEdit.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.ScFileAndProgEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScFileAndProgEdit.Location = new System.Drawing.Point(0, 0);
            this.ScFileAndProgEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ScFileAndProgEdit.Name = "ScFileAndProgEdit";
            // 
            // ScFileAndProgEdit.Panel1
            // 
            this.ScFileAndProgEdit.Panel1.Controls.Add(this.LstFiles);
            // 
            // ScFileAndProgEdit.Panel2
            // 
            this.ScFileAndProgEdit.Panel2.Controls.Add(this.panel1);
            this.ScFileAndProgEdit.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ScFileAndProgEdit.Panel2.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.ScFileAndProgEdit.Size = new System.Drawing.Size(856, 596);
            this.ScFileAndProgEdit.SplitterDistance = 218;
            this.ScFileAndProgEdit.TabIndex = 0;
            this.ScFileAndProgEdit.TabStop = false;
            // 
            // LstFiles
            // 
            this.LstFiles.BackColor = System.Drawing.SystemColors.Window;
            this.LstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LstFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.LstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstFiles.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstFiles.FullRowSelect = true;
            this.LstFiles.GridLines = true;
            this.LstFiles.HideSelection = false;
            this.LstFiles.LabelWrap = false;
            this.LstFiles.LargeImageList = this.FilePanelIcons;
            this.LstFiles.Location = new System.Drawing.Point(0, 0);
            this.LstFiles.Margin = new System.Windows.Forms.Padding(0);
            this.LstFiles.MultiSelect = false;
            this.LstFiles.Name = "LstFiles";
            this.LstFiles.Scrollable = false;
            this.LstFiles.Size = new System.Drawing.Size(218, 596);
            this.LstFiles.SmallImageList = this.FilePanelIcons;
            this.LstFiles.TabIndex = 1;
            this.LstFiles.TabStop = false;
            this.LstFiles.UseCompatibleStateImageBehavior = false;
            this.LstFiles.View = System.Windows.Forms.View.Details;
            this.LstFiles.DoubleClick += new System.EventHandler(this.LstFiles_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 2000;
            // 
            // FilePanelIcons
            // 
            this.FilePanelIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.FilePanelIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FilePanelIcons.ImageStream")));
            this.FilePanelIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.FilePanelIcons.Images.SetKeyName(0, "folder.png");
            this.FilePanelIcons.Images.SetKeyName(1, "page_white.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(15, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 596);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TxtProgramToolBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtProgram, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 596);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // TxtProgramToolBar
            // 
            this.TxtProgramToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TxtProgramToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSaveRun,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.CmbSubroutines,
            this.toolStripLabel2,
            this.TxtFind});
            this.TxtProgramToolBar.Location = new System.Drawing.Point(0, 0);
            this.TxtProgramToolBar.Name = "TxtProgramToolBar";
            this.TxtProgramToolBar.Padding = new System.Windows.Forms.Padding(7, 3, 5, 3);
            this.TxtProgramToolBar.Size = new System.Drawing.Size(604, 29);
            this.TxtProgramToolBar.TabIndex = 1;
            this.TxtProgramToolBar.Text = "toolStrip1";
            // 
            // BtnSaveRun
            // 
            this.BtnSaveRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSaveRun.Image = global::PTMEdit.Properties.Resources.application_go;
            this.BtnSaveRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSaveRun.Name = "BtnSaveRun";
            this.BtnSaveRun.Size = new System.Drawing.Size(23, 20);
            this.BtnSaveRun.Text = "Save & Run (F5)";
            this.BtnSaveRun.ToolTipText = "Save & Run (F5)";
            this.BtnSaveRun.Click += new System.EventHandler(this.BtnSaveRun_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(76, 20);
            this.toolStripLabel1.Text = "Subroutines :";
            // 
            // CmbSubroutines
            // 
            this.CmbSubroutines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSubroutines.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbSubroutines.Name = "CmbSubroutines";
            this.CmbSubroutines.Size = new System.Drawing.Size(200, 23);
            this.CmbSubroutines.DropDown += new System.EventHandler(this.CmbSubroutines_DropDown);
            this.CmbSubroutines.SelectedIndexChanged += new System.EventHandler(this.CmbSubroutines_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Image = global::PTMEdit.Properties.Resources.page_white_magnify;
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(8, 1, 5, 2);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(16, 20);
            // 
            // TxtFind
            // 
            this.TxtFind.AcceptsReturn = true;
            this.TxtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFind.Name = "TxtFind";
            this.TxtFind.Size = new System.Drawing.Size(200, 23);
            this.TxtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFind_KeyDown);
            // 
            // TxtProgram
            // 
            this.TxtProgram.AcceptsReturn = true;
            this.TxtProgram.AcceptsTab = true;
            this.TxtProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtProgram.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtProgram.Location = new System.Drawing.Point(0, 29);
            this.TxtProgram.Margin = new System.Windows.Forms.Padding(0);
            this.TxtProgram.Multiline = true;
            this.TxtProgram.Name = "TxtProgram";
            this.TxtProgram.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtProgram.Size = new System.Drawing.Size(604, 567);
            this.TxtProgram.TabIndex = 0;
            this.TxtProgram.WordWrap = false;
            this.TxtProgram.TextChanged += new System.EventHandler(this.TxtProgram_TextChanged);
            this.TxtProgram.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProgram_KeyDown);
            // 
            // ToolTabsControl
            // 
            this.ToolTabsControl.Controls.Add(this.TabTool1);
            this.ToolTabsControl.Controls.Add(this.TabTool2);
            this.ToolTabsControl.Controls.Add(this.TabTool3);
            this.ToolTabsControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ToolTabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolTabsControl.Location = new System.Drawing.Point(0, 0);
            this.ToolTabsControl.Margin = new System.Windows.Forms.Padding(0);
            this.ToolTabsControl.Name = "ToolTabsControl";
            this.ToolTabsControl.SelectedIndex = 0;
            this.ToolTabsControl.Size = new System.Drawing.Size(234, 596);
            this.ToolTabsControl.TabIndex = 1;
            this.ToolTabsControl.TabStop = false;
            // 
            // TabTool1
            // 
            this.TabTool1.Location = new System.Drawing.Point(4, 24);
            this.TabTool1.Margin = new System.Windows.Forms.Padding(0);
            this.TabTool1.Name = "TabTool1";
            this.TabTool1.Size = new System.Drawing.Size(226, 568);
            this.TabTool1.TabIndex = 0;
            this.TabTool1.Text = "Tool 1";
            this.TabTool1.UseVisualStyleBackColor = true;
            // 
            // TabTool2
            // 
            this.TabTool2.Location = new System.Drawing.Point(4, 24);
            this.TabTool2.Margin = new System.Windows.Forms.Padding(0);
            this.TabTool2.Name = "TabTool2";
            this.TabTool2.Size = new System.Drawing.Size(226, 568);
            this.TabTool2.TabIndex = 1;
            this.TabTool2.Text = "Tool 2";
            this.TabTool2.UseVisualStyleBackColor = true;
            // 
            // TabTool3
            // 
            this.TabTool3.Location = new System.Drawing.Point(4, 24);
            this.TabTool3.Margin = new System.Windows.Forms.Padding(0);
            this.TabTool3.Name = "TabTool3";
            this.TabTool3.Size = new System.Drawing.Size(226, 568);
            this.TabTool3.TabIndex = 2;
            this.TabTool3.Text = "Tool 3";
            this.TabTool3.UseVisualStyleBackColor = true;
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBtnTextFg,
            this.MenuBtnTextBg,
            this.MenuBtnWindowColor});
            this.colorsToolStripMenuItem.Image = global::PTMEdit.Properties.Resources.color_wheel;
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // MenuBtnTextFg
            // 
            this.MenuBtnTextFg.Name = "MenuBtnTextFg";
            this.MenuBtnTextFg.Size = new System.Drawing.Size(180, 22);
            this.MenuBtnTextFg.Text = "Text foreground";
            this.MenuBtnTextFg.Click += new System.EventHandler(this.MenuBtnTextFg_Click);
            // 
            // MenuBtnTextBg
            // 
            this.MenuBtnTextBg.Name = "MenuBtnTextBg";
            this.MenuBtnTextBg.Size = new System.Drawing.Size(180, 22);
            this.MenuBtnTextBg.Text = "Text background";
            this.MenuBtnTextBg.Click += new System.EventHandler(this.MenuBtnTextBg_Click);
            // 
            // MenuBtnWindowColor
            // 
            this.MenuBtnWindowColor.Name = "MenuBtnWindowColor";
            this.MenuBtnWindowColor.Size = new System.Drawing.Size(180, 22);
            this.MenuBtnWindowColor.Text = "Window";
            this.MenuBtnWindowColor.Click += new System.EventHandler(this.MenuBtnWindowColor_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 682);
            this.Controls.Add(this.PnlRoot);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1150, 720);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTMEdit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlRoot.ResumeLayout(false);
            this.ScMainAndTools.Panel1.ResumeLayout(false);
            this.ScMainAndTools.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScMainAndTools)).EndInit();
            this.ScMainAndTools.ResumeLayout(false);
            this.ScFileAndProgEdit.Panel1.ResumeLayout(false);
            this.ScFileAndProgEdit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScFileAndProgEdit)).EndInit();
            this.ScFileAndProgEdit.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.TxtProgramToolBar.ResumeLayout(false);
            this.TxtProgramToolBar.PerformLayout();
            this.ToolTabsControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel PnlRoot;
        private System.Windows.Forms.SplitContainer ScMainAndTools;
        private System.Windows.Forms.SplitContainer ScFileAndProgEdit;
        private System.Windows.Forms.ImageList FilePanelIcons;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnExit;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnSave;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnSaveAs;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnNew;
        private System.Windows.Forms.ListView LstFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabControl ToolTabsControl;
        private System.Windows.Forms.TabPage TabTool1;
        private System.Windows.Forms.TabPage TabTool2;
        private System.Windows.Forms.TabPage TabTool3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip TxtProgramToolBar;
        private System.Windows.Forms.TextBox TxtProgram;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnTglFileList;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnTglTools;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnEditCfg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnSaveRun;
        private System.Windows.Forms.ToolStripComboBox CmbSubroutines;
        private System.Windows.Forms.ToolStripButton BtnSaveRun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox TxtFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnFontDec;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnFontInc;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnToggleToolBar;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnGotoLineNr;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnTextFg;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnTextBg;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnWindowColor;
    }
}

