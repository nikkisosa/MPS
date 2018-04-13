using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MPSystem.Model
{
    class contactModel
    {
        private static string str = string.Empty;
        public static string addContact(Entity.variables ent){
            
            string query = "INSERT INTO contact([mobile_no],[network],[group]) VALUES (@mobile_no,@network,@group);";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();
            
            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@mobile_no",ent.mobile_no);
                cmd.Parameters.AddWithValue("@network", ent.network);
                cmd.Parameters.AddWithValue("@group", ent.group);
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

        public static string editContact(Entity.variables ent)
        {

            string query = "UPDATE contact SET [mobile_no] = @mobile_no,[network] = @network,[group] = @group WHERE id = @id;";
            SqlConnection conn = config.sqlconnection;
            SqlCommand cmd = new SqlCommand();

            try
            {
                conn.Open();
                cmd.CommandText = query;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@mobile_no", ent.mobile_no);
                cmd.Parameters.AddWithValue("@network", ent.network);
                cmd.Parameters.AddWithValue("@group", ent.group);
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

        public static string getContacts(int page, string filter = "All", string search = "All")
        {
            int pages = (Entity.variables.pageSize * (page - 1));
            string query = "";
            if (filter == "All")
            {
                query = "SELECT * FROM contact ORDER BY id DESC OFFSET " + pages + " ROWS FETCH NEXT " + Entity.variables.pageSize + " ROWS ONLY";
            }
            else if (filter == "Mobile No")
            {
                query = "SELECT * FROM contact WHERE mobile_no = @search ORDER BY id DESC OFFSET " + pages + " ROWS FETCH NEXT " + Entity.variables.pageSize + " ROWS ONLY";
            }
            else if (filter == "Network")
            {
                query = "SELECT * FROM contact WHERE network = @search  ORDER BY id DESC OFFSET " + pages + " ROWS FETCH NEXT " + Entity.variables.pageSize + " ROWS ONLY";
            }
            else if (filter == "Group")
            {
                query = "SELECT * FROM contact WHERE [group] = @search  ORDER BY id DESC OFFSET " + pages + " ROWS FETCH NEXT " + Entity.variables.pageSize + " ROWS ONLY";
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
                if(filter == "All")
                {

                }
                else if (filter != "All")
                {
                    cmd.Parameters.AddWithValue("@search", search);
                }
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Entity.variables ent = new Entity.variables();
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

        public static string getTotalPage()
        {
            string query = "SELECT COUNT(id) FROM contact";
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

        public static string deleteContact(int id)
        {
            string query = "DELETE FROM contact WHERE id = @id";
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
