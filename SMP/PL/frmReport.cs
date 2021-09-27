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
    public partial class FrmRep : Form
    {
        DB_SMPEntities db = new DB_SMPEntities();
        // elements for delete function
        tb_cat tb_cat = new tb_cat();
        BL.Methods methods = new BL.Methods();
        public FrmRep()
        {
            InitializeComponent();

        }

        

        private void btnSellsRep_Click(object sender, EventArgs e)
        {
           // SMP.PL.report = new XtraReport1();
           // report.ShowPreviw();
        }
    }
}
