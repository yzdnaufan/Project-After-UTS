namespace AplikasiWindowsForms
{
    partial class FormTambahSiswa
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
            this.textNamaKelas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDSiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaSiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AplikasiWindowsForms.DataSet1();
            this.LabelNamaKelas = new System.Windows.Forms.Label();
            this.LabelIDKelas = new System.Windows.Forms.Label();
            this.IDKelasText = new System.Windows.Forms.Label();
            this.TombolSimpan = new System.Windows.Forms.Button();
            this.dataSiswaTableAdapter = new AplikasiWindowsForms.DataSet1TableAdapters.DataSiswaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textNamaKelas
            // 
            this.textNamaKelas.AutoSize = true;
            this.textNamaKelas.BackColor = System.Drawing.Color.White;
            this.textNamaKelas.Location = new System.Drawing.Point(12, 39);
            this.textNamaKelas.Name = "textNamaKelas";
            this.textNamaKelas.Size = new System.Drawing.Size(92, 17);
            this.textNamaKelas.TabIndex = 0;
            this.textNamaKelas.Text = "Nama Kelas :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSiswaDataGridViewTextBoxColumn,
            this.namaSiswaDataGridViewTextBoxColumn,
            this.iDKelasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataSiswaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(612, 419);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDSiswaDataGridViewTextBoxColumn
            // 
            this.iDSiswaDataGridViewTextBoxColumn.DataPropertyName = "IDSiswa";
            this.iDSiswaDataGridViewTextBoxColumn.HeaderText = "IDSiswa";
            this.iDSiswaDataGridViewTextBoxColumn.Name = "iDSiswaDataGridViewTextBoxColumn";
            this.iDSiswaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaSiswaDataGridViewTextBoxColumn
            // 
            this.namaSiswaDataGridViewTextBoxColumn.DataPropertyName = "NamaSiswa";
            this.namaSiswaDataGridViewTextBoxColumn.HeaderText = "NamaSiswa";
            this.namaSiswaDataGridViewTextBoxColumn.Name = "namaSiswaDataGridViewTextBoxColumn";
            // 
            // iDKelasDataGridViewTextBoxColumn
            // 
            this.iDKelasDataGridViewTextBoxColumn.DataPropertyName = "IDKelas";
            this.iDKelasDataGridViewTextBoxColumn.HeaderText = "IDKelas";
            this.iDKelasDataGridViewTextBoxColumn.Name = "iDKelasDataGridViewTextBoxColumn";
            // 
            // dataSiswaBindingSource
            // 
            this.dataSiswaBindingSource.DataMember = "DataSiswa";
            this.dataSiswaBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LabelNamaKelas
            // 
            this.LabelNamaKelas.AutoSize = true;
            this.LabelNamaKelas.BackColor = System.Drawing.Color.White;
            this.LabelNamaKelas.Location = new System.Drawing.Point(110, 39);
            this.LabelNamaKelas.Name = "LabelNamaKelas";
            this.LabelNamaKelas.Size = new System.Drawing.Size(13, 17);
            this.LabelNamaKelas.TabIndex = 2;
            this.LabelNamaKelas.Text = "-";
            // 
            // LabelIDKelas
            // 
            this.LabelIDKelas.AutoSize = true;
            this.LabelIDKelas.BackColor = System.Drawing.Color.White;
            this.LabelIDKelas.Location = new System.Drawing.Point(575, 39);
            this.LabelIDKelas.Name = "LabelIDKelas";
            this.LabelIDKelas.Size = new System.Drawing.Size(13, 17);
            this.LabelIDKelas.TabIndex = 4;
            this.LabelIDKelas.Text = "-";
            this.LabelIDKelas.Click += new System.EventHandler(this.label2_Click);
            // 
            // IDKelasText
            // 
            this.IDKelasText.AutoSize = true;
            this.IDKelasText.BackColor = System.Drawing.Color.White;
            this.IDKelasText.Location = new System.Drawing.Point(477, 39);
            this.IDKelasText.Name = "IDKelasText";
            this.IDKelasText.Size = new System.Drawing.Size(68, 17);
            this.IDKelasText.TabIndex = 3;
            this.IDKelasText.Text = "ID Kelas :";
            // 
            // TombolSimpan
            // 
            this.TombolSimpan.Location = new System.Drawing.Point(513, 519);
            this.TombolSimpan.Name = "TombolSimpan";
            this.TombolSimpan.Size = new System.Drawing.Size(111, 34);
            this.TombolSimpan.TabIndex = 5;
            this.TombolSimpan.Text = "Simpan";
            this.TombolSimpan.UseVisualStyleBackColor = true;
            this.TombolSimpan.Click += new System.EventHandler(this.TombolSimpan_Click);
            // 
            // dataSiswaTableAdapter
            // 
            this.dataSiswaTableAdapter.ClearBeforeFill = true;
            // 
            // FormTambahSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 565);
            this.Controls.Add(this.TombolSimpan);
            this.Controls.Add(this.LabelIDKelas);
            this.Controls.Add(this.IDKelasText);
            this.Controls.Add(this.LabelNamaKelas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textNamaKelas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTambahSiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahSiswa";
            this.Load += new System.EventHandler(this.FormTambahSiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textNamaKelas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LabelNamaKelas;
        private System.Windows.Forms.Label LabelIDKelas;
        private System.Windows.Forms.Label IDKelasText;
        private System.Windows.Forms.Button TombolSimpan;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSiswaBindingSource;
        private DataSet1TableAdapters.DataSiswaTableAdapter dataSiswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKelasDataGridViewTextBoxColumn;
    }
}