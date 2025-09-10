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
namespace EXONSYSTEM.Layout
{
    public partial class frmViewRtf : MetroForm
    {
       // public string _rtf;

        public frmViewRtf()
        {
            InitializeComponent();
        }
        public frmViewRtf(string _rtf)
        {
            InitializeComponent();
        }
        public void UpdateView(TRichTextBox.AdvanRichTextBox _rtf,int _width)
        {
          //  rtfView.Width = _width;
            string rtf = _rtf.Rtf;
         
            rtfView.Rtf = rtf;
         // this.Width = _width + 100;
            rtfView.Update();
        }

        public void UpdateView2(RichTextBox _rtf, int _width)
        {
            rtfView.Visible = false;
          //  rtfView.Width = _width;
            string rtf = _rtf.Rtf;
            RichTextBox rtfTest = new RichTextBox();
            rtfTest.Location = new Point(20,60);
            
            rtfTest.Height = 600;
            //rtfTest.Width = _width;
          //  rtfTest.Width = _width;
           //rtfTest.Height = this.Height;
            rtfTest.Rtf = rtf;
            this.Height = rtfTest.Height + 20;
            // rtfTest.ScrollBars = RichTextBoxScrollBars.Both;
            this.Width = _width + 50;
            this.Controls.Add(rtfTest);
            this.Update();
           
        }
        private void frmViewRtf_Load(object sender, EventArgs e)
        {
          //  rtfView.Rtf = _rtf;
        }

        private void frmViewRtf_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
