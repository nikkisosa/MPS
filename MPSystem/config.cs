﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MPSystem
{
    class config
    {

        //private static string sqlCon = @"Data Source=(localdb)\V11.0;AttachDbFilename="+System.IO.Path.GetFullPath(@"..\..\DATA\MPS_DB.MDF")+";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        //private static string sqlCon = @"Data Source=(localdb)\V11.0;AttachDbFilename="+System.IO.Path.GetFullPath(@"DATA\MPS_DB.MDF")+";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        //private static string sqlCon = @"Data Source=(localdb)\V11.0;AttachDbFilename=" + Application.StartupPath.ToString()+@"\DATA\MPS_DB.MDF" + ";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        private static string sqlCon = @"Data Source=(localdb)\V11.0;AttachDbFilename=" + Environment.ExpandEnvironmentVariables(@"%AppData%\MPS\MPS_DB.MDF") + ";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        public static SqlConnection sqlconnection = new SqlConnection(sqlCon);

        public static List<Entity.variables> records = new List<Entity.variables>();
        public static Entity.variables record = new Entity.variables();
    }
}
