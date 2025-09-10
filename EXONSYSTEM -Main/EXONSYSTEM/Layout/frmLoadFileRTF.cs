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
using EXONSYSTEM.Common;

namespace EXONSYSTEM.Layout
{
    public partial class frmLoadFileRTF : MetroForm
    {
        public string TextMbtnOK
        {
            set
            {
                mbtnOK.ForeColor = Constant.FORCECOLOR_BUTTON_SUBMIT;
                mbtnOK.BackColor = Constant.BACKCOLOR_BUTTON_CONTROLLER;
                mbtnOK.Text = value;
                mbtnOK.Cursor = Cursors.Hand;
                mbtnOK.Size = Constant.SIZE_BUTTON_DEFAULT;
                mbtnOK.DialogResult = DialogResult.OK;
             
                this.Height = mbtnOK.Bottom + 20;
            }
        }
        public string TextMbtnCancel
        {
            set
            {
                mbtnCancel.ForeColor = Constant.FORCECOLOR_BUTTON_SUBMIT;
                mbtnCancel.BackColor = Constant.BACKCOLOR_BUTTON_CONTROLLER;
                mbtnCancel.Text = value;
                mbtnCancel.Cursor = Cursors.Hand;
                mbtnCancel.Size = Constant.SIZE_BUTTON_DEFAULT;
                mbtnCancel.DialogResult = DialogResult.Cancel;
                mbtnCancel.Visible = true;
             
            }
        }
        public string LoadRtf;
   
        private string _filepath;
        public frmLoadFileRTF(string filePath)
        {
            InitializeComponent();
            mbtnCancel.ForeColor = Constant.FORCECOLOR_BUTTON_SUBMIT;
            mbtnCancel.BackColor = Constant.BACKCOLOR_BUTTON_CONTROLLER;
         
            mbtnCancel.Cursor = Cursors.Hand;
            mbtnCancel.Size = Constant.SIZE_BUTTON_DEFAULT;
            mbtnCancel.DialogResult = DialogResult.Cancel;
            mbtnCancel.Visible = true;
            mbtnOK.ForeColor = Constant.FORCECOLOR_BUTTON_SUBMIT;
            mbtnOK.BackColor = Constant.BACKCOLOR_BUTTON_CONTROLLER;
           
            mbtnOK.Cursor = Cursors.Hand;
            mbtnOK.Size = Constant.SIZE_BUTTON_DEFAULT;
            mbtnOK.DialogResult = DialogResult.OK;

            _filepath = filePath;
        }

        private void frmLoadFileRTF_Load(object sender, EventArgs e)
        {

            try
            {
                richTextBox1.LoadFile(_filepath);
                LoadRtf = richTextBox1.Rtf;
            }
            catch
            {
                MessageBox.Show("Không load được dữ liệu! vui lòng mở lại","Thông báo");
            }
        }
    }
}
