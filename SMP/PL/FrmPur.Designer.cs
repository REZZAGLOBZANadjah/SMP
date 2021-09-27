
namespace SMP.PL
{
    partial class FrmPur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPur));
            this.pnPur = new System.Windows.Forms.Panel();
            this.gridControlPur = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPur_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Supp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Det = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Buy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Sell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_Qt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_TBuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_TSell = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPur_TRev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.pnPur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPur
            // 
            this.pnPur.Controls.Add(this.gridControlPur);
            this.pnPur.Controls.Add(this.panel1);
            this.pnPur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPur.Location = new System.Drawing.Point(0, 0);
            this.pnPur.Name = "pnPur";
            this.pnPur.Size = new System.Drawing.Size(1030, 670);
            this.pnPur.TabIndex = 4;
            // 
            // gridControlPur
            // 
            this.gridControlPur.DataSource = typeof(SMP.TB_Pur);
            this.gridControlPur.Location = new System.Drawing.Point(3, 3);
            this.gridControlPur.MainView = this.gridView1;
            this.gridControlPur.Name = "gridControlPur";
            this.gridControlPur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlPur.Size = new System.Drawing.Size(1024, 591);
            this.gridControlPur.TabIndex = 7;
            this.gridControlPur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPur_Name,
            this.colPur_Type,
            this.colPur_Cat,
            this.colPur_Supp,
            this.colPur_Det,
            this.colPur_Buy,
            this.colPur_Sell,
            this.colPur_Qt,
            this.colPur_TBuy,
            this.colPur_TSell,
            this.colPur_TRev});
            this.gridView1.GridControl = this.gridControlPur;
            this.gridView1.Name = "gridView1";
            // 
            // colPur_Name
            // 
            this.colPur_Name.Caption = "اسم المادة";
            this.colPur_Name.FieldName = "Pur_Name";
            this.colPur_Name.Name = "colPur_Name";
            this.colPur_Name.Visible = true;
            this.colPur_Name.VisibleIndex = 0;
            this.colPur_Name.Width = 114;
            // 
            // colPur_Type
            // 
            this.colPur_Type.Caption = "النوع";
            this.colPur_Type.FieldName = "Pur_Type";
            this.colPur_Type.Name = "colPur_Type";
            this.colPur_Type.Visible = true;
            this.colPur_Type.VisibleIndex = 1;
            this.colPur_Type.Width = 87;
            // 
            // colPur_Cat
            // 
            this.colPur_Cat.Caption = "الصنف";
            this.colPur_Cat.FieldName = "Pur_Cat";
            this.colPur_Cat.Name = "colPur_Cat";
            this.colPur_Cat.Visible = true;
            this.colPur_Cat.VisibleIndex = 2;
            this.colPur_Cat.Width = 87;
            // 
            // colPur_Supp
            // 
            this.colPur_Supp.Caption = "المورد";
            this.colPur_Supp.FieldName = "Pur_Supp";
            this.colPur_Supp.Name = "colPur_Supp";
            this.colPur_Supp.Visible = true;
            this.colPur_Supp.VisibleIndex = 3;
            this.colPur_Supp.Width = 87;
            // 
            // colPur_Det
            // 
            this.colPur_Det.Caption = "التفاصيل";
            this.colPur_Det.FieldName = "Pur_Det";
            this.colPur_Det.Name = "colPur_Det";
            this.colPur_Det.Visible = true;
            this.colPur_Det.VisibleIndex = 4;
            this.colPur_Det.Width = 101;
            // 
            // colPur_Buy
            // 
            this.colPur_Buy.Caption = "سعر الشراء";
            this.colPur_Buy.FieldName = "Pur_Buy";
            this.colPur_Buy.Name = "colPur_Buy";
            this.colPur_Buy.Visible = true;
            this.colPur_Buy.VisibleIndex = 5;
            this.colPur_Buy.Width = 84;
            // 
            // colPur_Sell
            // 
            this.colPur_Sell.Caption = "سعر البيع";
            this.colPur_Sell.FieldName = "Pur_Sell";
            this.colPur_Sell.Name = "colPur_Sell";
            this.colPur_Sell.Visible = true;
            this.colPur_Sell.VisibleIndex = 6;
            this.colPur_Sell.Width = 84;
            // 
            // colPur_Qt
            // 
            this.colPur_Qt.Caption = "الكمية";
            this.colPur_Qt.FieldName = "Pur_Qt";
            this.colPur_Qt.Name = "colPur_Qt";
            this.colPur_Qt.Visible = true;
            this.colPur_Qt.VisibleIndex = 7;
            this.colPur_Qt.Width = 84;
            // 
            // colPur_TBuy
            // 
            this.colPur_TBuy.Caption = "سعر الشراء الكلي";
            this.colPur_TBuy.FieldName = "Pur_TBuy";
            this.colPur_TBuy.Name = "colPur_TBuy";
            this.colPur_TBuy.Visible = true;
            this.colPur_TBuy.VisibleIndex = 8;
            this.colPur_TBuy.Width = 84;
            // 
            // colPur_TSell
            // 
            this.colPur_TSell.Caption = "سعر البيع الكلي";
            this.colPur_TSell.FieldName = "Pur_TSell";
            this.colPur_TSell.Name = "colPur_TSell";
            this.colPur_TSell.Visible = true;
            this.colPur_TSell.VisibleIndex = 9;
            this.colPur_TSell.Width = 84;
            // 
            // colPur_TRev
            // 
            this.colPur_TRev.Caption = "الارباح";
            this.colPur_TRev.FieldName = "Pur_TRev";
            this.colPur_TRev.Name = "colPur_TRev";
            this.colPur_TRev.Visible = true;
            this.colPur_TRev.VisibleIndex = 10;
            this.colPur_TRev.Width = 103;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.editSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 589);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 81);
            this.panel1.TabIndex = 6;
            // 
            // editSearch
            // 
            this.editSearch.Font = new System.Drawing.Font("Tahoma", 20F);
            this.editSearch.Location = new System.Drawing.Point(657, 23);
            this.editSearch.Name = "editSearch";
            this.editSearch.Size = new System.Drawing.Size(226, 40);
            this.editSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(892, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(43, 40);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDel.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Appearance.Options.UseFont = true;
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Location = new System.Drawing.Point(337, 23);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(104, 34);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "حذف";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(459, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 34);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "تحديث";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(201, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 34);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(67, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 34);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "اضافة ";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmPur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 670);
            this.Controls.Add(this.pnPur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPur";
            this.Text = "FrmCat";
            this.pnPur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnPur;
        public DevExpress.XtraGrid.GridControl gridControlPur;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Type;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Cat;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Supp;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Det;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Buy;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Sell;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_Qt;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_TBuy;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_TSell;
        private DevExpress.XtraGrid.Columns.GridColumn colPur_TRev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox editSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}