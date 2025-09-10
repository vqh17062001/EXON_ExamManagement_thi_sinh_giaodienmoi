using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXONSYSTEM.Layout;
using System.IO;

namespace EXON.ForRegister
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
            try
            {
                bool first = false;
                m = new Mutex(true, Application.ProductName.ToString(), out first);
                if ((first))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    try
                    {
                        Application.Run(new FormMain());
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("Máy chưa cài TX Control, vui lòng cài TX Control để tiếp tục sử dụng!");
                    }
                }
                else
                {
                    MessageBox.Show("Chương trình" + " " + Application.ProductName.ToString() + " " + "đã được khởi động");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chương trình gặp sự cố thoát chương trình và liên vệ với quản trị viên ");
                //File.SetAttributes(frmAuthentication.logFile, FileAttributes.ReadOnly);

            }
        }
    }
}
