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
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
            txt_NomServeur.Text = Properties.Settings.Default.Server;
            txt_Nom_database.Text = Properties.Settings.Default.Database;
            if (Properties.Settings.Default.Mode == "SQL")
            {
                rbSQL.Checked = true;
                //txt_NomServeur.Text = Properties.Settings.Default.Mode;
                txt_NomUtilisateur.Text = Properties.Settings.Default.ID;
                txt_Password.Text = Properties.Settings.Default.Password;
            }
            else
            {
                rbWindows.Checked = true;
                txt_NomUtilisateur.Clear();
                txt_Password.Clear();
                txt_NomUtilisateur.ReadOnly = true;
                txt_Password.ReadOnly = true;
            }


        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            
                Properties.Settings.Default.Server = txt_NomServeur.Text;
                Properties.Settings.Default.Database = txt_Nom_database.Text;
                Properties.Settings.Default.Mode = rbSQL.Checked == true ? "SQL" : "Windows";
                Properties.Settings.Default.ID = txt_NomUtilisateur.Text;
                Properties.Settings.Default.Password = txt_Password.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("INFORMATION VALIDER", "CONFIG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
        }

        private void FRM_CONFIG_Load(object sender, EventArgs e)
        {

        }

        private void rbSQL_CheckedChanged(object sender, EventArgs e)
        {
            txt_NomUtilisateur.ReadOnly = false;
            txt_Password.ReadOnly = false;
        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            txt_NomUtilisateur.ReadOnly = true;
            txt_Password.ReadOnly = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
