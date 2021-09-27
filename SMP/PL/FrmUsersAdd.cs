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
    public partial class FrmUsersAdd : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Users tb_Users = new TB_Users();
        BL.Methods methods = new BL.Methods();
        public int id;

        public FrmUsersAdd()
        {
            InitializeComponent();
        }
        // add or edit supplier
 
        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            //check if add or edit 
            if (editNameUsers.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txtCaption.Text = "اسم المستخدم مطلوب";
                dialog.Show();
                //dialog.Close();
            }
            else
            {
                //check if add or edit
                if (id == 0)
                {
                    //Add

                    tb_Users.User_Name = editNameUsers.Text;
                    tb_Users.User_Pass = editUsersPass.Text;
                    tb_Users.User_Roll = editUsersRoll.Text;
                    tb_Users.User_State = "False";
                    db.TB_Users.Add(tb_Users);
                    db.SaveChanges();

                    toast.txtCaption.Text = "تم اضافة مستخدم جديد";
                    toast.Show();
                    this.Close();


                }
                else
                {
                    //edit
                    // add action if the user does not add image or warning msg
                    tb_Users.User_Id = id;

                    tb_Users.User_Name = editNameUsers.Text;
                    tb_Users.User_Pass = editUsersPass.Text;
                    tb_Users.User_Roll = editUsersRoll.Text;
                    tb_Users.User_State = "False";

                    db.Entry(tb_Users).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    toast.txtCaption.Text = "تم تعديل مستخدم ";
                    toast.Show();
                    this.Close();
                }

            }
        }

    }
}
