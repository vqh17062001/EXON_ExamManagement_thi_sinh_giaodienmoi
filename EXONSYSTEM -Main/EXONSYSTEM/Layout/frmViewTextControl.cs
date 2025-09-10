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
using MetroFramework.Forms;

namespace EXONSYSTEM.Layout
{
     public partial class frmViewTextControl : MetroForm
     {
          public frmViewTextControl()
          {
               InitializeComponent();
          }
          public frmViewTextControl(TXTextControl.TextControl _rtf)
          {
               InitializeComponent();
          }
          public void UpdateView(TXTextControl.TextControl _rtf, int _width)
          {
            //  rtfView.Width = _width;
            //
            //viewTextControl.Text = _rtf.Text;
            string s;
            _rtf.Save(out s, TXTextControl.StringStreamType.RichTextFormat);


            //viewTextControl.AutoControlSize.AutoExpand = TXTextControl.AutoSizeDirection.Vertical;
            viewTextControl.Visible = true;
            viewTextControl.Location = new Point(3, 2);
            viewTextControl.Size = new Size(871, 295);
          
            viewTextControl.ViewMode = TXTextControl.ViewMode.SimpleControl;
            viewTextControl.AutoControlSize.AutoExpand = TXTextControl.AutoSizeDirection.Both;
            viewTextControl.MaximumSize = new Size(viewTextControl.Width, 500);

            this.Height = _rtf.Height + 10;
            this.Width = _rtf.Width + 10;


            Controllers.Instance.HandleRichTextBoxStyle(viewTextControl);

            if (viewTextControl.Height < 200)
            {
                viewTextControl.Load(s, TXTextControl.StringStreamType.RichTextFormat);
                viewTextControl.AutoControlSize.AutoExpand = TXTextControl.AutoSizeDirection.None;
            }
            else
            {
                viewTextControl.AutoControlSize.AutoExpand = TXTextControl.AutoSizeDirection.None;
                viewTextControl.ViewMode = TXTextControl.ViewMode.FloatingText;
                viewTextControl.ScrollBars = ScrollBars.Both;
                viewTextControl.Load(s, TXTextControl.StringStreamType.RichTextFormat);
            }

            //viewTextControl.Load(s, TXTextControl.StringStreamType.RichTextFormat);

            //viewTextControl.AutoControlSize.AutoExpand = TXTextControl.AutoSizeDirection.None;

            //if (viewTextControl.Height > 200)
            //{
            //    viewTextControl.ViewMode = TXTextControl.ViewMode.FloatingText;
            //    viewTextControl.ScrollBars = ScrollBars.Both;
            //}

            //TXTextControl.AutoSize auto_size = new TXTextControl.AutoSize();


            viewTextControl.Update();

          }

          private void frmViewTextControl_FormClosing(object sender, FormClosingEventArgs e)
          {
               this.Dispose();
          }

          private void frmViewTextControl_Load(object sender, EventArgs e)
          {
            //viewTextControl.ViewMode = TXTextControl.ViewMode.SimpleControl;
            //
            //auto_size.AutoExpand = TXTextControl.AutoSizeDirection.Both;
            //viewTextControl.AutoControlSize = auto_size;


        }
    }
}
