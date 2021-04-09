namespace AplikasiWindowsForms
{
    partial class FormTambahKelas
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
            this.Tambah = new System.Windows.Forms.Button();
            this.LabelKelas = new System.Windows.Forms.Label();
            this.TextBoxTambahKelas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tambah
            // 
            this.Tambah.Location = new System.Drawing.Point(196, 125);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(75, 23);
            this.Tambah.TabIndex = 0;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseVisualStyleBackColor = true;
            this.Tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // LabelKelas
            // 
            this.LabelKelas.AutoSize = true;
            this.LabelKelas.Location = new System.Drawing.Point(67, 58);
            this.LabelKelas.Name = "LabelKelas";
            this.LabelKelas.Size = new System.Drawing.Size(92, 17);
            this.LabelKelas.TabIndex = 1;
            this.LabelKelas.Text = "Nama Kelas :";
            // 
            // TextBoxTambahKelas
            // 
            this.TextBoxTambahKelas.Location = new System.Drawing.Point(70, 97);
            this.TextBoxTambahKelas.Name = "TextBoxTambahKelas";
            this.TextBoxTambahKelas.Size = new System.Drawing.Size(201, 22);
            this.TextBoxTambahKelas.TabIndex = 2;
            // 
            // FormTambahKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 216);
            this.Controls.Add(this.TextBoxTambahKelas);
            this.Controls.Add(this.LabelKelas);
            this.Controls.Add(this.Tambah);
            this.Name = "FormTambahKelas";
            this.Text = "FormTambahKelas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.Label LabelKelas;
        private System.Windows.Forms.TextBox TextBoxTambahKelas;
    }
}