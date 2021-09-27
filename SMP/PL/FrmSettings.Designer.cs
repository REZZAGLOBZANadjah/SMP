
namespace SMP.PL
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.btnSettings = new DevExpress.XtraEditors.SimpleButton();
            this.editSV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnSettings = new System.Windows.Forms.Panel();
            this.pnSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSettings.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSettings.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.Appearance.Options.UseFont = true;
            this.btnSettings.Appearance.Options.UseForeColor = true;
            this.btnSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.ImageOptions.Image")));
            this.btnSettings.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(109, 158);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSettings.Size = new System.Drawing.Size(235, 47);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "حفظ";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // editSV
            // 
            this.editSV.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editSV.Location = new System.Drawing.Point(26, 64);
            this.editSV.Name = "editSV";
            this.editSV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editSV.Size = new System.Drawing.Size(353, 27);
            this.editSV.TabIndex = 44;
            this.editSV.Text = "NAJAH";
            this.editSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(466, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 27);
            this.label10.TabIndex = 43;
            this.label10.Text = "السيرفر";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnSettings
            // 
            this.pnSettings.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnSettings.Controls.Add(this.editSV);
            this.pnSettings.Controls.Add(this.btnSettings);
            this.pnSettings.Controls.Add(this.label10);
            this.pnSettings.Location = new System.Drawing.Point(0, 0);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(559, 247);
            this.pnSettings.TabIndex = 45;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 247);
            this.Controls.Add(this.pnSettings);
            this.Name = "FrmSettings";
            this.Text = "FrmSettings";
            this.pnSettings.ResumeLayout(false);
            this.pnSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSettings;
        public System.Windows.Forms.TextBox editSV;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Panel pnSettings;
    }
}