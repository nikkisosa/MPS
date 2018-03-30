using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MPSystem.Model
{
    class promotionModel
    {
        private static string str = string.Empty;

        public static string addPromotion(Entity.variables ent)
        {

            string query = "INSERT INTO promotion([title],[details],[sendto]) VALUES (@title,@details,@sendto);";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@title", ent.promotionTitle);
                cmd.Parameters.AddWithValue("@details", ent.details);
                cmd.Parameters.AddWithValue("@sendto", ent.sendTo);
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

        public static string addLastSentPromotion(Entity.variables ent)
        {

            string query = "INSERT INTO lastPromoSent([lastPromoSent],[mobile_no]) VALUES (@lastpromo,@mobile_no);";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@lastpromo", ent.promotionTitle);
                cmd.Parameters.AddWithValue("@mobile_no", ent.mobile_no);
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

        public static string editPromotion(Entity.variables ent)
        {

            string query = "UPDATE promotion SET [title] = @title,[details] = @details,[sendto] = @sendto WHERE id = @id;";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@title", ent.promotionTitle);
                cmd.Parameters.AddWithValue("@details", ent.details);
                cmd.Parameters.AddWithValue("@sendto", ent.sendTo);
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

        public static string getPromotion()
        {
            string query = "SELECT * FROM promotion";
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
                    ent.promotionTitle = reader["title"].ToString();
                    ent.details = reader["details"].ToString();
                    ent.sendTo = reader["sendto"].ToString();
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

        public static string getGroupMembersNumber(string group)
        {
            string query = "SELECT mobile_no FROM contact WHERE [group] = @group ";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            try
            {
                config.records = new List<Entity.variables>();
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@group", group);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Entity.variables ent = new Entity.variables();
                    ent.mobile_no = reader["mobile_no"].ToString();
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

        public static string deletePromotion(int id)
        {
            string query = "DELETE FROM promotion WHERE id = @id";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", id);
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
