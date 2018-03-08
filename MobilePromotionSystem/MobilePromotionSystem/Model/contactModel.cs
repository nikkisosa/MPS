using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MobilePromotionSystem.Model
{
    class contactModel
    {
        private static string str = string.Empty;
        public static string addContact(Entity.Contacts ent){
            
            string query = "INSERT INTO contact([mobile_no],[network]) VALUES (@mobile_no,@network);";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            
            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@mobile_no",ent.mobile_no);
                cmd.Parameters.AddWithValue("@network", ent.network);
                cmd.ExecuteNonQuery();
                str = "success";
            }
            catch(SqlException err)
            {
                str = err.Message;
            }
            finally
            {
                conn.Close();
            }
            return str;
        }

        public static string getContacts(){
            string query = "SELECT * FROM contact";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            try
            {
                config.records = new List<Entity.Contacts>();
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Entity.Contacts ent = new Entity.Contacts();
                    ent.id = Convert.ToInt32(reader["id"].ToString());
                    ent.mobile_no = reader["mobile_no"].ToString();
                    ent.network = reader["network"].ToString();
                    ent.group = reader["group"].ToString();
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
    }

}
