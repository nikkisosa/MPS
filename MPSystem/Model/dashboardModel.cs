using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MPSystem.Model
{
    class dashBoardModel
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


        //Get the balance of the selected Ports/Mobile No.
        public static string getBalance(){
            
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
                    //ent.id = Convert.ToInt32(reader["id"].ToString());
                    //ent.mobile_no = reader["mobile_no"].ToString();
                    //ent.network = reader["network"].ToString();
                    //ent.group = reader["group"].ToString();
                    //config.records.Add(ent);
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
                logs.log("List of Active Ports Error: "+ err.Message);
            }
            finally
            {
                conn.Close();
            }
            return activePorts;
        }

        
 

        

       
    }

}
