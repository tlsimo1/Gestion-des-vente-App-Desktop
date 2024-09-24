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
    public partial class FRM_RESTORDATA : Form
    {
        SqlConnection con = new SqlConnection(@"Server=MONPC-PC\TLMSSQLSERVER;Database=master;Integrated Security=true");

        public FRM_RESTORDATA()
        {
            InitializeComponent();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_chemain.Text = openFileDialog1.FileName ;
            }
        }

        private void btn_restor_Click(object sender, EventArgs e)
        {

            string QUERY = "ALTER Database Product_DB SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database Product_DB From Disk='" + txt_chemain.Text + "'";
            SqlCommand cmd = new SqlCommand(QUERY, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("RESTORE DATABASE SUCCESSFULLY", "RESTORE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
