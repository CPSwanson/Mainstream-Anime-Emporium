using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mainstream_Anime_Emporium
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Processes processes = new Processes();

            //Application will attempt to grab products from database before loading
            if(processes.loadProducts() == true)
            {
                Application.Run(new frmLogin());
            }
            else    //If the products cannot be loaded, the application will immediately close
            {
                DialogResult result = MessageBox.Show("Could not contact database to gather product information", "Critical Error", MessageBoxButtons.OK);
                if(result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}
