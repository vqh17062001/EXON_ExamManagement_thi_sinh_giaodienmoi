using TRichTextBox;
namespace EXONSYSTEM.Layout
{
    partial class frmViewRtf
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
            this.rtfView = new TRichTextBox.AdvanRichTextBox();
            this.SuspendLayout();
            // 
            // rtfView
            // 
            this.rtfView.BackColor = System.Drawing.Color.White;
            this.rtfView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfView.Dock = System.Windows.Forms.DockStyle.Fill;
           this.rtfView.EnableAutoDragDrop = true;
            this.rtfView.Location = new System.Drawing.Point(20, 60);
            this.rtfView.Name = "rtfView";
            this.rtfView.ReadOnly = true;
            this.rtfView.ShortcutsEnabled = false;
          //  this.rtfView.Size = new System.Drawing.Size(721, 260);
            this.rtfView.TabIndex = 0;
            this.rtfView.Text = "";
            // 
            // frmViewRtf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(761, 340);
            this.Controls.Add(this.rtfView);
            this.MinimizeBox = false;
            this.Name = "frmViewRtf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewRtf_FormClosing);
            this.Load += new System.EventHandler(this.frmViewRtf_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TRichTextBox.AdvanRichTextBox rtfView;
    }
}