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
    public partial class frmEmpMain : Form
    {
        bool dontClose = false;
        public frmEmpMain()
        {
            InitializeComponent();
        }

        private void loadSchedule()
        {
            EmpSchedule schedule = new EmpSchedule();
            schedule.SetDatabaseLogon("cpswanson", "1498787");
            schedule.RecordSelectionFormula = "{empSchedule.employeeid} = {?EmpID}";
            schedule.SetParameterValue("EmpID", Processes.ID);
            crvSchedule.ReportSource = schedule;
            crvSchedule.Refresh();
        }

        private void frmEmpMain_Load(object sender, EventArgs e)
        {
            loadSchedule();

            foreach(DataRow row in Processes.DTProducts.Rows)
            {
                double discount = double.Parse(row[3].ToString()); 
                if (discount > 0)
                {
                    txtDeals.Text += row[1].ToString() + " - " + (discount*100) + "%" + Environment.NewLine;
                }
            }
        }

        private void frmEmpMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Shutdown application if user hits the 'X' button
            if(e.CloseReason == CloseReason.UserClosing)
            {
                if(!dontClose)
                    Application.Exit();
            }
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            Processes.Login.Show();
            dontClose = true;
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            gpbEmp.Visible = true;

            Processes proc = new Processes();
            DataTable temp = proc.getEmpInfo(Processes.ID);

            txtUN.Text = temp.Rows[0][1].ToString();
            txtPW.Text = temp.Rows[0][2].ToString();
            txtFName.Text = temp.Rows[0][3].ToString();
            txtLName.Text = temp.Rows[0][4].ToString();
            txtPhone.Text = temp.Rows[0][5].ToString();
            txtEmail.Text = temp.Rows[0][6].ToString();
            loadSchedule();
        }

        //Update the employee's information
        private void btnSave_Click(object sender, EventArgs e)
        {
            Processes proc = new Processes();
            if(txtUN.Text != "" && txtPW.Text != "" && txtFName.Text != "" && txtLName.Text != ""
                && txtPhone.Text != "" && txtEmail.Text != "")
            {
                try
                {
                    System.Net.Mail.MailAddress address = new System.Net.Mail.MailAddress(txtEmail.Text);

                    MessageBox.Show(proc.updateEmp(txtUN.Text, txtPW.Text, txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text));
                }
                catch
                {
                    MessageBox.Show("Verify email address.");
                }
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            gpbEmp.Visible = false;
        }

        private void btnSchChange_Click(object sender, EventArgs e)
        {
            frmRequest request = new frmRequest();
            request.Text = "Request for Schedule Change.";
            request.txtRequest.Text = "Enter the changes you would like made to your schedule...";
            request.ShowDialog();
        }

        private void btnDaysOff_Click(object sender, EventArgs e)
        {
            frmRequest request = new frmRequest();
            request.Text = "Request for Days Off.";
            request.txtRequest.Text = "Enter the days you would like to have off...";
            request.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEHelp help = new frmEHelp();
            help.ShowDialog();
        }
    }
}
