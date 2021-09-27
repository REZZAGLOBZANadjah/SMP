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
    public partial class FrmCusAdd: Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Cus tb_Cus = new TB_Cus();
        BL.Methods methods = new BL.Methods();
        public int id;
        public FrmCusAdd()
        {
            InitializeComponent();
        }


       
        // add or edit supplier
        private void btnAddCat_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            //check if add or edit 
            if (editNameCus.Text=="")
            {
                dialog.Width = this.Width;
                dialog.txtCaption.Text = "اسم زبون مطلوب";
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
                    picCoverCus.Image.Save(methods.ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    tb_Cus.Cus_Name = editNameCus.Text;
                    tb_Cus.Cus_Phone = editPhoneCus.Text;
                    tb_Cus.Cus_Email= edtEmailCus.Text;
                    tb_Cus.Cus_Image = methods.convertByte();
                    db.TB_Cus.Add(tb_Cus);
                    db.SaveChanges();
                    toast.txtCaption.Text = "تم اضافة مورد جديد";
                    toast.Show();
                    this.Close();


                }
                else
                {
                    //edit
                    // add action if the user does not add image or warning msg
                    picCoverCus.Image.Save(methods.ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    tb_Cus.Cus_Name = editNameCus.Text;
                    tb_Cus.Cus_Phone = editPhoneCus.Text;
                    tb_Cus.Cus_Email = edtEmailCus.Text;
                    tb_Cus.Cus_Image = methods.convertByte();
                    tb_Cus.Cus_Id = id;
                    db.Entry(tb_Cus).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txtCaption.Text = "تم تعديل زبون ";
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
