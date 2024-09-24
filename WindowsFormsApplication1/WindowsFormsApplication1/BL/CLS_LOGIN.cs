using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WindowsFormsApplication1.BL
{
    class CLS_LOGIN
    {
        public DataTable LOGIN(string ID,string PWD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter [] param =new SqlParameter[2];

            param[0] = new SqlParameter("ID",SqlDbType.VarChar,50);
            param[0].Value = ID;

            param[1] = new SqlParameter("PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;

            
            DataTable DT = new DataTable();
            DT = DAL.SelectData("SP_LOGIN",param);
            DAL.Close();
            return DT;
        }
        public void ADD_USER(string ID , string FullName, string PWD , string UserType)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            param[1].Value = FullName;

            param[2] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[2].Value = PWD;

            param[3] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[3].Value = UserType;

            DAL.ExecuteCommande("ADD_USER", param);
            DAL.Close();
        }
        public void DELETE_USER( string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DAL.ExecuteCommande("DELETE_USER", param);
            DAL.Close();
        }
        public void EDIT_USER(string ID, string FullName, string PWD, string UserType)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@FullName", SqlDbType.VarChar, 50);
            param[1].Value = FullName;

            param[2] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[2].Value = PWD;

            param[3] = new SqlParameter("@UserType", SqlDbType.VarChar, 50);
            param[3].Value = UserType;

            DAL.ExecuteCommande("EDIT_USER", param);
            DAL.Close();
        }
        public DataTable SEARCH_USER(string Critirion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Critirion", SqlDbType.VarChar, 50);
            param[0].Value = Critirion;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("SEARCH_USER", param);
            DAL.Close();
            return DT;
        }
        
    }
}
