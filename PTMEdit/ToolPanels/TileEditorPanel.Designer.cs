
namespace PTMEdit
{
    partial class TileEditorPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PnlTileEdit = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnClear = new System.Windows.Forms.ToolStripButton();
            this.BtnFlipH = new System.Windows.Forms.ToolStripButton();
            this.BtnFlipV = new System.Windows.Forms.ToolStripButton();
            this.BtnInvert = new System.Windows.Forms.ToolStripButton();
            this.BtnShiftRight = new System.Windows.Forms.ToolStripButton();
            this.BtnShiftLeft = new System.Windows.Forms.ToolStripButton();
            this.BtnShiftDown = new System.Windows.Forms.ToolStripButton();
            this.BtnShiftUp = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTileIndex = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PnlTileEdit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 552);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PnlTileEdit
            // 
            this.PnlTileEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlTileEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTileEdit.Location = new System.Drawing.Point(20, 45);
            this.PnlTileEdit.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.PnlTileEdit.MaximumSize = new System.Drawing.Size(195, 195);
            this.PnlTileEdit.MinimumSize = new System.Drawing.Size(195, 195);
            this.PnlTileEdit.Name = "PnlTileEdit";
            this.PnlTileEdit.Size = new System.Drawing.Size(195, 195);
            this.PnlTileEdit.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 292);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.panel1.Size = new System.Drawing.Size(229, 257);
            this.panel1.TabIndex = 1;
            // 
            // TxtCode
            // 
            this.TxtCode.BackColor = System.Drawing.Color.White;
            this.TxtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCode.Location = new System.Drawing.Point(15, 0);
            this.TxtCode.Margin = new System.Windows.Forms.Padding(0);
            this.TxtCode.Multiline = true;
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.ReadOnly = true;
            this.TxtCode.Size = new System.Drawing.Size(199, 242);
            this.TxtCode.TabIndex = 2;
            this.TxtCode.WordWrap = false;
            this.TxtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCode_KeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnClear,
            this.BtnFlipH,
            this.BtnFlipV,
            this.BtnInvert,
            this.BtnShiftLeft,
            this.BtnShiftRight,
            this.BtnShiftUp,
            this.BtnShiftDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(235, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnClear
            // 
            this.BtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnClear.Image = global::PTMEdit.Properties.Resources.page_white;
            this.BtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(23, 22);
            this.BtnClear.Text = "Clear";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnFlipH
            // 
            this.BtnFlipH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnFlipH.Image = global::PTMEdit.Properties.Resources.shape_flip_horizontal;
            this.BtnFlipH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFlipH.Name = "BtnFlipH";
            this.BtnFlipH.Size = new System.Drawing.Size(23, 22);
            this.BtnFlipH.Text = "Horizontal flip";
            this.BtnFlipH.ToolTipText = "Horizontal flip";
            this.BtnFlipH.Click += new System.EventHandler(this.BtnFlipH_Click);
            // 
            // BtnFlipV
            // 
            this.BtnFlipV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnFlipV.Image = global::PTMEdit.Properties.Resources.shape_flip_vertical;
            this.BtnFlipV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFlipV.Name = "BtnFlipV";
            this.BtnFlipV.Size = new System.Drawing.Size(23, 22);
            this.BtnFlipV.Text = "Vertical flip";
            this.BtnFlipV.ToolTipText = "Vertical flip";
            this.BtnFlipV.Click += new System.EventHandler(this.BtnFlipV_Click);
            // 
            // BtnInvert
            // 
            this.BtnInvert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnInvert.Image = global::PTMEdit.Properties.Resources.color_picker_default;
            this.BtnInvert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnInvert.Name = "BtnInvert";
            this.BtnInvert.Size = new System.Drawing.Size(23, 22);
            this.BtnInvert.Text = "Invert";
            this.BtnInvert.Click += new System.EventHandler(this.BtnInvert_Click);
            // 
            // BtnShiftRight
            // 
            this.BtnShiftRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnShiftRight.Image = global::PTMEdit.Properties.Resources.arrow_right;
            this.BtnShiftRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnShiftRight.Name = "BtnShiftRight";
            this.BtnShiftRight.Size = new System.Drawing.Size(23, 22);
            this.BtnShiftRight.Text = "Shift right";
            this.BtnShiftRight.Click += new System.EventHandler(this.BtnShiftRight_Click);
            // 
            // BtnShiftLeft
            // 
            this.BtnShiftLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnShiftLeft.Image = global::PTMEdit.Properties.Resources.arrow_left;
            this.BtnShiftLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnShiftLeft.Name = "BtnShiftLeft";
            this.BtnShiftLeft.Size = new System.Drawing.Size(23, 22);
            this.BtnShiftLeft.Text = "Shift left";
            this.BtnShiftLeft.Click += new System.EventHandler(this.BtnShiftLeft_Click);
            // 
            // BtnShiftDown
            // 
            this.BtnShiftDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnShiftDown.Image = global::PTMEdit.Properties.Resources.arrow_down;
            this.BtnShiftDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnShiftDown.Name = "BtnShiftDown";
            this.BtnShiftDown.Size = new System.Drawing.Size(23, 22);
            this.BtnShiftDown.Text = "Shift down";
            this.BtnShiftDown.Click += new System.EventHandler(this.BtnShiftDown_Click);
            // 
            // BtnShiftUp
            // 
            this.BtnShiftUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnShiftUp.Image = global::PTMEdit.Properties.Resources.arrow_up;
            this.BtnShiftUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnShiftUp.Name = "BtnShiftUp";
            this.BtnShiftUp.Size = new System.Drawing.Size(23, 22);
            this.BtnShiftUp.Text = "Shift up";
            this.BtnShiftUp.ToolTipText = "Shift up";
            this.BtnShiftUp.Click += new System.EventHandler(this.BtnShiftUp_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.TxtTileIndex);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 250);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(235, 29);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(18, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Index :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTileIndex
            // 
            this.TxtTileIndex.Location = new System.Drawing.Point(65, 3);
            this.TxtTileIndex.Name = "TxtTileIndex";
            this.TxtTileIndex.Size = new System.Drawing.Size(58, 23);
            this.TxtTileIndex.TabIndex = 1;
            this.TxtTileIndex.TextChanged += new System.EventHandler(this.TxtTileIndex_TextChanged);
            // 
            // TileEditorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TileEditorPanel";
            this.Size = new System.Drawing.Size(235, 552);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PnlTileEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTileIndex;
        private System.Windows.Forms.ToolStripButton BtnClear;
        private System.Windows.Forms.ToolStripButton BtnFlipV;
        private System.Windows.Forms.ToolStripButton BtnFlipH;
        private System.Windows.Forms.ToolStripButton BtnInvert;
        private System.Windows.Forms.ToolStripButton BtnShiftDown;
        private System.Windows.Forms.ToolStripButton BtnShiftUp;
        private System.Windows.Forms.ToolStripButton BtnShiftRight;
        private System.Windows.Forms.ToolStripButton BtnShiftLeft;
    }
}
