using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.BL
{
    class CLS_CUSTOMER
    {
        public DataTable GET_ALL_CUSTOMERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_CUSTOMERS", null);
            DAL.Close();
            return DT;
        }
        public DataTable SEARSH_CUSTOMER(string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;

            DT = DAL.SelectData("SEARSH_CUSTOMER", param);
            DAL.Close();
            return DT;
        }
        public void ADD_CUSTOMER(string FIRST_NAME, string LAST_NAME, string TEL, string EMAIL, byte[] img, string Criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@firsName", SqlDbType.VarChar, 50);
            param[0].Value = FIRST_NAME;

            param[1] = new SqlParameter("@lastName", SqlDbType.VarChar, 50);
            param[1].Value = LAST_NAME;

            param[2] = new SqlParameter("@tel", SqlDbType.NChar);
            param[2].Value = TEL;

            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 50);
            param[3].Value = EMAIL;

            param[4] = new SqlParameter("@image", SqlDbType.Image);
            param[4].Value = img;

            param[5] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[5].Value = Criterion;

            DAL.ExecuteCommande("ADD_CUSTOMER", param);
            DAL.Close();
        }
        public void UPDATE_CUSTOMER(string FIRST_NAME, string LAST_NAME, string TEL, string EMAIL, byte[] img, string Criterion,int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@firsName", SqlDbType.VarChar, 50);
            param[0].Value = FIRST_NAME;

            param[1] = new SqlParameter("@lastName", SqlDbType.VarChar, 50);
            param[1].Value = LAST_NAME;

            param[2] = new SqlParameter("@tel", SqlDbType.NChar);
            param[2].Value = TEL;

            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 50);
            param[3].Value = EMAIL;

            param[4] = new SqlParameter("@image", SqlDbType.Image);
            param[4].Value = img;

            param[5] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[5].Value = Criterion;

            param[6] = new SqlParameter("@ID", SqlDbType.Int);
            param[6].Value = ID;

            DAL.ExecuteCommande("UPDATE_CUSTOMER", param);
            DAL.Close();
        }

        public void DELETE_CUSTOMER(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommande("DELETE_CUSTOMER", param);
            DAL.Close();
        }
    }
}
