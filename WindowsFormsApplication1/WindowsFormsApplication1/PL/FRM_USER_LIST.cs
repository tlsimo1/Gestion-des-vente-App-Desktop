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
    public partial class FRM_USER_LIST : Form
    {
        BL.CLS_LOGIN user = new BL.CLS_LOGIN();
        public FRM_USER_LIST()
        {
            InitializeComponent();
            this.griduserlist.DataSource = user.SEARCH_USER("");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER FRM = new FRM_ADD_USER();
            FRM.btn_VALIDER.Text = "VALIDER";
            FRM.ShowDialog();
            this.griduserlist.DataSource = user.SEARCH_USER("");
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER FRM = new FRM_ADD_USER();
            FRM.txt_name.Text = this.griduserlist.CurrentRow.Cells[0].Value.ToString();
            FRM.txt_pass.Text = this.griduserlist.CurrentRow.Cells[1].Value.ToString();
            FRM.cmb_type.Text = this.griduserlist.CurrentRow.Cells[2].Value.ToString();
            FRM.txt_fullname.Text = this.griduserlist.CurrentRow.Cells[3].Value.ToString();
            FRM.btn_VALIDER.Text = "UPDATE";
            FRM.ShowDialog();
            this.griduserlist.DataSource = user.SEARCH_USER("");
        }

        private void txtrecherch_TextChanged(object sender, EventArgs e)
        {
            this.griduserlist.DataSource = user.SEARCH_USER(txtrecherch.Text);
        }

        private void FRM_USER_LIST_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("VOULEZ VOUS VRAIMENT SUPPRIMER CETTE RECORD","DELETE",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                user.DELETE_USER(this.griduserlist.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("RECORD DELETING"," DELETE RECORD",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.griduserlist.DataSource = user.SEARCH_USER("");
            }

        }
    }
}
