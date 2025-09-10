using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXONSYSTEM.Layout
{
    public partial class frmDocKy : MetroFramework.Forms.MetroForm
    {
        private string pathfileHelp = Common.Constant.pathTempHelp;
        public frmDocKy()
        {
            InitializeComponent();
        }

        private void FrmDocKy_Load(object sender, EventArgs e)
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
