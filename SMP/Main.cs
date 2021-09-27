using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP
{
    public partial class Main : Form
    {
        // int form
        PL.FrmHome frmHome = new PL.FrmHome();
        PL.FrmCat frmCat = new PL.FrmCat();
        PL.FrmSup frmSupp = new PL.FrmSup();
        PL.FrmPur frmPur = new PL.FrmPur();
        PL.FrmCus frmCus = new PL.FrmCus();
        PL.FrmSell frmSell = new PL.FrmSell();
        PL.FrmRep frmRep = new PL.FrmRep();
        PL.FrmUsers frmUsers = new PL.FrmUsers();
        PL.FrmSettings frmSettings = new PL.FrmSettings();
        PL.FrmCallUs frmCallUs = new PL.FrmCallUs();
        TB_Users tb_Users = new TB_Users();


        BL.Methods methods = new BL.Methods();
        SMP.DB_SMPEntities db = new DB_SMPEntities();

        public Main()
        {
            InitializeComponent();
        }

       // close app

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
        // minimise app
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //max app
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;

            }

        }
        //collapse
        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (pnNavBar.Width>=244)
            {
                pnNavBar.Width = 50;
                pnTitleNav.Visible = false;
                pnHeaderNavBar.Height = 141;

            }
            else
            {
                pnNavBar.Width = 244;
                pnTitleNav.Visible = true;
                pnHeaderNavBar.Height = 141;
            }
        }

        // load home page
       private void btnHome_Click(object sender, EventArgs e)
        {
            pnCont.Controls.Clear();
            pnCont.Controls.Add(frmHome.pnHome);
            lbTitlePage.Text = "الصفحة الرئيسية";
        }
      
       private void mainLoad(object sender, EventArgs e)
        {
            pnCont.Controls.Clear();
            pnCont.Controls.Add(frmHome.pnHome);
            // set Roll
            if (lbRoll.Text == "مدير") 
            {
                btnUsers.Enabled = true;
            }
            else
            {
                btnUsers.Enabled = false;
            }
        }
     
        //load categories

       private void btnCat_Click(object sender, EventArgs e)
        {
            pnCont.Controls.Clear();
            pnCont.Controls.Add(frmCat.pnCat);
            db = new DB_SMPEntities();
            //frmCat.gridControl1.DataSource = db.tb_cat.ToList();
            lbTitlePage.Text = "الأصناف";

        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            pnCont.Controls.Clear();
            pnCont.Controls.Add(frmSupp.pnSupp);
            db = new DB_SMPEntities();
            //frmCat.gridControl1.DataSource = db.tb_cat.ToList();
            lbTitlePage.Text = "الموردين";
        }

        private void btnPur_Click(object sender, EventArgs e)
        {
            pnCont.Controls.Clear();
            pnCont.Controls.Add(frmPur.pnPur);
            db = new DB_SMPEntities();
            lbTitlePage.Text = "المشتريات";
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            pnCont.Controls.Clear();
            pnCont.Controls.Add(frmCus.pnCus);
            db = new DB_SMPEntities();
            lbTitlePage.Text = "العملاء";
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            pnCont.Controls.Clear();
            pnCont.Controls.Add(frmSell.pnSell);
            db = new DB_SMPEntities();
            lbTitlePage.Text = "المبيعات";
        }

        private void btnRep_Click(object sender, EventArgs e)
        {
            pnCont.Controls.Clear();
            pnCont.Controls.Add(frmRep.pnRep);
            db = new DB_SMPEntities();
            lbTitlePage.Text = "التفارير";
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            pnCont.Controls.Clear();
            pnCont.Controls.Add(frmUsers.pnUsers);
            db = new DB_SMPEntities();
            lbTitlePage.Text = "المستخدمين";
        }

        // الاعدادات Settings
        private void btnSettings_Click(object sender, EventArgs e)
        {
            //frmSettings.Show();
            pnCont.Controls.Clear();
            pnCont.Controls.Add(frmSettings.pnSettings);
            lbTitlePage.Text = "الاعدادات";

        }
        // call Us اتصل بنا
        private void callUs_Click(object sender, EventArgs e)
        {
            //frmCallUs.Show();
            pnCont.Controls.Clear();
            pnCont.Controls.Add(frmCallUs.pnCallUs);
            lbTitlePage.Text = "اتصل بنا";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //this.Close();
            PL.FrmLogin login = new PL.FrmLogin();
            this.Enabled = false;
            login.Show();  
            this.Hide();
            //Environment.Exit(0);
            
            try {
                tb_Users = db.TB_Users.Where(x => x.User_State == "True").FirstOrDefault();

                tb_Users.User_State = "False";
                db.Entry(tb_Users).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                this.Enabled = false;
                login.Show();
                this.Hide();
            }
            catch
            {
                login.Show();
                this.Hide();


            }
            

        }

       
    }
}
