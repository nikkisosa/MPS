using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPSystem.View;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;
using System.Timers;

namespace MPSystem
{
    public partial class MMS : Form
    {
        public BackgroundWorker bgWorker;
        public System.Timers.Timer bgTimer;
        public MMS()
        {
            InitializeComponent();
            bgWorker = new BackgroundWorker()
            {
                WorkerSupportsCancellation = true,
                WorkerReportsProgress = true
            };
            bgWorker.DoWork += worker_DoWork;
            bgWorker.ProgressChanged += worker_ProgressChanged;
            bgWorker.RunWorkerCompleted += worker_RunWorkerCompleted;
            //bgWorker.RunWorkerAsync();

            bgTimer = new System.Timers.Timer(1000 * 60 * 0.30); // Check Message Every 2 minutes
            bgTimer.Elapsed += bgTimer_Elapsed;
            bgTimer.Start();

           

        }

        private bool mouseDown;
        private Point lastLocation;

        void bgTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (!bgWorker.IsBusy)
                bgWorker.RunWorkerAsync();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker w = (BackgroundWorker)sender;

            while (true)
            {
                //check if cancellation was requested
                if (w.CancellationPending)
                {
                    //take any necessary action upon cancelling (rollback, etc.)

                    //notify the RunWorkerCompleted event handler
                    //that the operation was cancelled
                    e.Cancel = true;
                    return;
                }
                checkForIncommingMessage();
                try
                {
                    Thread.Sleep(1000 * 60 * (int)(1.30)); // 5 minutes sleep
                }
                catch(ThreadStateException)
                {

                }
                

                //w.ReportProgress(/*percentage*/);

            }
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //display the progress using e.ProgressPercentage and/or e.UserState
            logs.log("Checking Message....");
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                logs.log("Checking Message Canceled");
            }
            else
            {
                //do something else
            }
        }


        private void btn_contacts_Click(object sender, EventArgs e)
        {
            Mainpanel.Controls.Clear();
            if (!Mainpanel.Controls.Contains(ucContacts.Instance))
            {
                Mainpanel.Controls.Add(ucContacts.Instance);
                ucContacts.Instance.Dock = DockStyle.Fill;
                ucContacts.Instance.BringToFront();
            }
            else
            {
                ucContacts.Instance.BringToFront();
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
            
        }

        private void MMS_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MMS_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MMS_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btn_autoreply_Click(object sender, EventArgs e)
        {
            Mainpanel.Controls.Clear();

            if (!Mainpanel.Controls.Contains(ucAutoreply.Instance))
            {
                Mainpanel.Controls.Add(ucAutoreply.Instance);
                ucAutoreply.Instance.Dock = DockStyle.Fill;
                ucAutoreply.Instance.BringToFront();
            }
            else
            {
                ucAutoreply.Instance.BringToFront();
            }
        }

        private void btn_promos_Click(object sender, EventArgs e)
        {
            Mainpanel.Controls.Clear();

            if (!Mainpanel.Controls.Contains(ucPromotion.Instance))
            {
                Mainpanel.Controls.Add(ucPromotion.Instance);
                ucPromotion.Instance.Dock = DockStyle.Fill;
                ucPromotion.Instance.BringToFront();
            }
            else
            {
                ucPromotion.Instance.BringToFront();
            }
        }

        private void MMS_Load(object sender, EventArgs e)
        {
            //logs.log("hello test message1");
            //checkForIncommingMessage();

        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            Mainpanel.Controls.Clear();

            if (!Mainpanel.Controls.Contains(ucDashboard.Instance))
            {
                Mainpanel.Controls.Add(ucDashboard.Instance);
                ucDashboard.Instance.Dock = DockStyle.Fill;
                ucDashboard.Instance.BringToFront();
            }
            else
            {
                ucDashboard.Instance.BringToFront();
            }
        }

        public void checkForIncommingMessage()
        {

            List<string> ports = Model.MainFormModel.getListActivePorts();
            logs.log("Checking Message : " + string.Join(",", ports));
        
            for (int i = 0; i < ports.Count; i++)
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
                    //sp.WriteLine("AT\r");
                    

                       if (sp.IsOpen)
                       {
                           
                           sp.WriteLine("AT\r");
                           Thread.Sleep(500);
                           sp.WriteLine("AT+CMGF=1\r");
                           Thread.Sleep(500);
                           sp.WriteLine("AT+CMGL=\"REC UNREAD\"\r");
                           Thread.Sleep(3000);
                           Regex regEx = new Regex(@"\+CMGL: (\d+),""(.+)"",""(.+)"",(.*),""(.+)""\r\n(.+)\r\n");
                           Match match = regEx.Match(sp.ReadExisting());
                           while (match.Success)
                           {
                               string inboxID = match.Groups[1].Value;
                               string inboxStatus = match.Groups[2].Value;
                               string inboxSender = match.Groups[3].Value;
                               string inboxDateAndTime = match.Groups[4].Value;
                               string inboxBlank = match.Groups[5].Value;
                               string inboxData = match.Groups[6].Value;
                               //MessageBox.Show(inboxID);

                               string filteredMobileNo = inboxSender.Replace("+63", "0").Trim();
                               Entity.variables entity = new Entity.variables();
                               if (inboxData.Trim().Contains("YES"))
                               {


                                   string checkMobileNumber = Model.MainFormModel.checkMobileLastPromo(filteredMobileNo);

                                   if (checkMobileNumber == "success")
                                   {

                                       
                                       entity.promotionTitle = Model.MainFormModel.getLastPromo(filteredMobileNo);
                                       entity.mobile_no = inboxSender;
                                       entity.message = inboxData;
                                       string insertMessage = Model.MainFormModel.addMessages(entity);

                                       if (insertMessage != "success")
                                       {
                                           logs.log("Saving Message Failed: " + insertMessage);
                                       }
                                   }

                               }
                               else
                               {
                                   entity.promotionTitle = "N";
                                   entity.mobile_no = inboxSender;
                                   entity.message = inboxData;
                                   string insertMessage = Model.MainFormModel.addMessages(entity);

                                   if (insertMessage != "success")
                                   {
                                       logs.log("Saving Message Failed: " + insertMessage);
                                   }
                               }

                               string checkForAutoReplay = Model.MainFormModel.checkForAutoReplay(inboxData);
                               if (checkForAutoReplay != "false")
                               {
                                   
                                       sp.WriteLine("AT+CMGS=\"" + filteredMobileNo + "\"\r");
                                       Thread.Sleep(1000);
                                       sp.WriteLine(checkForAutoReplay + "\x1a");
                                       Thread.Sleep(4000);
                                       logs.log("Auto Replay Done");
                                  
                               }


                               match = match.NextMatch();

                           }


                       }
                        sp.Close();
                  

                }
                catch (Exception exception)
                {
                    //Log the Error
                    logs.log("ExceptionMainForm: " + exception.Message);
                }
            }
        }

        private void btn_messages_Click(object sender, EventArgs e)
        {
            Mainpanel.Controls.Clear();

            if (!Mainpanel.Controls.Contains(ucMessages.Instance))
            {
                Mainpanel.Controls.Add(ucMessages.Instance);
                ucMessages.Instance.Dock = DockStyle.Fill;
                ucMessages.Instance.BringToFront();
            }
            else
            {
                ucMessages.Instance.BringToFront();
            }
        }

        private void btn_ussd_Click(object sender, EventArgs e)
        {
            Mainpanel.Controls.Clear();

            if (!Mainpanel.Controls.Contains(ucUssd.Instance))
            {
                Mainpanel.Controls.Add(ucUssd.Instance);
                ucUssd.Instance.Dock = DockStyle.Fill;
                ucUssd.Instance.BringToFront();
            }
            else
            {
                ucUssd.Instance.BringToFront();
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            //frmDumpContact dc = new frmDumpContact();
            //dc.ShowDialog();
            Mainpanel.Controls.Clear();

            if (!Mainpanel.Controls.Contains(ucSettings.Instance))
            {
                Mainpanel.Controls.Add(ucSettings.Instance);
                ucSettings.Instance.Dock = DockStyle.Fill;
                ucSettings.Instance.BringToFront();
            }
            else
            {
                ucSettings.Instance.BringToFront();
            }
        }
    }
}
