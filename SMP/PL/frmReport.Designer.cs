
namespace SMP.PL
{
    partial class FrmRep
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
            this.pnRep = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSellsRep = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.pnRep.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnRep
            // 
            this.pnRep.Controls.Add(this.flowLayoutPanel1);
            this.pnRep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRep.Location = new System.Drawing.Point(0, 0);
            this.pnRep.Name = "pnRep";
            this.pnRep.Size = new System.Drawing.Size(1030, 670);
            this.pnRep.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.simpleButton8);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton9);
            this.flowLayoutPanel1.Controls.Add(this.btnSellsRep);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton11);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1030, 670);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // simpleButton8
            // 
            this.simpleButton8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton8.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton8.Appearance.Options.UseFont = true;
            this.simpleButton8.Location = new System.Drawing.Point(40, 40);
            this.simpleButton8.Margin = new System.Windows.Forms.Padding(20);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(273, 196);
            this.simpleButton8.TabIndex = 14;
            this.simpleButton8.Text = "تقرير الارباح";
            // 
            // simpleButton9
            // 
            this.simpleButton9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton9.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.Location = new System.Drawing.Point(353, 40);
            this.simpleButton9.Margin = new System.Windows.Forms.Padding(20);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(269, 196);
            this.simpleButton9.TabIndex = 15;
            this.simpleButton9.Text = "تقرير العملاء";
            // 
            // btnSellsRep
            // 
            this.btnSellsRep.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSellsRep.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellsRep.Appearance.Options.UseFont = true;
            this.btnSellsRep.Location = new System.Drawing.Point(662, 40);
            this.btnSellsRep.Margin = new System.Windows.Forms.Padding(20);
            this.btnSellsRep.Name = "btnSellsRep";
            this.btnSellsRep.Size = new System.Drawing.Size(265, 196);
            this.btnSellsRep.TabIndex = 16;
            this.btnSellsRep.Text = "تقرير المبيعات";
            this.btnSellsRep.Click += new System.EventHandler(this.btnSellsRep_Click);
            // 
            // simpleButton11
            // 
            this.simpleButton11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton11.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton11.Appearance.Options.UseFont = true;
            this.simpleButton11.Location = new System.Drawing.Point(40, 276);
            this.simpleButton11.Margin = new System.Windows.Forms.Padding(20);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(273, 210);
            this.simpleButton11.TabIndex = 17;
            this.simpleButton11.Text = "تقرير المشتريات";
            // 
            // FrmRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 670);
            this.Controls.Add(this.pnRep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRep";
            this.Text = "FrmCat";
            this.pnRep.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnRep;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton btnSellsRep;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
    }
}