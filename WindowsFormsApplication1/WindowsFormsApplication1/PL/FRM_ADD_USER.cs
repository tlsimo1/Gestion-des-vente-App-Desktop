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
    public partial class FRM_ADD_USER : Form
    {
        public FRM_ADD_USER()
        {
            InitializeComponent();
        }
        BL.CLS_LOGIN user = new BL.CLS_LOGIN();
        private void btn_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_VALIDER_Click(object sender, EventArgs e)
        {
            if(txt_name.Text==string.Empty || txt_fullname.Text==string.Empty || txt_pass.Text==string.Empty ||
                 cmb_type.Text==string.Empty )
            {
                MessageBox.Show("REMPLIR TOUS LES CHAMPS","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            return;
            }
            if(txt_pass.Text != txt_confirpass.Text)
            {
                MessageBox.Show("PASSWORD NON IDENTIQUE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(btn_VALIDER.Text=="UPDATE")
            {
                txt_name.Enabled = false;
                user.EDIT_USER(txt_name.Text, txt_fullname.Text, txt_pass.Text, cmb_type.Text);
                MessageBox.Show("UPDATE USER SUCCESSFULY", "UPDATE USER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            if (btn_VALIDER.Text == "VALIDER")
            {
            user.ADD_USER(txt_name.Text,txt_fullname.Text,txt_pass.Text,cmb_type.Text);
            MessageBox.Show("ADD USER SUCCESSFULY", "ADD USER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            txt_name.Clear();
            txt_pass.Clear();
            txt_fullname.Clear();
            txt_confirpass.Clear();
            txt_name.Focus();

        }

        private void txt_confirpass_Validated(object sender, EventArgs e)
        {
            if (txt_pass.Text != txt_confirpass.Text)
            {
                MessageBox.Show("PASSWORD NON IDENTIQUE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
