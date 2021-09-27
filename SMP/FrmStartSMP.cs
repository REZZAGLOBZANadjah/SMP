using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using SMP.PL;
namespace SMP
{
    public partial class FrmStartSMP : SplashScreen
    { 
        //init
        TB_Users tb_Users = new TB_Users();
        DB_SMPEntities db = new DB_SMPEntities();
        Main main = new Main();
        FrmLogin login = new FrmLogin();
        public FrmStartSMP()
        {
            InitializeComponent();
            this.labelCopyright.Text = "SMP" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //login.Show();

            tb_Users = db.TB_Users.Where(x => x.User_State == "True").FirstOrDefault();

             if (tb_Users != null)
             {
                 main.lbUserName.Text = tb_Users.User_Name;
                 main.lbRoll.Text = tb_Users.User_Roll;
                 main.Show();
             }
             else
             {
                 login.Show();
             }
            
            this.Hide();
            timer1.Enabled = false;
        }

       
    }
}