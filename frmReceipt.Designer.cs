namespace Mainstream_Anime_Emporium
{
    partial class frmReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceipt));
            this.crvReciept = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReciept
            // 
            this.crvReciept.ActiveViewIndex = -1;
            this.crvReciept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReciept.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReciept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReciept.Location = new System.Drawing.Point(0, 0);
            this.crvReciept.Name = "crvReciept";
            this.crvReciept.ShowCloseButton = false;
            this.crvReciept.ShowGroupTreeButton = false;
            this.crvReciept.ShowLogo = false;
            this.crvReciept.ShowParameterPanelButton = false;
            this.crvReciept.ShowRefreshButton = false;
            this.crvReciept.Size = new System.Drawing.Size(800, 450);
            this.crvReciept.TabIndex = 0;
            this.crvReciept.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvReciept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReceipt";
            this.Text = "Your Receipt";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReciept;
    }
}