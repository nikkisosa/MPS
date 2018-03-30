using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MPSystem.Model
{
    class MainFormModel
    {
        private static string str = string.Empty;


        //Get all the Active Ports
        public static string getActivePorts()
        {
            string query = "SELECT * FROM availablePorts";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            try
            {
                config.records = new List<Entity.variables>();
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Entity.variables ent = new Entity.variables();
                    ent.port = reader["port"].ToString();
                    ent.network = reader["network"].ToString();
                    ent.mobile_no = reader["mobile"].ToString();
                    ent.balance = Convert.ToInt32(reader["balance"].ToString());
                    config.records.Add(ent);
                }
                str = "success";
            }
            catch (SqlException err)
            {
                str = err.Message;
            }
            finally
            {
                conn.Close();
            }
            return str;
        }

        public static List<string> getListActivePorts()
        {
            var activePorts = new List<string>();
            string query = "SELECT * FROM availablePorts";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            try
            {
                
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    activePorts.Add(reader["port"].ToString());
                    
                }
                
            }
            catch (SqlException err)
            {
                logs.log(err.Message);
            }
            finally
            {
                conn.Close();
            }
            return activePorts;
        }


        public static string addMessages(Entity.variables ent)
        {

            string query = "INSERT INTO messages([mobile_no],[message],[lastPromoSent]) VALUES (@mobile_no,@message,@lastPromoSent);";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@mobile_no", ent.mobile_no);
                cmd.Parameters.AddWithValue("@message", ent.message);
                cmd.Parameters.AddWithValue("@lastPromoSent", ent.promotionTitle);
                cmd.ExecuteNonQuery();
                str = "success";
            }
            catch (SqlException err)
            {
                str = err.Message;
            }
            finally
            {
                conn.Close();
            }
            return str;
        }

        public static string getLastPromo(string mobileNo)
        {
            string query = "SELECT TOP 1 * FROM lastPromoSent where [mobile_no] = @mobile_no Order by [sentDate] DESC";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            try
            {
                
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@mobile_no", mobileNo);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    

                    str = reader["lastPromoSent"].ToString();
                    
                }
                //str = "success";
            }
            catch (SqlException err)
            {
                //str = err.Message;
                logs.log(err.Message);
            }
            finally
            {
                conn.Close();
            }
            return str;
        }

        public static string checkMobileLastPromo(string mobileNo)
        {
            string query = "SELECT TOP 1 * FROM lastPromoSent where [mobile_no] = @mobile_no Order by [sentDate] DESC";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            try
            {

                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@mobile_no", mobileNo);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    str = "success";
                }else
                {
                    str = mobileNo;
                }

            }
            catch (SqlException err)
            {
                //str = err.Message;
                logs.log(err.Message);
            }
            finally
            {
                conn.Close();
            }
            return str;
        }






    }

}
