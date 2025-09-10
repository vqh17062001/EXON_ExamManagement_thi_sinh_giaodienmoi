using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXONSYSTEM.Common;

namespace EXONSYSTEM.Controls
{
    public partial class ucTimePause : UserControl
    {
        private string _SoLan;
        private string _ThoiGianGianDoan;
        private string _ThoiGianKhoiDong;
        private int _width;
        public ucTimePause( string SoLan,string ThoiGianGianDoan, string ThoiGianKhoiDong,int width)
        {
            InitializeComponent();
            _SoLan = SoLan;
            _ThoiGianGianDoan = ThoiGianGianDoan;
            _ThoiGianKhoiDong = ThoiGianKhoiDong;
            _width = width;
        }

        private void ucTimePause_Load(object sender, EventArgs e)
        {
          
            lblThoiGianGianDoan.Text = "Thời gian gián đoạn lần " +_SoLan + ": " +_ThoiGianGianDoan;
            lblThoiGianGianDoan.Location = new Point(0, 10);
            lblThoiGianGianDoan.Font = new Font(Constant.FONT_FAMILY_DEFAULT, Constant.FONT_SIZE_DEFAULT, FontStyle.Bold);
            lblThoiGianGianDoan.Width = _width;
         
            lblThoiGianRestart.Text = "Thời gian khởi động lại lần " + _SoLan + ": " +_ThoiGianKhoiDong;
            lblThoiGianRestart.Location = new Point(0, lblThoiGianGianDoan.Bottom + 5);
            lblThoiGianRestart.Font = new Font(Constant.FONT_FAMILY_DEFAULT, Constant.FONT_SIZE_DEFAULT, FontStyle.Bold);
            lblThoiGianRestart.Width = _width;
          
        }
    }
}
