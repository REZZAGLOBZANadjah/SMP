
namespace SMP.EPL
{
    partial class Toast
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
            this.pnToast = new System.Windows.Forms.Panel();
            this.txtCaption = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picToast = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnToast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picToast)).BeginInit();
            this.SuspendLayout();
            // 
            // pnToast
            // 
            this.pnToast.Controls.Add(this.txtCaption);
            this.pnToast.Controls.Add(this.panel1);
            this.pnToast.Controls.Add(this.picToast);
            this.pnToast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnToast.Location = new System.Drawing.Point(0, 0);
            this.pnToast.Name = "pnToast";
            this.pnToast.Size = new System.Drawing.Size(500, 100);
            this.pnToast.TabIndex = 0;
            // 
            // txtCaption
            // 
            this.txtCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCaption.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCaption.Location = new System.Drawing.Point(47, 0);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(416, 100);
            this.txtCaption.TabIndex = 11;
            this.txtCaption.Text = "الرسالة";
            this.txtCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(463, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 100);
            this.panel1.TabIndex = 10;
            // 
            // picToast
            // 
            this.picToast.Dock = System.Windows.Forms.DockStyle.Left;
            this.picToast.Image = global::SMP.Properties.Resources.about_32x32;
            this.picToast.Location = new System.Drawing.Point(0, 0);
            this.picToast.Name = "picToast";
            this.picToast.Size = new System.Drawing.Size(47, 100);
            this.picToast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picToast.TabIndex = 12;
            this.picToast.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Toast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 100);
            this.Controls.Add(this.pnToast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Toast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Toast";
            this.TopMost = true;
            this.pnToast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picToast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnToast;
        public System.Windows.Forms.Label txtCaption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picToast;
        private System.Windows.Forms.Timer timer1;
    }
}