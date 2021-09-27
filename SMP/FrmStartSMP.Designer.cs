
namespace SMP
{
    partial class FrmStartSMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStartSMP));
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.peImage = new DevExpress.XtraEditors.PictureEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCopyright = new DevExpress.XtraEditors.LabelControl();
            this.peLogo = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl
            // 
            this.progressBarControl.EditValue = 0;
            this.progressBarControl.Location = new System.Drawing.Point(0, 333);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.EndColor = System.Drawing.Color.Teal;
            this.progressBarControl.Properties.StartColor = System.Drawing.Color.Teal;
            this.progressBarControl.Size = new System.Drawing.Size(458, 10);
            this.progressBarControl.TabIndex = 5;
            // 
            // peImage
            // 
            this.peImage.Location = new System.Drawing.Point(3, 1);
            this.peImage.Name = "peImage";
            this.peImage.Properties.AllowFocused = false;
            this.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peImage.Properties.Appearance.Options.UseBackColor = true;
            this.peImage.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.LightCyan;
            this.peImage.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peImage.Properties.ShowMenu = false;
            this.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peImage.Size = new System.Drawing.Size(449, 154);
            this.peImage.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelCopyright
            // 
            this.labelCopyright.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelCopyright.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.labelCopyright.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelCopyright.Appearance.Options.UseBackColor = true;
            this.labelCopyright.Appearance.Options.UseFont = true;
            this.labelCopyright.Appearance.Options.UseForeColor = true;
            this.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelCopyright.LineColor = System.Drawing.Color.Transparent;
            this.labelCopyright.LineVisible = true;
            this.labelCopyright.Location = new System.Drawing.Point(377, 311);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(27, 16);
            this.labelCopyright.TabIndex = 15;
            this.labelCopyright.Text = "SMP";
            // 
            // peLogo
            // 
            this.peLogo.EditValue = ((object)(resources.GetObject("peLogo.EditValue")));
            this.peLogo.Location = new System.Drawing.Point(0, 1);
            this.peLogo.Name = "peLogo";
            this.peLogo.Properties.AllowFocused = false;
            this.peLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peLogo.Properties.Appearance.Options.UseBackColor = true;
            this.peLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peLogo.Properties.ShowMenu = false;
            this.peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peLogo.Size = new System.Drawing.Size(458, 334);
            this.peLogo.TabIndex = 14;
            // 
            // FrmStartSMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 347);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.peLogo);
            this.Controls.Add(this.peImage);
            this.Controls.Add(this.progressBarControl);
            this.Name = "FrmStartSMP";
            this.Text = "SMP";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.PictureEdit peImage;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.PictureEdit peLogo;
        private DevExpress.XtraEditors.LabelControl labelCopyright;
    }
}
