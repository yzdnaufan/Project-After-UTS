using AplikasiWindowsForms.DataSet1TableAdapters;
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

        private void GetButton_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.TabelLaporan' table. You can move, or remove it, as needed.
            TabelLaporanTableAdapter adapter = new TabelLaporanTableAdapter();

            DataTable dt = adapter.GetDataBy((int)comboBox1.SelectedValue, dateTimePicker1.Text);

            if (dt.Rows.Count > 0)
            {
                //jika ada data

                DataTable dt_new = adapter.GetDataBy((int)comboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;

            }
            else
            {
                //jika tdk ada data

                DataSiswaTableAdapter dataSiswa = new DataSiswaTableAdapter();

                DataTable data_siswa = dataSiswa.GetDataByIDKelas((int)comboBox1.SelectedValue);

                foreach (DataRow row in data_siswa.Rows) 
                {
                    //menambah Record Laporan tiap siswa
                    adapter.InsertQuery((int)row[0], (int)comboBox1.SelectedValue, dateTimePicker1.Text, "", row[1].ToString(), comboBox1.Text);
                }

                DataTable dt_new = adapter.GetDataBy((int)comboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;

            }

        }

        private void SimpanButton_Click(object sender, EventArgs e)
        {
            TabelLaporanTableAdapter adapter = new TabelLaporanTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    adapter.UpdateQuery(row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString(), (int)comboBox1.SelectedValue, dateTimePicker1.Text);

                }


            }

            DataTable dt_new = adapter.GetDataBy((int)comboBox1.SelectedValue, dateTimePicker1.Text);
            dataGridView1.DataSource = dt_new;
        }

        private void HapusButton_Click(object sender, EventArgs e)
        {
            TabelLaporanTableAdapter adapter = new TabelLaporanTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    adapter.UpdateQuery("", row.Cells[0].Value.ToString(), (int)comboBox1.SelectedValue, dateTimePicker1.Text);

                }


            }

            DataTable dt_new = adapter.GetDataBy((int)comboBox1.SelectedValue, dateTimePicker1.Text);
            dataGridView1.DataSource = dt_new;
        }

        private void Getbutton1_Click(object sender, EventArgs e)
        {

            //get data

            DataSiswaTableAdapter dataSiswa = new DataSiswaTableAdapter();

            DataTable data_siswa = dataSiswa.GetDataByIDKelas((int)comboBox1.SelectedValue);

            TabelLaporanTableAdapter ada = new TabelLaporanTableAdapter();


            int Hadir = 0, Absen = 0, Terlambat = 0, Ijin = 0;

            //loop
            foreach(DataRow row in data_siswa.Rows)
            {
                //hitung kehadiran
                Hadir = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "hadir").Rows[0][6];

                //hitung absen
                Absen = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "absen").Rows[0][6];

                //hitung terlambat
                Terlambat = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "terlambat").Rows[0][6];

                //Ijin
                Ijin = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "ijin").Rows[0][6];

                ListViewItem litem = new ListViewItem();
                litem.Text = row[1].ToString();
                litem.SubItems.Add(Hadir.ToString());
                litem.SubItems.Add(Absen.ToString());
                litem.SubItems.Add(Terlambat.ToString());
                litem.SubItems.Add(Ijin.ToString());
                listView1.Items.Add(litem);
            }


            //tambahkan





        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();

            register.ShowDialog();
        }
    }
}
