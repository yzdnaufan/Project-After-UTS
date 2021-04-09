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
    public partial class Login_Page : Form
    {
        public bool FlagLogin { get; set; }

        public Login_Page()
        {
            InitializeComponent();
            FlagLogin = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Table_1TableAdapter userAdapter = new DataSet1TableAdapters.Table_1TableAdapter();
            DataTable dt = userAdapter.GetDataByUserAndPass(textBoxUser.Text, textBoxPass.Text);

            if (dt.Rows.Count > 0)
            {
                //ada isinya
                MessageBox.Show("Login Sukses");
                FlagLogin = true;
                Close();
            }
            else
            {
                //ngga ada isinya
                MessageBox.Show("Akses ditolak");
                FlagLogin = false;

            }

        }
        
    }
}
