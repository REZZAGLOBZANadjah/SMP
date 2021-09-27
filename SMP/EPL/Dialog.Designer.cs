
namespace SMP.EPL
{
    partial class Dialog
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnDialog = new System.Windows.Forms.Panel();
            this.txtCaption = new System.Windows.Forms.Label();
            this.pnDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnDialog
            // 
            this.pnDialog.Controls.Add(this.txtCaption);
            this.pnDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDialog.Location = new System.Drawing.Point(0, 0);
            this.pnDialog.Name = "pnDialog";
            this.pnDialog.Size = new System.Drawing.Size(469, 65);
            this.pnDialog.TabIndex = 0;
            // 
            // txtCaption
            // 
            this.txtCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCaption.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCaption.Location = new System.Drawing.Point(0, 0);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(469, 65);
            this.txtCaption.TabIndex = 10;
            this.txtCaption.Text = "الرسالة";
            this.txtCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 65);
            this.Controls.Add(this.pnDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dialog";
            this.ShowInTaskbar = false;
            this.Text = "Dialog";
            this.pnDialog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnDialog;
        public System.Windows.Forms.Label txtCaption;
    }
}