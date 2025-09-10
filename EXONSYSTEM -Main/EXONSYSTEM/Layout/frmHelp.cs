using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Diagnostics;
using EXONSYSTEM.Common;

namespace EXONSYSTEM.Layout
{
    public partial class frmHelp : MetroForm
    {
        private string pathfileHelp = Common.Constant.pathTempHelp;
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            try
            {
                //DialogResult dr = MetroMessageBox.Show(this, "Thông báo", "Bạn có muốn sửa ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100);
                //if (dr == DialogResult.Yes)
                //{
                //}
            
                string Path = (pathfileHelp + "\\help.rtf");

                if (File.Exists(Path))
                {
                    // hay vc ấy :v
                    richTextBox1.LoadFile(Path);
                }

                else
                {
                    MessageBox.Show("không tìm thấy file hướng dẫn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Gặp sự cố trong việc mở file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
