namespace Mainstream_Anime_Emporium
{
    partial class frmEmpMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpMain));
            this.crvSchedule = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.EmpSchedule1 = new Mainstream_Anime_Emporium.EmpSchedule();
            this.EmpSchedule2 = new Mainstream_Anime_Emporium.EmpSchedule();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDaysOff = new System.Windows.Forms.Button();
            this.btnSchChange = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.gpbEmp = new System.Windows.Forms.GroupBox();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.btnHide = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtDeals = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbEmp.SuspendLayout();
            this.tlpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvSchedule
            // 
            this.crvSchedule.ActiveViewIndex = -1;
            this.crvSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSchedule.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSchedule.Location = new System.Drawing.Point(0, 0);
            this.crvSchedule.Name = "crvSchedule";
            this.crvSchedule.ShowCloseButton = false;
            this.crvSchedule.ShowGotoPageButton = false;
            this.crvSchedule.ShowGroupTreeButton = false;
            this.crvSchedule.ShowLogo = false;
            this.crvSchedule.ShowPageNavigateButtons = false;
            this.crvSchedule.ShowParameterPanelButton = false;
            this.crvSchedule.ShowRefreshButton = false;
            this.crvSchedule.ShowTextSearchButton = false;
            this.crvSchedule.Size = new System.Drawing.Size(579, 720);
            this.crvSchedule.TabIndex = 0;
            this.crvSchedule.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.BackColor = System.Drawing.Color.White;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfo.Location = new System.Drawing.Point(596, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(125, 46);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Edit Information";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDaysOff
            // 
            this.btnDaysOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDaysOff.BackColor = System.Drawing.Color.White;
            this.btnDaysOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDaysOff.Location = new System.Drawing.Point(596, 162);
            this.btnDaysOff.Name = "btnDaysOff";
            this.btnDaysOff.Size = new System.Drawing.Size(125, 42);
            this.btnDaysOff.TabIndex = 2;
            this.btnDaysOff.Text = "Request Days Off";
            this.btnDaysOff.UseVisualStyleBackColor = false;
            this.btnDaysOff.Click += new System.EventHandler(this.btnDaysOff_Click);
            // 
            // btnSchChange
            // 
            this.btnSchChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchChange.BackColor = System.Drawing.Color.White;
            this.btnSchChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSchChange.Location = new System.Drawing.Point(596, 84);
            this.btnSchChange.Name = "btnSchChange";
            this.btnSchChange.Size = new System.Drawing.Size(125, 54);
            this.btnSchChange.TabIndex = 3;
            this.btnSchChange.Text = "Request Schedule Change";
            this.btnSchChange.UseVisualStyleBackColor = false;
            this.btnSchChange.Click += new System.EventHandler(this.btnSchChange_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOff.Location = new System.Drawing.Point(899, 679);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(93, 30);
            this.btnLogOff.TabIndex = 4;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // gpbEmp
            // 
            this.gpbEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbEmp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbEmp.Controls.Add(this.tlpInfo);
            this.gpbEmp.ForeColor = System.Drawing.Color.Black;
            this.gpbEmp.Location = new System.Drawing.Point(736, 10);
            this.gpbEmp.Name = "gpbEmp";
            this.gpbEmp.Size = new System.Drawing.Size(256, 380);
            this.gpbEmp.TabIndex = 5;
            this.gpbEmp.TabStop = false;
            this.gpbEmp.Text = "Your Information";
            this.gpbEmp.Visible = false;
            // 
            // tlpInfo
            // 
            this.tlpInfo.BackColor = System.Drawing.Color.Transparent;
            this.tlpInfo.ColumnCount = 2;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.Controls.Add(this.btnHide, 1, 6);
            this.tlpInfo.Controls.Add(this.txtPhone, 0, 4);
            this.tlpInfo.Controls.Add(this.btnSave, 0, 6);
            this.tlpInfo.Controls.Add(this.txtUN, 0, 0);
            this.tlpInfo.Controls.Add(this.txtEmail, 0, 5);
            this.tlpInfo.Controls.Add(this.txtPW, 0, 1);
            this.tlpInfo.Controls.Add(this.txtFName, 0, 2);
            this.tlpInfo.Controls.Add(this.txtLName, 0, 3);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(3, 18);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 7;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInfo.Size = new System.Drawing.Size(250, 359);
            this.tlpInfo.TabIndex = 6;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.White;
            this.btnHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHide.Location = new System.Drawing.Point(128, 309);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(119, 47);
            this.btnHide.TabIndex = 7;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhone.Location = new System.Drawing.Point(3, 207);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(119, 22);
            this.txtPhone.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(3, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 47);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUN
            // 
            this.tlpInfo.SetColumnSpan(this.txtUN, 2);
            this.txtUN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUN.Location = new System.Drawing.Point(3, 3);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(244, 22);
            this.txtUN.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.tlpInfo.SetColumnSpan(this.txtEmail, 2);
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Location = new System.Drawing.Point(3, 258);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(244, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPW
            // 
            this.tlpInfo.SetColumnSpan(this.txtPW, 2);
            this.txtPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPW.Location = new System.Drawing.Point(3, 54);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(244, 22);
            this.txtPW.TabIndex = 1;
            // 
            // txtFName
            // 
            this.tlpInfo.SetColumnSpan(this.txtFName, 2);
            this.txtFName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFName.Location = new System.Drawing.Point(3, 105);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(244, 22);
            this.txtFName.TabIndex = 2;
            // 
            // txtLName
            // 
            this.tlpInfo.SetColumnSpan(this.txtLName, 2);
            this.txtLName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLName.Location = new System.Drawing.Point(3, 156);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(244, 22);
            this.txtLName.TabIndex = 3;
            // 
            // txtDeals
            // 
            this.txtDeals.Location = new System.Drawing.Point(596, 441);
            this.txtDeals.Multiline = true;
            this.txtDeals.Name = "txtDeals";
            this.txtDeals.Size = new System.Drawing.Size(390, 223);
            this.txtDeals.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current Deals";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(786, 679);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEmpMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1004, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeals);
            this.Controls.Add(this.gpbEmp);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.btnSchChange);
            this.Controls.Add(this.btnDaysOff);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.crvSchedule);
            this.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEmpMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmpMain_FormClosing);
            this.Load += new System.EventHandler(this.frmEmpMain_Load);
            this.gpbEmp.ResumeLayout(false);
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSchedule;
        private EmpSchedule EmpSchedule1;
        private EmpSchedule EmpSchedule2;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnDaysOff;
        private System.Windows.Forms.Button btnSchChange;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.GroupBox gpbEmp;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.TextBox txtDeals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}