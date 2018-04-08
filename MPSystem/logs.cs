using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace MPSystem
{
    class logs
    {
        private static string path = string.Empty;
        private static string directory;
        private static string str = string.Empty;
        public static string log(string message)
        {
            try
            {
                directory = Application.StartupPath.ToString() + @"\Logs";
                System.IO.Directory.CreateDirectory(directory); // create if exist and if exist ignore
                path = System.IO.Path.GetFullPath(Application.StartupPath.ToString()+@"\Logs\logs-"+DateTime.Now.ToString("yyyy-MM-dd")+".txt");
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                    File.AppendAllLines(path, new[] { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " [" + message + "]" });
                    str = "success";
                }
                else if (File.Exists(path))
                {
                    File.AppendAllLines(path, new[] { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " [" + message + "]" });
                    str = "success";
                }
            }
            catch(IOException e)
            {
                str = e.Message;
            }
            finally
            {
                
            }
            
            return str;
        }

        public static string dumpContact(string number,string prefix,string sim)
        {
            try
            {
                directory = Application.StartupPath.ToString() + @"\Dump";
                System.IO.Directory.CreateDirectory(directory); // create if exist and if exist ignore
                path = System.IO.Path.GetFullPath(Application.StartupPath.ToString() + @"\Dump\Dump-"+ sim + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt");
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                    File.AppendAllLines(path, new[] { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " [Mobile Number (" + number + ") Prefix (" + prefix + ") Sim (" + sim + ")]" });
                    str = "success";
                }
                else if (File.Exists(path))
                {
                    File.AppendAllLines(path, new[] { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " [Mobile Number (" + number + ") Prefix (" + prefix + ") Sim (" + sim + ")]" });
                    str = "success";
                }
            }
            catch (IOException e)
            {
                str = e.Message;
            }
            finally
            {

            }

            return str;
        }
    }
}
