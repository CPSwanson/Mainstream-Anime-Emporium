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
    public partial class ucAddProduct : UserControl
    {
        internal frmMan_Main parent;

        public ucAddProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parent.change(1, 0);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            open.Filter = "Image Files(*.PNG; *.JPG)|*.png; *.jpg";
            if(open.FileName.Length > 0)
            {
                pbxImage.Image = new Bitmap(open.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != "" & txtPrice.Text != "" && pbxImage.Image != null)
            {
                Processes proc = new Processes();
                proc.addProduct(txtDesc.Text, double.Parse(txtPrice.Text), int.Parse(nudQuan.Value.ToString()), pbxImage.Image);
                parent.change(1, 0);
            }
            else
            {
                MessageBox.Show("Fill in all fields.");
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            txtPrice.SelectAll();
        }
    }
}
