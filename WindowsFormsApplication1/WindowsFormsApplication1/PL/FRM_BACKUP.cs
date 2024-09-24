using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PL
{
    public partial class FRM_BACKUP : Form
    {
        SqlConnection con = new SqlConnection(@"Server=MONPC-PC\TLMSSQLSERVER;Database=Product_DB;Integrated Security=true");
        

        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_BACKUP_Load(object sender, EventArgs e)
        {

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            string FileName = txt_chemain.Text + "\\Product_DB" + DateTime.Now.ToShortDateString().Replace('/','-')
                + " - " + DateTime.Now.ToLongTimeString().Replace(':','-');
            string QUERY = "Backup Database Product_DB to Disk='" + FileName + ".bak'";
            SqlCommand cmd = new SqlCommand(QUERY,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("RESTORE DATABASE SUCCESSFULLY","RESTORE DATA",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txt_chemain.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
