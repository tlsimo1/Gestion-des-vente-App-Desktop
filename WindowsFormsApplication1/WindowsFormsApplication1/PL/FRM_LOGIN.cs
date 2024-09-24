using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PL
{
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_LOGIN Login = new BL.CLS_LOGIN();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Dt = Login.LOGIN(txtlogin.Text, txtpwd.Text);
                if (Dt.Rows.Count > 0)
                {
                    if (Dt.Rows[0][2].ToString() == "ADMIN")
                    {
                        FRM_MAIN.getMainForm.usersToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.customersToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.productToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.sAUVGARDEToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.rESTOREToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.usersToolStripMenuItem.Visible = true;
                        Program.SalesMan = Dt.Rows[0]["FullName"].ToString();
                        this.Close();
                    }
                    else if (Dt.Rows[0][2].ToString() == "USER")
                    {
                        FRM_MAIN.getMainForm.usersToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.customersToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.productToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.sAUVGARDEToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.rESTOREToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getMainForm.usersToolStripMenuItem.Visible = false;
                        Program.SalesMan = Dt.Rows[0]["FullName"].ToString();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show(" Login Failed !");
                }
            }
            catch
            {
                MessageBox.Show("DATABASE INTROVABLE","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
