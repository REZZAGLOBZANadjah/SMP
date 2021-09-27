
namespace SMP.PL
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnAddCat = new System.Windows.Forms.Panel();
            this.lbUserPass = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitlePage = new System.Windows.Forms.Label();
            this.editUsersPass = new System.Windows.Forms.TextBox();
            this.editNameUsers = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.pnAddCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAddCat
            // 
            this.pnAddCat.Controls.Add(this.separatorControl1);
            this.pnAddCat.Controls.Add(this.label2);
            this.pnAddCat.Controls.Add(this.lbUserPass);
            this.pnAddCat.Controls.Add(this.btnClose);
            this.pnAddCat.Controls.Add(this.lbPass);
            this.pnAddCat.Controls.Add(this.lbUser);
            this.pnAddCat.Controls.Add(this.label1);
            this.pnAddCat.Controls.Add(this.lbTitlePage);
            this.pnAddCat.Controls.Add(this.editUsersPass);
            this.pnAddCat.Controls.Add(this.editNameUsers);
            this.pnAddCat.Controls.Add(this.pictureBox1);
            this.pnAddCat.Controls.Add(this.btnLogin);
            this.pnAddCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAddCat.Location = new System.Drawing.Point(0, 0);
            this.pnAddCat.Name = "pnAddCat";
            this.pnAddCat.Size = new System.Drawing.Size(623, 270);
            this.pnAddCat.TabIndex = 0;
            // 
            // lbUserPass
            // 
            this.lbUserPass.AutoSize = true;
            this.lbUserPass.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbUserPass.ForeColor = System.Drawing.Color.Red;
            this.lbUserPass.Location = new System.Drawing.Point(149, 196);
            this.lbUserPass.Name = "lbUserPass";
            this.lbUserPass.Size = new System.Drawing.Size(261, 19);
            this.lbUserPass.TabIndex = 63;
            this.lbUserPass.Text = "اسم المستخدم او كلمة المرور خاطئة";
            this.lbUserPass.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClose.Location = new System.Drawing.Point(586, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnClose.Size = new System.Drawing.Size(37, 35);
            this.btnClose.TabIndex = 62;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbPass.ForeColor = System.Drawing.Color.Red;
            this.lbPass.Location = new System.Drawing.Point(233, 154);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(125, 19);
            this.lbPass.TabIndex = 61;
            this.lbPass.Text = "ادخل كلمة المرور";
            this.lbPass.Visible = false;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbUser.ForeColor = System.Drawing.Color.Red;
            this.lbUser.Location = new System.Drawing.Point(203, 83);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(155, 19);
            this.lbUser.TabIndex = 60;
            this.lbUser.Text = "ادخل اسم المستخدم";
            this.lbUser.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(499, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 59;
            this.label1.Text = "كلمة المرور";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbTitlePage
            // 
            this.lbTitlePage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTitlePage.AutoSize = true;
            this.lbTitlePage.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbTitlePage.ForeColor = System.Drawing.Color.Gray;
            this.lbTitlePage.Location = new System.Drawing.Point(457, 76);
            this.lbTitlePage.Name = "lbTitlePage";
            this.lbTitlePage.Size = new System.Drawing.Size(156, 27);
            this.lbTitlePage.TabIndex = 58;
            this.lbTitlePage.Text = "اسم المستخدم";
            this.lbTitlePage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // editUsersPass
            // 
            this.editUsersPass.Font = new System.Drawing.Font("Tahoma", 20F);
            this.editUsersPass.Location = new System.Drawing.Point(155, 144);
            this.editUsersPass.Name = "editUsersPass";
            this.editUsersPass.Size = new System.Drawing.Size(261, 40);
            this.editUsersPass.TabIndex = 57;
            this.editUsersPass.UseSystemPasswordChar = true;
            // 
            // editNameUsers
            // 
            this.editNameUsers.Font = new System.Drawing.Font("Tahoma", 20F);
            this.editNameUsers.Location = new System.Drawing.Point(155, 69);
            this.editNameUsers.Name = "editNameUsers";
            this.editNameUsers.Size = new System.Drawing.Size(261, 40);
            this.editNameUsers.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SMP.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(12, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogin.ImageOptions.SvgImage")));
            this.btnLogin.Location = new System.Drawing.Point(3, 226);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(620, 44);
            this.btnLogin.TabIndex = 51;
            this.btnLogin.Text = "تسجيل الدخول";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(169, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 33);
            this.label2.TabIndex = 64;
            this.label2.Text = " SMP برنامج ادارة المبيعات ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineColor = System.Drawing.Color.DarkSlateGray;
            this.separatorControl1.LineThickness = 3;
            this.separatorControl1.Location = new System.Drawing.Point(0, 39);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(623, 23);
            this.separatorControl1.TabIndex = 65;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 270);
            this.ControlBox = false;
            this.Controls.Add(this.pnAddCat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.pnAddCat.ResumeLayout(false);
            this.pnAddCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnAddCat;
        public System.Windows.Forms.TextBox editUsersPass;
        public System.Windows.Forms.TextBox editNameUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        public DevExpress.XtraEditors.SimpleButton btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitlePage;
        public System.Windows.Forms.Label lbPass;
        public System.Windows.Forms.Label lbUser;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        public System.Windows.Forms.Label lbUserPass;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}