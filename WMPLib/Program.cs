using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Windows.Forms;
using System.IO;

namespace WMPLib
{
    class Program
    {
        public delegate void func();
        static void Main(string[] args)
        {
            string audio_path = "";
            double pos = 0;
            try
            {
                audio_path = args[0];
            }
            catch
            {
                MessageBox.Show("Đường dẫn đến file nghe không hợp lệ");
            }
            try
            {
                pos = Convert.ToDouble(args[1]);
            }
            catch
            {
                MessageBox.Show("Vị trí phát phải là số thực");
            }
            try
            {
                if (!System.IO.File.Exists(Path.GetFullPath(audio_path)))
                {
                    MessageBox.Show("File nghe không tồn tại");
                    return;
                }

                SoundManager sound = new SoundManager(audio_path);
                sound.Play(pos);

                Application.Run();
                //Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
