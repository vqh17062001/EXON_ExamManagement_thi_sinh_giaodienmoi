namespace EXONSYSTEM.Controls
{
    partial class ucListenning
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
            this.mtbAudio = new System.Windows.Forms.TrackBar();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblSeek = new System.Windows.Forms.Label();
            this.lblMaximumLenght = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mtbAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbAudio
            // 
            this.mtbAudio.Location = new System.Drawing.Point(155, 28);
            this.mtbAudio.Name = "mtbAudio";
            this.mtbAudio.Size = new System.Drawing.Size(225, 45);
            this.mtbAudio.TabIndex = 0;
            this.mtbAudio.Visible = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::EXONSYSTEM.Properties.Resources.PLAY_MEDIA;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(22, 16);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(48, 48);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblSeek
            // 
            this.lblSeek.AutoSize = true;
            this.lblSeek.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeek.Location = new System.Drawing.Point(76, 33);
            this.lblSeek.Name = "lblSeek";
            this.lblSeek.Size = new System.Drawing.Size(60, 17);
            this.lblSeek.TabIndex = 2;
            this.lblSeek.Text = "00:00:00";
            this.lblSeek.Visible = false;
            // 
            // lblMaximumLenght
            // 
            this.lblMaximumLenght.AutoSize = true;
            this.lblMaximumLenght.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximumLenght.Location = new System.Drawing.Point(400, 33);
            this.lblMaximumLenght.Name = "lblMaximumLenght";
            this.lblMaximumLenght.Size = new System.Drawing.Size(60, 17);
            this.lblMaximumLenght.TabIndex = 3;
            this.lblMaximumLenght.Text = "00:00:00";
            // 
            // ucListenning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtbAudio);
            this.Controls.Add(this.lblMaximumLenght);
            this.Controls.Add(this.lblSeek);
            this.Controls.Add(this.btnPlay);
            this.Name = "ucListenning";
            this.Size = new System.Drawing.Size(476, 76);
            ((System.ComponentModel.ISupportInitialize)(this.mtbAudio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar mtbAudio;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblSeek;
        private System.Windows.Forms.Label lblMaximumLenght;
    }
}
