using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPSystem
{
    public partial class SplashForm : Form
    {
        public static string[,] activePorts;
        public SplashForm()
        {
            InitializeComponent();
        }
        private void SplashForm_Load(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();

        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int portCounter = SerialPort.GetPortNames().Length;
            var tasks = new List<Task>();
            string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length;i++ )
                foreach (string port in ports)
                {
                    try
                    {

                        SerialPort sp = new SerialPort();
                        sp.PortName = ports[i];
                        sp.BaudRate = 115200;
                        sp.Parity = Parity.None;
                        sp.StopBits = StopBits.One;
                        sp.DataBits = 8;
                        sp.Handshake = Handshake.None;
                        sp.RtsEnable = true;
                        sp.NewLine = "\n";

                        //sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);


                        sp.Open();



                        Task task = Task.Factory.StartNew(() =>
                         {

                             if (sp.IsOpen)
                             {
                                 string portName = sp.PortName;
                                 Thread.Sleep(1000);
                                 sp.WriteLine("AT\r");
                                 Thread.Sleep(2000);

                                 string result = sp.ReadExisting();
                                 if (result.Contains("OK"))
                                 {
                                     sp.WriteLine("AT+CNUM\r");
                                     Thread.Sleep(2000);
                                     string cmdReadMobileNo = sp.ReadExisting();
                                     string[] lineResult = cmdReadMobileNo.Split(
                                         new[] { Environment.NewLine },
                                         StringSplitOptions.None
                                     );
                                     string[] strCNUM = lineResult[2].Split(',');


                                     activePorts = new string[,] { { sp.PortName, strCNUM[1] } };

                                 }


                             }


                         });

                        task.Wait();
                        double percentage = (double)(i + 1) / (double)ports.Length;
                        Action<double> update = p =>
                        {
                            progressBar.Value = (int)Math.Round(p * 100);
                        };
                        this.Invoke(update, percentage);

                    }
                    catch(Exception exs){

                    }
                    finally
                    {

                    }
                }


           

            
           
            //Task entireTask = Task.WhenAll(tasks.ToArray());
            //Task progressTask = Task.Run(async () =>
            //{
            //    while (!entireTask.IsCompleted)
            //    {
            //        await Task.Delay(1000);
            //    }

            //});
            //entireTask.Wait();
        }



        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                progressBar.Value = 0;
            }
            else
            {
                MMS mainForm = new MMS();
                mainForm.Show();
                this.Hide();
            }
        }

        public void HeavyJob()
        {

        }




    }
}
