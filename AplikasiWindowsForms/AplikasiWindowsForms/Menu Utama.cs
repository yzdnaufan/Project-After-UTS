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
                    logIn = true;
                }
            }
            
        }
    }
}
