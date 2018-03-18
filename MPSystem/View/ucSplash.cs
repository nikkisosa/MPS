using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace MPSystem.View
{
    public partial class ucSplash : Form
    {
        public ucSplash()
        {
            InitializeComponent();
            logs.log("*****Program Started*****");
        }

        private void ucSplash_Load(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int portCounter = SerialPort.GetPortNames().Length;
            var tasks = new List<Task>();
            string[] ports = SerialPort.GetPortNames();
            logs.log("Ports: " + string.Join(",",ports));
            Model.splashModel.deleteAvailablePorts();
            for (int i = 0; i < ports.Length; i++)
            {
                try
                {
                    //Serial Ports Setting
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


                    //Creating a task to check for the available ports.
                    Task task = Task.Factory.StartNew(() =>
                    {

                        if (sp.IsOpen)
                        {
                            string portName = sp.PortName;
                           
                            sp.WriteLine("AT\r");
                            Thread.Sleep(1000);

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
                                string mobileNo = strCNUM[1].Replace('"', ' ').Trim();
                                string mobilePrefix = Model.splashModel.getMobileNetwork(mobileNo.Substring(3,3));
                                
                                Entity.variables entity = new Entity.variables();
                                entity.port = sp.PortName;
                                entity.mobile_no = mobileNo;
                                entity.network = (mobilePrefix == "success" || mobilePrefix == "") ? "Unknown Network" : mobilePrefix;
                                entity.balance = 0;

                                //Add all the active ports in [activePorts] table.
                                string addAvailablePortsResult = Model.splashModel.addAvailablePorts(entity);
                                if (addAvailablePortsResult == "success")
                                {
                                    //Successful inserting the data.
                                    logs.log(entity.port + " has been added to active ports list. Ports Detail (Mobile No: "+entity.mobile_no+",Network: "+entity.network);
                                }
                                else
                                {
                                    // Log the errors
                                    logs.log("Failed to add the active port: " + addAvailablePortsResult);
                                }
                                sp.Close();
                            }

                        }


                    });

                    task.Wait();
                    double percentage = (double)(i + 1) / (double)ports.Length;
                    //Update the ProgressBar UI.
                    Action<double> update = p =>
                    {
                        SplashProgBar.Value = (int)Math.Round(p * 100);
                    };
                    this.Invoke(update, percentage);

                }
                catch (Exception exception)
                {
                    
                    //Log the Error
                    logs.log("Failed to add Comport: (" + ports[i].ToString() + ")  Exception: " +exception.Message);
                }
            }
        }


        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                SplashProgBar.Value = 0;
            }
            else
            {
                MMS mainForm = new MMS();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
