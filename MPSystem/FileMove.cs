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
            string path = Application.StartupPath.ToString() + @"\DATA";
            string appData = Environment.ExpandEnvironmentVariables(@"%AppData%\MPS\Data");
            if (!Directory.Exists(appData))
            {
                System.IO.Directory.CreateDirectory(appData);
                //File.Move(path, appData);
                //File.Move(path2, appData);
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                FileInfo[] copy = dirInfo.GetFiles();
                foreach (FileInfo fi in copy)
                {
                    try
                    {
                        File.Copy(fi.FullName, appData + fi.Name);
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

            }
            return str;
        }
    }
}
