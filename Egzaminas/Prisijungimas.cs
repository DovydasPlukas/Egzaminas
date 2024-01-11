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
    public partial class Prisijungimas : Form
    {
        public Prisijungimas()
        {
            InitializeComponent();
            //Paslepti rasoma slaptazodi
            textBoxPassword.PasswordChar = '*';
        }

        private void ButtonPrisijungti_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        public string GetUser()
        {
            return textBoxUser.Text;
        }

        public string GetPassword()
        {
            return textBoxPassword.Text;
        }
    }
}
