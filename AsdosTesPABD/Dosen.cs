using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsdosTesPABD
{
    public partial class Dosen : Form
    {
        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=BimbinganSkripsi;Integrated Security=True;User=sa;Password=Chluni2350719";

        public Dosen()
        {
            InitializeComponent();
            LoadDosenView();
        }

        private void LoadDosenView()
        {
            string selectQuery = "SELECT * FROM Dosen";

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

                        dosenView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading dosen data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void srcBtn_Click(object sender, EventArgs e)
        {
            string keyword = dosenTB.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keyword to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchQuery = "SELECT * FROM Dosen WHERE nidn LIKE @keyword OR nama_dsn LIKE @keyword";

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
                        dosenView.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No matching records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dosenView.DataSource = null;
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