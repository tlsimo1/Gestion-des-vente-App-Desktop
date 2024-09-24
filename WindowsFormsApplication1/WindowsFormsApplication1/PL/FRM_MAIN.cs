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
    public partial class FRM_MAIN : Form
    {
        //----- activation désactivation main------------------
        private static FRM_MAIN frm;
        static void frm_FormClosed(object sender,FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_MAIN getMainForm
        {
            get
            {
                if(frm==null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        //------------------------------------------------

        public FRM_MAIN()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.usersToolStripMenuItem.Enabled = false;
            this.customersToolStripMenuItem.Enabled = false;
            this.productToolStripMenuItem.Enabled = false;
            this.sAUVGARDEToolStripMenuItem.Enabled = false;
            this.rESTOREToolStripMenuItem.Enabled = false;

        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN login = new FRM_LOGIN();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nEWPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT FRM = new FRM_ADD_PRODUCT();
            FRM.ShowDialog();
        }

        private void mANAGEMENTPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS pr = new FRM_PRODUCTS();
            pr.StartPosition = FormStartPosition.CenterScreen;
            pr.ShowDialog();
        }

        private void mANAGEMENTCATEGORIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORIES FRM = new FRM_CATEGORIES();
            FRM.StartPosition = FormStartPosition.CenterScreen;
            FRM.ShowDialog();
            

        }

        private void mANAGMENTCUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CUSTOMERS FRM = new CUSTOMERS();
            FRM.StartPosition = FormStartPosition.CenterScreen;
            FRM.ShowDialog();

        }

        private void mANAGEMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS_LIST FRM = new FRM_ORDERS_LIST();
            FRM.StartPosition = FormStartPosition.CenterScreen;
            FRM.ShowDialog();
        }

        private void nEWPURCHASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS FRM = new FRM_ORDERS();
            FRM.StartPosition = FormStartPosition.CenterScreen;
            FRM.ShowDialog();
        }

        private void nEWUSERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_ADD_USER FRM = new FRM_ADD_USER();
            FRM.StartPosition = FormStartPosition.CenterScreen;
            FRM.ShowDialog();
        }

        private void mANAGMENTUSERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_USER_LIST FRM = new FRM_USER_LIST();
            FRM.StartPosition = FormStartPosition.CenterScreen;
            FRM.ShowDialog();
        }

        private void sAUVGARDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_BACKUP FRM = new FRM_BACKUP();
            FRM.StartPosition = FormStartPosition.CenterScreen;
            FRM.ShowDialog();
        }

        private void rESTOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_RESTORDATA FRM = new FRM_RESTORDATA();
            FRM.StartPosition = FormStartPosition.CenterScreen;
            FRM.ShowDialog();
        }

        private void cONFIGURATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_CONFIG FRM = new FRM_CONFIG();
            FRM.StartPosition = FormStartPosition.CenterScreen;
            FRM.ShowDialog();
        }
    }
}
