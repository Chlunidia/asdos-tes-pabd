using System;
using System.Windows.Forms;

namespace AsdosTesPABD
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            pwTB.PasswordChar = '*';
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = unameTB.Text;
            string password = pwTB.Text;

            // Periksa apakah username dan password sesuai
            if (username == "luni" && password == "harutoku")
            {
                MessageBox.Show("Login successful!");
                this.Hide();

                // Buka form Menu setelah login berhasil
                Menu menuForm = new Menu();
                menuForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login failed! Please check your username and password.");
            }
        }
    }
}