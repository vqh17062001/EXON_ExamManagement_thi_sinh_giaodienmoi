using EXONSYSTEM.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXONSYSTEM
{
    static class Program
    {
        static Mutex m;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool first = false;
            m = new Mutex(true, Application.ProductName.ToString(), out first);
            if ((first))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmConfigApplication());
            }

            else
            {
                MessageBox.Show("Chương trình" + " " + Application.ProductName.ToString() + " " + " đã được khởi động");
            }
        }
    }
}
