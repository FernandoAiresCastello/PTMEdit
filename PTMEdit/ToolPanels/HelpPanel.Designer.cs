
namespace PTMEdit
{
    partial class HelpPanel
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
            this.LstTopics = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.TxtHelp = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LstTopics, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TxtHelp, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 552);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(235, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LstTopics
            // 
            this.LstTopics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LstTopics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstTopics.FullRowSelect = true;
            this.LstTopics.GridLines = true;
            this.LstTopics.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LstTopics.HideSelection = false;
            this.LstTopics.Location = new System.Drawing.Point(3, 28);
            this.LstTopics.MultiSelect = false;
            this.LstTopics.Name = "LstTopics";
            this.LstTopics.Size = new System.Drawing.Size(229, 257);
            this.LstTopics.TabIndex = 3;
            this.LstTopics.UseCompatibleStateImageBehavior = false;
            this.LstTopics.View = System.Windows.Forms.View.Details;
            this.LstTopics.SelectedIndexChanged += new System.EventHandler(this.LstTopics_Click);
            this.LstTopics.Click += new System.EventHandler(this.LstTopics_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Command";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Params";
            // 
            // TxtHelp
            // 
            this.TxtHelp.BackColor = System.Drawing.SystemColors.Window;
            this.TxtHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtHelp.Location = new System.Drawing.Point(3, 291);
            this.TxtHelp.Multiline = true;
            this.TxtHelp.Name = "TxtHelp";
            this.TxtHelp.ReadOnly = true;
            this.TxtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtHelp.Size = new System.Drawing.Size(229, 258);
            this.TxtHelp.TabIndex = 4;
            // 
            // HelpPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HelpPanel";
            this.Size = new System.Drawing.Size(235, 552);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView LstTopics;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox TxtHelp;
    }
}
