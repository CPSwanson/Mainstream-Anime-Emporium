using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mainstream_Anime_Emporium
{
    public partial class ucProduct : UserControl
    {
        public int proID = 0;

        public ucProduct()
        {
            InitializeComponent();
        }

        //Prompts the customer to specify the quantity they wish to purchase
        private void pnlItem_Click(object sender, EventArgs e)
        {
            frmAddToCart add = new frmAddToCart();
            add.proID = proID;
            add.ShowDialog();
            add.TopMost = true;
        }
    }
}
