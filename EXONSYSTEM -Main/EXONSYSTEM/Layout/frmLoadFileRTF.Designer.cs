namespace EXONSYSTEM.Layout
{
    partial class frmLoadFileRTF
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mbtnCancel = new MetroFramework.Controls.MetroButton();
            this.mbtnOK = new MetroFramework.Controls.MetroButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mbtnCancel);
            this.panel1.Controls.Add(this.mbtnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 79);
            this.panel1.TabIndex = 1;
            // 
            // mbtnCancel
            // 
            this.mbtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbtnCancel.Location = new System.Drawing.Point(399, 22);
            this.mbtnCancel.Name = "mbtnCancel";
            this.mbtnCancel.Size = new System.Drawing.Size(127, 35);
            this.mbtnCancel.TabIndex = 4;
            this.mbtnCancel.Text = "Hủy";
            this.mbtnCancel.UseCustomBackColor = true;
            this.mbtnCancel.UseCustomForeColor = true;
            this.mbtnCancel.UseSelectable = true;
            this.mbtnCancel.Visible = false;
            // 
            // mbtnOK
            // 
            this.mbtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mbtnOK.Location = new System.Drawing.Point(239, 22);
            this.mbtnOK.Name = "mbtnOK";
            this.mbtnOK.Size = new System.Drawing.Size(127, 35);
            this.mbtnOK.TabIndex = 3;
            this.mbtnOK.Text = "Load dữ liệu";
            this.mbtnOK.UseCustomBackColor = true;
            this.mbtnOK.UseCustomForeColor = true;
            this.mbtnOK.UseSelectable = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(20, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(752, 303);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // frmLoadFileRTF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 462);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmLoadFileRTF";
            this.Text = "Câu trả lời được soạn thảo bằng word";
            this.Load += new System.EventHandler(this.frmLoadFileRTF_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroButton mbtnCancel;
        private MetroFramework.Controls.MetroButton mbtnOK;
    }
}