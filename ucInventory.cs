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
    public partial class ucInventory : UserControl
    {
        internal frmMan_Main parent;
        public ucInventory()
        {
            InitializeComponent();
        }

        private void ucInventory_Load(object sender, EventArgs e)
        {
            dgvInv.DataSource = Processes.DTProducts;
            dgvInv.Columns[0].HeaderText = "Product ID";
            dgvInv.Columns[1].HeaderText = "Description";
            dgvInv.Columns[2].HeaderText = "Price";
            dgvInv.Columns[2].DefaultCellStyle.Format = "c";
            dgvInv.Columns[3].HeaderText = "Discount (%)";
            dgvInv.Columns[4].HeaderText = "Supplier ID";
            dgvInv.Columns[5].HeaderText = "Number In Stock";
        }

        //Switches control in panel to control for adding a new product
        private void btnAdd_Click(object sender, EventArgs e)
        {
            parent.change(4,0);
        }

        //Switches control in panel to control for updating product
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvInv.CurrentRow.Cells[0].Value.ToString());
            parent.change(5,id);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvInv.CurrentRow.Cells[0].Value.ToString());
            parent.change(6, id);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            crInventory inv = new crInventory();
            inv.SetDatabaseLogon("cpswanson", "1498787");
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = ".pdf";
            saveFile.Filter = "PDF|*.pdf";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                string path = saveFile.FileName;
                inv.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path);
            }
        }
    }
}
