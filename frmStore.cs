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
    public partial class frmStore : Form
    {
        public frmStore()
        {
            InitializeComponent();
        }

        //Sends user back to login form
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Processes proc = new Processes();
            proc.clearCart();

            Processes.Login.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Brings up Cart form
        private void btnCart_Click(object sender, EventArgs e)
        {
            //Will only load if customer has items in cart
            if(Processes.Cart.Count != 0)
            {
                frmCart cart = new frmCart();
                cart.ShowDialog();
            }
            else
            {
                MessageBox.Show("Your cart is empty.");
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmCHelp help = new frmCHelp();
            help.ShowDialog();
        }
    }
}
