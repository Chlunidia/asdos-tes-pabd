namespace AsdosTesPABD
{
    partial class loginForm
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
            this.loginTxt = new System.Windows.Forms.Label();
            this.unameTxt = new System.Windows.Forms.Label();
            this.pwTxt = new System.Windows.Forms.Label();
            this.unameTB = new System.Windows.Forms.TextBox();
            this.pwTB = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loginGB = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.loginGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTxt
            // 
            this.loginTxt.AutoSize = true;
            this.loginTxt.Font = new System.Drawing.Font("Monotype Corsiva", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTxt.Location = new System.Drawing.Point(413, 124);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(149, 67);
            this.loginTxt.TabIndex = 0;
            this.loginTxt.Text = "Login";
            // 
            // unameTxt
            // 
            this.unameTxt.AutoSize = true;
            this.unameTxt.Location = new System.Drawing.Point(3, 0);
            this.unameTxt.Name = "unameTxt";
            this.unameTxt.Size = new System.Drawing.Size(83, 20);
            this.unameTxt.TabIndex = 1;
            this.unameTxt.Text = "Username";
            // 
            // pwTxt
            // 
            this.pwTxt.AutoSize = true;
            this.pwTxt.Location = new System.Drawing.Point(3, 50);
            this.pwTxt.Name = "pwTxt";
            this.pwTxt.Size = new System.Drawing.Size(78, 20);
            this.pwTxt.TabIndex = 2;
            this.pwTxt.Text = "Password";
            // 
            // unameTB
            // 
            this.unameTB.Location = new System.Drawing.Point(300, 3);
            this.unameTB.Multiline = true;
            this.unameTB.Name = "unameTB";
            this.unameTB.Size = new System.Drawing.Size(292, 44);
            this.unameTB.TabIndex = 3;
            // 
            // pwTB
            // 
            this.pwTB.Location = new System.Drawing.Point(300, 53);
            this.pwTB.Multiline = true;
            this.pwTB.Name = "pwTB";
            this.pwTB.Size = new System.Drawing.Size(292, 44);
            this.pwTB.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(180, 438);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(607, 56);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.unameTxt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pwTxt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pwTB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.unameTB, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // loginGB
            // 
            this.loginGB.Controls.Add(this.tableLayoutPanel1);
            this.loginGB.Location = new System.Drawing.Point(180, 273);
            this.loginGB.Name = "loginGB";
            this.loginGB.Size = new System.Drawing.Size(607, 159);
            this.loginGB.TabIndex = 7;
            this.loginGB.TabStop = false;
            this.loginGB.Text = "Enter Username and Password";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 727);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.loginGB);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.loginGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginTxt;
        private System.Windows.Forms.Label unameTxt;
        private System.Windows.Forms.Label pwTxt;
        private System.Windows.Forms.TextBox unameTB;
        private System.Windows.Forms.TextBox pwTB;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox loginGB;
    }
}

