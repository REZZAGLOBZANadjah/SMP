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
    public partial class FrmSuppAdd: Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_SUPP tb_Supp = new TB_SUPP();
        BL.Methods methods = new BL.Methods();
        public int id;
        public FrmSuppAdd()
        {
            InitializeComponent();
        }


       
        // add or edit supplier
        private void btnAddCat_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            //check if add or edit 
            if (editNameSup.Text=="")
            {
                dialog.Width = this.Width;
                dialog.txtCaption.Text = "اسم المورد مطلوب";
                dialog.Show();
                //dialog.Close();
            }
            else
            {
                //check if add or edit
                if (id==0)
                {
                    //Add
                    // add action if the user does not add image or warning msg
                    picCoverSupp.Image.Save(methods.ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    tb_Supp.Supp_Name = editNameSup.Text;
                    tb_Supp.Supp_Phone = editPhoneSupp.Text;
                    tb_Supp.Supp_Email= edtEmailSupp.Text;
                    tb_Supp.Supp_Image = methods.convertByte();
                    db.TB_SUPP.Add(tb_Supp);
                    db.SaveChanges();
                    toast.txtCaption.Text = "تم اضافة مورد جديد";
                    toast.Show();
                    this.Close();


                }
                else
                {
                    //edit
                    // add action if the user does not add image or warning msg
                    picCoverSupp.Image.Save(methods.ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    tb_Supp.Supp_Name = editNameSup.Text;
                    tb_Supp.Supp_Phone = editPhoneSupp.Text;
                    tb_Supp.Supp_Email = edtEmailSupp.Text;
                    tb_Supp.Supp_Image = methods.convertByte();
                    tb_Supp.Supp_Id = id;
                    db.Entry(tb_Supp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txtCaption.Text = "تم تعديل المورد ";
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
    }
}
