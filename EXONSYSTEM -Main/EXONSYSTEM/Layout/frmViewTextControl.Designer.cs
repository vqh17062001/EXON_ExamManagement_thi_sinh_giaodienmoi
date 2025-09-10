namespace EXONSYSTEM.Layout
{
     partial class frmViewTextControl
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
            this.viewTextControl = new TXTextControl.TextControl();
            this.SuspendLayout();
            // 
            // viewTextControl
            // 
            this.viewTextControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTextControl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTextControl.Location = new System.Drawing.Point(20, 60);
            this.viewTextControl.Name = "viewTextControl";
            this.viewTextControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.viewTextControl.Size = new System.Drawing.Size(885, 296);
            this.viewTextControl.TabIndex = 1;
            this.viewTextControl.UserNames = null;
            this.viewTextControl.ViewMode = TXTextControl.ViewMode.SimpleControl;
            // 
            // frmViewTextControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 376);
            this.Controls.Add(this.viewTextControl);
            this.MinimizeBox = false;
            this.Name = "frmViewTextControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewTextControl_FormClosing);
            this.Load += new System.EventHandler(this.frmViewTextControl_Load);
            this.ResumeLayout(false);

          }

        #endregion

        private TXTextControl.TextControl viewTextControl;
    }
}