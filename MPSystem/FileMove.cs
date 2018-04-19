using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace MPSystem
{
    class FileMove
    {
        public static string str = string.Empty;

        public static string moveToAppData()
        {
            string path = Application.StartupPath.ToString() + @"\DATA\";
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+"\\MPS\\";
            string fileName = "MPS_DB.MDF";
            if (!Directory.Exists(appData))
            {
                System.IO.Directory.CreateDirectory(appData);
                //File.Move(path, appData);
                //File.Move(path2, appData);
                try
                {
                    File.Copy(path + fileName, appData + fileName, false);
                    str = "success";
                }
                catch (IOException io)
                {
                    str = io.Message;
                    logs.log(io.Message);
                }
                finally
                {

                }

            }
            return str;
        }
    }
}
