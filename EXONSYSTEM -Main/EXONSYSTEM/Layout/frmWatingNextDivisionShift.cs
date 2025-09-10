using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO.DataProvider;
using EXONSYSTEM.Common;
using EXONSYSTEM.Layout;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Drawing.Html;
namespace EXONSYSTEM.Layout
{
    public partial class frmWatingNextDivisionShift : Form
    {
        Timer timerGetContestShiftNext = new Timer();
        ContestantInformation CI = new ContestantInformation();
        Contest C = new Contest();
        private string ContestName;
        private int ContestantID;
        private static SqlConnection Sql;
        public delegate void SendInformationToMainForm(ContestantInformation CI, Contest C,SqlConnection sql);
        public frmWatingNextDivisionShift()
        {
            InitializeComponent();
        }
        public frmWatingNextDivisionShift(string _ContestName, int _ContestantID, SqlConnection sql)
        {
            InitializeComponent();
            this.ContestName = _ContestName;
            this.ContestantID = _ContestantID;
            DTO.MainForm = new frmMainForm();
            DTO.LoadingForm = new frmLoading();
            DTO.NotificationForm = new frmNotification();

            DTO.WaitingForm = new frmWaiting();
            Sql = sql;

        }

        private void frmWatingNextDivisionShift_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            HandlePanelWaitingDivisionShiftNext();
        }

        private void HandlePanelWaitingDivisionShiftNext()
        {

            MetroPanel mpnWaiting = new MetroPanel();
            mpnWaiting.Name = "mpnWaiting";
            Controllers.Instance.SetCanChangeMetroPanelColor(mpnWaiting);
            mpnWaiting.Location = new Point(0, 0);
            mpnWaiting.Width = Constant.WIDTH_SCREEN;
            mpnWaiting.Height = Constant.HEIGHT_SCREEN;
            mpnWaiting.BackColor = Constant.BACKCOLOR_PANEL_WELCOME;
            mpnWaiting.BringToFront();
            this.Controls.Add(mpnWaiting);

            MetroPanel mpnWaitingWraper = new MetroPanel();
            Controllers.Instance.SetCanChangeMetroPanelColor(mpnWaitingWraper);
            mpnWaitingWraper.BackColor = Constant.COLOR_TRANSPARENT;
            mpnWaiting.Controls.Add(mpnWaitingWraper);
            mpnWaitingWraper.AutoSize = true;

            MetroPanel mpnWaitingContent = new MetroPanel();
            Controllers.Instance.SetCanChangeMetroPanelColor(mpnWaitingContent);
            mpnWaitingContent.BackColor = Constant.COLOR_TRANSPARENT;
            mpnWaitingWraper.Controls.Add(mpnWaitingContent);
            mpnWaitingContent.AutoSize = true;

            Label lbContestName = new Label();
            lbContestName.AutoSize = true;
            lbContestName.Text = ContestName.ToUpper();
            lbContestName.Font = new Font(Constant.FONT_FAMILY_DEFAULT, 30, FontStyle.Bold);
            lbContestName.BackColor = Constant.COLOR_TRANSPARENT;
            lbContestName.ForeColor = Constant.FORCECOLOR_LABEL_CONTEST_NAME;
            mpnWaitingWraper.Controls.Add(lbContestName);
            mpnWaitingWraper.Width = lbContestName.Width;

            Label lbContent = new Label();
            lbContent.Text = Properties.Resources.MSG_GUI_0059;
            lbContent.Font = new Font(Constant.FONT_FAMILY_DEFAULT, 30, FontStyle.Bold);
            lbContent.BackColor = Constant.COLOR_TRANSPARENT;
            lbContent.ForeColor = Constant.FORCECOLOR_LABEL_CONTEST_NAME;
            lbContent.AutoSize = true;
            lbContent.Location = new Point(0, lbContestName.Bottom + 400);
            mpnWaitingContent.Controls.Add(lbContent);

            int widthWrapper = mpnWaitingWraper.Width > mpnWaitingContent.Width ? mpnWaitingWraper.Width : mpnWaitingContent.Width;
            lbContestName.Location = new Point(Convert.ToInt32((widthWrapper - lbContestName.Width) / 2));
            if (lbContestName.Width < mpnWaitingContent.Width)
            {
                mpnWaitingContent.Location = new Point(0, lbContestName.Bottom + 50);
            }
            else
            {
                mpnWaitingContent.Location = new Point(300, lbContestName.Bottom + 50);
            }
            mpnWaitingWraper.Location = new Point(Convert.ToInt32((Constant.WIDTH_SCREEN - widthWrapper) / 2), Convert.ToInt32((Constant.HEIGHT_SCREEN - mpnWaitingWraper.Height) / 2));

            timerGetContestShiftNext.Interval = 1000;
            timerGetContestShiftNext.Start();
            timerGetContestShiftNext.Tick += TimerGetContestShiftNext_Tick;
        }
        private void TimerGetContestShiftNext_Tick(object sender, EventArgs e)
        {

            ErrorController rEC = new ErrorController();

            ContestantBUS.Instance.HandleDivisionShiftNext(ContestantID, out C, out CI, out rEC);
            if (rEC.ErrorCode == Constant.STATUS_OK)
            {
                Log.Instance.WriteLog(Properties.Resources.MSG_LOG_INFO, "AUTHENTICATION", Properties.Resources.MSG_MESS_0007);
                SendInformationToMainForm sitm = new SendInformationToMainForm(DTO.MainForm.HandleInformationFromAuthenForm);
                sitm(CI, C,Sql);
                timerGetContestShiftNext.Stop();
                this.Hide();
                DTO.MainForm.Show();
            }
            else if (rEC.ErrorCode == Constant.STATUS_LOGIN_FAIL)
            {
                //Controllers.Instance.ShowNotificationForm(Constant.TYPE_NOTIFICATION_INFO, "Bạn đã hoàn thành xong bài thi đánh giá năng lực!", this);
                //Controllers.Instance.ExitApplicationFromNotificationForm(this);
            }
            else if (rEC.ErrorCode == Constant.STATUS_COMPLETE)
            {
                Controllers.Instance.ShowNotificationForm(Constant.TYPE_NOTIFICATION_INFO, Properties.Resources.MSG_GUI_0064, this);
                Controllers.Instance.ExitApplicationFromNotificationForm(this);
            }
            else
            {
                Log.Instance.WriteErrorLog(Properties.Resources.MSG_LOG_FATAL, Controllers.Instance.HandleStringErrorController(rEC));
                Controllers.Instance.ShowNotificationForm(Constant.TYPE_NOTIFICATION_WARNING, Controllers.Instance.HandleStringErrorController(rEC), this);
                Controllers.Instance.ExitApplicationFromNotificationForm(this);
            }
        }

        private void frmWatingNextDivisionShift_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmWatingNextDivisionShift_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}
