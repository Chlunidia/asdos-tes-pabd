using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsdosTesPABD
{
    public partial class Bimbingan : Form
    {
        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=BimbinganSkripsi;Integrated Security=True;User=sa;Password=Chluni2350719";

        public Bimbingan()
        {
            InitializeComponent();
            LoadBimbinganData();
            LoadDosenData();
        }

        private void LoadBimbinganData()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Bimbingan_View";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    bimView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading skripsi data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadDosenData()
        {
            string query = "SELECT nidn, nama_dsn FROM Dosen";

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    dosenCB.DataSource = dataTable;
                    dosenCB.DisplayMember = "nama_dsn";
                    dosenCB.ValueMember = "nidn";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading dosen data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addbimBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();
                    string idBimbingan = GenerateUniqueID(connection);
                    string nidn = dosenCB.SelectedValue.ToString();
                    DateTime tanggalBimbingan = bimDate.Value;
                    string insertQuery = "INSERT INTO Bimbingan_Tugas_Akhir (id_bim, nim, nidn, tgl_bim) " +
                                         "VALUES (@id, @nim, @nidn, @tglBim)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", idBimbingan);
                        command.Parameters.AddWithValue("@nim", nimbimTB.Text);
                        command.Parameters.AddWithValue("@nidn", nidn);
                        command.Parameters.AddWithValue("@tglBim", tanggalBimbingan);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bimbingan added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputFields();
                            LoadBimbinganData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add bimbingan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding bimbingan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadBimbinganData();
            ClearInputFields();
        }

        private string GenerateUniqueID(SqlConnection connection)
        {
            string idBimbingan = "";
            int count = 1;

            while (true)
            {
                idBimbingan = "BM" + count.ToString().PadLeft(4, '0');
                string checkQuery = "SELECT COUNT(*) FROM Bimbingan_Tugas_Akhir WHERE id_bim = @id";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@id", idBimbingan);
                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount == 0)
                    {
                        break;
                    }
                }

                count++;
            }

            return idBimbingan;
        }

        private void ClearInputFields()
        {
            nimbimTB.Text = "";
            bimDate.Value = DateTime.Now;
            idbimTB.Text = "";
        }

        private void editbimBtn_Click(object sender, EventArgs e)
        {
            string idBimbingan = idbimTB.Text;
            string nim = nimbimTB.Text;
            string nidn = dosenCB.SelectedValue.ToString();
            DateTime tanggalBimbingan = bimDate.Value;

            if (string.IsNullOrEmpty(idBimbingan) || string.IsNullOrEmpty(nim) || string.IsNullOrEmpty(nidn))
            {
                MessageBox.Show("Please select a bimbingan to edit and fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();
                    string updateQuery = "UPDATE Bimbingan_Tugas_Akhir SET nim = @nim, nidn = @nidn, tgl_bim = @tglBim WHERE id_bim = @id";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@nim", nim);
                        command.Parameters.AddWithValue("@nidn", nidn);
                        command.Parameters.AddWithValue("@tglBim", tanggalBimbingan);
                        command.Parameters.AddWithValue("@id", idBimbingan);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bimbingan updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputFields();
                            LoadBimbinganData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update bimbingan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating bimbingan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ClearInputFields();
            LoadBimbinganData();
        }

        private void clrbimBtn_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void srcbimBtn_Click(object sender, EventArgs e)
        {
            string keyword = idbimTB.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keyword to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchQuery = "SELECT * FROM Bimbingan_View WHERE id_bim LIKE @keyword OR nim LIKE @keyword OR nama_mahasiswa LIKE @keyword OR nama_dosen LIKE @keyword";

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
                        bimView.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("No matching records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bimView.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ClearInputFields();
        }

        private void delbimBtn_Click(object sender, EventArgs e)
        {
            string idBimbingan = idbimTB.Text;
            if (string.IsNullOrEmpty(idBimbingan))
            {
                MessageBox.Show("Please enter the ID of the bimbingan to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this bimbingan?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    try
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM Bimbingan_Tugas_Akhir WHERE id_bim = @id";
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@id", idBimbingan);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Bimbingan deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete bimbingan. Bimbingan with specified ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting bimbingan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            ClearInputFields();
            LoadBimbinganData();
        }
    }
}
