using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mainstream_Anime_Emporium
{
    public partial class frmRecovery : Form
    {
        public frmRecovery()
        {
            InitializeComponent();
        }

        //Searches database for password and sends email
        private void button1_Click(object sender, EventArgs e)
        {
            Processes proc = new Processes();
            if (txtUsername.Text != "" && txtEmail.Text != "")
                MessageBox.Show(proc.getPassword(txtUsername.Text, txtEmail.Text));
            else
                MessageBox.Show("Please fill in all fields.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
