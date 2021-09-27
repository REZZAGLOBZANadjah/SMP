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
    public partial class FrmCatAdd : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        tb_cat tbCat = new tb_cat();
        BL.Methods methods = new BL.Methods();
        PL.FrmCat frmCat = new FrmCat();
        public int id;
        public FrmCatAdd()
        {
            InitializeComponent();
        }


       
        // add or edit categorie
        private void btnAddCat_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            //check if add or edit 
            if (editNameCat.Text=="")
            {
                dialog.Width = this.Width;
                dialog.txtCaption.Text = "اسم الصنف مطلوب";
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
                    picCover.Image.Save(methods.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    
                    tbCat.cat_name = editNameCat.Text;
                    tbCat.Cat_cover = methods.convertByte();
                    db.tb_cat.Add(tbCat);
                    db.SaveChanges();
                   
                    //frmCat.updateData();
                    // update data
                    db = new DB_SMPEntities();
                    frmCat.gridControl1.DataSource = db.tb_cat.ToList();
                    // 
                    toast.txtCaption.Text = "تم اضافة صنف جديد";
                    toast.Show();
                    this.Close();


                }
                else
                {
                    //edit
                    // add action if the user does not add image or warning msg
                    picCover.Image.Save(methods.ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    tbCat.cat_name = editNameCat.Text;
                    tbCat.Cat_cover = methods.convertByte();
                    tbCat.id_cat = id;
                    db.Entry(tbCat).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txtCaption.Text = "تم تعديل صنف جديد";
                    db = new DB_SMPEntities();
                    frmCat.gridControl1.DataSource = db.tb_cat.ToList();
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
