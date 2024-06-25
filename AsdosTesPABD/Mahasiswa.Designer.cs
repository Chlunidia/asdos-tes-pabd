namespace AsdosTesPABD
{
    partial class Mahasiswa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mhsTxt = new System.Windows.Forms.Label();
            this.mhsGB = new System.Windows.Forms.GroupBox();
            this.stsfilterCB = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mhsView = new System.Windows.Forms.DataGridView();
            this.nimmhsTB = new System.Windows.Forms.TextBox();
            this.srcBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.mhsGB.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mhsView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mhsView);
            this.panel1.Controls.Add(this.mhsGB);
            this.panel1.Controls.Add(this.mhsTxt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 620);
            this.panel1.TabIndex = 0;
            // 
            // mhsTxt
            // 
            this.mhsTxt.AutoSize = true;
            this.mhsTxt.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mhsTxt.Location = new System.Drawing.Point(322, 17);
            this.mhsTxt.Name = "mhsTxt";
            this.mhsTxt.Size = new System.Drawing.Size(307, 53);
            this.mhsTxt.TabIndex = 6;
            this.mhsTxt.Text = "Data Mahasiswa";
            // 
            // mhsGB
            // 
            this.mhsGB.Controls.Add(this.tableLayoutPanel1);
            this.mhsGB.Location = new System.Drawing.Point(3, 87);
            this.mhsGB.Name = "mhsGB";
            this.mhsGB.Size = new System.Drawing.Size(948, 133);
            this.mhsGB.TabIndex = 7;
            this.mhsGB.TabStop = false;
            this.mhsGB.Text = "Cari Data Mahasiswa";
            // 
            // stsfilterCB
            // 
            this.stsfilterCB.FormattingEnabled = true;
            this.stsfilterCB.Items.AddRange(new object[] {
            "All",
            "Sudah Daftar",
            "Belum Daftar"});
            this.stsfilterCB.Location = new System.Drawing.Point(3, 3);
            this.stsfilterCB.Name = "stsfilterCB";
            this.stsfilterCB.Size = new System.Drawing.Size(927, 28);
            this.stsfilterCB.TabIndex = 0;
            this.stsfilterCB.SelectedIndexChanged += new System.EventHandler(this.stsfilterCB_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.stsfilterCB, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(936, 108);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.95699F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.04301F));
            this.tableLayoutPanel2.Controls.Add(this.nimmhsTB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.srcBtn, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(930, 48);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // mhsView
            // 
            this.mhsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mhsView.Location = new System.Drawing.Point(3, 235);
            this.mhsView.Name = "mhsView";
            this.mhsView.RowHeadersWidth = 62;
            this.mhsView.RowTemplate.Height = 28;
            this.mhsView.Size = new System.Drawing.Size(948, 382);
            this.mhsView.TabIndex = 8;
            // 
            // nimmhsTB
            // 
            this.nimmhsTB.Location = new System.Drawing.Point(3, 3);
            this.nimmhsTB.Multiline = true;
            this.nimmhsTB.Name = "nimmhsTB";
            this.nimmhsTB.Size = new System.Drawing.Size(812, 42);
            this.nimmhsTB.TabIndex = 0;
            // 
            // srcBtn
            // 
            this.srcBtn.Location = new System.Drawing.Point(821, 3);
            this.srcBtn.Name = "srcBtn";
            this.srcBtn.Size = new System.Drawing.Size(106, 42);
            this.srcBtn.TabIndex = 1;
            this.srcBtn.Text = "Search";
            this.srcBtn.UseVisualStyleBackColor = true;
            this.srcBtn.Click += new System.EventHandler(this.srcBtn_Click);
            // 
            // Mahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.panel1);
            this.Name = "Mahasiswa";
            this.Text = "Mahasiswa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mhsGB.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mhsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mhsTxt;
        private System.Windows.Forms.DataGridView mhsView;
        private System.Windows.Forms.GroupBox mhsGB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox stsfilterCB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox nimmhsTB;
        private System.Windows.Forms.Button srcBtn;
    }
}