namespace AsdosTesPABD
{
    partial class Menu
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
            this.menuPnl = new System.Windows.Forms.Panel();
            this.tableMenuPnl = new System.Windows.Forms.TableLayoutPanel();
            this.skrpBtn = new System.Windows.Forms.Button();
            this.bimBtn = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.wlcmTxt = new System.Windows.Forms.Label();
            this.mhsBtn = new System.Windows.Forms.Button();
            this.bosenBtn = new System.Windows.Forms.Button();
            this.menuPnl.SuspendLayout();
            this.tableMenuPnl.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPnl
            // 
            this.menuPnl.Controls.Add(this.tableMenuPnl);
            this.menuPnl.Location = new System.Drawing.Point(12, 12);
            this.menuPnl.Name = "menuPnl";
            this.menuPnl.Size = new System.Drawing.Size(982, 76);
            this.menuPnl.TabIndex = 0;
            // 
            // tableMenuPnl
            // 
            this.tableMenuPnl.ColumnCount = 4;
            this.tableMenuPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMenuPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMenuPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMenuPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMenuPnl.Controls.Add(this.bimBtn, 3, 0);
            this.tableMenuPnl.Controls.Add(this.skrpBtn, 2, 0);
            this.tableMenuPnl.Controls.Add(this.mhsBtn, 0, 0);
            this.tableMenuPnl.Controls.Add(this.bosenBtn, 1, 0);
            this.tableMenuPnl.Location = new System.Drawing.Point(3, 3);
            this.tableMenuPnl.Name = "tableMenuPnl";
            this.tableMenuPnl.RowCount = 1;
            this.tableMenuPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMenuPnl.Size = new System.Drawing.Size(976, 70);
            this.tableMenuPnl.TabIndex = 0;
            // 
            // skrpBtn
            // 
            this.skrpBtn.Location = new System.Drawing.Point(491, 3);
            this.skrpBtn.Name = "skrpBtn";
            this.skrpBtn.Size = new System.Drawing.Size(238, 64);
            this.skrpBtn.TabIndex = 0;
            this.skrpBtn.Text = "Daftar Skripsi";
            this.skrpBtn.UseVisualStyleBackColor = true;
            this.skrpBtn.Click += new System.EventHandler(this.skrpBtn_Click);
            // 
            // bimBtn
            // 
            this.bimBtn.Location = new System.Drawing.Point(735, 3);
            this.bimBtn.Name = "bimBtn";
            this.bimBtn.Size = new System.Drawing.Size(238, 64);
            this.bimBtn.TabIndex = 1;
            this.bimBtn.Text = "Ajukan Bimbingan";
            this.bimBtn.UseVisualStyleBackColor = true;
            this.bimBtn.Click += new System.EventHandler(this.bimBtn_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.wlcmTxt);
            this.panelMenu.Location = new System.Drawing.Point(12, 94);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(982, 656);
            this.panelMenu.TabIndex = 1;
            // 
            // wlcmTxt
            // 
            this.wlcmTxt.AutoSize = true;
            this.wlcmTxt.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlcmTxt.Location = new System.Drawing.Point(389, 250);
            this.wlcmTxt.Name = "wlcmTxt";
            this.wlcmTxt.Size = new System.Drawing.Size(183, 53);
            this.wlcmTxt.TabIndex = 0;
            this.wlcmTxt.Text = "Welcome!";
            // 
            // mhsBtn
            // 
            this.mhsBtn.Location = new System.Drawing.Point(3, 3);
            this.mhsBtn.Name = "mhsBtn";
            this.mhsBtn.Size = new System.Drawing.Size(238, 64);
            this.mhsBtn.TabIndex = 2;
            this.mhsBtn.Text = "Data Mahasiswa";
            this.mhsBtn.UseVisualStyleBackColor = true;
            this.mhsBtn.Click += new System.EventHandler(this.mhsBtn_Click);
            // 
            // bosenBtn
            // 
            this.bosenBtn.Location = new System.Drawing.Point(247, 3);
            this.bosenBtn.Name = "bosenBtn";
            this.bosenBtn.Size = new System.Drawing.Size(238, 64);
            this.bosenBtn.TabIndex = 3;
            this.bosenBtn.Text = "Data Dosen";
            this.bosenBtn.UseVisualStyleBackColor = true;
            this.bosenBtn.Click += new System.EventHandler(this.bosenBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 762);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuPnl);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuPnl.ResumeLayout(false);
            this.tableMenuPnl.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPnl;
        private System.Windows.Forms.TableLayoutPanel tableMenuPnl;
        private System.Windows.Forms.Button skrpBtn;
        private System.Windows.Forms.Button bimBtn;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label wlcmTxt;
        private System.Windows.Forms.Button mhsBtn;
        private System.Windows.Forms.Button bosenBtn;
    }
}