
namespace SMP.PL
{
    partial class FrmSellAdd
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
            this.pnAddSell = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.editQte = new DevExpress.XtraEditors.SpinEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.editSellPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.editTQte = new System.Windows.Forms.Label();
            this.editTSell = new System.Windows.Forms.Label();
            this.editTBuy = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editCus = new System.Windows.Forms.ComboBox();
            this.editSellName = new System.Windows.Forms.ComboBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitlePage = new System.Windows.Forms.Label();
            this.btnAddSell = new DevExpress.XtraEditors.SimpleButton();
            this.pnAddSell.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editQte.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAddSell
            // 
            this.pnAddSell.Controls.Add(this.label3);
            this.pnAddSell.Controls.Add(this.groupBox3);
            this.pnAddSell.Controls.Add(this.groupBox2);
            this.pnAddSell.Controls.Add(this.groupBox1);
            this.pnAddSell.Controls.Add(this.btnAddSell);
            this.pnAddSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAddSell.Location = new System.Drawing.Point(0, 0);
            this.pnAddSell.Name = "pnAddSell";
            this.pnAddSell.Size = new System.Drawing.Size(972, 548);
            this.pnAddSell.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(469, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "الكمية غير كافية";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.editQte);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.editSellPrice);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.groupBox3.Location = new System.Drawing.Point(460, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(501, 223);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "البيـــــــــــــــــــــــــــــــــــــــــــــــــع ";
            // 
            // editQte
            // 
            this.editQte.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.editQte.Location = new System.Drawing.Point(22, 150);
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
            this.label8.Location = new System.Drawing.Point(421, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 27);
            this.label8.TabIndex = 45;
            this.label8.Text = "الكمية";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // editSellPrice
            // 
            this.editSellPrice.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editSellPrice.Location = new System.Drawing.Point(22, 76);
            this.editSellPrice.Name = "editSellPrice";
            this.editSellPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editSellPrice.Size = new System.Drawing.Size(261, 27);
            this.editSellPrice.TabIndex = 42;
            this.editSellPrice.Text = "0";
            this.editSellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editSellPrice.TextChanged += new System.EventHandler(this.ediBuy_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(393, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 27);
            this.label10.TabIndex = 41;
            this.label10.Text = "سعر البيع";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.editTQte);
            this.groupBox2.Controls.Add(this.editTSell);
            this.groupBox2.Controls.Add(this.editTBuy);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(436, 480);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تفاصيل المادة";
            // 
            // editTQte
            // 
            this.editTQte.AutoSize = true;
            this.editTQte.BackColor = System.Drawing.Color.Transparent;
            this.editTQte.Font = new System.Drawing.Font("Tahoma", 22F);
            this.editTQte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editTQte.Location = new System.Drawing.Point(203, 312);
            this.editTQte.Name = "editTQte";
            this.editTQte.Size = new System.Drawing.Size(31, 36);
            this.editTQte.TabIndex = 46;
            this.editTQte.Text = "0";
            // 
            // editTSell
            // 
            this.editTSell.AutoSize = true;
            this.editTSell.BackColor = System.Drawing.Color.Transparent;
            this.editTSell.Font = new System.Drawing.Font("Tahoma", 22F);
            this.editTSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editTSell.Location = new System.Drawing.Point(203, 235);
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
            this.editTBuy.Location = new System.Drawing.Point(203, 149);
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
            this.label13.Location = new System.Drawing.Point(175, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 33);
            this.label13.TabIndex = 43;
            this.label13.Text = "الكمية";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(153, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 33);
            this.label12.TabIndex = 42;
            this.label12.Text = "سعر البيع";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(140, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 33);
            this.label11.TabIndex = 41;
            this.label11.Text = "سعر الشراء";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.editCus);
            this.groupBox1.Controls.Add(this.editSellName);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbTitlePage);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 18F);
            this.groupBox1.Location = new System.Drawing.Point(459, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(501, 214);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات أساسية";
            // 
            // editCus
            // 
            this.editCus.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editCus.FormattingEnabled = true;
            this.editCus.Location = new System.Drawing.Point(14, 95);
            this.editCus.Name = "editCus";
            this.editCus.Size = new System.Drawing.Size(261, 27);
            this.editCus.TabIndex = 48;
            // 
            // editSellName
            // 
            this.editSellName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.editSellName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.editSellName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.editSellName.FormattingEnabled = true;
            this.editSellName.Location = new System.Drawing.Point(14, 47);
            this.editSellName.Name = "editSellName";
            this.editSellName.Size = new System.Drawing.Size(261, 27);
            this.editSellName.TabIndex = 47;
            this.editSellName.SelectedIndexChanged += new System.EventHandler(this.editSellName_SelectedIndexChanged);
            this.editSellName.SelectedValueChanged += new System.EventHandler(this.editSellName_SelectedIndexChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.linkLabel2.Location = new System.Drawing.Point(281, 99);
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
            this.linkLabel1.Location = new System.Drawing.Point(281, 51);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 23);
            this.linkLabel1.TabIndex = 45;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اضافة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(424, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 39;
            this.label1.Text = "العميل";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbTitlePage
            // 
            this.lbTitlePage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTitlePage.AutoSize = true;
            this.lbTitlePage.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbTitlePage.ForeColor = System.Drawing.Color.Gray;
            this.lbTitlePage.Location = new System.Drawing.Point(383, 49);
            this.lbTitlePage.Name = "lbTitlePage";
            this.lbTitlePage.Size = new System.Drawing.Size(112, 27);
            this.lbTitlePage.TabIndex = 37;
            this.lbTitlePage.Text = "اسم المادة";
            this.lbTitlePage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAddSell
            // 
            this.btnAddSell.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddSell.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSell.Appearance.Options.UseFont = true;
            this.btnAddSell.Location = new System.Drawing.Point(842, 490);
            this.btnAddSell.Name = "btnAddSell";
            this.btnAddSell.Size = new System.Drawing.Size(121, 44);
            this.btnAddSell.TabIndex = 18;
            this.btnAddSell.Text = "اضافة ";
            this.btnAddSell.Click += new System.EventHandler(this.btnAddSell_Click);
            // 
            // FrmSellAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 548);
            this.Controls.Add(this.pnAddSell);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSellAdd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmSellAdd_Load);
            this.pnAddSell.ResumeLayout(false);
            this.pnAddSell.PerformLayout();
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
        public System.Windows.Forms.Panel pnAddSell;
        public DevExpress.XtraEditors.SimpleButton btnAddSell;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox editSellPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitlePage;
        public DevExpress.XtraEditors.SpinEdit editQte;
        public System.Windows.Forms.Label editTQte;
        public System.Windows.Forms.Label editTSell;
        public System.Windows.Forms.Label editTBuy;
        public System.Windows.Forms.ComboBox editCus;
        public System.Windows.Forms.ComboBox editSellName;
        private System.Windows.Forms.Label label3;
    }
}