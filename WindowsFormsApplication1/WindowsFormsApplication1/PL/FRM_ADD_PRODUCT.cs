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

namespace WindowsFormsApplication1.PL
{
    public partial class FRM_ADD_PRODUCT : Form
    {
        public string state = "ADD";
        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();

            cmb_cat.DataSource = prd.Get_ALL_Caterories();
            cmb_cat.DisplayMember = "DESCRIPTION_CAT";
            cmb_cat.ValueMember = "ID_CAT";

        }

        private void btn_browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Image Browser |*.JPG;*.PNG;*.BMP;*.GIF";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(OFD.FileName);
            }

        }

        private void FRM_ADD_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void btn_ADD_Click(object sender, EventArgs e)
        {
            if (state == "ADD")
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                prd.ADD_PRODUCT(Convert.ToInt32(cmb_cat.SelectedValue), txt_des.Text, Convert.ToInt32(txt_stock.Text),
                   txt_price.Text, Convert.ToInt32(txt_productid.Text), byteimage);

                MessageBox.Show("ADD PRODUCT SUCCESS ....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                prd.UPDATE_PRODUCT(Convert.ToInt32(cmb_cat.SelectedValue), txt_des.Text, Convert.ToInt32(txt_stock.Text),
                   txt_price.Text, Convert.ToInt32(txt_productid.Text), byteimage);

                MessageBox.Show("UPDATING PRODUCT SUCCESS ....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FRM_PRODUCTS.getMainForm.gridlistproduct.DataSource = prd.GET_ALL_PRODUCT();
        }

        private void txt_productid_Validated(object sender, EventArgs e)
        {
            try
            {
                if (state == "ADD")
                {
                    DataTable DT = new DataTable();
                    DT = prd.VERIFYPRODUCT(Convert.ToInt32(txt_productid.Text));
                    if (DT.Rows.Count > 0)
                    {
                        MessageBox.Show("ID EXIXST DEJA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_productid.Focus();
                        txt_productid.SelectionStart = 0;
                        txt_productid.SelectionLength = txt_productid.TextLength;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_productid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
