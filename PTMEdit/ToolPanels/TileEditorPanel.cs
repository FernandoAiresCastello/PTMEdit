using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TileGameLib.Components;
using TileGameLib.Graphics;

namespace PTMEdit
{
    public partial class TileEditorPanel : UserControl
    {
        private TiledDisplay Display;
        private const int PixelStateOff = 0;
        private const int PixelStateOn = 1;

        public TileEditorPanel(Control parent)
        {
            InitializeComponent();
            Parent = parent;
            Parent.Text = "Tile editor";
            Dock = DockStyle.Fill;

            Display = new TiledDisplay(PnlTileEdit, 8, 8, 3);

            Display.Graphics.Palette.Clear(2);
            Display.Graphics.Palette.Set(PixelStateOff, 0xffffff);
            Display.Graphics.Palette.Set(PixelStateOn, 0x000000);

            Display.SetMainGridColor(Color.FromArgb(50, 192, 192, 192));
            Display.ShowGrid = true;

            Display.Graphics.Clear(PixelStateOff);
            Display.MouseClick += Disp_MouseClick;
            Display.MouseDown += Display_MouseDown;
            Display.MouseMove += Display_MouseMove;
        }

        private void Display_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
                OnDisplayClick(sender, e);
        }

        private void Display_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
                OnDisplayClick(sender, e);
        }

        private void Disp_MouseClick(object sender, MouseEventArgs e)
        {
            OnDisplayClick(sender, e);
        }

        private void OnDisplayClick(object sender, MouseEventArgs e)
        {
            PutPixel(Display.GetMouseToCellPos(e.Location), e.Button == MouseButtons.Left);
        }

        private void PutPixel(Point pos, bool state)
        {
            if (pos.X < 0 || pos.Y < 0 || pos.X > 7 || pos.Y > 7)
                return;

            Tile tile = state ? 
                new Tile(0, PixelStateOn, PixelStateOn) : 
                new Tile(0, PixelStateOff, PixelStateOff);

            Display.Graphics.PutTile(pos.X, pos.Y, tile);
            Display.Refresh();
            TxtCode.Text = SerializeToCode();
        }

        private void ClearPixels()
        {
            for (int y = 0; y < 8; y++)
                for (int x = 0; x < 8; x++)
                    Display.Graphics.PutTile(x, y, new Tile(0, PixelStateOff, PixelStateOff));

            Display.Refresh();
            TxtCode.Text = SerializeToCode();
        }

        private string SerializeToCode()
        {
            StringBuilder buf = new StringBuilder();
            
            for (int y = 0; y < 8; y++)
            {
                buf.Append($"CHR {TxtTileIndex.Text},{y},&b");

                for (int x = 0; x < 8; x++)
                {
                    Tile tile = Display.Graphics.GetTile(x, y);
                    string bit = tile.ForeColor == PixelStateOn ? "1" : "0";
                    buf.Append(bit);
                }

                buf.Append(Environment.NewLine);
            }

            return buf.ToString();
        }

        private void ParseFromCode()
        {
            string[] rows = TxtCode.Text.Trim().ToLower().Split(Environment.NewLine);

            int x = 0;
            int y = 0;

            foreach (string row in rows)
            {
                string[] parts = row.Trim().Split(',');
                if (parts.Length != 3)
                    continue;

                string bits = parts[2].Substring(2);

                foreach (char bit in bits)
                {
                    Tile tile = bit == '1' ?
                        new Tile(0, PixelStateOn, PixelStateOn) :
                        new Tile(0, PixelStateOff, PixelStateOff);

                    if (x < 8 && y < 8)
                        Display.Graphics.PutTile(x, y, tile);

                    x++;
                }

                y++;
                x = 0;
            }

            Display.Refresh();
        }

        private void TxtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string originalText = TxtCode.Text;

                e.Handled = true;
                e.SuppressKeyPress = true;

                string clipboardText = Clipboard.GetText().Trim();
                StringBuilder buf = new StringBuilder();
                string[] lines = clipboardText.Split(Environment.NewLine);

                if (!clipboardText.ToUpper().StartsWith("CHR ") || lines.Length != 8)
                {
                    TxtCode.Text = originalText;
                    TxtCode.Select(0, 0);

                    MessageBox.Show(this, 
                        "Tile could not be parsed from clipboard text", 
                        "Invalid code block", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                foreach (string line in lines)
                    buf.AppendLine(line.Trim());

                TxtCode.Text = buf.ToString();

                ParseFromCode();

                if (TxtCode.Lines.Length > 0)
                    TxtTileIndex.Text = TxtCode.Lines[0].Split(',')[0][3..].Trim();
            }
        }

        private void TxtTileIndex_TextChanged(object sender, EventArgs e)
        {
            TxtCode.Text = SerializeToCode();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearPixels();
        }

        private TilePixels SerializeToPixels()
        {
            StringBuilder binaryString = new StringBuilder();

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Tile tile = Display.Graphics.GetTile(x, y);
                    string bit = tile.ForeColor == PixelStateOn ? "1" : "0";
                    binaryString.Append(bit);
                }
            }

            TilePixels pixels = new TilePixels();
            pixels.FromBinaryString(binaryString.ToString());
            return pixels;
        }

        private void ParseFromPixels(TilePixels pixels)
        {
            string binaryString = pixels.ToBinaryString();

            int i = 0;

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Tile tile = binaryString[i++] == '1' ?
                        new Tile(0, PixelStateOn, PixelStateOn) :
                        new Tile(0, PixelStateOff, PixelStateOff);

                    Display.Graphics.PutTile(x, y, tile);
                }
            }

            Display.Refresh();
            TxtCode.Text = SerializeToCode();
        }

        private void BtnFlipH_Click(object sender, EventArgs e)
        {
            TilePixels pixels = SerializeToPixels();
            pixels.FlipHorizontal();
            ParseFromPixels(pixels);
        }

        private void BtnFlipV_Click(object sender, EventArgs e)
        {
            TilePixels pixels = SerializeToPixels();
            pixels.FlipVertical();
            ParseFromPixels(pixels);
        }

        private void BtnInvert_Click(object sender, EventArgs e)
        {
            TilePixels pixels = SerializeToPixels();
            pixels.Invert();
            ParseFromPixels(pixels);
        }

        private void BtnShiftDown_Click(object sender, EventArgs e)
        {
            TilePixels pixels = SerializeToPixels();
            pixels.RotateDown();
            ParseFromPixels(pixels);
        }

        private void BtnShiftUp_Click(object sender, EventArgs e)
        {
            TilePixels pixels = SerializeToPixels();
            pixels.RotateUp();
            ParseFromPixels(pixels);
        }

        private void BtnShiftRight_Click(object sender, EventArgs e)
        {
            TilePixels pixels = SerializeToPixels();
            pixels.RotateRight();
            ParseFromPixels(pixels);
        }

        private void BtnShiftLeft_Click(object sender, EventArgs e)
        {
            TilePixels pixels = SerializeToPixels();
            pixels.RotateLeft();
            ParseFromPixels(pixels);
        }
    }
}
