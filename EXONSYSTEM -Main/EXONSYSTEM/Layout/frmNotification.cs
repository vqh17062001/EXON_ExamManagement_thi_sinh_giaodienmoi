using EXONSYSTEM.Common;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXONSYSTEM.Layout
{
    public partial class frmNotification : MetroForm
    {
        public int DivisionShiftID;
        public int ContestantShiftID;

        public string Content
        {
            set
            {
                lbContent.Text = value;
                lbContent.MaximumSize = new Size(this.Width - 10, 0);
                lbContent.Location = new Point(Convert.ToInt32((this.Width - lbContent.Width) / 2), 60);
            }
        }
        public string ContentOpenWord
        {
            set
            {
                this.Width = 600;
                lbContent.Text = value;
                lbContent.Font = new Font(Constant.FONT_FAMILY_DEFAULT, 13, FontStyle.Italic);
                lbContent.MaximumSize = new Size(this.Width - 10, 0);
                lbContent.Location = new Point(Convert.ToInt32((this.Width - lbContent.Width) / 2), 60);
            }
        }
        public string Header
        {
            set
            {
                this.Text = value;
            }
        }
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
                mbtnOK.Location = new Point(Convert.ToInt32((this.Width - mbtnOK.Width) / 2), lbContent.Bottom + 10);
                this.Height = mbtnOK.Bottom + 20;
            }
        }
        public string TextMbtnOKOpenWord
        {
            set
            {
                mbtnOK.ForeColor = Constant.FORCECOLOR_BUTTON_SUBMIT;
                mbtnOK.BackColor = Constant.BACKCOLOR_BUTTON_CONTROLLER;
                mbtnOK.Text = value;
                mbtnOK.Cursor = Cursors.Hand;
                mbtnOK.Size = new Size(200, 30);
                mbtnOK.DialogResult = DialogResult.OK;
                mbtnOK.Location = new Point(Convert.ToInt32((this.Width - mbtnOK.Width) / 4), lbContent.Bottom + 20);
                this.Height = mbtnOK.Bottom + 20;
            }
        }
        public void SetMbtnOK(bool check)
        {
            mbtnOK.Enabled = check;
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
                mbtnCancel.Location = new Point(mbtnOK.Right + 20, mbtnOK.Top);
            }
        }
        public frmNotification()
        {
            InitializeComponent();
            this.Text = Properties.Resources.MSG_MESS_0001;
            this.Font = new Font(Constant.FONT_FAMILY_DEFAULT, Constant.FONT_SIZE_DEFAULT + 2, FontStyle.Regular);
        }
        public frmNotification(int _divisionShiftID, int _ContestantShiftID)
        {
            InitializeComponent();
            this.DivisionShiftID = _divisionShiftID;
            ContestantShiftID = _ContestantShiftID;
            this.Text = Properties.Resources.MSG_MESS_0001;
            this.Font = new Font(Constant.FONT_FAMILY_DEFAULT, Constant.FONT_SIZE_DEFAULT + 2, FontStyle.Regular);
        }
        /// <summary>
        /// Alt +f4
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override System.Boolean ProcessCmdKey(ref
            System.Windows.Forms.Message msg, System.Windows.Forms.Keys
            keyData)
        {

            if (keyData == (System.Windows.Forms.Keys.Menu | System.Windows.Forms.Keys.Alt))
                return false;
            return true;
        }
    }
}
