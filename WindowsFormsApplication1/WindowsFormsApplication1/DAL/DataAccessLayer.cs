using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;
        public DataAccessLayer()
        {
            string mode = Properties.Settings.Default.Mode;
            if(mode=="SQL")
            {
                sqlconnection = new SqlConnection(@"Server=" +
                Properties.Settings.Default.Server + ";Database=" +
                Properties.Settings.Default.Database + ";Integrated Security=false;User ID="+
                Properties.Settings.Default.ID+";Password="+
                Properties.Settings.Default.Password+"");
            }
            else
            {
                sqlconnection = new SqlConnection(@"Server=" + 
                Properties.Settings.Default.Server + ";Database=" + 
                Properties.Settings.Default.Database + ";Integrated Security=true");

            }
            
        }
        public void Open()
        {
            if(sqlconnection.State!=ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Closed)
            {
                sqlconnection.Close();
            }
        }

        // method to read data from database

        public DataTable SelectData(string Stored_procedure,SqlParameter[] param)
        {
            
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = Stored_procedure;
                sqlcmd.Connection = sqlconnection;
                if (param != null)
                {
                    for (int i = 0; i < param.Length; i++)
                    {
                        sqlcmd.Parameters.Add(param[i]);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
           
        }
        // method to insert update delete data from database
        public void ExecuteCommande(string Stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                    sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
            
        }




    }
}
