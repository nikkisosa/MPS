using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MPSystem.Model
{
    class ussdHistoryModel
    {
        private static string str = string.Empty;

        public static string addHistory(Entity.variables ent)
        {

            string query = "INSERT INTO ussdHistory([reply],[created_at]) VALUES (@reply,@created_at);";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@reply", ent.reply);
                cmd.Parameters.AddWithValue("@created_at", ent.dateCreated);
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

        public static string getUssdHistory(int page)
        {
            int pages = (Entity.variables.pageSize * (page - 1));
            string query = "SELECT * FROM ussdHistory ORDER BY id DESC OFFSET " + pages + " ROWS FETCH NEXT " + Entity.variables.pageSize + " ROWS ONLY";
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
                    ent.reply = reader["reply"].ToString();
                    ent.dateCreated = reader["created_at"].ToString();
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
            string query = "SELECT COUNT(id) FROM ussdHistory";
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
    }
}
