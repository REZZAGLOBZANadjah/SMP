using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using SMP.EPL;
namespace SMP.PL
{
    public partial class FrmCat : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        // elements for delete function
        tb_cat tb_cat = new tb_cat();
        BL.Methods methods = new BL.Methods();
        int id;
        public FrmCat()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            SMP.DB_SMPEntities dbContext = new SMP.DB_SMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.tb_cat.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.tb_cat.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PL.FrmCatAdd frmAddCat = new PL.FrmCatAdd();
            frmAddCat.id = 0;
            frmAddCat.btnAddCat.Text = "اضافة";
            frmAddCat.Show();
            updateData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             db  = new DB_SMPEntities();
            gridControl1.DataSource = db.tb_cat.ToList();
        }

        // delete cat
        private void btnDel_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            try
            {
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("id_cat"));
                var rs = MessageBox.Show("عملية حذف", "هل أنت متأكد من هذه العملية", MessageBoxButtons.YesNo);

                if (rs == DialogResult.Yes )
                {
                    tb_cat = db.tb_cat.Where(x => x.id_cat == id).FirstOrDefault();
                    db.Entry(tb_cat).State = EntityState.Deleted;
                    db.SaveChanges();
                    toast.txtCaption.Text = "تم حذف صنف";
                    toast.Show();
                    updateData();
                }
            }
            catch
            {
                toast.txtCaption.Text = "لا يوجد صنف لحذفه ";
                toast.Show();


            }


        }
        //function update data in gridview
        public void updateData()
        {
            db = new DB_SMPEntities();
            gridControl1.DataSource = db.tb_cat.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var _search = editSearch.Text;
            gridControl1.DataSource = db.tb_cat.Where(x => x.cat_name.Contains(_search)).ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PL.FrmCatAdd frmAddCat = new PL.FrmCatAdd();
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            try
            {
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("id_cat"));
                tb_cat = db.tb_cat.Where(x => x.id_cat == id).FirstOrDefault();
                if (id != 0)
                {
                    frmAddCat.editNameCat.Text = tb_cat.cat_name.ToString();

                    methods.by = tb_cat.Cat_cover;
                    frmAddCat.picCover.Image = Image.FromStream(methods.convertImage());
                    frmAddCat.id = id;
                    frmAddCat.btnAddCat.Text = "تعديل";
                    frmAddCat.Show();
                    updateData();

                }
                else
                {
                    toast.txtCaption.Text = "لا يوجد صنف لتعديله ";
                    toast.Show();
                }
                
            }
            catch
            {
                toast.txtCaption.Text = "لا يوجد صنف لتعديله ";
                toast.Show();

            }




        }

       
    }
}
