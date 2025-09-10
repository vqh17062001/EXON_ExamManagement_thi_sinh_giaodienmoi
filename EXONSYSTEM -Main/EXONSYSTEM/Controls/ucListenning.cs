using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BUS;
using System.Data.SqlClient;
using System.Diagnostics;

namespace EXONSYSTEM.Controls
{
    public partial class ucListenning : UserControl
    {
        public int TimeListened = 0; /// thời gian đã nghe được lưu lại
        public int TestDetailID;
        public WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public WMPLib.IWMPMedia mediaInfo;
        public bool CheckPlay = false;
        private byte[] _Audio;

        public bool loadingPlayer;
        private string pathfile = Common.Constant.PATH_EXON;
        public int maxAudio;

        private string Url;
        private Timer timerAudio;
        public int TimeChecked = 0;
        private System.Windows.Forms.Timer time;
        private string fileProcess = Application.StartupPath + "\\WMPLib.exe";
        static Process process;
        public ucListenning(byte[] Audio, int timeListened, int testDetailID)
        {
            InitializeComponent();
            TimeListened = timeListened;
            TestDetailID = testDetailID;

            CreateFileAudio(Audio, TestDetailID);

            //this._Audio = Audio;
        }

        private void CreateFileAudio(byte[] Audio, int TestDetailID)
        {
            string filepath = TestDetailID.ToString();
            if (!Directory.Exists(Path.Combine(pathfile, "temp")))
                Directory.CreateDirectory(Path.Combine(pathfile, "temp"));

            File.WriteAllBytes(pathfile + "\\temp\\" + filepath + ".mp3", Audio);
            Url = Path.Combine(pathfile, "temp\\" + filepath + ".mp3");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bắt đầu bài nghe?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.ParentForm.Controls["flpnListOfQuestions"].Focus();
                    if (TimeListened < 0)
                    {
                        TimeListened = -TimeListened;
                    }
                    else
                    {
                        TimeListened = 0;
                    }
                    //wplayer.PlayStateChange += Wplayer_PlayStateChange;
                    //wplayer.URL = Url;
                    mediaInfo = wplayer.newMedia(Url);
                    maxAudio = (int)mediaInfo.duration;
                    lblMaximumLenght.Text = mediaInfo.durationString;
                    //wplayer.controls.play();
                    loadingPlayer = true;
                    CheckPlay = true;
                    TimeChecked = TimeListened;
                    ProcessStartInfo startInfo = new ProcessStartInfo(Path.GetFullPath(fileProcess));

                    startInfo.Arguments = Path.GetFullPath(Url) + " " + TimeListened;
                    using (Process exeProcess = Process.Start(startInfo))
                    {


                    }

                    // //time = new System.Windows.Forms.Timer();

                    //wplayer.controls.currentPosition = TimeListened;

                    //lblSeek.Text = string.Format("{0}:{1}", TimeListened / 60,
                    //    (TimeListened % 60).ToString("00"));
                    timerAudio = new Timer();
                    timerAudio.Interval = 5000;
                    timerAudio.Tick += TimerAudio_Tick;
                    ////time.Tick += timerPlayMusic;
                    ////time.Start();
                    timerAudio.Start();
                    btnPlay.Enabled = false;

                    //mtbAudio.Maximum = (int)mediaInfo.duration;
                    //mtbAudio.Value = TimeChecked;

                }
            }
            catch
            {
                MessageBox.Show("Không tìm thấy chương trình nghe WMPLib.exe", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// lưu thời gian đã nghe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerAudio_Tick(object sender, EventArgs e)
        {
            try
            {
                TimeChecked += 5;
                //if (TimeChecked <= mediaInfo.duration)
                //{
                //    mtbAudio.Value = TimeChecked;
                //}
                //mtbAudio.Update();
            }
            catch
            { }
        }

        private void timerPlayMusic(object sender, EventArgs e)
        {
            try
            {
                //if (wplayer == null) return;
                //mtbAudio.Value = (int)wplayer.controls.currentPosition;
                //if (mtbAudio.Value == mtbAudio.Maximum)
                //{
                //    timerAudio.Stop();
                //    time.Stop();
                //}
                // mtbAudio.Update();
                lblSeek.Text = string.Format("{0}:{1}", (int)wplayer.controls.currentPosition / 60,
                    ((int)wplayer.controls.currentPosition % 60).ToString("00"));
            }
            catch
            {

            }
        }

        private void Wplayer_PlayStateChange(int NewState)
        {
            if (loadingPlayer && NewState == 3)
            {
                lblMaximumLenght.Text = wplayer.currentMedia.durationString;
                maxAudio = (int)wplayer.currentMedia.duration;
                //mtbAudio.Maximum = (int)wplayer.currentMedia.duration;
                loadingPlayer = false;
                wplayer.controls.stop();
            }
        }
    }
}
