using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PTMEdit
{
    public partial class PaletteEditorPanel : UserControl
    {
        public PaletteEditorPanel(Control parent)
        {
            InitializeComponent();
            Parent = parent;
            Parent.Text = "Color sampler";
            Dock = DockStyle.Fill;

            TxtForeColor.Tag = PnlForeColor;
            TxtBackColor.Tag = PnlBackColor;

            TxtForeColor.TextChanged += TxtRgb_TextChanged;
            TxtBackColor.TextChanged += TxtRgb_TextChanged;
            TxtForeColor.KeyDown += TxtRgb_KeyDown;
            TxtBackColor.KeyDown += TxtRgb_KeyDown;
        }

        private void TxtRgb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length != 6)
                return;

            Color? color = ParseColorRgbHex(textBox.Text);

            if (color.HasValue)
            {
                Panel panel = textBox.Tag as Panel;
                panel.BackColor = color.Value;
            }
        }

        private Color? ParseColorRgbHex(string hex)
        {
            try
            {
                hex = "FF" + hex;
                int rgb = int.Parse(hex, System.Globalization.NumberStyles.AllowHexSpecifier);
                return Color.FromArgb(rgb);
            }
            catch
            {
                return null;
            }
        }

        private void TxtRgb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                TextBox textBox = sender as TextBox;
                string originalText = textBox.Text;

                try
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true;

                    string clipboardText = Clipboard.GetText().Trim();
                    string[] parts = clipboardText.Split(',');
                    if (parts.Length == 1)
                        textBox.Text = parts[0].Trim().Replace("&h", "");
                    else
                        textBox.Text = parts[parts.Length - 1].Trim().Replace("&h", "");
                }
                catch
                {
                    textBox.Text = originalText;
                }
            }
        }
    }
}
