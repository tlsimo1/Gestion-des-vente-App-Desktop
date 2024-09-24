using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CrystalDecisions.Shared;

namespace WindowsFormsApplication1.PL
{
    public partial class FRM_CATEGORIES : Form
    {
        SqlConnection con = new SqlConnection(@"Server=MONPC-PC\TLMSSQLSERVER;Database=Product_DB;Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt = new System.Data.DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public FRM_CATEGORIES()
        {               
            InitializeComponent();
            da = new SqlDataAdapter("select ID_CAT as 'ID CATEGORIES',DESCRIPTION_CAT as 'DESCRIPION' from CATEGORIES", con);
            da.Fill(dt);
            gridview_cat.DataSource = dt;
            txt_id.DataBindings.Add("text", dt, "ID CATEGORIES");
            txt_des.DataBindings.Add("text", dt, "DESCRIPION");
            bmb=this.BindingContext[dt];
            lblposition.Text = (bmb.Position+1) + " / " + bmb.Count;
        }

        private void FRM_CATEGORIES_Load(object sender, EventArgs e)
        {

        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblposition.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void btn_der_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblposition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblposition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btn_suiv_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblposition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btn_new.Enabled = false;
            btn_add.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txt_id.Text = id.ToString();
            txt_des.Focus();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("ADD sussessFuly","ADD",MessageBoxButtons.OK,MessageBoxIcon.Information);
            btn_add.Enabled = false;
            btn_new.Enabled = true;
            lblposition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("DELETING sussessFuly", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_add.Enabled = false;
            btn_new.Enabled = true;
            lblposition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("EDITED sussessFuly", "EDIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblposition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btn_rptsl_Click(object sender, EventArgs e)
        {
            RPT.rpt_cat_single rpt = new RPT.rpt_cat_single();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            rpt.SetParameterValue("@id",Convert.ToInt32(txt_id.Text));
            
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btn_rpt_Click(object sender, EventArgs e)
        {

            RPT.rpt_all_cat rpt = new RPT.rpt_all_cat();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btn_pdft_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_cat myreport = new RPT.rpt_all_cat();
            //create export option
            ExportOptions export = new ExportOptions();
            //create objet for destination
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();
            PdfFormatOptions pdflformat = new PdfFormatOptions();
            // set the path of destination
            dfoptions.DiskFileName = @"D:\CategoriesList.pdf";
            export = myreport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdflformat;

            export.ExportDestinationOptions = dfoptions;
            myreport.Refresh();
            myreport.Export();
            MessageBox.Show("List Exported SuccessFully", " Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_rptp_Click(object sender, EventArgs e)
        {
            RPT.rpt_cat_single myreport = new RPT.rpt_cat_single();
            //create export option
            ExportOptions export = new ExportOptions();
            //create objet for destination
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();
            PdfFormatOptions pdflformat = new PdfFormatOptions();
            // set the path of destination
            dfoptions.DiskFileName = @"D:\CategorieDetails.pdf";
            export = myreport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdflformat;

            export.ExportDestinationOptions = dfoptions;
            myreport.SetParameterValue("@id", Convert.ToInt32(txt_id.Text));
            myreport.Export();
            MessageBox.Show("List Exported SuccessFully", " Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
