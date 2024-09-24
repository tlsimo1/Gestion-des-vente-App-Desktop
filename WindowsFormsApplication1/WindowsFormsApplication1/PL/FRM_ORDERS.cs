using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApplication1.PL
{
    public partial class FRM_ORDERS : Form
    {
        BL.CLS_ORDERS order = new BL.CLS_ORDERS();
        DataTable DT = new DataTable();
        public FRM_ORDERS()
        {
            InitializeComponent();
            CREATEDATATABLE();
            RESIZEDGV();
            txt_user.Text = Program.SalesMan;
        }
        void CALCULEAMOUNT()
        {
            if (txt_prixproduct.Text != string.Empty && txt_quantite.Text != string.Empty)
                txt_amount.Text = (Convert.ToDouble(txt_prixproduct.Text) * Convert.ToInt32(txt_quantite.Text)).ToString();

        }
        void CALCULETOTALAMOUNT()
        {
            if (txt_remise.Text != string.Empty && txt_amount.Text != string.Empty)
            {
                double Discount = Convert.ToDouble(txt_remise.Text);
                double Amount = Convert.ToDouble(txt_amount.Text);
                double TotalAmount = Amount - (Amount * (Discount / 100));
                txt_totalG.Text = TotalAmount.ToString();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void CREATEDATATABLE()
        {
            DT.Columns.Add("ORDER ID");
            DT.Columns.Add("LIBELE PRODUCT");
            DT.Columns.Add("PRIX");
            DT.Columns.Add("QUANTITE");
            DT.Columns.Add("AMOUNT");
            DT.Columns.Add("REMISE %");
            DT.Columns.Add("TOTAL");
            grid_commande.DataSource = DT;
        }
        void CLEARBOXES()
        {

            txt_productid.Clear();
            txt_libleproduct.Clear();
            txt_prixproduct.Clear();
            txt_quantite.Clear();
            txt_amount.Clear();
            txt_remise.Clear();
            txt_totalG.Clear();
            btn_browse.Focus();
        }
        void CLEARDATA()
        {
            txt_custid.Clear();
            txt_productid.Clear();
            txt_custfirstname.Clear();
            txt_custlastname.Clear();
            txt_custtel.Clear();
            txt_custemeil.Clear();
            picCustomer.Image = null;
            txt_orderid.Clear();
            txt_desorder.Clear();
            dateorder.Text = null;
            txt_user.Clear();
            CLEARBOXES();
            DT.Clear();
            grid_commande.DataSource = null;
            txt_total.Clear();
            btn_new.Enabled = true;
            btn_valide.Enabled = false;
            btn_imprimer.Enabled = true;
        }
        void RESIZEDGV()
        {
            this.grid_commande.RowHeadersWidth = 85;
            this.grid_commande.Columns[0].Width = 107;
            this.grid_commande.Columns[1].Width = 161;
            this.grid_commande.Columns[2].Width = 107;
            this.grid_commande.Columns[3].Width = 107;
            this.grid_commande.Columns[4].Width = 107;
            this.grid_commande.Columns[5].Width = 107;
            this.grid_commande.Columns[6].Width = 122;

        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            this.txt_orderid.Text = order.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            btn_valide.Enabled = true;
            btn_new.Enabled = false;
            txt_desorder.Focus();
        }

        private void btn_searchcust_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERSLIST frm = new FRM_CUSTOMERSLIST();
            frm.ShowDialog();
            if (frm.gridcustomerlist.CurrentRow.Cells[5].Value is DBNull)
            {
                MessageBox.Show("CETTE CUSTOMER N'A PAS DE PHOTO");
                txt_custid.Text = frm.gridcustomerlist.CurrentRow.Cells[0].Value.ToString();
                txt_custfirstname.Text = frm.gridcustomerlist.CurrentRow.Cells[1].Value.ToString();
                txt_custlastname.Text = frm.gridcustomerlist.CurrentRow.Cells[2].Value.ToString();
                txt_custtel.Text = frm.gridcustomerlist.CurrentRow.Cells[3].Value.ToString();
                txt_custemeil.Text = frm.gridcustomerlist.CurrentRow.Cells[4].Value.ToString();
                picCustomer.Image = null;
                return;
            }
            txt_custid.Text = frm.gridcustomerlist.CurrentRow.Cells[0].Value.ToString();
            txt_custfirstname.Text = frm.gridcustomerlist.CurrentRow.Cells[1].Value.ToString();
            txt_custlastname.Text = frm.gridcustomerlist.CurrentRow.Cells[2].Value.ToString();
            txt_custtel.Text = frm.gridcustomerlist.CurrentRow.Cells[3].Value.ToString();
            txt_custemeil.Text = frm.gridcustomerlist.CurrentRow.Cells[4].Value.ToString();
            byte[] custPicture = (byte[])frm.gridcustomerlist.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(custPicture);
            picCustomer.Image = Image.FromStream(ms);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLEARBOXES();
            PL.FRM_PRODUCT_LIST FRM = new FRM_PRODUCT_LIST();
            FRM.ShowDialog();
            txt_productid.Text = FRM.gridAllProduct.CurrentRow.Cells[0].Value.ToString();
            txt_libleproduct.Text = FRM.gridAllProduct.CurrentRow.Cells[1].Value.ToString();
            txt_prixproduct.Text = FRM.gridAllProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void txt_prixproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            char separatdecimal = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != separatdecimal)
            {
                e.Handled = true;
            }
        }

        private void txt_quantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_prixproduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_prixproduct.Text != string.Empty)
            {
                txt_quantite.Focus();
            }
        }

        private void txt_quantite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_quantite.Text != string.Empty)
            {
                txt_remise.Focus();
            }
        }

        private void txt_prixproduct_KeyUp(object sender, KeyEventArgs e)
        {
            CALCULEAMOUNT();
            CALCULETOTALAMOUNT();
        }

        private void txt_quantite_KeyUp(object sender, KeyEventArgs e)
        {
            CALCULEAMOUNT();
            CALCULETOTALAMOUNT();
        }

        private void txt_remise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_remise_KeyUp(object sender, KeyEventArgs e)
        {
            CALCULETOTALAMOUNT();
        }

        private void txt_remise_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (order.VERIFY_QTE(Convert.ToInt32(txt_productid.Text), Convert.ToInt32(txt_quantite.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("QUANTITE EN STOCK INSUFUSANTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }
                for (int i = 0; i < grid_commande.Rows.Count - 1; i++)
                {
                    if (grid_commande.Rows[i].Cells[0].Value.ToString() == txt_productid.Text)
                    {
                        MessageBox.Show("PRODUCT EXIST DEJA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }
                DataRow DR = DT.NewRow();

                DR[0] = txt_productid.Text;
                DR[1] = txt_libleproduct.Text;
                DR[2] = txt_prixproduct.Text;
                DR[3] = txt_quantite.Text;
                DR[4] = txt_amount.Text;
                DR[5] = txt_remise.Text;
                DR[6] = txt_totalG.Text;

                DT.Rows.Add(DR);
                grid_commande.DataSource = DT;
                CLEARBOXES();

                txt_total.Text = (from DataGridViewRow row in grid_commande.Rows
                                  where row.Cells[6].FormattedValue.ToString() != string.Empty
                                  select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
        }

        private void grid_commande_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_productid.Text = this.grid_commande.CurrentRow.Cells[0].Value.ToString();
                txt_libleproduct.Text = this.grid_commande.CurrentRow.Cells[1].Value.ToString();
                txt_prixproduct.Text = this.grid_commande.CurrentRow.Cells[2].Value.ToString();
                txt_quantite.Text = this.grid_commande.CurrentRow.Cells[3].Value.ToString();
                txt_amount.Text = this.grid_commande.CurrentRow.Cells[4].Value.ToString();
                txt_remise.Text = this.grid_commande.CurrentRow.Cells[5].Value.ToString();
                txt_totalG.Text = this.grid_commande.CurrentRow.Cells[6].Value.ToString();
                grid_commande.Rows.RemoveAt(grid_commande.CurrentRow.Index);
            }
            catch
            {
                return;
            }
        }

        private void grid_commande_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txt_total.Text = (from DataGridViewRow row in grid_commande.Rows
                              where row.Cells[6].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_commande_DoubleClick(sender, e);
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grid_commande.Rows.RemoveAt(grid_commande.CurrentRow.Index);
        }

        private void deleteAllRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DT.Clear();
            grid_commande.Refresh();
        }


        private void btn_valide_Click(object sender, EventArgs e)
        {
            if (txt_custid.Text == string.Empty || txt_orderid.Text == string.Empty || txt_desorder.Text == string.Empty || grid_commande.Rows.Count < 1)
            {
                MessageBox.Show("REMPLIRE TOUS LES CHAMPS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            order.ADD_ORDER(Convert.ToInt32(txt_orderid.Text), dateorder.Value, Convert.ToInt32(txt_custid.Text), txt_desorder.Text, txt_user.Text);
            for (int i = 0; i < grid_commande.Rows.Count - 1; i++)
            {
                order.ADD_ORDER_DETAIL(Convert.ToInt32(grid_commande.Rows[i].Cells[0].Value),
                                        Convert.ToInt32(txt_orderid.Text),
                                        Convert.ToInt32(grid_commande.Rows[i].Cells[3].Value.ToString()),
                                        grid_commande.Rows[i].Cells[2].Value.ToString(),
                                        Convert.ToInt32(grid_commande.Rows[i].Cells[5].Value.ToString()),
                                        grid_commande.Rows[i].Cells[4].Value.ToString(),
                                       Convert.ToDouble(grid_commande.Rows[i].Cells[6].Value));
            }
            MessageBox.Show("ADD COMMANDE SUCCESSFULY", "ADD COMMANDE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEARDATA();
        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {
            int order_id = Convert.ToInt32(order.GET_LAST_ORDER_FORPrint().Rows[0][0]);
            RPT.rpt_orders report = new RPT.rpt_orders();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            report.SetDataSource(order.GET_ORDER_DETAIL(order_id));
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
        }
    }
}
