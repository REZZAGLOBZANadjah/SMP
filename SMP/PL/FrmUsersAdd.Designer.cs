
namespace SMP.PL
{
    partial class FrmUsersAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsersAdd));
            this.pnAddCat = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.editUsersPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editNameUsers = new System.Windows.Forms.TextBox();
            this.lbTitlePage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddUsers = new DevExpress.XtraEditors.SimpleButton();
            this.editUsersRoll = new System.Windows.Forms.ComboBox();
            this.pnAddCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAddCat
            // 
            this.pnAddCat.Controls.Add(this.editUsersRoll);
            this.pnAddCat.Controls.Add(this.label10);
            this.pnAddCat.Controls.Add(this.editUsersPass);
            this.pnAddCat.Controls.Add(this.label1);
            this.pnAddCat.Controls.Add(this.editNameUsers);
            this.pnAddCat.Controls.Add(this.lbTitlePage);
            this.pnAddCat.Controls.Add(this.pictureBox1);
            this.pnAddCat.Controls.Add(this.label11);
            this.pnAddCat.Controls.Add(this.btnAddUsers);
            this.pnAddCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAddCat.Location = new System.Drawing.Point(0, 0);
            this.pnAddCat.Name = "pnAddCat";
            this.pnAddCat.Size = new System.Drawing.Size(817, 344);
            this.pnAddCat.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(694, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 27);
            this.label10.TabIndex = 58;
            this.label10.Text = "الصلاحية";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // editUsersPass
            // 
            this.editUsersPass.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editUsersPass.Location = new System.Drawing.Point(315, 138);
            this.editUsersPass.Name = "editUsersPass";
            this.editUsersPass.Size = new System.Drawing.Size(261, 27);
            this.editUsersPass.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(672, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 56;
            this.label1.Text = "كلمة المرور";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // editNameUsers
            // 
            this.editNameUsers.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editNameUsers.Location = new System.Drawing.Point(315, 81);
            this.editNameUsers.Name = "editNameUsers";
            this.editNameUsers.Size = new System.Drawing.Size(261, 27);
            this.editNameUsers.TabIndex = 55;
            // 
            // lbTitlePage
            // 
            this.lbTitlePage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTitlePage.AutoSize = true;
            this.lbTitlePage.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbTitlePage.ForeColor = System.Drawing.Color.Gray;
            this.lbTitlePage.Location = new System.Drawing.Point(630, 81);
            this.lbTitlePage.Name = "lbTitlePage";
            this.lbTitlePage.Size = new System.Drawing.Size(156, 27);
            this.lbTitlePage.TabIndex = 54;
            this.lbTitlePage.Text = "اسم المستخدم";
            this.lbTitlePage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(33, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 39);
            this.label11.TabIndex = 52;
            this.label11.Text = "اضافة مستخدم";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddUsers.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsers.Appearance.Options.UseFont = true;
            this.btnAddUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUsers.ImageOptions.Image")));
            this.btnAddUsers.Location = new System.Drawing.Point(315, 283);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(471, 44);
            this.btnAddUsers.TabIndex = 51;
            this.btnAddUsers.Text = "اضافة ";
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // editUsersRoll
            // 
            this.editUsersRoll.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editUsersRoll.FormattingEnabled = true;
            this.editUsersRoll.Items.AddRange(new object[] {
            "مدير",
            "مستخدم"});
            this.editUsersRoll.Location = new System.Drawing.Point(315, 195);
            this.editUsersRoll.Name = "editUsersRoll";
            this.editUsersRoll.Size = new System.Drawing.Size(261, 27);
            this.editUsersRoll.TabIndex = 61;
            // 
            // FrmUsersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 344);
            this.Controls.Add(this.pnAddCat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsersAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.pnAddCat.ResumeLayout(false);
            this.pnAddCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnAddCat;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox editUsersPass;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox editNameUsers;
        private System.Windows.Forms.Label lbTitlePage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        public DevExpress.XtraEditors.SimpleButton btnAddUsers;
        public System.Windows.Forms.ComboBox editUsersRoll;
    }
}