namespace EXONSYSTEM.Layout
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
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnDB = new System.Windows.Forms.Panel();
            this.lbIPDB = new System.Windows.Forms.Label();
            this.mtxbIPDatabase = new MetroFramework.Controls.MetroTextBox();
            this.lbLine2 = new System.Windows.Forms.Label();
            this.lbDB = new System.Windows.Forms.Label();
            this.lbLine1 = new System.Windows.Forms.Label();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnContent.SuspendLayout();
            this.pnDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContent
            // 
            this.pnContent.Controls.Add(this.pnDB);
            this.pnContent.Controls.Add(this.lbLine2);
            this.pnContent.Controls.Add(this.lbDB);
            this.pnContent.Controls.Add(this.lbLine1);
            this.pnContent.Location = new System.Drawing.Point(23, 64);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(658, 260);
            this.pnContent.TabIndex = 0;
            // 
            // pnDB
            // 
            this.pnDB.Controls.Add(this.lbIPDB);
            this.pnDB.Controls.Add(this.mtxbIPDatabase);
            this.pnDB.Location = new System.Drawing.Point(4, 44);
            this.pnDB.Name = "pnDB";
            this.pnDB.Size = new System.Drawing.Size(651, 141);
            this.pnDB.TabIndex = 2;
            // 
            // lbIPDB
            // 
            this.lbIPDB.AutoSize = true;
            this.lbIPDB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIPDB.Location = new System.Drawing.Point(33, 13);
            this.lbIPDB.Name = "lbIPDB";
            this.lbIPDB.Size = new System.Drawing.Size(27, 21);
            this.lbIPDB.TabIndex = 1;
            this.lbIPDB.Text = "IP";
            // 
            // mtxbIPDatabase
            // 
            // 
            // 
            // 
            this.mtxbIPDatabase.CustomButton.Image = null;
            this.mtxbIPDatabase.CustomButton.Location = new System.Drawing.Point(220, 2);
            this.mtxbIPDatabase.CustomButton.Name = "";
            this.mtxbIPDatabase.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtxbIPDatabase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxbIPDatabase.CustomButton.TabIndex = 1;
            this.mtxbIPDatabase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxbIPDatabase.CustomButton.UseSelectable = true;
            this.mtxbIPDatabase.CustomButton.Visible = false;
            this.mtxbIPDatabase.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtxbIPDatabase.Lines = new string[] {
        "169.254.227.0"};
            this.mtxbIPDatabase.Location = new System.Drawing.Point(83, 3);
            this.mtxbIPDatabase.MaxLength = 32767;
            this.mtxbIPDatabase.Name = "mtxbIPDatabase";
            this.mtxbIPDatabase.PasswordChar = '\0';
            this.mtxbIPDatabase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxbIPDatabase.SelectedText = "";
            this.mtxbIPDatabase.SelectionLength = 0;
            this.mtxbIPDatabase.SelectionStart = 0;
            this.mtxbIPDatabase.ShortcutsEnabled = true;
            this.mtxbIPDatabase.Size = new System.Drawing.Size(250, 32);
            this.mtxbIPDatabase.TabIndex = 1;
            this.mtxbIPDatabase.Text = "169.254.227.0";
            this.mtxbIPDatabase.UseSelectable = true;
            this.mtxbIPDatabase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxbIPDatabase.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxbIPDatabase.TextChanged += new System.EventHandler(this.mtxb_TextChanged);
            this.mtxbIPDatabase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxb_KeyPress);
            this.mtxbIPDatabase.Validating += new System.ComponentModel.CancelEventHandler(this.mtxb_Validating);
            // 
            // lbLine2
            // 
            this.lbLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbLine2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLine2.Location = new System.Drawing.Point(-1, 188);
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
            this.lbDB.Click += new System.EventHandler(this.lbDB_Click);
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
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.DisplayFocus = true;
            this.btnSubmit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSubmit.Highlight = true;
            this.btnSubmit.Location = new System.Drawing.Point(197, 330);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(269, 37);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "KIỂM TRA KẾT NỐI";
            this.btnSubmit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSubmit.UseCustomBackColor = true;
            this.btnSubmit.UseCustomForeColor = true;
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.UseStyleColors = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmConfigApplication
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 379);
            this.ControlBox = false;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "frmConfigApplication";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmConfigApplication_Load);
            this.pnContent.ResumeLayout(false);
            this.pnContent.PerformLayout();
            this.pnDB.ResumeLayout(false);
            this.pnDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Label lbLine1;
        private System.Windows.Forms.Label lbIPDB;
        private System.Windows.Forms.Label lbLine2;
        private System.Windows.Forms.Label lbDB;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private System.Windows.Forms.Panel pnDB;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MetroFramework.Controls.MetroTextBox mtxbIPDatabase;
    }
}