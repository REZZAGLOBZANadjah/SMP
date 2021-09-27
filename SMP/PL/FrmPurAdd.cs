using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMP.EPL;
 
namespace SMP.PL
{
    public partial class FrmPurAdd : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Pur tb_Pur = new TB_Pur();
        BL.Methods methods = new BL.Methods();
        public int id;
        double buy, sell, qte, tSell, tBuy, tRev;
        public FrmPurAdd()
        {
            InitializeComponent();
        }



        // add or edit supplier
        private void btnAddPur_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            //check if add or edit 
            if (editNamePur.Text == ""|| editTypePur.Text=="" || editCat.Text == "" || editSup.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txtCaption.Text = " حقل مطلوب ";
                dialog.Show();
                dialog.Close();
            }
            else
            {
                //check if add or edit
                if (id == 0)
                {
                    //Add
                    // add action if the user does not add image or warning msg
                    tb_Pur.Pur_Name = editNamePur.Text;
                    tb_Pur.Pur_Type = editTypePur.Text;
                    tb_Pur.Pur_Cat = editCat.Text;
                    tb_Pur.Pur_Supp = editSup.Text;
                    tb_Pur.Pur_Det = editPurDet.Text;

                    tb_Pur.Pur_Buy  = Convert.ToDouble(editBuy.Text);
                    tb_Pur.Pur_Sell = Convert.ToDouble(editSell.Text);
                    tb_Pur.Pur_Qt= Convert.ToDouble(editQte.Text);

                    tb_Pur.Pur_TBuy = Convert.ToDouble(editTBuy.Text);
                    tb_Pur.Pur_TSell = Convert.ToDouble(editTSell.Text);
                    tb_Pur.Pur_TRev = Convert.ToDouble(editTRev.Text);
                    db.TB_Pur.Add(tb_Pur);
                    db.SaveChanges();
                    toast.txtCaption.Text = "تم اجراء عملية شراء";
                    toast.Show();
                    this.Close();


                }
                else
                {
                    //edit
                    tb_Pur.Pur_Id = id;

                    tb_Pur.Pur_Name = editNamePur.Text;
                    tb_Pur.Pur_Type = editTypePur.Text;
                    tb_Pur.Pur_Cat = editCat.Text;
                    tb_Pur.Pur_Supp = editSup.Text;
                    tb_Pur.Pur_Det = editPurDet.Text;
                    tb_Pur.Pur_Buy = Convert.ToDouble(editBuy.Text);
                    tb_Pur.Pur_Sell = Convert.ToDouble(editSell.Text);
                    tb_Pur.Pur_Qt = Convert.ToDouble(editQte.Text);
                    //proCall();
                    tb_Pur.Pur_TBuy = Convert.ToDouble(editTBuy.Text);
                    tb_Pur.Pur_TSell = Convert.ToDouble(editTSell.Text);
                    tb_Pur.Pur_TRev = Convert.ToDouble(editTRev.Text);

                   // tb_Pur.Pur_Id = id;

                    db.Entry(tb_Pur).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    toast.txtCaption.Text = "تم تعديل عملية شراء ";
                    toast.Show();
                    this.Close();
                }

            }

        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmAddCat.Close();
        }

        private void ediBuy_TextChanged(object sender, EventArgs e)
        {
            proCall();
        }

        private void editSell_TextChanged(object sender, EventArgs e)
        {
            proCall();
        }

        private void editCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editQte_EditValueChanged(object sender, EventArgs e)
        {
            proCall();
        }

        private void FrmPurAddAction(object sender, EventArgs e)
        {

            editCat.DataSource = db.tb_cat.Select(x => x.cat_name).ToList();
            editSup.DataSource = db.TB_SUPP.Select(x => x.Supp_Name).ToList();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FrmCatAdd frmAddCat = new PL.FrmCatAdd();
            frmAddCat.id = 0;
            frmAddCat.btnAddCat.Text = "اضافة";
            frmAddCat.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PL.FrmSuppAdd frmAddSupp = new PL.FrmSuppAdd();
            frmAddSupp.id = 0;
            frmAddSupp.btnAddSupp.Text = "اضافة";
            frmAddSupp.Show();
        }

        // void calculate rev
        private void proCall(){
            buy = Convert.ToDouble(editBuy.Text);
            sell = Convert.ToDouble(editSell.Text);
            qte = Convert.ToDouble(editQte.Value);
            tSell = sell * qte;
            tBuy = buy * qte;
            tRev = tSell - tBuy;
            editTSell.Text = tSell.ToString();
            editTBuy.Text = tBuy.ToString();
            editTRev.Text = tRev.ToString();

        }
    }
}
