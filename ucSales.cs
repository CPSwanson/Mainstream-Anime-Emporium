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
    public partial class ucSales : UserControl
    {
        public ucSales()
        {
            InitializeComponent();
        }

        private void ucSales_Load(object sender, EventArgs e)
        {
            crSales_D day = new crSales_D();
            day.SetDatabaseLogon("cpswanson", "1498787");
            day.Refresh();
            crvSales.ReportSource = day;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            crSales_D day = new crSales_D();
            day.SetDatabaseLogon("cpswanson", "1498787");
            day.Refresh();
            crvSales.ReportSource = day;
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            crSales_W week = new crSales_W();
            week.SetDatabaseLogon("cpswanson", "1498787");
            week.Refresh();
            crvSales.ReportSource = week;
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            crSales_M month = new crSales_M();
            month.SetDatabaseLogon("cpswanson", "1498787");
            month.Refresh();
            crvSales.ReportSource = month;
        }
    }
}
