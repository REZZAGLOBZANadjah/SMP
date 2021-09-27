
namespace SMP.PL
{
    partial class FrmCatAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatAdd));
            this.pnAddCat = new System.Windows.Forms.Panel();
            this.btnAddCat = new DevExpress.XtraEditors.SimpleButton();
            this.picCover = new DevExpress.XtraEditors.PictureEdit();
            this.editNameCat = new System.Windows.Forms.TextBox();
            this.lbTitlePage = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.pnAddCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAddCat
            // 
            this.pnAddCat.Controls.Add(this.btnAddCat);
            this.pnAddCat.Controls.Add(this.picCover);
            this.pnAddCat.Controls.Add(this.editNameCat);
            this.pnAddCat.Controls.Add(this.lbTitlePage);
            this.pnAddCat.Controls.Add(this.btnClose);
            this.pnAddCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAddCat.Location = new System.Drawing.Point(0, 0);
            this.pnAddCat.Name = "pnAddCat";
            this.pnAddCat.Size = new System.Drawing.Size(475, 380);
            this.pnAddCat.TabIndex = 0;
            // 
            // btnAddCat
            // 
            this.btnAddCat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddCat.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.Appearance.Options.UseFont = true;
            this.btnAddCat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCat.ImageOptions.Image")));
            this.btnAddCat.Location = new System.Drawing.Point(320, 308);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(121, 44);
            this.btnAddCat.TabIndex = 18;
            this.btnAddCat.Text = "اضافة ";
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // picCover
            // 
            this.picCover.EditValue = ((object)(resources.GetObject("picCover.EditValue")));
            this.picCover.Location = new System.Drawing.Point(96, 142);
            this.picCover.Name = "picCover";
            this.picCover.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picCover.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picCover.Size = new System.Drawing.Size(207, 152);
            this.picCover.TabIndex = 17;
            // 
            // editNameCat
            // 
            this.editNameCat.Font = new System.Drawing.Font("Tahoma", 20F);
            this.editNameCat.Location = new System.Drawing.Point(96, 86);
            this.editNameCat.Name = "editNameCat";
            this.editNameCat.Size = new System.Drawing.Size(207, 40);
            this.editNameCat.TabIndex = 16;
            // 
            // lbTitlePage
            // 
            this.lbTitlePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitlePage.AutoSize = true;
            this.lbTitlePage.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTitlePage.Location = new System.Drawing.Point(131, 33);
            this.lbTitlePage.Name = "lbTitlePage";
            this.lbTitlePage.Size = new System.Drawing.Size(128, 29);
            this.lbTitlePage.TabIndex = 15;
            this.lbTitlePage.Text = "اسم الصنف";
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClose.Location = new System.Drawing.Point(424, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 14;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmCatAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 380);
            this.Controls.Add(this.pnAddCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCatAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.pnAddCat.ResumeLayout(false);
            this.pnAddCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTitlePage;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        public System.Windows.Forms.Panel pnAddCat;
        public DevExpress.XtraEditors.SimpleButton btnAddCat;
        public DevExpress.XtraEditors.PictureEdit picCover;
        public System.Windows.Forms.TextBox editNameCat;
    }
}