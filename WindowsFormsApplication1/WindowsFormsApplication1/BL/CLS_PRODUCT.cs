using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.BL
{
    class CLS_PRODUCT
    {

        public DataTable Get_ALL_Caterories()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
    
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_ALL_Caterories", null);
            DAL.Close();
            return DT;
        }
       
        public void ADD_PRODUCT(int ID_CAT,string LABEL_PRODUCT ,int QTE,string PRICE,int ID_PRODUCT,byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param=new SqlParameter[6];

            param[0]=new SqlParameter("@ID_CAT",SqlDbType.Int);
            param[0].Value = ID_CAT;

            param[1] = new SqlParameter("@LABEL_PRODUCT", SqlDbType.VarChar,50);
            param[1].Value = LABEL_PRODUCT;

            param[2] = new SqlParameter("@QTE", SqlDbType.Int);
            param[2].Value = QTE;

            param[3] = new SqlParameter("@PRICE",  SqlDbType.VarChar,50);
            param[3].Value = PRICE;

            param[4] = new SqlParameter("@ID_PRODUCT", SqlDbType.Int);
            param[4].Value = ID_PRODUCT;

            param[5] = new SqlParameter("@IMAGE", SqlDbType.Image);
            param[5].Value = img;
            DAL.ExecuteCommande("ADD_PRODUCT",param);
            DAL.Close();
        }
        public void UPDATE_PRODUCT(int ID_CAT, string LABEL_PRODUCT, int QTE, string PRICE, int ID_PRODUCT, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_CAT;

            param[1] = new SqlParameter("@LABEL_PRODUCT", SqlDbType.VarChar, 50);
            param[1].Value = LABEL_PRODUCT;

            param[2] = new SqlParameter("@QTE", SqlDbType.Int);
            param[2].Value = QTE;

            param[3] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[3].Value = PRICE;

            param[4] = new SqlParameter("@ID_PRODUCT", SqlDbType.Int);
            param[4].Value = ID_PRODUCT;

            param[5] = new SqlParameter("@IMAGE", SqlDbType.Image);
            param[5].Value = img;
            DAL.ExecuteCommande("UPDATE_PRODUCT", param);
            DAL.Close();
        }
        public DataTable VERIFYPRODUCT( int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DataTable DT = new DataTable();
            DT = DAL.SelectData("VERIFYPRODUCT", param);
            DAL.Close();
            return DT;
        }
        public DataTable GET_ALL_PRODUCT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
           
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_PRODUCT", null);
            DAL.Close();
            return DT;
        }
        public DataTable SERSH_PRODUCT(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar);
            param[0].Value = ID;
            DataTable DT = new DataTable();
            DT = DAL.SelectData("SERSH_PRODUCT", param);
            DAL.Close();
            return DT;
        }
        public DataTable GET_IMAGE_PRODUCT(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_IMAGE_PRODUCT", param);
            DAL.Close();
            return DT;
        }
        public void DELETE_PRODUCT(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommande("DELETE_PRODUCT", param);
            DAL.Close();
        }
    }
}
