using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MobilePromotionSystem
{
    class config
    {
        private static string sqlCon = @"Data Source=(localdb)\Projects;AttachDbFilename=D:\MPS\MobilePromotionSystem\MobilePromotionSystem\MPS_DB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        public static SqlConnection sqlconnection = new SqlConnection(sqlCon);

        public static List<Entity.Contacts> records = new List<Entity.Contacts>();
        public static Entity.Contacts record = new Entity.Contacts();
    }
}
