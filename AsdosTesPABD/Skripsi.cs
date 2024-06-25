using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsdosTesPABD
{
    public partial class Skripsi : Form
    {
        private string stringConnection = "Data Source=CHLUNIDIA;Initial Catalog=BimbinganSkripsi;Integrated Security=True;User=sa;Password=Chluni2350719";

        public Skripsi()
        {
            InitializeComponent();
            LoadSkripsiData();
            srcskrpBtn.Click += srcskrpBtn_Click;
        }

        private void LoadSkripsiData()
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Skripsi_View";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    skrpView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading skripsi data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nimskrpTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void judulTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void addskrpBtn_Click(object sender, EventArgs e)
        {
            string nim = nimskrpTB.Text;
            string judul = judulTB.Text;
            string status = stsCB.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nim) || string.IsNullOrEmpty(judul) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();

                    string idSkripsi = GenerateUniqueID(connection);

                    string insertQuery = "INSERT INTO Skripsi (id, judul, nim, status) VALUES (@id, @judul, @nim, @status)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", idSkripsi);
                        command.Parameters.AddWithValue("@judul", judul);
                        command.Parameters.AddWithValue("@nim", nim);
                        command.Parameters.AddWithValue("@status", status);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Skripsi added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add skripsi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadSkripsiData();
            ClearInputFields();
        }

        private string GenerateUniqueID(SqlConnection connection)
        {
            string idSkripsi = "";
            int count = 1;

            while (true)
            {
                idSkripsi = "SK" + count.ToString().PadLeft(4, '0');

                string checkQuery = "SELECT COUNT(*) FROM Skripsi WHERE id = @id";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@id", idSkripsi);
                    int existingCount = (int)checkCmd.ExecuteScalar();
                    if (existingCount == 0)
                    {
                        break;
                    }
                }

                count++;
            }

            return idSkripsi;
        }

        private void ClearInputFields()
        {
            nimskrpTB.Text = "";
            judulTB.Text = "";
            stsCB.SelectedIndex = -1;
            idskrpTB.Text = "";
        }

        private void editskrpBtn_Click(object sender, EventArgs e)
        {
            string idSkripsi = idskrpTB.Text;

            string nim = nimskrpTB.Text;
            string judul = judulTB.Text;
            string status = stsCB.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(idSkripsi) || string.IsNullOrEmpty(nim) || string.IsNullOrEmpty(judul) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please select a skripsi to edit and fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE Skripsi SET judul = @judul, nim = @nim, status = @status WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@judul", judul);
                        command.Parameters.AddWithValue("@nim", nim);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@id", idSkripsi);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Skripsi updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update skripsi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadSkripsiData();
            ClearInputFields();
        }

        private void clearskrpBtn_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void idskrpTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void srcskrpBtn_Click(object sender, EventArgs e)
        {
            string keyword = idskrpTB.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keyword to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Skripsi_View WHERE id_skripsi LIKE @keyword OR judul LIKE @keyword OR nim LIKE @keyword OR nama_mahasiswa LIKE @keyword OR status LIKE @keyword";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    skrpView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ClearInputFields();
        }

        private void delskrpBtn_Click(object sender, EventArgs e)
        {
            string idToDelete = idskrpTB.Text.Trim();

            if (string.IsNullOrEmpty(idToDelete))
            {
                MessageBox.Show("Please enter the ID of the skripsi to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this skripsi?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    try
                    {
                        connection.Open();

                        string deleteQuery = "DELETE FROM Skripsi WHERE id = @id";
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@id", idToDelete);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Skripsi deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearInputFields();
                            }
                            else
                            {
                                MessageBox.Show("Skripsi with the provided ID was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting skripsi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            LoadSkripsiData();
            ClearInputFields();
        }

        private void filterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = filterCB.SelectedItem?.ToString();

            if (selectedStatus == "All")
            {
                LoadSkripsiData();
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    try
                    {
                        connection.Open();

                        string selectQuery = "SELECT * FROM Skripsi_View WHERE status = @status";
                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@status", selectedStatus);

                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            skrpView.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while filtering skripsi data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void skrpView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stsTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
