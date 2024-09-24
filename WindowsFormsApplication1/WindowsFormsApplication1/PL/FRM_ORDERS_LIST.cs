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
    public partial class FRM_ORDERS_LIST : Form
    {
        public FRM_ORDERS_LIST()
        {
            InitializeComponent();
            this.gridlistorders.DataSource = order.SEARCHORDERS("");
        }
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();

        private void btn_report_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int order_id = Convert.ToInt32(this.gridlistorders.CurrentRow.Cells[0].Value);
            RPT.rpt_orders report = new RPT.rpt_orders();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            report.SetDataSource(order.GET_ORDER_DETAIL(order_id));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void txtrecherch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gridlistorders.DataSource = order.SEARCHORDERS(txtrecherch.Text);
            }
            catch
            {
                return;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
