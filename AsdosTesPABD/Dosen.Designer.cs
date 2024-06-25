namespace AsdosTesPABD
{
    partial class Dosen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dosenPanel = new System.Windows.Forms.Panel();
            this.dosenView = new System.Windows.Forms.DataGridView();
            this.dosenGB = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dosenTB = new System.Windows.Forms.TextBox();
            this.srcBtn = new System.Windows.Forms.Button();
            this.dosenTxt = new System.Windows.Forms.Label();
            this.dosenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dosenView)).BeginInit();
            this.dosenGB.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dosenPanel
            // 
            this.dosenPanel.Controls.Add(this.dosenView);
            this.dosenPanel.Controls.Add(this.dosenGB);
            this.dosenPanel.Controls.Add(this.dosenTxt);
            this.dosenPanel.Location = new System.Drawing.Point(12, 12);
            this.dosenPanel.Name = "dosenPanel";
            this.dosenPanel.Size = new System.Drawing.Size(954, 620);
            this.dosenPanel.TabIndex = 0;
            // 
            // dosenView
            // 
            this.dosenView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dosenView.Location = new System.Drawing.Point(3, 170);
            this.dosenView.Name = "dosenView";
            this.dosenView.RowHeadersWidth = 62;
            this.dosenView.RowTemplate.Height = 28;
            this.dosenView.Size = new System.Drawing.Size(948, 440);
            this.dosenView.TabIndex = 11;
            // 
            // dosenGB
            // 
            this.dosenGB.Controls.Add(this.tableLayoutPanel2);
            this.dosenGB.Location = new System.Drawing.Point(3, 80);
            this.dosenGB.Name = "dosenGB";
            this.dosenGB.Size = new System.Drawing.Size(948, 84);
            this.dosenGB.TabIndex = 10;
            this.dosenGB.TabStop = false;
            this.dosenGB.Text = "Cari Data Dosen";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.95699F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.04301F));
            this.tableLayoutPanel2.Controls.Add(this.srcBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dosenTB, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(936, 48);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dosenTB
            // 
            this.dosenTB.Location = new System.Drawing.Point(3, 3);
            this.dosenTB.Multiline = true;
            this.dosenTB.Name = "dosenTB";
            this.dosenTB.Size = new System.Drawing.Size(812, 42);
            this.dosenTB.TabIndex = 0;
            // 
            // srcBtn
            // 
            this.srcBtn.Location = new System.Drawing.Point(826, 3);
            this.srcBtn.Name = "srcBtn";
            this.srcBtn.Size = new System.Drawing.Size(106, 42);
            this.srcBtn.TabIndex = 1;
            this.srcBtn.Text = "Search";
            this.srcBtn.UseVisualStyleBackColor = true;
            this.srcBtn.Click += new System.EventHandler(this.srcBtn_Click);
            // 
            // dosenTxt
            // 
            this.dosenTxt.AutoSize = true;
            this.dosenTxt.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dosenTxt.Location = new System.Drawing.Point(360, 13);
            this.dosenTxt.Name = "dosenTxt";
            this.dosenTxt.Size = new System.Drawing.Size(222, 53);
            this.dosenTxt.TabIndex = 9;
            this.dosenTxt.Text = "Data Dosen";
            // 
            // Dosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.dosenPanel);
            this.Name = "Dosen";
            this.Text = "Dosen";
            this.dosenPanel.ResumeLayout(false);
            this.dosenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dosenView)).EndInit();
            this.dosenGB.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dosenPanel;
        private System.Windows.Forms.DataGridView dosenView;
        private System.Windows.Forms.GroupBox dosenGB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox dosenTB;
        private System.Windows.Forms.Button srcBtn;
        private System.Windows.Forms.Label dosenTxt;
    }
}