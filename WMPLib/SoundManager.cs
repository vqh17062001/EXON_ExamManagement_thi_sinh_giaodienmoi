using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WMPLib
{
    public class SoundManager
    {
        WindowsMediaPlayer sound;
        IWMPMedia mediaInfo;

        public SoundManager(string _filePath)
        {
            sound = new WindowsMediaPlayer();
            mediaInfo = sound.newMedia(_filePath);
            sound.currentMedia = sound.newMedia(_filePath);
            sound.controls.stop();
            sound.PlayStateChange += Sound_PlayStateChange;
        }

        private void Sound_PlayStateChange(int NewState)
        {
            if (NewState == 1)
            {
                Program.func exit = new Program.func(Application.Exit);
                exit();
            }
        }

        public void Play()
        {
            sound.controls.play();
        }

        public void Play(double pos)
        {
            if (pos > mediaInfo.duration)
                sound.controls.currentPosition = 0;
            else
                sound.controls.currentPosition = pos;
            sound.controls.play();
        }

        public void Stop()
        {
            sound.controls.stop();
        }

        public void Pause()
        {
            sound.controls.pause();
        }

        public void Resume()
        {
            if (sound.status == "Paused")
                sound.controls.play();
        }

        public bool IsEnd()
        {
            return (sound.status == "Stopped");
        }
    }
}
