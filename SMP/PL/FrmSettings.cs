using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace SMP.PL
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            const string qu=  "\"";
            var sv = editSV.Text;
            var conStr = @"metadata = res://*/SMPModel.csdl|res://*/SMPModel.ssdl|res://*/SMPModel.msl;provider=System.Data.SqlClient;provider connection string=" + qu + ";data source=" + sv + ";initial catalog=DB_SMP;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\";";
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.ConnectionStrings.ConnectionStrings["DB_SMPEntities"].ConnectionString=conStr;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings ");
            var strl = config.ConnectionStrings.ConnectionStrings["DB_SMPEntities"].ConnectionString = conStr;
            MessageBox.Show(strl);
            Application.Restart();

        }
    }
}
