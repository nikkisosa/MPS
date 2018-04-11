using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MPSystem.Model
{
    class messageModel
    {
        private static string str = string.Empty;

        public static string getMessage(int page,string search = ""){
            int pages = (Entity.variables.pageSize * (page - 1));
            string query = "";
            if(search == "")
            {
                query = "SELECT * FROM messages ORDER BY id DESC OFFSET " + pages + " ROWS FETCH NEXT " + Entity.variables.pageSize + " ROWS ONLY";
            }
            else
            {
                query = "SELECT * FROM messages WHERE mobile_no = @search OR message = @search OR lastPromoSent = @search ORDER BY id DESC OFFSET " + pages + " ROWS FETCH NEXT " + Entity.variables.pageSize + " ROWS ONLY";
            }
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            try
            {
                config.records = new List<Entity.variables>();
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                if (search == "")
                {
                }
                else
                {
                    cmd.Parameters.AddWithValue("@search", search);
                }
                
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Entity.variables ent = new Entity.variables();
                    ent.id = Convert.ToInt32(reader["Id"].ToString());
                    ent.mobile_no = reader["mobile_no"].ToString();
                    ent.message = reader["message"].ToString();
                    ent.dateCreated = reader["created_at"].ToString();
                    ent.promotionTitle = reader["lastPromoSent"].ToString();
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
            string query = "SELECT COUNT(id) FROM messages";
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
