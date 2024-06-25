using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsdosTesPABD
{
    public partial class Mahasiswa : Form
    {
        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=BimbinganSkripsi;Integrated Security=True;User=sa;Password=Chluni2350719";

        public Mahasiswa()
        {
            InitializeComponent();
            LoadMahasiswaView();
        }

        private void LoadMahasiswaView()
        {
            string selectQuery = "SELECT * FROM Mahasiswa_View";

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        mhsView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading mahasiswa data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void stsfilterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = stsfilterCB.SelectedItem?.ToString();

            string selectQuery = "SELECT * FROM Mahasiswa_View";

            if (selectedFilter == "Sudah Daftar")
            {
                selectQuery += " WHERE id_skripsi IS NOT NULL";
            }
            else if (selectedFilter == "Belum Daftar")
            {
                selectQuery += " WHERE id_skripsi IS NULL";
            }

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        mhsView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while filtering mahasiswa data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void srcBtn_Click(object sender, EventArgs e)
        {
            string keyword = nimmhsTB.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keyword to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchQuery = "SELECT * FROM Mahasiswa_View WHERE nim LIKE @keyword OR nama LIKE @keyword OR id_skripsi LIKE @keyword";

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(searchQuery, connection);
                    command.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                     
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        mhsView.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No matching records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mhsView.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
