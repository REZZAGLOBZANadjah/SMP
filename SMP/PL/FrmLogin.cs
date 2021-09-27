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
    public partial class FrmLogin : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        TB_Users tb_Users = new TB_Users();
        Main main = new Main();
        public FrmLogin()
        {
            InitializeComponent();
        }
        // add or edit supplier
 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Toast toast = new Toast();
            Dialog dialog = new Dialog();
            //check if add or edit 
            if ( (editNameUsers.Text == "" || editUsersPass.Text == ""))
            {
                MessageBox.Show("ادخل اسم المستخدم و كلمة المرور");
            }
            else
            {

                // login here
                tb_Users = db.TB_Users.Where(x => x.User_Name == editNameUsers.Text && x.User_Pass == editUsersPass.Text).FirstOrDefault();

                if (tb_Users!= null)
                {
                    tb_Users.User_State = "True";
                    db.Entry(tb_Users).State = System.Data.Entity.EntityState.Modified;
                    main.lbUserName.Text = tb_Users.User_Name;
                    main.lbRoll.Text = tb_Users.User_Roll;
                    main.Enabled = true;
                    db.SaveChanges();
                    main.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Faild Login");

                }

            }
               

            }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


       
    }

