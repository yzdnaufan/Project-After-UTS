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
    public partial class FormTambahSiswa : Form
    {

        public int IDKelas { get; set; }

        public string NamaKelas { get; set; }

        public FormTambahSiswa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormTambahSiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DataSiswa' table. You can move, or remove it, as needed.
            this.dataSiswaTableAdapter.Fill(this.dataSet1.DataSiswa);

            dataSiswaBindingSource.Filter = "IDKelas = '" + IDKelas.ToString() + "'";

            LabelNamaKelas.Text = NamaKelas;

            LabelIDKelas.Text = IDKelas.ToString();

        }

        private void TombolSimpan_Click(object sender, EventArgs e)
        {

            this.dataSiswaBindingSource.EndEdit();

            //menyimpan data editan kedalam DB
            this.dataSiswaTableAdapter.Update(dataSet1.DataSiswa);

            
        }
        
    }
}
