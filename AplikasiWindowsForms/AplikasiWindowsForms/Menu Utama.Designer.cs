namespace AplikasiWindowsForms
{
    partial class MenuUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.TambahSiswaButton = new System.Windows.Forms.Button();
            this.TambahKelasButton = new System.Windows.Forms.Button();
            this.HapusButton = new System.Windows.Forms.Button();
            this.SimpanButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namaSiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelLaporanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new AplikasiWindowsForms.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataKelasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AplikasiWindowsForms.DataSet1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Getbutton1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataKelasTableAdapter = new AplikasiWindowsForms.DataSet1TableAdapters.DataKelasTableAdapter();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelLaporanTableAdapter = new AplikasiWindowsForms.DataSet1TableAdapters.TabelLaporanTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelLaporanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKelasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 585);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RegisterButton);
            this.tabPage1.Controls.Add(this.GetButton);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.TambahSiswaButton);
            this.tabPage1.Controls.Add(this.TambahKelasButton);
            this.tabPage1.Controls.Add(this.HapusButton);
            this.tabPage1.Controls.Add(this.SimpanButton);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kehadiran";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(621, 482);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(136, 31);
            this.RegisterButton.TabIndex = 11;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(480, 59);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(69, 23);
            this.GetButton.TabIndex = 10;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserLabel,
            this.StatusLabelUser});
            this.statusStrip1.Location = new System.Drawing.Point(3, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(757, 25);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UserLabel
            // 
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(62, 20);
            this.UserLabel.Text = "User Id :";
            // 
            // StatusLabelUser
            // 
            this.StatusLabelUser.Name = "StatusLabelUser";
            this.StatusLabelUser.Size = new System.Drawing.Size(15, 20);
            this.StatusLabelUser.Text = "-";
            // 
            // TambahSiswaButton
            // 
            this.TambahSiswaButton.Location = new System.Drawing.Point(621, 88);
            this.TambahSiswaButton.Name = "TambahSiswaButton";
            this.TambahSiswaButton.Size = new System.Drawing.Size(136, 31);
            this.TambahSiswaButton.TabIndex = 8;
            this.TambahSiswaButton.Text = "Tambah Siswa";
            this.TambahSiswaButton.UseVisualStyleBackColor = true;
            this.TambahSiswaButton.Click += new System.EventHandler(this.TambahSiswaButton_Click);
            // 
            // TambahKelasButton
            // 
            this.TambahKelasButton.Location = new System.Drawing.Point(621, 46);
            this.TambahKelasButton.Name = "TambahKelasButton";
            this.TambahKelasButton.Size = new System.Drawing.Size(136, 36);
            this.TambahKelasButton.TabIndex = 7;
            this.TambahKelasButton.Text = "Tambah Kelas";
            this.TambahKelasButton.UseVisualStyleBackColor = true;
            this.TambahKelasButton.Click += new System.EventHandler(this.TambahKelasButton_Click);
            // 
            // HapusButton
            // 
            this.HapusButton.Location = new System.Drawing.Point(480, 151);
            this.HapusButton.Name = "HapusButton";
            this.HapusButton.Size = new System.Drawing.Size(90, 34);
            this.HapusButton.TabIndex = 6;
            this.HapusButton.Text = "Hapus";
            this.HapusButton.UseVisualStyleBackColor = true;
            this.HapusButton.Click += new System.EventHandler(this.HapusButton_Click);
            // 
            // SimpanButton
            // 
            this.SimpanButton.Location = new System.Drawing.Point(480, 111);
            this.SimpanButton.Name = "SimpanButton";
            this.SimpanButton.Size = new System.Drawing.Size(90, 34);
            this.SimpanButton.TabIndex = 5;
            this.SimpanButton.Text = "Simpan";
            this.SimpanButton.UseVisualStyleBackColor = true;
            this.SimpanButton.Click += new System.EventHandler(this.SimpanButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaSiswaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabelLaporanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(392, 355);
            this.dataGridView1.TabIndex = 4;
            // 
            // namaSiswaDataGridViewTextBoxColumn
            // 
            this.namaSiswaDataGridViewTextBoxColumn.DataPropertyName = "NamaSiswa";
            this.namaSiswaDataGridViewTextBoxColumn.HeaderText = "NamaSiswa";
            this.namaSiswaDataGridViewTextBoxColumn.Name = "namaSiswaDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // tabelLaporanBindingSource
            // 
            this.tabelLaporanBindingSource.DataMember = "TabelLaporan";
            this.tabelLaporanBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kelas";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(274, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dataKelasBindingSource;
            this.comboBox1.DisplayMember = "NamaKelas";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IDKelas";
            // 
            // dataKelasBindingSource
            // 
            this.dataKelasBindingSource.DataMember = "DataKelas";
            this.dataKelasBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Getbutton1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Laporan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Getbutton1
            // 
            this.Getbutton1.Location = new System.Drawing.Point(469, 58);
            this.Getbutton1.Name = "Getbutton1";
            this.Getbutton1.Size = new System.Drawing.Size(69, 23);
            this.Getbutton1.TabIndex = 15;
            this.Getbutton1.Text = "Get";
            this.Getbutton1.UseVisualStyleBackColor = true;
            this.Getbutton1.Click += new System.EventHandler(this.Getbutton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kelas";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(263, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(156, 22);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.dataKelasBindingSource;
            this.comboBox2.DisplayMember = "NamaKelas";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(27, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 24);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.ValueMember = "IDKelas";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 140);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(575, 376);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nama Siswa";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kehadiran";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Absen";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Terlambat";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ijin";
            // 
            // dataKelasTableAdapter
            // 
            this.dataKelasTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // tabelLaporanTableAdapter
            // 
            this.tabelLaporanTableAdapter.ClearBeforeFill = true;
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 585);
            this.Controls.Add(this.tabControl1);
            this.Name = "MenuUtama";
            this.Text = "Menu Utama";
            this.Activated += new System.EventHandler(this.MenuUtama_Activated);
            this.Load += new System.EventHandler(this.MenuUtama_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelLaporanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKelasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button TambahSiswaButton;
        private System.Windows.Forms.Button TambahKelasButton;
        private System.Windows.Forms.Button HapusButton;
        private System.Windows.Forms.Button SimpanButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelUser;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataKelasBindingSource;
        private DataSet1TableAdapters.DataKelasTableAdapter dataKelasTableAdapter;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource tabelLaporanBindingSource;
        private DataSet1TableAdapters.TabelLaporanTableAdapter tabelLaporanTableAdapter;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Getbutton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.ToolStripStatusLabel UserLabel;
    }
}