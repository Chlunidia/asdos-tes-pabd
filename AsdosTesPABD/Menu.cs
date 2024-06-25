using System;
using System.Windows.Forms;

namespace AsdosTesPABD
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void skrpBtn_Click(object sender, EventArgs e)
        {
            Skripsi daftarSkripsi = new Skripsi();
            AddFormToPanel(daftarSkripsi, panelMenu);
        }

        private void bimBtn_Click(object sender, EventArgs e)
        {
            Bimbingan daftarBimbingan = new Bimbingan();
            AddFormToPanel(daftarBimbingan, panelMenu);
        }

        private void mhsBtn_Click(object sender, EventArgs e)
        {
            Mahasiswa dataMhs = new Mahasiswa();
            AddFormToPanel(dataMhs, panelMenu);
        }

        private void bosenBtn_Click(object sender, EventArgs e)
        {
            Dosen dataDosen = new Dosen();
            AddFormToPanel(dataDosen, panelMenu);
        }

        private void AddFormToPanel(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }
    }
}
