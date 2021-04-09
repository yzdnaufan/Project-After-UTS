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
    public partial class FormTambahKelas : Form
    {
        public int UserID { get; set; }

        public FormTambahKelas()
        {
            InitializeComponent();
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.DataKelasTableAdapter dataKelas = new DataSet1TableAdapters.DataKelasTableAdapter();
                dataKelas.TambahKelas(TextBoxTambahKelas.Text, UserID);
            MessageBox.Show("Berhasil Menambahkan Kelas");
            Close();

        }
    }
}
