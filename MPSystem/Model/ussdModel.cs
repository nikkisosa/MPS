using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MPSystem.Model
{
    class ussdModel
    {
        private static string str = string.Empty;

        public static string addUssdCommand(Entity.variables ent)
        {

            string query = "INSERT INTO ussdcommand([command],[description]) VALUES (@command,@description);";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@command", ent.command);
                cmd.Parameters.AddWithValue("@description", ent.details);
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

        public static string editUssdCommand(Entity.variables ent)
        {

            string query = "UPDATE ussdcommand SET [command] = @command,[description] = @description WHERE id = @id;";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@command", ent.command);
                cmd.Parameters.AddWithValue("@description", ent.details);
                cmd.Parameters.AddWithValue("@id", ent.id);
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

        public static string getUssdCommand(int page)
        {
            int pages = (Entity.variables.pageSize * (page - 1));
            string query = "SELECT * FROM ussdcommand ORDER BY id DESC OFFSET " + pages + " ROWS FETCH NEXT " + Entity.variables.pageSize + " ROWS ONLY";
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
                    ent.id = Convert.ToInt32(reader["id"].ToString());
                    ent.command = reader["command"].ToString();
                    ent.details = reader["description"].ToString();
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

        public static string getTotalPage()
        {
            string query = "SELECT COUNT(id) FROM ussdcommand";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            try
            {
                config.records = new List<Entity.variables>();
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                Entity.variables ent = new Entity.variables();
                ent.totalpage = (Int32)cmd.ExecuteScalar();
                config.records.Add(ent);
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

        public static string deleteUssdCommand(int id,bool all = false)
        {
            string query = string.Empty;
            if(all == true)
            {
                query = "DELETE FROM ussdcommand";
            }
            else if(all == false)
            {
                query = "DELETE FROM ussdcommand WHERE id = @id";
            }

             
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                if (all == true)
                {

                }
                else if (all == false)
                {
                    cmd.Parameters.AddWithValue("@id", id);
                }
                
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
