namespace AsdosTesPABD
{
    partial class Skripsi
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
            this.skrpPnl = new System.Windows.Forms.Panel();
            this.filGB = new System.Windows.Forms.GroupBox();
            this.filterCB = new System.Windows.Forms.ComboBox();
            this.skrpGB = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nimskrpTxt = new System.Windows.Forms.Label();
            this.dosenTxt = new System.Windows.Forms.Label();
            this.nimskrpTB = new System.Windows.Forms.TextBox();
            this.judulTB = new System.Windows.Forms.TextBox();
            this.stsTxt = new System.Windows.Forms.Label();
            this.stsCB = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.srcskrpBtn = new System.Windows.Forms.Button();
            this.delskrpBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addskrpBtn = new System.Windows.Forms.Button();
            this.editskrpBtn = new System.Windows.Forms.Button();
            this.clearskrpBtn = new System.Windows.Forms.Button();
            this.idskrpGB = new System.Windows.Forms.GroupBox();
            this.idskrpTB = new System.Windows.Forms.TextBox();
            this.skrpView = new System.Windows.Forms.DataGridView();
            this.skrpTxt = new System.Windows.Forms.Label();
            this.skrpPnl.SuspendLayout();
            this.filGB.SuspendLayout();
            this.skrpGB.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.idskrpGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skrpView)).BeginInit();
            this.SuspendLayout();
            // 
            // skrpPnl
            // 
            this.skrpPnl.Controls.Add(this.filGB);
            this.skrpPnl.Controls.Add(this.skrpGB);
            this.skrpPnl.Controls.Add(this.skrpView);
            this.skrpPnl.Controls.Add(this.skrpTxt);
            this.skrpPnl.Location = new System.Drawing.Point(12, 12);
            this.skrpPnl.Name = "skrpPnl";
            this.skrpPnl.Size = new System.Drawing.Size(954, 620);
            this.skrpPnl.TabIndex = 2;
            // 
            // filGB
            // 
            this.filGB.Controls.Add(this.filterCB);
            this.filGB.Location = new System.Drawing.Point(394, 96);
            this.filGB.Name = "filGB";
            this.filGB.Size = new System.Drawing.Size(557, 72);
            this.filGB.TabIndex = 6;
            this.filGB.TabStop = false;
            this.filGB.Text = "Filter Status";
            // 
            // filterCB
            // 
            this.filterCB.FormattingEnabled = true;
            this.filterCB.Items.AddRange(new object[] {
            "All",
            "Proses",
            "Selesai",
            "Lulus"});
            this.filterCB.Location = new System.Drawing.Point(6, 33);
            this.filterCB.Name = "filterCB";
            this.filterCB.Size = new System.Drawing.Size(545, 28);
            this.filterCB.TabIndex = 0;
            this.filterCB.SelectedIndexChanged += new System.EventHandler(this.filterCB_SelectedIndexChanged);
            // 
            // skrpGB
            // 
            this.skrpGB.Controls.Add(this.tableLayoutPanel2);
            this.skrpGB.Controls.Add(this.tableLayoutPanel3);
            this.skrpGB.Controls.Add(this.tableLayoutPanel1);
            this.skrpGB.Controls.Add(this.idskrpGB);
            this.skrpGB.Location = new System.Drawing.Point(3, 160);
            this.skrpGB.Name = "skrpGB";
            this.skrpGB.Size = new System.Drawing.Size(379, 417);
            this.skrpGB.TabIndex = 2;
            this.skrpGB.TabStop = false;
            this.skrpGB.Text = "Daftar Skripsi";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.08381F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.91619F));
            this.tableLayoutPanel2.Controls.Add(this.nimskrpTxt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dosenTxt, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.nimskrpTB, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.judulTB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.stsTxt, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.stsCB, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(379, 163);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // nimskrpTxt
            // 
            this.nimskrpTxt.AutoSize = true;
            this.nimskrpTxt.Location = new System.Drawing.Point(3, 0);
            this.nimskrpTxt.Name = "nimskrpTxt";
            this.nimskrpTxt.Size = new System.Drawing.Size(38, 20);
            this.nimskrpTxt.TabIndex = 0;
            this.nimskrpTxt.Text = "NIM";
            // 
            // dosenTxt
            // 
            this.dosenTxt.AutoSize = true;
            this.dosenTxt.Location = new System.Drawing.Point(3, 54);
            this.dosenTxt.Name = "dosenTxt";
            this.dosenTxt.Size = new System.Drawing.Size(98, 20);
            this.dosenTxt.TabIndex = 1;
            this.dosenTxt.Text = "Judul Skripsi";
            // 
            // nimskrpTB
            // 
            this.nimskrpTB.Location = new System.Drawing.Point(151, 3);
            this.nimskrpTB.Multiline = true;
            this.nimskrpTB.Name = "nimskrpTB";
            this.nimskrpTB.Size = new System.Drawing.Size(222, 47);
            this.nimskrpTB.TabIndex = 2;
            this.nimskrpTB.TextChanged += new System.EventHandler(this.nimskrpTB_TextChanged);
            // 
            // judulTB
            // 
            this.judulTB.Location = new System.Drawing.Point(151, 57);
            this.judulTB.Multiline = true;
            this.judulTB.Name = "judulTB";
            this.judulTB.Size = new System.Drawing.Size(222, 48);
            this.judulTB.TabIndex = 3;
            this.judulTB.TextChanged += new System.EventHandler(this.judulTB_TextChanged);
            // 
            // stsTxt
            // 
            this.stsTxt.AutoSize = true;
            this.stsTxt.Location = new System.Drawing.Point(3, 108);
            this.stsTxt.Name = "stsTxt";
            this.stsTxt.Size = new System.Drawing.Size(56, 20);
            this.stsTxt.TabIndex = 4;
            this.stsTxt.Text = "Status";
            // 
            // stsCB
            // 
            this.stsCB.FormattingEnabled = true;
            this.stsCB.Items.AddRange(new object[] {
            "Proses",
            "Selesai",
            "Lulus"});
            this.stsCB.Location = new System.Drawing.Point(151, 111);
            this.stsCB.Name = "stsCB";
            this.stsCB.Size = new System.Drawing.Size(222, 28);
            this.stsCB.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.srcskrpBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.delskrpBtn, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 348);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(376, 54);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // srcskrpBtn
            // 
            this.srcskrpBtn.Location = new System.Drawing.Point(3, 3);
            this.srcskrpBtn.Name = "srcskrpBtn";
            this.srcskrpBtn.Size = new System.Drawing.Size(182, 48);
            this.srcskrpBtn.TabIndex = 0;
            this.srcskrpBtn.Text = "Search";
            this.srcskrpBtn.UseVisualStyleBackColor = true;
            this.srcskrpBtn.Click += new System.EventHandler(this.srcskrpBtn_Click);
            // 
            // delskrpBtn
            // 
            this.delskrpBtn.Location = new System.Drawing.Point(191, 3);
            this.delskrpBtn.Name = "delskrpBtn";
            this.delskrpBtn.Size = new System.Drawing.Size(182, 48);
            this.delskrpBtn.TabIndex = 1;
            this.delskrpBtn.Text = "Delete";
            this.delskrpBtn.UseVisualStyleBackColor = true;
            this.delskrpBtn.Click += new System.EventHandler(this.delskrpBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.addskrpBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editskrpBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearskrpBtn, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 202);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 54);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // addskrpBtn
            // 
            this.addskrpBtn.Location = new System.Drawing.Point(3, 3);
            this.addskrpBtn.Name = "addskrpBtn";
            this.addskrpBtn.Size = new System.Drawing.Size(120, 48);
            this.addskrpBtn.TabIndex = 0;
            this.addskrpBtn.Text = "Ajukan";
            this.addskrpBtn.UseVisualStyleBackColor = true;
            this.addskrpBtn.Click += new System.EventHandler(this.addskrpBtn_Click);
            // 
            // editskrpBtn
            // 
            this.editskrpBtn.Location = new System.Drawing.Point(129, 3);
            this.editskrpBtn.Name = "editskrpBtn";
            this.editskrpBtn.Size = new System.Drawing.Size(120, 48);
            this.editskrpBtn.TabIndex = 1;
            this.editskrpBtn.Text = "Edit";
            this.editskrpBtn.UseVisualStyleBackColor = true;
            this.editskrpBtn.Click += new System.EventHandler(this.editskrpBtn_Click);
            // 
            // clearskrpBtn
            // 
            this.clearskrpBtn.Location = new System.Drawing.Point(255, 3);
            this.clearskrpBtn.Name = "clearskrpBtn";
            this.clearskrpBtn.Size = new System.Drawing.Size(121, 48);
            this.clearskrpBtn.TabIndex = 2;
            this.clearskrpBtn.Text = "Clear";
            this.clearskrpBtn.UseVisualStyleBackColor = true;
            this.clearskrpBtn.Click += new System.EventHandler(this.clearskrpBtn_Click);
            // 
            // idskrpGB
            // 
            this.idskrpGB.Controls.Add(this.idskrpTB);
            this.idskrpGB.Location = new System.Drawing.Point(0, 262);
            this.idskrpGB.Name = "idskrpGB";
            this.idskrpGB.Size = new System.Drawing.Size(379, 80);
            this.idskrpGB.TabIndex = 4;
            this.idskrpGB.TabStop = false;
            this.idskrpGB.Text = "Cari Skripsi";
            // 
            // idskrpTB
            // 
            this.idskrpTB.Location = new System.Drawing.Point(3, 25);
            this.idskrpTB.Multiline = true;
            this.idskrpTB.Name = "idskrpTB";
            this.idskrpTB.Size = new System.Drawing.Size(373, 49);
            this.idskrpTB.TabIndex = 0;
            this.idskrpTB.TextChanged += new System.EventHandler(this.idskrpTB_TextChanged);
            // 
            // skrpView
            // 
            this.skrpView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skrpView.Location = new System.Drawing.Point(394, 174);
            this.skrpView.Name = "skrpView";
            this.skrpView.RowHeadersWidth = 62;
            this.skrpView.RowTemplate.Height = 28;
            this.skrpView.Size = new System.Drawing.Size(557, 443);
            this.skrpView.TabIndex = 1;
            this.skrpView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skrpView_CellContentClick);
            // 
            // skrpTxt
            // 
            this.skrpTxt.AutoSize = true;
            this.skrpTxt.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skrpTxt.Location = new System.Drawing.Point(320, 20);
            this.skrpTxt.Name = "skrpTxt";
            this.skrpTxt.Size = new System.Drawing.Size(262, 53);
            this.skrpTxt.TabIndex = 0;
            this.skrpTxt.Text = "Daftar Skripsi";
            // 
            // Skripsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.skrpPnl);
            this.Name = "Skripsi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skripsi";
            this.skrpPnl.ResumeLayout(false);
            this.skrpPnl.PerformLayout();
            this.filGB.ResumeLayout(false);
            this.skrpGB.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.idskrpGB.ResumeLayout(false);
            this.idskrpGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skrpView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel skrpPnl;
        private System.Windows.Forms.GroupBox filGB;
        private System.Windows.Forms.ComboBox filterCB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button srcskrpBtn;
        private System.Windows.Forms.Button delskrpBtn;
        private System.Windows.Forms.GroupBox idskrpGB;
        private System.Windows.Forms.TextBox idskrpTB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addskrpBtn;
        private System.Windows.Forms.Button editskrpBtn;
        private System.Windows.Forms.Button clearskrpBtn;
        private System.Windows.Forms.GroupBox skrpGB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label nimskrpTxt;
        private System.Windows.Forms.TextBox nimskrpTB;
        private System.Windows.Forms.DataGridView skrpView;
        private System.Windows.Forms.Label skrpTxt;
        private System.Windows.Forms.Label dosenTxt;
        private System.Windows.Forms.TextBox judulTB;
        private System.Windows.Forms.Label stsTxt;
        private System.Windows.Forms.ComboBox stsCB;
    }
}