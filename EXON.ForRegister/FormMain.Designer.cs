namespace EXON.ForRegister
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelStatus = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExam = new System.Windows.Forms.Button();
            this.TextControlTest = new TXTextControl.TextControl();
            this.panelMain = new MetroFramework.Controls.MetroPanel();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.pictureBox1);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(806, 117);
            this.panelStatus.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::EXON.ForRegister.Properties.Resources.LogoHVnew3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 295);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TextControlTest);
            this.panel3.Controls.Add(this.btnExam);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(806, 124);
            this.panel3.TabIndex = 7;
            //
            // TextControlTest
            // 
            this.TextControlTest.AutoControlSize.AutoExpand = TXTextControl.AutoSizeDirection.Both;
            this.TextControlTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextControlTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextControlTest.EditMode = TXTextControl.EditMode.ReadOnly;
            this.TextControlTest.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextControlTest.Location = new System.Drawing.Point(81, 2);
            this.TextControlTest.Margin = new System.Windows.Forms.Padding(5);
            this.TextControlTest.Name = "TextControlTest";
            this.TextControlTest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextControlTest.Size = new System.Drawing.Size(1, 1);
            this.TextControlTest.TabIndex = 0;
            this.TextControlTest.UserNames = null;
            this.TextControlTest.ViewMode = TXTextControl.ViewMode.SimpleControl;
            // 
            // btnExam
            // 
            this.btnExam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExam.AutoSize = true;
            this.btnExam.BackColor = System.Drawing.Color.White;
            this.btnExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExam.FlatAppearance.BorderSize = 0;
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.ForeColor = System.Drawing.Color.White;
            this.btnExam.Image = global::EXON.ForRegister.Properties.Resources.vaothi;
            this.btnExam.Location = new System.Drawing.Point(294, 13);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(248, 108);
            this.btnExam.TabIndex = 0;
            this.btnExam.Text = "Vào Thi";
            this.btnExam.UseVisualStyleBackColor = false;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.HorizontalScrollbarBarColor = true;
            this.panelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMain.HorizontalScrollbarSize = 12;
            this.panelMain.Location = new System.Drawing.Point(20, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(808, 297);
            this.panelMain.TabIndex = 1;
            this.panelMain.VerticalScrollbarBarColor = true;
            this.panelMain.VerticalScrollbarHighlightOnWheel = false;
            this.panelMain.VerticalScrollbarSize = 12;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 377);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Hệ thống thi online";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroPanel panelMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExam;
        private TXTextControl.TextControl TextControlTest;
    }
}