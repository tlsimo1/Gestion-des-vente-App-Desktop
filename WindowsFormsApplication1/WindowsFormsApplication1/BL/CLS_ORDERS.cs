using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.BL
{
    class CLS_ORDERS
    {
        public DataTable GET_LAST_ORDER_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_LAST_ORDER_ID", null);
            DAL.Close();
            return DT;
        }
        public DataTable GET_LAST_ORDER_FORPrint()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_LAST_ORDER_FORPrint", null);
            DAL.Close();
            return DT;
        }
        public void ADD_ORDER(int ID_ORDER, DateTime DATE_ORDER, int CUSTOMER_ID, string DESCRIPTION_ORDER, string SALESMAN)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[0].Value = ID_ORDER;

            param[1] = new SqlParameter("@DATE_ORDER", SqlDbType.DateTime);
            param[1].Value = DATE_ORDER;

            param[2] = new SqlParameter("@CUSTOMER_ID", SqlDbType.Int);
            param[2].Value = CUSTOMER_ID;

            param[3] = new SqlParameter("@DESCRIPTION_ORDER", SqlDbType.VarChar, 150);
            param[3].Value = DESCRIPTION_ORDER;

            param[4] = new SqlParameter("@SALESMAN", SqlDbType.VarChar,50);
            param[4].Value = SALESMAN;


            DAL.ExecuteCommande("ADD_ORDER", param);
            DAL.Close();
        }
        public void ADD_ORDER_DETAIL(int ID_PRODUCT, int ID_ORDER, int QTE, string PRICE, float DISCOUNT, string AMOUNT, double TOTAL_AMOUNT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@ID_PRODUCT", SqlDbType.Int);
            param[0].Value = ID_PRODUCT;

            param[1] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            param[1].Value = ID_ORDER;

            param[2] = new SqlParameter("@QTE", SqlDbType.Int);
            param[2].Value = QTE;

            param[3] = new SqlParameter("@PRICE", SqlDbType.VarChar, 150);
            param[3].Value = PRICE;

            param[4] = new SqlParameter("@DISCOUNT", SqlDbType.Float);
            param[4].Value = DISCOUNT;

            param[5] = new SqlParameter("@AMOUNT", SqlDbType.VarChar, 50);
            param[5].Value = AMOUNT;

            param[6] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.Float);
            param[6].Value = TOTAL_AMOUNT;


            DAL.ExecuteCommande("ADD_ORDER_DETAIL", param);
            DAL.Close();
        }
        public DataTable VERIFY_QTE(int ID_PRODUCT,int QTE_STQ)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID_Product_ID", SqlDbType.Int);
            param[0].Value = ID_PRODUCT;

            param[1] = new SqlParameter("@PRODUCT_QTE", SqlDbType.Int);
            param[1].Value = QTE_STQ;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("VERIFY_QTE", param);
            DAL.Close();
            return DT;
        }
        public DataTable GET_ORDER_DETAIL(int ID_ORDERS)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ORDER_ID", SqlDbType.Int);
            param[0].Value = ID_ORDERS;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ORDER_DETAIL", param);
            DAL.Close();
            return DT;
        }
        public DataTable SEARCHORDERS(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("SEARCHORDERS", param);
            DAL.Close();
            return DT;
        }
    }
}
