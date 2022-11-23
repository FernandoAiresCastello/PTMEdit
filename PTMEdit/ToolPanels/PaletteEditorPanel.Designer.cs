
namespace PTMEdit
{
    partial class PaletteEditorPanel
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PnlBackColor = new System.Windows.Forms.Panel();
            this.PnlForeColor = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtForeColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBackColor = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.PnlBackColor.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PnlBackColor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 552);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(235, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PnlBackColor
            // 
            this.PnlBackColor.BackColor = System.Drawing.Color.Black;
            this.PnlBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlBackColor.Controls.Add(this.PnlForeColor);
            this.PnlBackColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBackColor.Location = new System.Drawing.Point(0, 25);
            this.PnlBackColor.Margin = new System.Windows.Forms.Padding(0);
            this.PnlBackColor.Name = "PnlBackColor";
            this.PnlBackColor.Padding = new System.Windows.Forms.Padding(50);
            this.PnlBackColor.Size = new System.Drawing.Size(235, 263);
            this.PnlBackColor.TabIndex = 3;
            // 
            // PnlForeColor
            // 
            this.PnlForeColor.BackColor = System.Drawing.Color.White;
            this.PnlForeColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlForeColor.Location = new System.Drawing.Point(50, 50);
            this.PnlForeColor.Margin = new System.Windows.Forms.Padding(0);
            this.PnlForeColor.Name = "PnlForeColor";
            this.PnlForeColor.Size = new System.Drawing.Size(131, 159);
            this.PnlForeColor.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TxtForeColor, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtBackColor, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 291);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(229, 258);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Foreground";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtForeColor
            // 
            this.TxtForeColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtForeColor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtForeColor.Location = new System.Drawing.Point(80, 32);
            this.TxtForeColor.MaxLength = 6;
            this.TxtForeColor.Name = "TxtForeColor";
            this.TxtForeColor.Size = new System.Drawing.Size(146, 23);
            this.TxtForeColor.TabIndex = 3;
            this.TxtForeColor.Text = "ffffff";
            this.TxtForeColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBackColor
            // 
            this.TxtBackColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBackColor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtBackColor.Location = new System.Drawing.Point(80, 3);
            this.TxtBackColor.MaxLength = 6;
            this.TxtBackColor.Name = "TxtBackColor";
            this.TxtBackColor.Size = new System.Drawing.Size(146, 23);
            this.TxtBackColor.TabIndex = 1;
            this.TxtBackColor.Text = "000000";
            this.TxtBackColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PaletteEditorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PaletteEditorPanel";
            this.Size = new System.Drawing.Size(235, 552);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.PnlBackColor.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel PnlBackColor;
        private System.Windows.Forms.Panel PnlForeColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtForeColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBackColor;
    }
}
