using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;


namespace WindowsFormsApplication1.PL
{
    public partial class FRM_PRODUCTS : Form
    {
        //--------------------------------------------------
        private static FRM_PRODUCTS frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_PRODUCTS getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRODUCTS();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        //--------------------------------------------------


        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();
        public FRM_PRODUCTS()
        { 
            InitializeComponent();
            if (frm == null)
                frm = this;
            BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();
            this.gridlistproduct.DataSource = prd.GET_ALL_PRODUCT();
        }

        private void FRM_PRODUCTS_Load(object sender, EventArgs e)
        {

        }

        private void txtrecherch_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.SERSH_PRODUCT(txtrecherch.Text);
            this.gridlistproduct.DataSource = DT;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT fr = new FRM_ADD_PRODUCT();
            fr.ShowDialog();
        }

        private void btn_sup_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("voulez vous vraiment supprimer cette record","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
           {
            prd.DELETE_PRODUCT(Convert.ToInt32(this.gridlistproduct.CurrentRow.Cells[0].Value));
            MessageBox.Show("RECORD DELETING", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            this.gridlistproduct.DataSource = prd.GET_ALL_PRODUCT();
           }
           else
           {
               MessageBox.Show("OPERATION ANNULER", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.txt_productid.Text = this.gridlistproduct.CurrentRow.Cells[0].Value.ToString();
            frm.txt_des.Text = this.gridlistproduct.CurrentRow.Cells[1].Value.ToString();
            frm.txt_stock.Text = this.gridlistproduct.CurrentRow.Cells[2].Value.ToString();
            frm.txt_price.Text = this.gridlistproduct.CurrentRow.Cells[3].Value.ToString();
            frm.cmb_cat.Text = this.gridlistproduct.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "Update Product " + this.gridlistproduct.CurrentRow.Cells[0].Value.ToString();
            frm.btn_ADD.Text = "Update";
            frm.state = "UPDATE";
            frm.txt_productid.ReadOnly = true;
            byte [] image=(byte[])prd.GET_IMAGE_PRODUCT(Convert.ToInt32(this.gridlistproduct.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();

        }

        private void btn_img_Click(object sender, EventArgs e)
        {
            FRM_VIEW_IMAGEP_RODUCT frm = new FRM_VIEW_IMAGEP_RODUCT();
            byte[] image = (byte[])prd.GET_IMAGE_PRODUCT(Convert.ToInt32(this.gridlistproduct.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pic_IMAGE.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void btn_rport_Click(object sender, EventArgs e)
        {
            RPT.rpt_prod_single myreport = new RPT.rpt_prod_single();
            myreport.SetParameterValue("@id",this.gridlistproduct.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_RPT_PRODUCT myForm = new RPT.FRM_RPT_PRODUCT();
            myForm.crystalReportViewer1.ReportSource = myreport;
            myForm.ShowDialog();
        
        }

        private void btn_allreport_Click(object sender, EventArgs e)
        {
            RPT.Cachedrpt_all_products myreport = new RPT.Cachedrpt_all_products();
            RPT.FRM_RPT_PRODUCT myForm = new RPT.FRM_RPT_PRODUCT();
            myForm.crystalReportViewer1.ReportSource = myreport;
            myForm.ShowDialog();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_products myreport = new RPT.rpt_all_products();
            //create export option
            ExportOptions export = new ExportOptions();
            //create objet for destination
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();
            ExcelFormatOptions excelformat = new ExcelFormatOptions();
            // set the path of destination
            dfoptions.DiskFileName = @"D:\ProductsList.xls";
            export = myreport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.Excel;
            export.ExportFormatOptions = excelformat;
            export.ExportDestinationOptions= dfoptions;
            myreport.Export();
            MessageBox.Show("List Exported SuccessFully"," Export",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
