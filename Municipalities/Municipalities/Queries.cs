using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Municipalities
{
    public class Queries
    {
        private SqlConnection conn;
        public Queries()
        {
            string cstring = ConfigurationManager.ConnectionStrings["sqlServer"].ConnectionString;
            conn = new SqlConnection(cstring);
        }
        
        private void openConnection()
        {
            try
            {
                conn.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        private void closeConnection()
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        public List<Municipality> selectMunicipalities()
        {
            List<Municipality> result = new List<Municipality>();
            try
            {
                openConnection();
                string sql = "select * from municipalities";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Municipality mun = new Municipality();
                    mun.OB_ID = Int32.Parse(reader.GetValue(0)+"");
                    mun.OB_NAME = reader.GetValue(1) + "";
                    mun.OB_UNAME = reader.GetValue(2) + "";
                    result.Add(mun);
                }
                closeConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            return result;
        }
    }
}