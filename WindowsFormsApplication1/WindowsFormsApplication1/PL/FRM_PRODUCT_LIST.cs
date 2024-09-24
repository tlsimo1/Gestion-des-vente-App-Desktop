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
    public partial class FRM_PRODUCT_LIST : Form
    {
        BL.CLS_PRODUCT prod = new BL.CLS_PRODUCT();
        public FRM_PRODUCT_LIST()
        {
            InitializeComponent();
            this.gridAllProduct.DataSource = prod.GET_ALL_PRODUCT();
        }

        private void gridAllProduct_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
