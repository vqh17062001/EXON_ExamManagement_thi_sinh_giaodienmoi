namespace CHECKDB
{
    partial class frmConfigApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigApplication));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnDB = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdbname = new MetroFramework.Controls.MetroTextBox();
            this.lbIPDB = new System.Windows.Forms.Label();
            this.txtServerName = new MetroFramework.Controls.MetroTextBox();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.lbLine2 = new System.Windows.Forms.Label();
            this.lbDB = new System.Windows.Forms.Label();
            this.lbLine1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnContent.SuspendLayout();
            this.pnDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pnContent
            // 
            this.pnContent.Controls.Add(this.pnDB);
            this.pnContent.Controls.Add(this.btnSubmit);
            this.pnContent.Controls.Add(this.lbLine2);
            this.pnContent.Controls.Add(this.lbDB);
            this.pnContent.Controls.Add(this.lbLine1);
            this.pnContent.Location = new System.Drawing.Point(23, 63);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(658, 310);
            this.pnContent.TabIndex = 9;
            // 
            // pnDB
            // 
            this.pnDB.Controls.Add(this.txtPort);
            this.pnDB.Controls.Add(this.label4);
            this.pnDB.Controls.Add(this.label3);
            this.pnDB.Controls.Add(this.txtPassword);
            this.pnDB.Controls.Add(this.label2);
            this.pnDB.Controls.Add(this.txtUser);
            this.pnDB.Controls.Add(this.label1);
            this.pnDB.Controls.Add(this.txtdbname);
            this.pnDB.Controls.Add(this.lbIPDB);
            this.pnDB.Controls.Add(this.txtServerName);
            this.pnDB.Location = new System.Drawing.Point(4, 44);
            this.pnDB.Name = "pnDB";
            this.pnDB.Size = new System.Drawing.Size(651, 201);
            this.pnDB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(34, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(220, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassword.Lines = new string[] {
        "1234@abcd"};
            this.txtPassword.Location = new System.Drawing.Point(219, 162);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(250, 32);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "1234@abcd";
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(33, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(220, 2);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUser.Lines = new string[] {
        "sa"};
            this.txtUser.Location = new System.Drawing.Point(219, 119);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(250, 32);
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "sa";
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(33, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "DatabaseName";
            // 
            // txtdbname
            // 
            // 
            // 
            // 
            this.txtdbname.CustomButton.Image = null;
            this.txtdbname.CustomButton.Location = new System.Drawing.Point(220, 2);
            this.txtdbname.CustomButton.Name = "";
            this.txtdbname.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtdbname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdbname.CustomButton.TabIndex = 1;
            this.txtdbname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdbname.CustomButton.UseSelectable = true;
            this.txtdbname.CustomButton.Visible = false;
            this.txtdbname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtdbname.Lines = new string[] {
        "MTAQuizNN"};
            this.txtdbname.Location = new System.Drawing.Point(219, 79);
            this.txtdbname.MaxLength = 32767;
            this.txtdbname.Name = "txtdbname";
            this.txtdbname.PasswordChar = '\0';
            this.txtdbname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdbname.SelectedText = "";
            this.txtdbname.SelectionLength = 0;
            this.txtdbname.SelectionStart = 0;
            this.txtdbname.ShortcutsEnabled = true;
            this.txtdbname.Size = new System.Drawing.Size(250, 32);
            this.txtdbname.TabIndex = 3;
            this.txtdbname.Text = "MTAQuizNN";
            this.txtdbname.UseSelectable = true;
            this.txtdbname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdbname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbIPDB
            // 
            this.lbIPDB.AutoSize = true;
            this.lbIPDB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIPDB.Location = new System.Drawing.Point(33, 13);
            this.lbIPDB.Name = "lbIPDB";
            this.lbIPDB.Size = new System.Drawing.Size(101, 21);
            this.lbIPDB.TabIndex = 1;
            this.lbIPDB.Text = "ServerName";
            // 
            // txtServerName
            // 
            // 
            // 
            // 
            this.txtServerName.CustomButton.Image = null;
            this.txtServerName.CustomButton.Location = new System.Drawing.Point(220, 2);
            this.txtServerName.CustomButton.Name = "";
            this.txtServerName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtServerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServerName.CustomButton.TabIndex = 1;
            this.txtServerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServerName.CustomButton.UseSelectable = true;
            this.txtServerName.CustomButton.Visible = false;
            this.txtServerName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtServerName.Lines = new string[] {
        "MAYCHUNN\\SQLEXPRESS"};
            this.txtServerName.Location = new System.Drawing.Point(219, 3);
            this.txtServerName.MaxLength = 32767;
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.PasswordChar = '\0';
            this.txtServerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServerName.SelectedText = "";
            this.txtServerName.SelectionLength = 0;
            this.txtServerName.SelectionStart = 0;
            this.txtServerName.ShortcutsEnabled = true;
            this.txtServerName.Size = new System.Drawing.Size(250, 32);
            this.txtServerName.TabIndex = 1;
            this.txtServerName.Text = "MAYCHUNN\\SQLEXPRESS";
            this.txtServerName.UseSelectable = true;
            this.txtServerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.DisplayFocus = true;
            this.btnSubmit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSubmit.Highlight = true;
            this.btnSubmit.Location = new System.Drawing.Point(223, 260);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(269, 37);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "KIỂM TRA KẾT NỐI";
            this.btnSubmit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSubmit.UseCustomBackColor = true;
            this.btnSubmit.UseCustomForeColor = true;
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.UseStyleColors = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbLine2
            // 
            this.lbLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbLine2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLine2.Location = new System.Drawing.Point(-1, 248);
            this.lbLine2.Name = "lbLine2";
            this.lbLine2.Size = new System.Drawing.Size(660, 1);
            this.lbLine2.TabIndex = 0;
            // 
            // lbDB
            // 
            this.lbDB.AutoSize = true;
            this.lbDB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDB.Location = new System.Drawing.Point(238, 15);
            this.lbDB.Name = "lbDB";
            this.lbDB.Size = new System.Drawing.Size(127, 24);
            this.lbDB.TabIndex = 0;
            this.lbDB.Text = "Cơ sở dữ liệu";
            // 
            // lbLine1
            // 
            this.lbLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbLine1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLine1.Location = new System.Drawing.Point(-1, 39);
            this.lbLine1.Name = "lbLine1";
            this.lbLine1.Size = new System.Drawing.Size(658, 1);
            this.lbLine1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(33, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port";
            // 
            // txtPort
            // 
            // 
            // 
            // 
            this.txtPort.CustomButton.Image = null;
            this.txtPort.CustomButton.Location = new System.Drawing.Point(220, 2);
            this.txtPort.CustomButton.Name = "";
            this.txtPort.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPort.CustomButton.TabIndex = 1;
            this.txtPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPort.CustomButton.UseSelectable = true;
            this.txtPort.CustomButton.Visible = false;
            this.txtPort.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPort.Lines = new string[] {
        "1433"};
            this.txtPort.Location = new System.Drawing.Point(219, 41);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.ShortcutsEnabled = true;
            this.txtPort.Size = new System.Drawing.Size(250, 32);
            this.txtPort.TabIndex = 9;
            this.txtPort.Text = "1433";
            this.txtPort.UseSelectable = true;
            this.txtPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmConfigApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 408);
            this.ControlBox = false;
            this.Controls.Add(this.pnContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "frmConfigApplication";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            this.pnDB.ResumeLayout(false);
            this.pnDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Panel pnDB;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtdbname;
        private System.Windows.Forms.Label lbIPDB;
        private MetroFramework.Controls.MetroTextBox txtServerName;
        private System.Windows.Forms.Label lbLine2;
        private System.Windows.Forms.Label lbDB;
        private System.Windows.Forms.Label lbLine1;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private System.Windows.Forms.Label label4;
    }
}