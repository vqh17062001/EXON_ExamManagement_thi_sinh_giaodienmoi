using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXONSYSTEM.Controls
{

    public class TypeAssistant
    {
        public event EventHandler Idled = delegate { };
        public int WaitingMilliSeconds { get; set; }
        System.Threading.Timer waitingTimer;
        public RichTextBox _rtf { get; set; }
        public TypeAssistant(RichTextBox rtf=null)
        {
            _rtf = rtf;
            WaitingMilliSeconds = 800;
            waitingTimer = new System.Threading.Timer(p =>
            {
                Idled(_rtf, EventArgs.Empty);
            });
        }

        public void TextChanged()
        {
            waitingTimer.Change(WaitingMilliSeconds, System.Threading.Timeout.Infinite);
        }
    }
}
