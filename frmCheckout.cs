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
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Pulls in and displays available customer info as well as cost info for order 
        private void frmCheckout_Load(object sender, EventArgs e)
        {
            txtSub.Text = string.Format("{0:C}", Processes.Sub.ToString());
            txtTax.Text = string.Format("{0:C}", Processes.Tax.ToString());
            txtTotal.Text = string.Format("{0:C}", Processes.Total.ToString());

            Processes processes = new Processes();
            DataTable temp = processes.getCustInfo();

            txtName.Text = temp.Rows[0][3].ToString() + " " + temp.Rows[0][4].ToString();
            txtAddress.Text = temp.Rows[0][5].ToString();
            txtCity.Text = temp.Rows[0][6].ToString();
            cbxState.Text = temp.Rows[0][7].ToString();
            txtZip.Text = temp.Rows[0][8].ToString();
            txtPhone.Text = temp.Rows[0][9].ToString();
            txtEmail.Text = temp.Rows[0][10].ToString();
        }

        //Confirms the purchase and gives the user reciept.
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAddress.Text != "" && txtCity.Text != "" && cbxState.Text != "" &&
                txtZip.Text != "" && txtPhone.Text != "" && txtEmail.Text != "")
            {
                try
                {
                    System.Net.Mail.MailAddress address = new System.Net.Mail.MailAddress(txtEmail.Text);

                    Processes proc = new Processes();
                    string res = proc.newOrder(txtAddress.Text, txtCity.Text, cbxState.Text, txtZip.Text, txtPhone.Text, txtEmail.Text);
                    DialogResult result = MessageBox.Show(res, "Order status", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        frmReceipt receipt = new frmReceipt();
                        this.Close();
                        receipt.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all of your information.");
            }
        }
    }
}
