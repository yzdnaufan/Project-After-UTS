using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiWindowsForms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (PassBox.Text != ConfirmBox.Text)
            {
                MessageBox.Show("Password Tidak Cocok");
                return;
            }

            DataSet1TableAdapters.Table_1TableAdapter adapter = new DataSet1TableAdapters.Table_1TableAdapter();

            adapter.InsertQuery(UserBox.Text, PassBox.Text);

            MessageBox.Show("Registrasi Berhasil");
            Close();
        }
    }
}
