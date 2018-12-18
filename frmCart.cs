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
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();
        }

        private void loadCart()
        {
            Processes proc = new Processes();
            flpCart.Visible = false;
            flpCart.Controls.Clear();

            if(Processes.Cart.Count == 0)
            {
                this.Close();
            }

            //Displays the items selected for purchase with respective quantities and prices
            foreach (Processes._item item in Processes.Cart)
            {
                foreach (DataRow row in Processes.DTProducts.Rows)
                {
                    //Matches items in cart to database to pull product info
                    if (int.Parse(row[0].ToString()) == item.ID)
                    {
                        GroupBox cItem = new GroupBox();
                        cItem.Size = new Size(730, 150);
                        cItem.Text = "";

                        Label lblID = new Label();
                        lblID.Text = item.ID.ToString();
                        lblID.Visible = false;

                        PictureBox pbxItem = new PictureBox();
                        pbxItem.Size = new Size(120, 120);
                        pbxItem.Location = new Point(10, 20);
                        pbxItem.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbxItem.Image = proc.getImage(item.ID);

                        Label lblName = new Label();
                        lblName.Text = row[1].ToString();
                        lblName.ForeColor = Color.White;
                        lblName.Size = new Size(34, 36);
                        lblName.Location = new Point(153, 70);
                        lblName.AutoSize = true;

                        TextBox txtQuantity = new TextBox();
                        txtQuantity.Text = item.Quantity.ToString();
                        txtQuantity.Size = new Size(34, 36);
                        txtQuantity.Location = new Point(500, 70);
                        txtQuantity.ReadOnly = true;
                        txtQuantity.TabStop = false;

                        Button btnRemove = new Button();
                        btnRemove.Text = "Remove";
                        btnRemove.Size = new Size(70, 36);
                        btnRemove.Location = new Point(620, 30);
                        btnRemove.Click += btnRemove_Click;
                        void btnRemove_Click(object _sender, EventArgs _e)
                        {
                            proc.removeFromCart(int.Parse(lblID.Text));
                            loadCart();
                        }

                        TextBox txtPrice = new TextBox();
                        double price = double.Parse(row[2].ToString());
                        double discount = double.Parse(row[2].ToString()) * (double.Parse(row[3].ToString()) / 100);
                        txtPrice.Text = string.Format("{0:C}", ((price - discount) * item.Quantity));
                        txtPrice.Size = new Size(80, 36);
                        txtPrice.Location = new Point(610, 70);
                        txtPrice.ReadOnly = true;
                        txtPrice.TabStop = false;

                        cItem.Controls.Add(pbxItem);
                        cItem.Controls.Add(lblName);
                        cItem.Controls.Add(txtQuantity);
                        cItem.Controls.Add(txtPrice);
                        cItem.Controls.Add(btnRemove);
                        flpCart.Controls.Add(cItem);
                        break;
                    }
                }
            }

            flpCart.Visible = true;
            lblSub.Text = string.Format("{0:C}", Processes.Sub);
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            loadCart();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Directs customer to checkout form to finalize purchase
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout checkout = new frmCheckout();
            checkout.Show();
            this.Close();
        }
    }
}
