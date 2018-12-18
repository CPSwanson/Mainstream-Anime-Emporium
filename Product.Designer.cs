namespace Mainstream_Anime_Emporium
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPrice.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(0, 257);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(256, 25);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "$00.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(256, 26);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Item";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlItem
            // 
            this.pnlItem.BackgroundImage = global::Mainstream_Anime_Emporium.Properties.Resources.Background;
            this.pnlItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItem.Location = new System.Drawing.Point(0, 26);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(256, 256);
            this.pnlItem.TabIndex = 2;
            this.pnlItem.Click += new System.EventHandler(this.pnlItem_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.lblName);
            this.DoubleBuffered = true;
            this.Name = "Product";
            this.Size = new System.Drawing.Size(256, 282);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblPrice;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Panel pnlItem;
    }
}
