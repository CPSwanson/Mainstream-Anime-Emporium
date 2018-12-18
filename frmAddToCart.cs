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
    public partial class frmAddToCart : Form
    {
        public int proID;

        public frmAddToCart()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Gathers the desired quantity the customer wishes to purchase
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(nudQuantity.Value != 0)
            {
                Processes proc = new Processes();
                proc.addToCart(proID, Convert.ToInt32(nudQuantity.Value));
                this.Close();
            }
            else
            {
                MessageBox.Show("You do not have a quantity selected.");
            }
        }
    }
}
