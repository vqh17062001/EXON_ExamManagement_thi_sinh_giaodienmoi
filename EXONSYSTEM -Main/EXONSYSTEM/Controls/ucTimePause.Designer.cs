namespace EXONSYSTEM.Controls
{
    partial class ucTimePause
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblThoiGianGianDoan = new System.Windows.Forms.Label();
            this.lblThoiGianRestart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblThoiGianGianDoan
            // 
            this.lblThoiGianGianDoan.AutoSize = true;
            this.lblThoiGianGianDoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianGianDoan.Location = new System.Drawing.Point(35, 11);
            this.lblThoiGianGianDoan.Name = "lblThoiGianGianDoan";
            this.lblThoiGianGianDoan.Size = new System.Drawing.Size(53, 21);
            this.lblThoiGianGianDoan.TabIndex = 0;
            this.lblThoiGianGianDoan.Text = "label1";
            // 
            // lblThoiGianRestart
            // 
            this.lblThoiGianRestart.AutoSize = true;
            this.lblThoiGianRestart.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblThoiGianRestart.Location = new System.Drawing.Point(35, 43);
            this.lblThoiGianRestart.Name = "lblThoiGianRestart";
            this.lblThoiGianRestart.Size = new System.Drawing.Size(53, 21);
            this.lblThoiGianRestart.TabIndex = 1;
            this.lblThoiGianRestart.Text = "label2";
            // 
            // ucTimePause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblThoiGianRestart);
            this.Controls.Add(this.lblThoiGianGianDoan);
            this.Name = "ucTimePause";
            this.Size = new System.Drawing.Size(454, 70);
            this.Load += new System.EventHandler(this.ucTimePause_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThoiGianGianDoan;
        private System.Windows.Forms.Label lblThoiGianRestart;
    }
}
