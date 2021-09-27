
namespace SMP.PL
{
    partial class FrmSuppAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuppAdd));
            this.pnAddCat = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.edtEmailSupp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.editPhoneSupp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSupp = new DevExpress.XtraEditors.SimpleButton();
            this.picCoverSupp = new DevExpress.XtraEditors.PictureEdit();
            this.editNameSup = new System.Windows.Forms.TextBox();
            this.lbTitlePage = new System.Windows.Forms.Label();
            this.pnAddCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoverSupp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAddCat
            // 
            this.pnAddCat.Controls.Add(this.label2);
            this.pnAddCat.Controls.Add(this.edtEmailSupp);
            this.pnAddCat.Controls.Add(this.label3);
            this.pnAddCat.Controls.Add(this.editPhoneSupp);
            this.pnAddCat.Controls.Add(this.label1);
            this.pnAddCat.Controls.Add(this.btnAddSupp);
            this.pnAddCat.Controls.Add(this.picCoverSupp);
            this.pnAddCat.Controls.Add(this.editNameSup);
            this.pnAddCat.Controls.Add(this.lbTitlePage);
            this.pnAddCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAddCat.Location = new System.Drawing.Point(0, 0);
            this.pnAddCat.Name = "pnAddCat";
            this.pnAddCat.Size = new System.Drawing.Size(449, 514);
            this.pnAddCat.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(102, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "الصورة";
            // 
            // edtEmailSupp
            // 
            this.edtEmailSupp.Font = new System.Drawing.Font("Tahoma", 20F);
            this.edtEmailSupp.Location = new System.Drawing.Point(9, 182);
            this.edtEmailSupp.Name = "edtEmailSupp";
            this.edtEmailSupp.Size = new System.Drawing.Size(261, 40);
            this.edtEmailSupp.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(346, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "الايميل";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // editPhoneSupp
            // 
            this.editPhoneSupp.Font = new System.Drawing.Font("Tahoma", 20F);
            this.editPhoneSupp.Location = new System.Drawing.Point(9, 119);
            this.editPhoneSupp.Name = "editPhoneSupp";
            this.editPhoneSupp.Size = new System.Drawing.Size(261, 40);
            this.editPhoneSupp.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(309, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "رقم الهاتف";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddSupp.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupp.Appearance.Options.UseFont = true;
            this.btnAddSupp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCat.ImageOptions.Image")));
            this.btnAddSupp.Location = new System.Drawing.Point(285, 458);
            this.btnAddSupp.Name = "btnAddSupp";
            this.btnAddSupp.Size = new System.Drawing.Size(121, 44);
            this.btnAddSupp.TabIndex = 18;
            this.btnAddSupp.Text = "اضافة ";
            this.btnAddSupp.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // picCoverSupp
            // 
            this.picCoverSupp.EditValue = ((object)(resources.GetObject("picCoverSupp.EditValue")));
            this.picCoverSupp.Location = new System.Drawing.Point(36, 276);
            this.picCoverSupp.Name = "picCoverSupp";
            this.picCoverSupp.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picCoverSupp.Properties.Appearance.Options.UseBackColor = true;
            this.picCoverSupp.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picCoverSupp.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picCoverSupp.Size = new System.Drawing.Size(207, 163);
            this.picCoverSupp.TabIndex = 17;
            // 
            // editNameSup
            // 
            this.editNameSup.Font = new System.Drawing.Font("Tahoma", 20F);
            this.editNameSup.Location = new System.Drawing.Point(9, 56);
            this.editNameSup.Name = "editNameSup";
            this.editNameSup.Size = new System.Drawing.Size(261, 40);
            this.editNameSup.TabIndex = 16;
            // 
            // lbTitlePage
            // 
            this.lbTitlePage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTitlePage.AutoSize = true;
            this.lbTitlePage.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTitlePage.Location = new System.Drawing.Point(301, 62);
            this.lbTitlePage.Name = "lbTitlePage";
            this.lbTitlePage.Size = new System.Drawing.Size(126, 29);
            this.lbTitlePage.TabIndex = 15;
            this.lbTitlePage.Text = "اسم المورد";
            this.lbTitlePage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmSupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 514);
            this.Controls.Add(this.pnAddCat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSupAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.pnAddCat.ResumeLayout(false);
            this.pnAddCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCoverSupp.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTitlePage;
        public System.Windows.Forms.Panel pnAddCat;
        public DevExpress.XtraEditors.SimpleButton btnAddSupp;
        public DevExpress.XtraEditors.PictureEdit picCoverSupp;
        public System.Windows.Forms.TextBox editNameSup;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox edtEmailSupp;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox editPhoneSupp;
        private System.Windows.Forms.Label label1;
    }
}