namespace AsdosTesPABD
{
    partial class Bimbingan
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
            this.bimPanel = new System.Windows.Forms.Panel();
            this.bimTxt = new System.Windows.Forms.Label();
            this.bimView = new System.Windows.Forms.DataGridView();
            this.bimGB = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.srcbimBtn = new System.Windows.Forms.Button();
            this.delbimBtn = new System.Windows.Forms.Button();
            this.idbimGB = new System.Windows.Forms.GroupBox();
            this.idbimTB = new System.Windows.Forms.TextBox();
            this.menuTbl = new System.Windows.Forms.TableLayoutPanel();
            this.addbimBtn = new System.Windows.Forms.Button();
            this.editbimBtn = new System.Windows.Forms.Button();
            this.clrbimBtn = new System.Windows.Forms.Button();
            this.bimTable = new System.Windows.Forms.TableLayoutPanel();
            this.nimbimTxt = new System.Windows.Forms.Label();
            this.dsnbimTxt = new System.Windows.Forms.Label();
            this.tglbimTxt = new System.Windows.Forms.Label();
            this.nimbimTB = new System.Windows.Forms.TextBox();
            this.dosenCB = new System.Windows.Forms.ComboBox();
            this.bimDate = new System.Windows.Forms.DateTimePicker();
            this.bimPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bimView)).BeginInit();
            this.bimGB.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.idbimGB.SuspendLayout();
            this.menuTbl.SuspendLayout();
            this.bimTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // bimPanel
            // 
            this.bimPanel.Controls.Add(this.bimTxt);
            this.bimPanel.Controls.Add(this.bimView);
            this.bimPanel.Controls.Add(this.bimGB);
            this.bimPanel.Location = new System.Drawing.Point(12, 12);
            this.bimPanel.Name = "bimPanel";
            this.bimPanel.Size = new System.Drawing.Size(954, 620);
            this.bimPanel.TabIndex = 0;
            // 
            // bimTxt
            // 
            this.bimTxt.AutoSize = true;
            this.bimTxt.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bimTxt.Location = new System.Drawing.Point(316, 20);
            this.bimTxt.Name = "bimTxt";
            this.bimTxt.Size = new System.Drawing.Size(332, 53);
            this.bimTxt.TabIndex = 5;
            this.bimTxt.Text = "Ajukan Bimbingan";
            // 
            // bimView
            // 
            this.bimView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bimView.Location = new System.Drawing.Point(363, 94);
            this.bimView.Name = "bimView";
            this.bimView.RowHeadersWidth = 62;
            this.bimView.RowTemplate.Height = 28;
            this.bimView.Size = new System.Drawing.Size(588, 523);
            this.bimView.TabIndex = 4;
            // 
            // bimGB
            // 
            this.bimGB.Controls.Add(this.tableLayoutPanel1);
            this.bimGB.Controls.Add(this.idbimGB);
            this.bimGB.Controls.Add(this.menuTbl);
            this.bimGB.Controls.Add(this.bimTable);
            this.bimGB.Location = new System.Drawing.Point(3, 142);
            this.bimGB.Name = "bimGB";
            this.bimGB.Size = new System.Drawing.Size(341, 421);
            this.bimGB.TabIndex = 3;
            this.bimGB.TabStop = false;
            this.bimGB.Text = "Ajukan Bimbingan";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.srcbimBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.delbimBtn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 357);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 53);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // srcbimBtn
            // 
            this.srcbimBtn.Location = new System.Drawing.Point(3, 3);
            this.srcbimBtn.Name = "srcbimBtn";
            this.srcbimBtn.Size = new System.Drawing.Size(158, 47);
            this.srcbimBtn.TabIndex = 0;
            this.srcbimBtn.Text = "Search";
            this.srcbimBtn.UseVisualStyleBackColor = true;
            this.srcbimBtn.Click += new System.EventHandler(this.srcbimBtn_Click);
            // 
            // delbimBtn
            // 
            this.delbimBtn.Location = new System.Drawing.Point(167, 3);
            this.delbimBtn.Name = "delbimBtn";
            this.delbimBtn.Size = new System.Drawing.Size(159, 47);
            this.delbimBtn.TabIndex = 1;
            this.delbimBtn.Text = "Delete";
            this.delbimBtn.UseVisualStyleBackColor = true;
            this.delbimBtn.Click += new System.EventHandler(this.delbimBtn_Click);
            // 
            // idbimGB
            // 
            this.idbimGB.Controls.Add(this.idbimTB);
            this.idbimGB.Location = new System.Drawing.Point(6, 275);
            this.idbimGB.Name = "idbimGB";
            this.idbimGB.Size = new System.Drawing.Size(329, 76);
            this.idbimGB.TabIndex = 2;
            this.idbimGB.TabStop = false;
            this.idbimGB.Text = "Cari Riwayat Bimbingan";
            // 
            // idbimTB
            // 
            this.idbimTB.Location = new System.Drawing.Point(7, 25);
            this.idbimTB.Multiline = true;
            this.idbimTB.Name = "idbimTB";
            this.idbimTB.Size = new System.Drawing.Size(316, 45);
            this.idbimTB.TabIndex = 0;
            // 
            // menuTbl
            // 
            this.menuTbl.ColumnCount = 3;
            this.menuTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuTbl.Controls.Add(this.addbimBtn, 0, 0);
            this.menuTbl.Controls.Add(this.editbimBtn, 1, 0);
            this.menuTbl.Controls.Add(this.clrbimBtn, 2, 0);
            this.menuTbl.Location = new System.Drawing.Point(6, 208);
            this.menuTbl.Name = "menuTbl";
            this.menuTbl.RowCount = 1;
            this.menuTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuTbl.Size = new System.Drawing.Size(329, 53);
            this.menuTbl.TabIndex = 1;
            // 
            // addbimBtn
            // 
            this.addbimBtn.Location = new System.Drawing.Point(3, 3);
            this.addbimBtn.Name = "addbimBtn";
            this.addbimBtn.Size = new System.Drawing.Size(103, 47);
            this.addbimBtn.TabIndex = 0;
            this.addbimBtn.Text = "Ajukan";
            this.addbimBtn.UseVisualStyleBackColor = true;
            this.addbimBtn.Click += new System.EventHandler(this.addbimBtn_Click);
            // 
            // editbimBtn
            // 
            this.editbimBtn.Location = new System.Drawing.Point(112, 3);
            this.editbimBtn.Name = "editbimBtn";
            this.editbimBtn.Size = new System.Drawing.Size(103, 47);
            this.editbimBtn.TabIndex = 1;
            this.editbimBtn.Text = "Edit";
            this.editbimBtn.UseVisualStyleBackColor = true;
            this.editbimBtn.Click += new System.EventHandler(this.editbimBtn_Click);
            // 
            // clrbimBtn
            // 
            this.clrbimBtn.Location = new System.Drawing.Point(221, 3);
            this.clrbimBtn.Name = "clrbimBtn";
            this.clrbimBtn.Size = new System.Drawing.Size(105, 47);
            this.clrbimBtn.TabIndex = 2;
            this.clrbimBtn.Text = "Clear";
            this.clrbimBtn.UseVisualStyleBackColor = true;
            this.clrbimBtn.Click += new System.EventHandler(this.clrbimBtn_Click);
            // 
            // bimTable
            // 
            this.bimTable.ColumnCount = 2;
            this.bimTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bimTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bimTable.Controls.Add(this.nimbimTxt, 0, 0);
            this.bimTable.Controls.Add(this.dsnbimTxt, 0, 1);
            this.bimTable.Controls.Add(this.tglbimTxt, 0, 2);
            this.bimTable.Controls.Add(this.nimbimTB, 1, 0);
            this.bimTable.Controls.Add(this.dosenCB, 1, 1);
            this.bimTable.Controls.Add(this.bimDate, 1, 2);
            this.bimTable.Location = new System.Drawing.Point(6, 35);
            this.bimTable.Name = "bimTable";
            this.bimTable.RowCount = 3;
            this.bimTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.bimTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.bimTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.bimTable.Size = new System.Drawing.Size(329, 159);
            this.bimTable.TabIndex = 0;
            // 
            // nimbimTxt
            // 
            this.nimbimTxt.AutoSize = true;
            this.nimbimTxt.Location = new System.Drawing.Point(3, 0);
            this.nimbimTxt.Name = "nimbimTxt";
            this.nimbimTxt.Size = new System.Drawing.Size(38, 20);
            this.nimbimTxt.TabIndex = 0;
            this.nimbimTxt.Text = "NIM";
            // 
            // dsnbimTxt
            // 
            this.dsnbimTxt.AutoSize = true;
            this.dsnbimTxt.Location = new System.Drawing.Point(3, 53);
            this.dsnbimTxt.Name = "dsnbimTxt";
            this.dsnbimTxt.Size = new System.Drawing.Size(56, 20);
            this.dsnbimTxt.TabIndex = 1;
            this.dsnbimTxt.Text = "Dosen";
            // 
            // tglbimTxt
            // 
            this.tglbimTxt.AutoSize = true;
            this.tglbimTxt.Location = new System.Drawing.Point(3, 106);
            this.tglbimTxt.Name = "tglbimTxt";
            this.tglbimTxt.Size = new System.Drawing.Size(145, 20);
            this.tglbimTxt.TabIndex = 2;
            this.tglbimTxt.Text = "Tanggal Bimbingan";
            // 
            // nimbimTB
            // 
            this.nimbimTB.Location = new System.Drawing.Point(167, 3);
            this.nimbimTB.Multiline = true;
            this.nimbimTB.Name = "nimbimTB";
            this.nimbimTB.Size = new System.Drawing.Size(156, 47);
            this.nimbimTB.TabIndex = 3;
            // 
            // dosenCB
            // 
            this.dosenCB.FormattingEnabled = true;
            this.dosenCB.Location = new System.Drawing.Point(167, 56);
            this.dosenCB.Name = "dosenCB";
            this.dosenCB.Size = new System.Drawing.Size(156, 28);
            this.dosenCB.TabIndex = 4;
            // 
            // bimDate
            // 
            this.bimDate.Location = new System.Drawing.Point(167, 109);
            this.bimDate.Name = "bimDate";
            this.bimDate.Size = new System.Drawing.Size(159, 26);
            this.bimDate.TabIndex = 5;
            // 
            // Bimbingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.bimPanel);
            this.Name = "Bimbingan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bimbingan";
            this.bimPanel.ResumeLayout(false);
            this.bimPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bimView)).EndInit();
            this.bimGB.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.idbimGB.ResumeLayout(false);
            this.idbimGB.PerformLayout();
            this.menuTbl.ResumeLayout(false);
            this.bimTable.ResumeLayout(false);
            this.bimTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bimPanel;
        private System.Windows.Forms.Label bimTxt;
        private System.Windows.Forms.DataGridView bimView;
        private System.Windows.Forms.GroupBox bimGB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button srcbimBtn;
        private System.Windows.Forms.Button delbimBtn;
        private System.Windows.Forms.GroupBox idbimGB;
        private System.Windows.Forms.TextBox idbimTB;
        private System.Windows.Forms.TableLayoutPanel menuTbl;
        private System.Windows.Forms.Button addbimBtn;
        private System.Windows.Forms.Button editbimBtn;
        private System.Windows.Forms.Button clrbimBtn;
        private System.Windows.Forms.TableLayoutPanel bimTable;
        private System.Windows.Forms.Label nimbimTxt;
        private System.Windows.Forms.Label dsnbimTxt;
        private System.Windows.Forms.Label tglbimTxt;
        private System.Windows.Forms.TextBox nimbimTB;
        private System.Windows.Forms.ComboBox dosenCB;
        private System.Windows.Forms.DateTimePicker bimDate;
    }
}