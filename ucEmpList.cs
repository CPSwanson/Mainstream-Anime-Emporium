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
    public partial class ucEmpList : UserControl
    {
        internal frmMan_Main parent;

        public ucEmpList()
        {
            InitializeComponent();
        }

        private void usEmpList_Load(object sender, EventArgs e)
        {
            Processes proc = new Processes();
            dgvEmpList.DataSource = proc.getEmpInfo();
            dgvEmpList.Columns[0].HeaderText = "Employee ID";
            dgvEmpList.Columns[1].Visible = false;
            dgvEmpList.Columns[2].Visible = false;
            dgvEmpList.Columns[3].HeaderText = "First Name";
            dgvEmpList.Columns[4].HeaderText = "Last Name";
            dgvEmpList.Columns[5].HeaderText = "Phone";
            dgvEmpList.Columns[6].HeaderText = "Email";
            dgvEmpList.Columns[7].Visible = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            parent.change(7, int.Parse(dgvEmpList.CurrentRow.Cells[0].Value.ToString()));
        }
    }
}
