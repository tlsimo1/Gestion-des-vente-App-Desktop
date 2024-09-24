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
    public partial class FRM_CUSTOMERSLIST : Form
    {
        BL.CLS_CUSTOMER cust = new BL.CLS_CUSTOMER();
        public FRM_CUSTOMERSLIST()
        {
            InitializeComponent();
            this.gridcustomerlist.DataSource = cust.GET_ALL_CUSTOMERS();
            this.gridcustomerlist.Columns[0].Visible=false;
            this.gridcustomerlist.Columns[5].Visible = false;
        }

        private void gridcustomerlist_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
