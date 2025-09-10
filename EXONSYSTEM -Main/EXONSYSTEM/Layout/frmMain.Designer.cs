namespace EXONSYSTEM
{
    partial class frmMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.timeCountDown = new System.Windows.Forms.Timer(this.components);
            this.pnInformation = new MetroFramework.Controls.MetroPanel();
            this.mpnInformationWrapper1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpnListOfButtonQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTimer = new System.Windows.Forms.Label();
            this.flpnListOfQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.timeAltTab = new System.Windows.Forms.Timer(this.components);
            this.timerReadyToLoadTest = new System.Windows.Forms.Timer(this.components);
            this.timerReadyToTest = new System.Windows.Forms.Timer(this.components);
            this.pnInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeCountDown
            // 
            this.timeCountDown.Interval = 1000;
            this.timeCountDown.Tick += new System.EventHandler(this.timeCountDown_Tick);
            // 
            // pnInformation
            // 
            this.pnInformation.Controls.Add(this.mpnInformationWrapper1);
            this.pnInformation.Controls.Add(this.flpnListOfButtonQuestions);
            this.pnInformation.Controls.Add(this.lbTimer);
            this.pnInformation.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnInformation.HorizontalScrollbarBarColor = true;
            this.pnInformation.HorizontalScrollbarHighlightOnWheel = false;
            this.pnInformation.HorizontalScrollbarSize = 10;
            this.pnInformation.Location = new System.Drawing.Point(12, 12);
            this.pnInformation.Name = "pnInformation";
            this.pnInformation.Size = new System.Drawing.Size(46, 100);
            this.pnInformation.TabIndex = 7;
            this.pnInformation.UseCustomBackColor = true;
            this.pnInformation.UseCustomForeColor = true;
            this.pnInformation.VerticalScrollbarBarColor = true;
            this.pnInformation.VerticalScrollbarHighlightOnWheel = false;
            this.pnInformation.VerticalScrollbarSize = 10;
            // 
            // mpnInformationWrapper1
            // 
            this.mpnInformationWrapper1.BackColor = System.Drawing.Color.Transparent;
            this.mpnInformationWrapper1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpnInformationWrapper1.Location = new System.Drawing.Point(3, 7);
            this.mpnInformationWrapper1.Name = "mpnInformationWrapper1";
            this.mpnInformationWrapper1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mpnInformationWrapper1.Size = new System.Drawing.Size(20, 17);
            this.mpnInformationWrapper1.TabIndex = 4;
            // 
            // flpnListOfButtonQuestions
            // 
            this.flpnListOfButtonQuestions.AutoScroll = true;
            this.flpnListOfButtonQuestions.BackColor = System.Drawing.Color.Transparent;
            this.flpnListOfButtonQuestions.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpnListOfButtonQuestions.Location = new System.Drawing.Point(17, 30);
            this.flpnListOfButtonQuestions.Name = "flpnListOfButtonQuestions";
            this.flpnListOfButtonQuestions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flpnListOfButtonQuestions.Size = new System.Drawing.Size(26, 54);
            this.flpnListOfButtonQuestions.TabIndex = 3;
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(7, 7);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(0, 73);
            this.lbTimer.TabIndex = 2;
            // 
            // flpnListOfQuestions
            // 
            this.flpnListOfQuestions.AutoScroll = true;
            this.flpnListOfQuestions.AutoSize = true;
            this.flpnListOfQuestions.Location = new System.Drawing.Point(96, 19);
            this.flpnListOfQuestions.Name = "flpnListOfQuestions";
            this.flpnListOfQuestions.Size = new System.Drawing.Size(100, 100);
            this.flpnListOfQuestions.TabIndex = 2;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 204);
            this.Controls.Add(this.flpnListOfQuestions);
            this.Controls.Add(this.pnInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainForm";
            this.Text = "Chương trình thi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnInformation.ResumeLayout(false);
            this.pnInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timeCountDown;
        private MetroFramework.Controls.MetroPanel pnInformation;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.FlowLayoutPanel flpnListOfQuestions;
        private System.Windows.Forms.FlowLayoutPanel flpnListOfButtonQuestions;
        private System.Windows.Forms.FlowLayoutPanel mpnInformationWrapper1;
        private System.Windows.Forms.Timer timeAltTab;
        private System.Windows.Forms.Timer timerReadyToLoadTest;
        private System.Windows.Forms.Timer timerReadyToTest;
    }
}

