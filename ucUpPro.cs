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
    public partial class ucUpPro : UserControl
    {
        internal frmMan_Main parent;
        int id;
        int initQuan;
        public ucUpPro()
        {
            InitializeComponent();
        }
        //Overloaded constructer to capture id of product to be updated
        public ucUpPro(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        //Loads information of product into control
        private void ucUpPro_Load(object sender, EventArgs e)
        {
            Processes proc = new Processes();
            bool eol = true;

            foreach (DataRow item in Processes.DTProducts.Rows)
            {
                if (int.Parse(item[0].ToString()) == id)
                {
                    txtDesc.Text = item[1].ToString();
                    double price = Math.Round(double.Parse(item[2].ToString()));
                    txtPrice.Text = price.ToString();
                    txtDisc.Text = item[3].ToString();
                    nudQuan.Value = int.Parse(item[5].ToString());
                    initQuan = int.Parse(item[5].ToString());
                    pbxImage.Image = proc.getImage(id);
                    eol = false;
                    break;
                }
            }

            if (eol)
            {
                parent.change(1, 0);
            }
        }

        //Sends new information to database for updating
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != "" && txtPrice.Text != "" && txtDisc.Text != "")
            {
                Processes proc = new Processes();
                double price = double.Parse(txtPrice.Text);
                double disc = double.Parse(txtDisc.Text);
                int quan = int.Parse(nudQuan.Value.ToString()) - initQuan;

                proc.updateInv(id, txtDesc.Text, price, disc, quan, pbxImage.Image);
                parent.change(8,0);
            }
        }

        //Returns panel back to inventory
        private void btnCancel_Click(object sender, EventArgs e)
        {
            parent.change(1, 0);
        }

        //Let's the manager update the product's image
        private void btnReplace_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            open.Filter = "Image Files|*.png;*.jpg";
            if (open.FileName.Length > 0)
            {
                pbxImage.Image = new Bitmap(open.FileName);
            }
        }
    }
}
