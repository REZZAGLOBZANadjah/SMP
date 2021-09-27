
namespace SMP.PL
{
    partial class FrmPurAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPurAdd));
            this.pnAddCat = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.editSell = new System.Windows.Forms.TextBox();
            this.editQte = new DevExpress.XtraEditors.SpinEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.editBuy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.editTRev = new System.Windows.Forms.Label();
            this.editTSell = new System.Windows.Forms.Label();
            this.editTBuy = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editSup = new System.Windows.Forms.ComboBox();
            this.editCat = new System.Windows.Forms.ComboBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.editPurDet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editTypePur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editNamePur = new System.Windows.Forms.TextBox();
            this.lbTitlePage = new System.Windows.Forms.Label();
            this.btnAddPur = new DevExpress.XtraEditors.SimpleButton();
            this.pnAddCat.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editQte.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAddCat
            // 
            this.pnAddCat.Controls.Add(this.groupBox3);
            this.pnAddCat.Controls.Add(this.groupBox2);
            this.pnAddCat.Controls.Add(this.groupBox1);
            this.pnAddCat.Controls.Add(this.btnAddPur);
            this.pnAddCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAddCat.Location = new System.Drawing.Point(0, 0);
            this.pnAddCat.Name = "pnAddCat";
            this.pnAddCat.Size = new System.Drawing.Size(972, 548);
            this.pnAddCat.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.editSell);
            this.groupBox3.Controls.Add(this.editQte);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.editBuy);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.groupBox3.Location = new System.Drawing.Point(460, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(501, 162);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "البيع و الشراء";
            // 
            // editSell
            // 
            this.editSell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editSell.Location = new System.Drawing.Point(13, 78);
            this.editSell.Name = "editSell";
            this.editSell.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editSell.Size = new System.Drawing.Size(261, 27);
            this.editSell.TabIndex = 49;
            this.editSell.Text = "0";
            this.editSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editQte
            // 
            this.editQte.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.editQte.Location = new System.Drawing.Point(12, 122);
            this.editQte.Name = "editQte";
            this.editQte.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editQte.Properties.Appearance.Options.UseFont = true;
            this.editQte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.editQte.Size = new System.Drawing.Size(262, 26);
            this.editQte.TabIndex = 48;
            this.editQte.EditValueChanged += new System.EventHandler(this.editQte_EditValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(414, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 27);
            this.label8.TabIndex = 45;
            this.label8.Text = "الكمية";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(333, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 27);
            this.label9.TabIndex = 43;
            this.label9.Text = "سعر البيع(مفرد)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // editBuy
            // 
            this.editBuy.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editBuy.Location = new System.Drawing.Point(12, 37);
            this.editBuy.Name = "editBuy";
            this.editBuy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editBuy.Size = new System.Drawing.Size(261, 27);
            this.editBuy.TabIndex = 42;
            this.editBuy.Text = "0";
            this.editBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editBuy.TextChanged += new System.EventHandler(this.ediBuy_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(317, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 27);
            this.label10.TabIndex = 41;
            this.label10.Text = "سعر الشراء(مفرد)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.editTRev);
            this.groupBox2.Controls.Add(this.editTSell);
            this.groupBox2.Controls.Add(this.editTBuy);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(436, 289);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // editTRev
            // 
            this.editTRev.AutoSize = true;
            this.editTRev.BackColor = System.Drawing.Color.Transparent;
            this.editTRev.Font = new System.Drawing.Font("Tahoma", 22F);
            this.editTRev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editTRev.Location = new System.Drawing.Point(203, 227);
            this.editTRev.Name = "editTRev";
            this.editTRev.Size = new System.Drawing.Size(31, 36);
            this.editTRev.TabIndex = 46;
            this.editTRev.Text = "0";
            // 
            // editTSell
            // 
            this.editTSell.AutoSize = true;
            this.editTSell.BackColor = System.Drawing.Color.Transparent;
            this.editTSell.Font = new System.Drawing.Font("Tahoma", 22F);
            this.editTSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editTSell.Location = new System.Drawing.Point(203, 150);
            this.editTSell.Name = "editTSell";
            this.editTSell.Size = new System.Drawing.Size(31, 36);
            this.editTSell.TabIndex = 45;
            this.editTSell.Text = "0";
            // 
            // editTBuy
            // 
            this.editTBuy.AutoSize = true;
            this.editTBuy.BackColor = System.Drawing.Color.Transparent;
            this.editTBuy.Font = new System.Drawing.Font("Tahoma", 22F);
            this.editTBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editTBuy.Location = new System.Drawing.Point(203, 64);
            this.editTBuy.Name = "editTBuy";
            this.editTBuy.Size = new System.Drawing.Size(31, 36);
            this.editTBuy.TabIndex = 44;
            this.editTBuy.Text = "0";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(143, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 33);
            this.label13.TabIndex = 43;
            this.label13.Text = "الأرباح الكلية";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(84, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(268, 33);
            this.label12.TabIndex = 42;
            this.label12.Text = "المبيعات(السعر الكلي)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(71, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(294, 33);
            this.label11.TabIndex = 41;
            this.label11.Text = "المشتريات(السعر الكلي)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editSup);
            this.groupBox1.Controls.Add(this.editCat);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.editPurDet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.editTypePur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.editNamePur);
            this.groupBox1.Controls.Add(this.lbTitlePage);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.groupBox1.Location = new System.Drawing.Point(459, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(501, 295);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات أساسية";
            // 
            // editSup
            // 
            this.editSup.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editSup.FormattingEnabled = true;
            this.editSup.Location = new System.Drawing.Point(11, 151);
            this.editSup.Name = "editSup";
            this.editSup.Size = new System.Drawing.Size(261, 27);
            this.editSup.TabIndex = 48;
            // 
            // editCat
            // 
            this.editCat.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editCat.FormattingEnabled = true;
            this.editCat.Location = new System.Drawing.Point(10, 116);
            this.editCat.Name = "editCat";
            this.editCat.Size = new System.Drawing.Size(261, 27);
            this.editCat.TabIndex = 47;
            this.editCat.SelectedIndexChanged += new System.EventHandler(this.editCat_SelectedIndexChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.linkLabel2.Location = new System.Drawing.Point(273, 151);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(54, 23);
            this.linkLabel2.TabIndex = 46;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "اضافة";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.linkLabel1.Location = new System.Drawing.Point(273, 115);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 23);
            this.linkLabel1.TabIndex = 45;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اضافة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // editPurDet
            // 
            this.editPurDet.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editPurDet.Location = new System.Drawing.Point(10, 184);
            this.editPurDet.Multiline = true;
            this.editPurDet.Name = "editPurDet";
            this.editPurDet.Size = new System.Drawing.Size(339, 88);
            this.editPurDet.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(421, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 27);
            this.label7.TabIndex = 43;
            this.label7.Text = "تفاصيل";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(431, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 27);
            this.label6.TabIndex = 42;
            this.label6.Text = "المورد";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(443, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 27);
            this.label3.TabIndex = 41;
            this.label3.Text = "النوع";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // editTypePur
            // 
            this.editTypePur.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editTypePur.Location = new System.Drawing.Point(10, 73);
            this.editTypePur.Name = "editTypePur";
            this.editTypePur.Size = new System.Drawing.Size(261, 27);
            this.editTypePur.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(429, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 39;
            this.label1.Text = "الصنف";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // editNamePur
            // 
            this.editNamePur.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editNamePur.Location = new System.Drawing.Point(10, 35);
            this.editNamePur.Name = "editNamePur";
            this.editNamePur.Size = new System.Drawing.Size(261, 27);
            this.editNamePur.TabIndex = 38;
            // 
            // lbTitlePage
            // 
            this.lbTitlePage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTitlePage.AutoSize = true;
            this.lbTitlePage.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbTitlePage.ForeColor = System.Drawing.Color.Gray;
            this.lbTitlePage.Location = new System.Drawing.Point(379, 45);
            this.lbTitlePage.Name = "lbTitlePage";
            this.lbTitlePage.Size = new System.Drawing.Size(112, 27);
            this.lbTitlePage.TabIndex = 37;
            this.lbTitlePage.Text = "اسم المادة";
            this.lbTitlePage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAddPur
            // 
            this.btnAddPur.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddPur.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPur.Appearance.Options.UseFont = true;
            this.btnAddPur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPur.ImageOptions.Image")));
            this.btnAddPur.Location = new System.Drawing.Point(842, 490);
            this.btnAddPur.Name = "btnAddPur";
            this.btnAddPur.Size = new System.Drawing.Size(121, 44);
            this.btnAddPur.TabIndex = 18;
            this.btnAddPur.Text = "اضافة ";
            this.btnAddPur.Click += new System.EventHandler(this.btnAddPur_Click);
            // 
            // FrmPurAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 548);
            this.Controls.Add(this.pnAddCat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPurAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmPurAddAction);
            this.pnAddCat.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editQte.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnAddCat;
        public DevExpress.XtraEditors.SimpleButton btnAddPur;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox editBuy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox editTypePur;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox editNamePur;
        private System.Windows.Forms.Label lbTitlePage;
        public System.Windows.Forms.TextBox editSell;
        public DevExpress.XtraEditors.SpinEdit editQte;
        public System.Windows.Forms.Label editTRev;
        public System.Windows.Forms.Label editTSell;
        public System.Windows.Forms.Label editTBuy;
        public System.Windows.Forms.ComboBox editSup;
        public System.Windows.Forms.ComboBox editCat;
        public System.Windows.Forms.TextBox editPurDet;
    }
}