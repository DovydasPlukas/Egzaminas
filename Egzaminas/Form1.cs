using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Egzaminas
{
    public partial class Form1 : Form
    {
        public SqlConnection cnn { get; private set; }
        public string connectionString { get; private set; }
        private Klasifikatorius klasifikatorius;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            Prisijungimas prisijungimas = new Prisijungimas();
            if (prisijungimas.ShowDialog() == DialogResult.OK)
            {
                string username = prisijungimas.GetUser(); // User: Testavimas
                string password = prisijungimas.GetPassword(); // Password: Testavimas

                connectionString = @"Data Source=DESKTOP-9ACMJSI\SQLEXPRESS;
                                            Initial Catalog = Finansai;
                                            User ID=" + username + ";" +
                                            "Password=" + password;

                cnn = new SqlConnection(connectionString);

                try
                {
                    cnn.Open();
                    buttonConnect.BackColor = Color.Green;
                    cnn.Close();
                    buttonConnect.Enabled = false;
                    updateDataGrid();
                    // Automatiskas skaiciavimas (Veikia tik be filtro)
                    AtnaujintiLabel();
                    // Tik prisijungus galima naudoti buttons
                    buttonExtend.Enabled = true;
                    buttonDelete.Enabled = true;
                    buttonEdit.Enabled = true;
                    buttonInsert.Enabled = true;
                    buttonUpdate.Enabled = true;
                    Ataskaita.Enabled = true;
                    UpdateComboBoxKategorija();
                }
                catch
                {
                    MessageBox.Show("Prisjungti nepavyko!");
                    buttonConnect.BackColor = Color.Red;
                }
            }
            else
            {
                // Jeigu vartotojas isjungia form/programma neirasius 
                MessageBox.Show("Isjungta programa");
                buttonConnect.BackColor = Color.Red;
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBoxSuma.Text != "" && comboBoxKategorija.Text != "")
            {
                try
                {
                    cnn.Open();
                    int kategorijaid = GetKategorijaId(comboBoxKategorija.Text);
                    string query;
                    string suma = textBoxSuma.Text;
                    string tipas;
                    string data = DateTimePicker.Value.ToString();
                    if (textBoxSuma.Text.StartsWith("-"))
                    {
                        // Jeigu "suma" yra "-", tai "Tipas" yra "Islaidos"
                        tipas = "Islaidos";
                    }
                    else
                    {
                        // Kitaip, tai "Pajamos"
                        tipas = "Pajamos";
                    }
                    query = "INSERT INTO dbo.Apzvalga (kategorijaid, data, suma, tipas)";
                    query += "VALUES ('" + kategorijaid + "', '" + data + "','" + suma + "','" + tipas + "');";

                    SqlCommand command = new SqlCommand(query, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();

                    updateDataGrid();
                    AtnaujintiLabel();
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
            string kategorija = "";
            string data = "";
            string suma = "";
            string tipas;

            if (textBoxSuma.Text != "") { suma = textBoxSuma.Text; }
            if (DateTimePicker.Value.ToString() != "") { data = DateTimePicker.Value.ToString(); }
            if (comboBoxKategorija.Text != "") { kategorija = comboBoxKategorija.Text; }

            if (textBoxSuma.Text.StartsWith("-"))
            { tipas = "Islaidos"; }
            else
            { tipas = "Pajamos"; }

            int kategorijaid = GetKategorijaId(kategorija);

            string query = "UPDATE Apzvalga SET Kategorijaid = " + kategorijaid + ", " +
                "Data = '" + data + "', Suma = '" + suma + "', " +
                "Tipas = '" + tipas + "' WHERE ID = " + cellValue + ";";

            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand(query, cnn);
                command.ExecuteNonQuery();
                cnn.Close();
                updateDataGrid();
                AtnaujintiLabel();
            }
            catch
            {
                MessageBox.Show("Nepavyko atnaujinti įrašo");
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string cellValue = getIdValue();
            string query = "DELETE FROM Apzvalga WHERE ID =" + cellValue + ";";
            try
            {
                cnn.Open();
                SqlCommand command = new SqlCommand(query, cnn);
                command.ExecuteNonQuery();
                cnn.Close();
                updateDataGrid();
                AtnaujintiLabel();
            }
            catch
            {
                MessageBox.Show("Nepavyko ištrinti įrašo");
            }
        }
        private void Ataskaita_Click(object sender, EventArgs e)
        {
            Ataskaita ataskaita = new Ataskaita();

            List<string> kategorijaItems = GetKategorijaValues();
            ataskaita.UpdateComboBoxKategorija(kategorijaItems);

            if (ataskaita.ShowDialog() == DialogResult.OK)
            {
                string tipas = ataskaita.Tipas();
                string kategorija = ataskaita.Kategorija();
                string min = ataskaita.Min();
                string max = ataskaita.Max();
                string start = ataskaita.Start();
                string end = ataskaita.End();

                string whereClause = GenerateWhereClause(tipas, kategorija, min, max, start, end);

                string query = "SELECT Apzvalga.ID, Kategorija.kategorija, Apzvalga.data, Apzvalga.suma, Apzvalga.tipas FROM Apzvalga " +
                    "INNER JOIN Kategorija ON Apzvalga.Kategorijaid = Kategorija.ID WHERE " + whereClause;

                try
                {
                    cnn.Open();
                    updateDataGrid(query);
                    AtnaujintiLabel();
                    cnn.Close();
                }
                catch
                {
                    MessageBox.Show("Nepavyko įvykdyti ataskaitos");
                }
            }
        }

        private string GenerateWhereClause(string tipas, string kategorija, string min, string max, string start, string end)
        {
            StringBuilder whereClause = new StringBuilder();

            bool added = false;

            if (!string.IsNullOrEmpty(tipas))
            {
                whereClause.Append("Apzvalga.Tipas = '" + tipas + "'");
                added = true;
            }

            if (!string.IsNullOrEmpty(kategorija))
            {
                int kategorijaid = GetKategorijaId(kategorija);
                if (added) { whereClause.Append(" AND "); }
                whereClause.Append("Apzvalga.Kategorijaid = " + kategorijaid);
                added = true;
            }

            if (!string.IsNullOrEmpty(min))
            {
                if (added) { whereClause.Append(" AND "); }
                whereClause.Append("Apzvalga.Suma >= '" + min + "'");
                added = true;
            }

            if (!string.IsNullOrEmpty(max))
            {
                if (added) { whereClause.Append(" AND "); }
                whereClause.Append("Apzvalga.Suma <= '" + max + "'");
                added = true;
            }

            if (!string.IsNullOrEmpty(start))
            {
                if (added) { whereClause.Append(" AND "); }
                whereClause.Append("Apzvalga.Data >= '" + start + "'");
                added = true;
            }

            if (!string.IsNullOrEmpty(end))
            {
                if (added) { whereClause.Append(" AND "); }
                whereClause.Append("Apzvalga.Data <= '" + end + "'");
            }

            return whereClause.ToString();
        }



        private void buttonExtend_Click(object sender, EventArgs e)
        {
            klasifikatorius = new Klasifikatorius(this);
            klasifikatorius.ShowDialog();
            UpdateComboBoxKategorija();
        }
        //Combobox kategorija uzpildymas
        public List<string> GetKategorijaValues()
        {
            List<string> kategorijaValues = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Kategorija FROM Kategorija";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                kategorijaValues.Add(reader["Kategorija"].ToString());
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Klaida");
            }

            return kategorijaValues;
        }
        private void UpdateComboBoxKategorija()
        {
            List<string> kategorijaValues = GetKategorijaValues();
            comboBoxKategorija.Items.Clear();
            comboBoxKategorija.Items.AddRange(kategorijaValues.ToArray());
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            updateDataGrid();
            AtnaujintiLabel();
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
            {
                query = "SELECT" +
                    " Apzvalga.ID," +
                    " Kategorija.kategorija," +
                    " Apzvalga.data," +
                    " Apzvalga.suma," +
                    " Apzvalga.tipas" +
                    " FROM Apzvalga" +
                    " INNER JOIN Kategorija ON Apzvalga.Kategorijaid = Kategorija.ID;";
            }
            else { query = customQuery; }
            SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Apzvalga");
            dataGridView1.DataSource = ds.Tables["Apzvalga"].DefaultView;
        }
        // Labels nesikeicia jeigu pasirenkama "Kurti ataskaita"
        private void AtnaujintiLabel()
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();

                // Pajamos
                string pajamosQuery = "SELECT ISNULL(SUM(suma), 0) FROM Apzvalga WHERE Tipas = 'Pajamos'";
                SqlCommand pajamosCommand = new SqlCommand(pajamosQuery, cnn);
                decimal pajamosResult = Convert.ToDecimal(pajamosCommand.ExecuteScalar());
                Pajamos.Text = $"Pajamos: {pajamosResult.ToString("C")}";

                // Islaidos
                string islaidosQuery = "SELECT ISNULL(SUM(suma), 0) FROM Apzvalga WHERE Tipas = 'Islaidos'";
                SqlCommand islaidosCommand = new SqlCommand(islaidosQuery, cnn);
                decimal islaidosResult = Convert.ToDecimal(islaidosCommand.ExecuteScalar());
                Islaidos.Text = $"Islaidos: {islaidosResult.ToString("C")}";

                // Likutis
                decimal likutisResult = pajamosResult + islaidosResult;
                Likutis.Text = $"Likutis: {likutisResult.ToString("C")}";

                cnn.Close();
            }
        }

        private int GetKategorijaId(string selectedKategorija)
        {
            int kategorijaid = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT ID FROM dbo.Kategorija WHERE Kategorija = @Kategorija";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Kategorija", selectedKategorija);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            kategorijaid = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Klaida kategorijaid nebuvo rastas");
            }

            return kategorijaid;
        }
    }
}