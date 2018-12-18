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
    public partial class ucInvoice : UserControl
    {
        internal frmMan_Main parent;
        public ucInvoice()
        {
            InitializeComponent();
        }

        private void ucInvoice_Load(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.SetDatabaseLogon("cpswanson", "1498787");
            crvInvoice.ReportSource = invoice;
        }
    }
}
