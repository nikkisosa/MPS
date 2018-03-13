using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MPSystem.Model
{
    class splashModel
    {
        private static string str = string.Empty;
        public static string addAvailablePorts(Entity.variables entity){

            string query = "INSERT INTO availablePorts([port],[network],[mobile],[balance]) VALUES (@port,@network,@mobile_no,@balance);";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            
            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@port", entity.port);
                cmd.Parameters.AddWithValue("@network", entity.network);
                cmd.Parameters.AddWithValue("@mobile_no", entity.mobile_no);
                cmd.Parameters.AddWithValue("@balance", entity.balance);
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

        public static string getMobileNetwork(string mobilePrefix)
        {
            string query = "SELECT * FROM mobilePrefix where mobilePrefix = @mobilePrefix";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            try
            {
                config.records = new List<Entity.variables>();
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@mobilePrefix", mobilePrefix);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Entity.variables ent = new Entity.variables();
                    str = reader["mobileNetwork"].ToString();
                    
                }
                
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

        public static string deleteAvailablePorts()
        {
            string query = "DELETE FROM availablePorts";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.ExecuteReader();
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
