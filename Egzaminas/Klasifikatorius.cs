using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egzaminas
{
    public partial class Klasifikatorius : Form
    {
        private SqlConnection cnn;
        private string connectionString;

        public Klasifikatorius(Form1 form1)
        {
            InitializeComponent();
            cnn = form1.cnn;
            connectionString = form1.connectionString;
            updateDataGrid();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    cnn.Open();
                    string query;
                    string kategorija = textBox1.Text;

                    query = "INSERT INTO dbo.Kategorija (kategorija)";
                    query += "VALUES ('" + kategorija + "');";
                    SqlCommand command = new SqlCommand(query, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    updateDataGrid();
                }
                catch
                {
                    MessageBox.Show("Įrašymas nepavyko");
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string cellValue = getIdValue();
            string kategorija = textBox1.Text;

            if (string.IsNullOrEmpty(kategorija))
            {
                MessageBox.Show("Neirasyta Kategorija.");
                return;
            }

            string query = "UPDATE Kategorija SET Kategorija = @Kategorija WHERE ID = @ID;";

            try
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand(query, cnn))
                {
                    command.Parameters.AddWithValue("@Kategorija", kategorija);
                    command.Parameters.AddWithValue("@ID", cellValue);

                    command.ExecuteNonQuery();
                }
                cnn.Close();
                updateDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepavyko atnaujinti įrašo: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string cellValue = getIdValue();
            string query = "DELETE FROM Kategorija WHERE ID =" + cellValue + ";";
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand(query, cnn);
                command.ExecuteNonQuery();
                cnn.Close();
                updateDataGrid();
            }
            catch
            {
                MessageBox.Show("Nepavyko ištrinti įrašo");
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private string getIdValue()
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["ID"].Value);
            return cellValue;
        }
        public void updateDataGrid(string customQuery = "")
        {
            string query;
            if (customQuery == "")
            { query = "SELECT * FROM Kategorija"; }
            else { query = customQuery; }
            SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Kategorija");
            dataGridView1.DataSource = ds.Tables["Kategorija"].DefaultView;
        }
    }
}
