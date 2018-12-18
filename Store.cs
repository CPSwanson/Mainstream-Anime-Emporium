using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Mainstream_Anime_Emporium
{
    public class Store : FlowLayoutPanel
    {
        public Store()
        {
            Processes proc = new Processes();

            this.DoubleBuffered = true;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "flpStore";
            this.Size = new System.Drawing.Size(1600, 1080);
            this.TabIndex = 4;
            this.Visible = false;

            foreach (DataRow item in Processes.DTProducts.Rows)
            {
                //Only displays items that have existing inventory
                if(int.Parse(item[5].ToString()) > 0)
                {
                    ucProduct product = new ucProduct();
                    product.proID = int.Parse(item[0].ToString());
                    product.pbxImage.Image = proc.getImage(product.proID);
                    product.lblName.Text = item[1].ToString();
                    double price = double.Parse(item[2].ToString());
                    double discount = double.Parse(item[2].ToString()) * (double.Parse(item[3].ToString()) / 100);
                    product.lblPrice.Text = string.Format("{0:C}", price-discount);

                    this.Controls.Add(product);
                }
            }
            this.Visible = true;
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            this.Invalidate();
            base.OnScroll(se);
        }
    }
}
