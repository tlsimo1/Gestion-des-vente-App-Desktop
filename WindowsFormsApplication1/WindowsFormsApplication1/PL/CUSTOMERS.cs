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

namespace WindowsFormsApplication1.PL
{
    public partial class CUSTOMERS : Form
    {
        BL.CLS_CUSTOMER cust = new BL.CLS_CUSTOMER();
        int ID, position;
        public CUSTOMERS()
        {
            InitializeComponent();
            this.gridcustomers.DataSource = cust.GET_ALL_CUSTOMERS();
            gridcustomers.Columns[0].Visible=false;
            gridcustomers.Columns[5].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] picture;
                if(picCustomer.Image==null)
                {
                    picture=new byte[0];
                    cust.ADD_CUSTOMER(txt_firstname.Text, txt_lastname.Text, txt_tel.Text, txt_emeil.Text, picture, "without_image");
                    MessageBox.Show("ADD CATEGORIE SUCCESSfULY", "ADD CATEGORIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.gridcustomers.DataSource = cust.GET_ALL_CUSTOMERS();
                }
                MemoryStream ms = new MemoryStream();
                picCustomer.Image.Save(ms, picCustomer.Image.RawFormat);
                picture = ms.ToArray();
                cust.ADD_CUSTOMER(txt_firstname.Text, txt_lastname.Text, txt_tel.Text, txt_emeil.Text, picture, "with_image");
                MessageBox.Show("ADD CATEGORIE SUCCESSfULY", "ADD CATEGORIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gridcustomers.DataSource = cust.GET_ALL_CUSTOMERS();
            }
            catch
            {
                return;
            }
            finally
            {
                btn_add.Enabled = false;
                btn_new.Enabled = true;
            }
        }

        private void picCustomer_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Image Browser |*.JPG;*.PNG;*.BMP;*.GIF";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                picCustomer.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void CUSTOMERS_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_tel.Clear();
            txt_emeil.Clear();
            picCustomer.Image = null;
            txt_firstname.Focus();
            btn_add.Enabled = true;
            btn_new.Enabled = false;
        }

        private void txt_firstname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txt_lastname.Focus();
            }
        }

        private void txt_lastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_tel.Focus();
            }
        }

        private void txt_tel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_emeil.Focus();
            }
        }

        private void txt_emeil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.Focus();
            }
        }

        private void gridcustomers_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                picCustomer.Image = null;
                ID =Convert.ToInt32(gridcustomers.CurrentRow.Cells[0].Value);
                this.txt_firstname.Text = gridcustomers.CurrentRow.Cells[1].Value.ToString();
                this.txt_lastname.Text = gridcustomers.CurrentRow.Cells[2].Value.ToString();
                this.txt_tel.Text = gridcustomers.CurrentRow.Cells[3].Value.ToString();
                this.txt_emeil.Text = gridcustomers.CurrentRow.Cells[4].Value.ToString();
                byte[] picture = (byte[])gridcustomers.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(picture);
                picCustomer.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID == 0)
                {
                    MessageBox.Show("CETTE ELEMENT N'EXIXST PAS");
                    return;
                }
                byte[] picture;
                if (picCustomer.Image == null)
                {
                    picture = new byte[0];
                    cust.UPDATE_CUSTOMER(txt_firstname.Text, txt_lastname.Text, txt_tel.Text, txt_emeil.Text, picture, "without_image",ID);
                    MessageBox.Show("UPDATING CATEGORIE SUCCESSfULY", "UPDATE CATEGORIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.gridcustomers.DataSource = cust.GET_ALL_CUSTOMERS();
                }
                MemoryStream ms = new MemoryStream();
                picCustomer.Image.Save(ms, picCustomer.Image.RawFormat);
                picture = ms.ToArray();
                cust.UPDATE_CUSTOMER(txt_firstname.Text, txt_lastname.Text, txt_tel.Text, txt_emeil.Text, picture, "with_image",ID);
                MessageBox.Show("UPDATING CATEGORIE SUCCESSfULY", "UPDATE CATEGORIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gridcustomers.DataSource = cust.GET_ALL_CUSTOMERS();
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(ID==0)
            {
                MessageBox.Show("CETTE ELEMENT N'EXIXST PAS");
                return;
            }
            if(MessageBox.Show("VOULEZ VOUS VRAIMENT SUPPRIMER CETTE USER","CONFIRMATION",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                cust.DELETE_CUSTOMER(ID);
                MessageBox.Show("DELETING CATEGORIE SUCCESSfULY", "DELETE CATEGORIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.gridcustomers.DataSource = cust.GET_ALL_CUSTOMERS();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.gridcustomers.DataSource = cust.SEARSH_CUSTOMER(txt_search.Text);
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btn_search_Click(sender,e);
            }
        }
        private void Navigate(int Index)
        {
            try
            {
                picCustomer.Image = null;
                DataRowCollection DRC = cust.GET_ALL_CUSTOMERS().Rows;
                ID = Convert.ToInt32((DRC[Index][0]));
                txt_firstname.Text = DRC[Index][1].ToString();
                txt_lastname.Text = DRC[Index][2].ToString();
                txt_tel.Text = DRC[Index][3].ToString();
                txt_emeil.Text = DRC[Index][4].ToString();
                byte[] picture = (byte[])DRC[Index][5];
                MemoryStream ms = new MemoryStream(picture);
                picCustomer.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }

        private void btn_pr_Click(object sender, EventArgs e)
        {
            Navigate(0);
        }

        private void btn_dernier_Click(object sender, EventArgs e)
        {
            position = cust.GET_ALL_CUSTOMERS().Rows.Count - 1;
            Navigate(position);
        }

        private void btn_prc_Click(object sender, EventArgs e)
        {
            if (position==0)
            {
                MessageBox.Show("C'EST LE PREMIER ELEMENT");
            }
            position -= 1;
            Navigate(position);
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            if (position == cust.GET_ALL_CUSTOMERS().Rows.Count-1)
            {
                MessageBox.Show("C'EST LE DERNIER ELEMENT");
            }
            position += 1;
            Navigate(position);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
