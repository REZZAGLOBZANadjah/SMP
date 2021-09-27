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
    public partial class FrmSellAdd : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Pur tb_Pur = new TB_Pur();
        TB_Sell tb_Sell = new TB_Sell();
        BL.Methods methods = new BL.Methods();
        public int id;
        double qtP// previous quantite
            , qtN// new quantite
            ,qtR// required quentite
            ;
        public FrmSellAdd()
        {
            InitializeComponent();
        }



        // add or edit supplier
        private void btnAddSell_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            // check if add or edit
            qtP = Convert.ToDouble(editTQte.Text);
            qtN= Convert.ToDouble(editQte.Text);
            qtR = qtP - qtN;
            if (editSellName.Text == "" )
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
                    if (qtR >= 0)
                    {
                        //Add
                        // add action if the user does not add image or warning msg
                        tb_Sell.Sell_Name = editSellName.Text;
                        tb_Sell.Sell_Cus = editCus.Text;

                        tb_Sell.Sell_Price = Convert.ToDouble(editSellPrice.Text);
                        tb_Sell.Sell_Qte = Convert.ToDouble(editQte.Text);

                        tb_Sell.Sell_Tprice = (Convert.ToDouble(editQte.Text)) * (Convert.ToDouble(editSellPrice.Text));
                        tb_Sell.Sell_Date = DateTime.Now;

                        db.TB_Sell.Add(tb_Sell);

                        tb_Pur.Pur_Qt = qtR;
                        db.Entry(tb_Pur).State = System.Data.Entity.EntityState.Modified;

                        db.SaveChanges();
                        toast.txtCaption.Text = "تم اجراء عملية بيع";
                        toast.Show();
                        this.Close();

                    }
                    else
                    {
                        label3.Visible = true;
                    }
                   
                     
                }
                else
                {
                    //edit
                    //tb_Pur.Pur_Id = id;

                    tb_Sell.Sell_Name = editSellName.Text;
                    tb_Sell.Sell_Cus = editCus.Text;
                    

                    tb_Sell.Sell_Id = id;

                    db.Entry(tb_Sell).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    toast.txtCaption.Text = "تم تعديل عملية بيع ";
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

        private void editSellName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 
            tb_Pur = db.TB_Pur.Where(x => x.Pur_Name == editSellName.Text).FirstOrDefault();
            editTBuy.Text = tb_Pur.Pur_Buy.ToString();
            editTSell.Text = tb_Pur.Pur_Sell.ToString();
            editTQte.Text = tb_Pur.Pur_Qt.ToString();
        }

        private void FrmSellAdd_Load(object sender, EventArgs e)
        {
            //GET DATA from pur table and cus table
           var purName = db.TB_Pur.Select(x => x.Pur_Name).ToList();
            var suppName = db.TB_Cus.Select(x => x.Cus_Name).ToList();
            editSellName.DataSource = purName;
            editCus.DataSource = suppName;
            //auto complete selle name and custumer

            AutoCompleteStringCollection ACSC1 =new  AutoCompleteStringCollection();
            AutoCompleteStringCollection ACSC2 = new AutoCompleteStringCollection();
            ACSC1.AddRange(purName.ToArray());
            ACSC2.AddRange(suppName.ToArray());
            editSellName.AutoCompleteCustomSource = ACSC1;
            editCus.AutoCompleteCustomSource = ACSC2;

           
        }

        private void editQte_EditValueChanged(object sender, EventArgs e)
        {
            proCall();
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

        //// void calculate rev
        private void proCall(){
        //    buy = Convert.ToDouble(editSellPrice.Text);
        //    sell = Convert.ToDouble(editSellPrice.Text);
        //    qte = Convert.ToDouble(editQte.Value);
        //    tSell = sell * qte;
        //    tBuy = buy * qte;
        //    tRev = tSell - tBuy;
        //    editTSell.Text = tSell.ToString();
        //    editTBuy.Text = tBuy.ToString();
        //    editTQte.Text = tRev.ToString();

        }
    }
}
