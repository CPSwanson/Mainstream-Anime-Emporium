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
    public partial class frmMan_Main : Form
    {
        bool dontClose = false;
        ucInventory inv;
        ucAddProduct addP;
        ucUpPro upPro;
        ucEmpList empList;
        ucEmpSchedule schedule;
        ucInvoice invoice;
        ucSales sales;

        public frmMan_Main()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Processes.Login.Show();
            dontClose = true;
            this.Close();
        }

        private void frmMan_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Shutdown application if user hits the 'X' button
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!dontClose)
                    Application.Exit();
            }
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            change(1,0);
        }

        private void btnSch_Click(object sender, EventArgs e)
        {
            change(2, 0);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            change(3, 0);
        }

        //Switches control in panel based on arguement
        public void change(int _case, int id)
        {
            switch(_case)
            {
                case 1: //Brings up control showing store inventory
                    inv = new ucInventory();
                    pnlHolder.Controls.Clear();
                    pnlHolder.Controls.Add(inv);
                    inv.Dock = DockStyle.Fill;
                    inv.parent = this;
                    break;
                case 2: //Brings up control showing employee for manipulating schedules
                    empList = new ucEmpList();
                    pnlHolder.Controls.Clear();
                    pnlHolder.Controls.Add(empList);
                    empList.Dock = DockStyle.Fill;
                    empList.parent = this;
                    break;
                case 3: //Brings up control for viewing sales reports
                    sales = new ucSales();
                    pnlHolder.Controls.Clear();
                    pnlHolder.Controls.Add(sales);
                    sales.Dock = DockStyle.Fill;
                    break;
                case 4: //Brings up control for adding product
                    addP = new ucAddProduct();
                    pnlHolder.Controls.Clear();
                    pnlHolder.Controls.Add(addP);
                    addP.Dock = DockStyle.Fill;
                    addP.parent = this;
                    break;
                case 5: //Brings up control for updating product
                    upPro = new ucUpPro(id);
                    pnlHolder.Controls.Clear();
                    pnlHolder.Controls.Add(upPro);
                    upPro.Dock = DockStyle.Fill;
                    upPro.parent = this;
                    break;
                case 6: //Removes product from database and reloads dgv
                    Processes proc = new Processes();
                    MessageBox.Show(proc.removeProduct(id));
                    inv = new ucInventory();
                    pnlHolder.Controls.Clear();
                    pnlHolder.Controls.Add(inv);
                    inv.Dock = DockStyle.Fill;
                    inv.parent = this;
                    break;
                case 7: //Shows schedule for employee to be updated
                    schedule = new ucEmpSchedule(id);
                    pnlHolder.Controls.Clear();
                    pnlHolder.Controls.Add(schedule);
                    schedule.Dock = DockStyle.Fill;
                    schedule.parent = this;
                    break;
                case 8: //Show's invoice for inventory orders
                    invoice = new ucInvoice();
                    pnlHolder.Controls.Clear();
                    pnlHolder.Controls.Add(invoice);
                    invoice.Dock = DockStyle.Fill;
                    invoice.parent = this;
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMan_Main_Load(object sender, EventArgs e)
        {
            change(1, 0);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmMHelp help = new frmMHelp();
            help.ShowDialog();
        }
    }
}
