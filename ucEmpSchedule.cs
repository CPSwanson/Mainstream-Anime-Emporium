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
    public partial class ucEmpSchedule : UserControl
    {
        internal frmMan_Main parent;
        int _id;
        public ucEmpSchedule()
        {
            InitializeComponent();
        }
        public ucEmpSchedule(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void ucEmpSchedule_Load(object sender, EventArgs e)
        {
            Processes proc = new Processes();
            DataTable[] tables = proc.getSchedule(_id);

            tlpHolder.Visible = false;

            txtMon.Text = tables[0].Rows[0][1].ToString();
            txtTues.Text = tables[0].Rows[0][2].ToString();
            txtWed.Text = tables[0].Rows[0][3].ToString();
            txtThur.Text = tables[0].Rows[0][4].ToString();
            txtFri.Text = tables[0].Rows[0][5].ToString();
            txtSat.Text = tables[0].Rows[0][6].ToString();
            txtSun.Text = tables[0].Rows[0][7].ToString();
            txtSL.Text = tables[0].Rows[0][8].ToString();
            txtVaca.Text = tables[0].Rows[0][9].ToString();

            foreach (DataRow req in tables[1].Rows)
            {
                txtRequests.Text += req[1].ToString() + Environment.NewLine;
            }

            tlpHolder.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parent.change(2,0);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Processes proc = new Processes();

            if (txtMon.Text != "" && txtTues.Text != "" && txtWed.Text != "" &&
                txtThur.Text != "" && txtMon.Text != "" && txtSat.Text != "" &&
                txtSun.Text != "")
            {
                string[] days = new string[7] {txtMon.Text, txtTues.Text, txtWed.Text, txtThur.Text, txtMon.Text, txtSat.Text, txtSun.Text};
                int vaca = int.Parse(txtVaca.Text);
                int sL = int.Parse(txtSL.Text);

                foreach(string day in days)
                {
                    if (day == "Vacation")
                        vaca -= 1;
                    else if (day == "Sick")
                        sL -= 1;
                }

                proc.upSchedule(_id, days, vaca, sL);
                parent.change(2, 0);
            }
        }
    }
}
