
namespace SMP.PL
{
    partial class FrmSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSell));
            this.pnSell = new System.Windows.Forms.Panel();
            this.gridControlSell = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSell_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Cus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Qte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Tprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSell_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.pnSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSell
            // 
            this.pnSell.Controls.Add(this.gridControlSell);
            this.pnSell.Controls.Add(this.panel1);
            this.pnSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSell.Location = new System.Drawing.Point(0, 0);
            this.pnSell.Name = "pnSell";
            this.pnSell.Size = new System.Drawing.Size(1030, 670);
            this.pnSell.TabIndex = 4;
            // 
            // gridControlSell
            // 
            this.gridControlSell.DataSource = typeof(SMP.TB_Sell);
            this.gridControlSell.Location = new System.Drawing.Point(3, 3);
            this.gridControlSell.MainView = this.gridView1;
            this.gridControlSell.Name = "gridControlSell";
            this.gridControlSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlSell.Size = new System.Drawing.Size(1024, 591);
            this.gridControlSell.TabIndex = 7;
            this.gridControlSell.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colSell_Name,
            this.colSell_Cus,
            this.colSell_Price,
            this.colSell_Qte,
            this.colSell_Tprice,
            this.colSell_Date});
            this.gridView1.GridControl = this.gridControlSell;
            this.gridView1.Name = "gridView1";
            // 
            // colSell_Name
            // 
            this.colSell_Name.Caption = "البيان";
            this.colSell_Name.FieldName = "Sell_Name";
            this.colSell_Name.Name = "colSell_Name";
            this.colSell_Name.Visible = true;
            this.colSell_Name.VisibleIndex = 0;
            // 
            // colSell_Cus
            // 
            this.colSell_Cus.Caption = "الزبون";
            this.colSell_Cus.FieldName = "Sell_Cus";
            this.colSell_Cus.Name = "colSell_Cus";
            this.colSell_Cus.Visible = true;
            this.colSell_Cus.VisibleIndex = 1;
            // 
            // colSell_Price
            // 
            this.colSell_Price.Caption = "المبلغ";
            this.colSell_Price.FieldName = "Sell_Price";
            this.colSell_Price.Name = "colSell_Price";
            this.colSell_Price.Visible = true;
            this.colSell_Price.VisibleIndex = 2;
            // 
            // colSell_Qte
            // 
            this.colSell_Qte.Caption = "كمية";
            this.colSell_Qte.FieldName = "Sell_Qte";
            this.colSell_Qte.Name = "colSell_Qte";
            this.colSell_Qte.Visible = true;
            this.colSell_Qte.VisibleIndex = 3;
            // 
            // colSell_Tprice
            // 
            this.colSell_Tprice.Caption = "المجموع";
            this.colSell_Tprice.FieldName = "Sell_Tprice";
            this.colSell_Tprice.Name = "colSell_Tprice";
            this.colSell_Tprice.Visible = true;
            this.colSell_Tprice.VisibleIndex = 4;
            // 
            // colSell_Date
            // 
            this.colSell_Date.Caption = "التاريخ";
            this.colSell_Date.FieldName = "Sell_Date";
            this.colSell_Date.Name = "colSell_Date";
            this.colSell_Date.Visible = true;
            this.colSell_Date.VisibleIndex = 5;
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
            this.btnEdit.Enabled = false;
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
            // FrmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 670);
            this.Controls.Add(this.pnSell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSell";
            this.Text = "FrmCat";
            this.pnSell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnSell;
        public DevExpress.XtraGrid.GridControl gridControlSell;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox editSearch;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Cus;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Price;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Qte;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Tprice;
        private DevExpress.XtraGrid.Columns.GridColumn colSell_Date;
    }
}