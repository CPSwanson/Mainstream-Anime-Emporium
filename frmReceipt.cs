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
    public partial class frmReceipt : Form
    {
        public frmReceipt()
        {
            InitializeComponent();
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            Reciept reciept = new Reciept();
            reciept.SetDatabaseLogon("cpswanson", "1498787");
            reciept.Refresh();
            crvReciept.ReportSource = reciept;
        }
    }
}
