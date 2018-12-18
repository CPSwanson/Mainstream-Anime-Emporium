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
    public partial class frmRequest : Form
    {
        public frmRequest()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtRequest.Text != string.Empty)
            {
                Processes proc = new Processes();
                proc.sendRequest(txtRequest.Text);
                txtRequest.Text = "Request Submitted.";
                btnSubmit.Enabled = false;
                btnCancel.Text = "Close";
            }
        }

        private void txtRequest_Enter(object sender, EventArgs e)
        {
            txtRequest.SelectAll();
        }
    }
}
