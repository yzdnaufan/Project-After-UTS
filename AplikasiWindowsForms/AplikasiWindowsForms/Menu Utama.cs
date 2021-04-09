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
    public partial class Menu_Utama : Form
    {
        public Menu_Utama()
        {
            InitializeComponent();
        }

        private void Load_Menu_Utama(object sender, EventArgs e)
        {
            //buka login
            LoginPage newLogin = new LoginPage();
            newLogin.ShowDialog();

        }
    }