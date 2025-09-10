using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXONSYSTEM.Common;
using EXONSYSTEM.Controls;

namespace EXONSYSTEM.Layout
{
    public partial class frmViewTimePause : MetroFramework.Forms.MetroForm
    {
        private int _ContestantShiftID;
        public frmViewTimePause(int ContestantShiftID)
        {
            InitializeComponent();
            this._ContestantShiftID = ContestantShiftID;
        }
        private void frmViewTimePause_Load(object sender, EventArgs e)
        {

            int count = 1;
            List<CONTESTANTPAUSE> lstContestantPaust = new List<CONTESTANTPAUSE>();
            BUS.ContestantBUS.Instance.GetListContestantPause(_ContestantShiftID, out lstContestantPaust);
            if (lstContestantPaust == null)
            {
                MessageBox.Show("Có lỗi khi lấy dữ liệu gián đoạn", "Thông báo!");
            }
            else
            {
                if (lstContestantPaust.Count > 0)
                {
                    int w = 10;
                    foreach (CONTESTANTPAUSE item in lstContestantPaust)
                    {

                        int ContestantRealPauseTime = item.ContestantRealPauseTime ?? default(int);
                        int ContestantRealRestartTime = 0;

                        if (item.ContestantRealRestartTime.HasValue)
                        {
                            ContestantRealRestartTime = item.ContestantRealRestartTime.Value;
                        }
                        ucTimePause uc = new ucTimePause(count.ToString(), Controllers.Instance.ConvertUnixToDateTime(ContestantRealPauseTime).ToString("HH:mm:ss dd/MM/yyyy"), Controllers.Instance.ConvertUnixToDateTime(ContestantRealRestartTime).ToString("HH:mm:ss dd/MM/yyyy"), pnlMain.Width);

                        uc.Location = new Point(0, w);
                        pnlMain.Controls.Add(uc);
                        count++;
                        w += 72;
                    }
                }
                else
                {
                    Label lblNotifi = new Label();
                    lblNotifi.Text = "Không có quãng thời gian gián đoạn";
                    lblNotifi.Location = new Point(0, 10);
                    lblNotifi.Width = pnlMain.Width;
                    lblNotifi.Font = new Font(Constant.FONT_FAMILY_DEFAULT, Constant.FONT_SIZE_DEFAULT, FontStyle.Bold);
                    pnlMain.Controls.Add(lblNotifi);
                }
            }



        }
    }
}
