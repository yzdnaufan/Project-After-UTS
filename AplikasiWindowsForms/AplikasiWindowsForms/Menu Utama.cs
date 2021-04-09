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
    public partial class MenuUtama : Form
    {
        public bool logIn { get; set; }
        public int UserID { get; set; }

        public MenuUtama()
        {
            InitializeComponent();
            logIn = false;
        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {
            

        }

        private void MenuUtama_Activated(object sender, EventArgs e)
        {
            if (logIn == false)
            {
                //buka form login
                Login_Page login_ = new Login_Page();
                login_.ShowDialog();

                //check flag login berhasil atau tidak

                if (login_.FlagLogin == false)
                {
                    Close();
                }
                else
                {
                    UserID = login_.UserID;
                    StatusLabelUser.Text = UserID.ToString();
                    logIn = true;

                    // TODO: This line of code loads data into the 'dataSet1.DataKelas' table. You can move, or remove it, as needed.
                    this.dataKelasTableAdapter.Fill(this.dataSet1.DataKelas);

                    //filter Kelas berdasar User ID yang login
                    dataKelasBindingSource.Filter = "UserID = '" + UserID.ToString() + "'";
                }
            }
            
        }

        private void TambahKelasButton_Click(object sender, EventArgs e)
        {
            FormTambahKelas tambahKelas = new FormTambahKelas();
            tambahKelas.UserID = this.UserID;
            tambahKelas.ShowDialog();

        }

        private void TambahSiswaButton_Click(object sender, EventArgs e)
        {
            FormTambahSiswa tambahSiswa = new FormTambahSiswa();

            tambahSiswa.NamaKelas = comboBox1.Text;
            tambahSiswa.IDKelas = (int) comboBox1.SelectedValue;

            tambahSiswa.ShowDialog();

        }
    }
}
