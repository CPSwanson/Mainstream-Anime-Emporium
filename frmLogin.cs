using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace Mainstream_Anime_Emporium
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Attempts to log user in as a customer
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //Attemps to log customer in
            Processes proc = new Processes();
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (proc.custLogIn(txtUsername.Text, txtPassword.Text))
                {
                    frmStore store = new frmStore();
                    this.Hide();
                    store.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Check credentials or create a new account");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        //Enables this to be hidden and brought back up if a user logs out
        private void frmLogin_Load(object sender, EventArgs e)
        {
            Processes.Login = this;
        }

        //Attemps to log employee in
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Processes proc = new Processes();
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (proc.empLogIn(txtUsername.Text, txtPassword.Text))
                {
                    if (Processes.Manager == false)
                    {
                        frmEmpMain empMain = new frmEmpMain();
                        this.Hide();
                        empMain.ShowDialog();
                    }
                    else
                    {
                        frmMan_Main manMain = new frmMan_Main();
                        this.Hide();
                        manMain.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Check credentials");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        //Brings up small menu for user to create a new customer account
        private void btnCreate_Click(object sender, EventArgs e)
        {
            gpbNewAcc.Visible = true;
        }

        //Attempts to generate a new customer account
        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            Processes proc = new Processes();
            if(txtFName.Text != "" && txtLName.Text != "" && txtUN.Text != "" && txtPW.Text != "")
            {
                MessageBox.Show(proc.newAccount(txtUN.Text, txtPW.Text,txtFName.Text,txtLName.Text));
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        //Brings up a small introduction to the application
        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        //Allows user to recover password
        private void btnForgot_Click(object sender, EventArgs e)
        {
            frmRecovery recovery = new frmRecovery();
            recovery.ShowDialog();
        }
    }
}
