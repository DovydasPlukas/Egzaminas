using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egzaminas
{
    public partial class Ataskaita : Form
    {
        public ComboBox ComboBoxKategorija
        {
            get { return comboBoxKategorija; }
        }
        public Ataskaita()
        {
            InitializeComponent();
        }
        private void DienuSkaicius()
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            TimeSpan timeDifference = endDate - startDate;
            int daysDifference = timeDifference.Days;

            Dienos.Text = $"Dienu kiekis: {daysDifference}";
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            DienuSkaicius();
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            DienuSkaicius();
        }
        // Grazinu visus ivestus duomenis
        public string Tipas()
        {
            return comboBoxTipas.Text;
        }
        public string Kategorija()
        {
            return comboBoxKategorija.Text;
        }
        public string Min()
        {
            return textBoxMin.Text;
        }
        public string Max()
        {
            return textBoxMax.Text;
        }
        public string Start()
        {
            return dateTimePickerStart.Value.ToString();
        }
        public string End()
        {
            return dateTimePickerEnd.Value.ToString();
        }
        private void Filtruoti_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        public void UpdateComboBoxKategorija(List<string> kategorijaValues)
        {
            ComboBoxKategorija.Items.Clear();
            ComboBoxKategorija.Items.AddRange(kategorijaValues.ToArray());
        }
    }
}
