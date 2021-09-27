using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP.PL
{
    public partial class FrmHome : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        public FrmHome()
        {
            InitializeComponent();
            //count categories
            List<tb_cat> listCat = db.tb_cat.ToList();
            lbCat.Text = listCat.Count.ToString();
            // count customer
            List<TB_Cus> listCus = db.TB_Cus.ToList();
            lbCus.Text = listCus.Count.ToString();

            // count Pur
            List<TB_Pur> listPur = db.TB_Pur.ToList();
            lbPur.Text = listPur.Count.ToString();
            // count Sell
            List<TB_Sell> listSell = db.TB_Sell.ToList();
            lbSell.Text = listSell.Count.ToString();
            // count SUPP
            List<TB_SUPP> listSUPP = db.TB_SUPP.ToList();
            lbSupp.Text = listSUPP.Count.ToString();
            // count Reports

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            PL.FrmPurAdd frmAddPur = new PL.FrmPurAdd();
            frmAddPur.id = 0;
            frmAddPur.btnAddPur.Text = "اضافة";
            frmAddPur.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            PL.FrmCusAdd frmAddCus = new PL.FrmCusAdd();
            frmAddCus.id = 0;
            frmAddCus.btnAddCus.Text = "اضافة";
            frmAddCus.Show();
            //updateData();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            PL.FrmPurAdd frmAddPur = new PL.FrmPurAdd();
            frmAddPur.id = 0;
            frmAddPur.btnAddPur.Text = "اضافة";
            frmAddPur.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PL.FrmSuppAdd frmAddSupp = new PL.FrmSuppAdd();
            frmAddSupp.id = 0;
            frmAddSupp.btnAddSupp.Text = "اضافة";
            frmAddSupp.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PL.FrmCatAdd frmAddCat = new PL.FrmCatAdd();
            frmAddCat.id = 0;
            frmAddCat.btnAddCat.Text = "اضافة";
            frmAddCat.Show();
            //updateData();
        }
    }
}
