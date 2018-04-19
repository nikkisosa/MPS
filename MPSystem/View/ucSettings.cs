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
using System.Text.RegularExpressions;
using System.Diagnostics;
namespace MPSystem.View
{
    public partial class ucSettings : UserControl
    {
        private static ucSettings _instance;
        public static ucSettings Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSettings();
                return _instance;
            }
        }

        public ucSettings()
        {
            InitializeComponent();

            backgroundworker.DoWork += backgroundworker_DoWork;
            backgroundworker.ProgressChanged += backgroundworker_ProgressChanged;
            backgroundworker.RunWorkerCompleted += backgroundworker_RunWorkerCompleted;
            backgroundworker.WorkerReportsProgress = true;
            backgroundworker.WorkerSupportsCancellation = true;
        }

        void backgroundworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Process was cancelled");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("There was an error running the process. The thread aborted");
            }
            else
            {
                loadPorts();
            }
        }

        void backgroundworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        void backgroundworker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                backgroundworker.ReportProgress(i);

                //Check if there is a request to cancel the process
                if (backgroundworker.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundworker.ReportProgress(0);
                    return;
                }
            }
            //If the process exits the loop, ensure that progress is set to 100%
            //Remember in the loop we set i < 100 so in theory the process will complete at 99%
            backgroundworker.ReportProgress(100);
        }

        private void loadPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length; i++)
            {
                try
                {
                    cboPorts.Items.Add(ports[i]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ucSettings_Load(object sender, EventArgs e)
        {
            btnDump.Enabled = false;
            backgroundworker.RunWorkerAsync();
        }

        private void cboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                logs.log("********" + cboPorts.Text + " Selected********");
                SerialPort _serial = new SerialPort();
                _serial.BaudRate = 115200;
                _serial.Parity = Parity.None;
                _serial.StopBits = StopBits.One;
                _serial.DataBits = 8;
                _serial.Handshake = Handshake.None;
                _serial.RtsEnable = true;
                _serial.NewLine = "\n";
                _serial.PortName = cboPorts.Text;
                _serial.Open();
                _serial.WriteLine("AT+COPS=3,0\r");
                Thread.Sleep(100);
                _serial.WriteLine("AT+COPS?\r");
                Thread.Sleep(100);
                _serial.Write(new byte[] { 26 }, 0, 1);
                Thread.Sleep(100);

                Regex regEx = new Regex(@"\+COPS: (\d+),(.+),""(.+)""\r\n");
                Match match = regEx.Match(_serial.ReadExisting());
                lblNetwork.Text = match.Groups[3].Value;

                btnDump.Enabled = true;
                _serial.Close();
               
            }
            catch (Exception ex)
            {
                logs.log(ex.Message);
            }
        }

        private void btnDump_Click(object sender, EventArgs e)
        {
            try
            {
                logs.log("********Start Dumping Contacts********");
                btnDump.Enabled = false;
                SerialPort _serial = new SerialPort();
                _serial.BaudRate = 115200;
                _serial.Parity = Parity.None;
                _serial.StopBits = StopBits.One;
                _serial.DataBits = 8;
                _serial.Handshake = Handshake.None;
                _serial.RtsEnable = true;
                _serial.NewLine = "\n";
                _serial.PortName = cboPorts.Text;
                _serial.Open();
                _serial.WriteLine("AT+CPBS=\"SM\"\r");
                Thread.Sleep(100);
                _serial.WriteLine("AT+CPBR=1,250\r");
                Thread.Sleep(100);
                _serial.Write(new byte[] { 26 }, 0, 1);
                Thread.Sleep(100);

                Regex regEx = new Regex(@"\+CPBR: (\d+),""(.+)"",(.+),""(.+)""\r\n");
                foreach (Match match in regEx.Matches(_serial.ReadExisting()))
                {
                    string mobileNo = match.Groups[2].Value;
                    
                    string filteredNumber = mobileNo.Replace("+639", "09").Trim().Replace("639", "09").Trim();
                    if(filteredNumber.Length > 10)
                    {
                        string mobilePrefix = Model.splashModel.getMobileNetwork(filteredNumber.Substring(1, 3));
                        Entity.variables entity = new Entity.variables();
                        entity.network = (mobilePrefix == "success" || mobilePrefix == "") ? "Unknown Network" : mobilePrefix;
                        logs.dumpContact(filteredNumber, entity.network, lblNetwork.Text);
                    }
                    
                }

                logs.log("********Dump started********");
                _serial.Close();
                logs.log("********Stop Dumping Contacts********");
                btnDump.Enabled = true;
            }
            catch (Exception ex)
            {
                logs.log(ex.Message);
                btnDump.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState.ToString() == "Checked") 
            {
                pnlDump.Size = new Size(pnlDump.Size.Width,128);
                panel1.Location = new Point(15, 170);
                pnlClearData.Location = new Point(15, 231);
            }
            else
            {
                pnlDump.Size = new Size(pnlDump.Size.Width, 55);
                panel1.Location = new Point(15, 95);
                pnlClearData.Location = new Point(15, 156);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath.ToString() + @"\Logs");
        }

        private void chkClearData_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClearData.CheckState.ToString() == "Checked")
            {
                pnlClearData.Size = new Size(pnlClearData.Size.Width,111);
            }
            else
            {
                pnlClearData.Size = new Size(pnlClearData.Size.Width, 55);
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            string str = string.Empty;
            string module = cboModule.Text.ToUpper();
            logs.log("*******START DELETING RECORD FROM "+module+"*******");
            switch (cboModule.Text)
            {
                case "Auto Reply":
                    str = Model.autoreplyModel.deleteAutoReply(0, true);
                    break;
                case "Contact":
                    str = Model.contactModel.deleteContact(0, true);
                    break;
                case "Message":
                    str = Model.messageModel.deleteMessages(0, true);
                    break;
                case "USSD Command":
                    str = Model.ussdModel.deleteUssdCommand(0, true);
                    str += Model.ussdHistoryModel.deleteUssdHistory(0, true);
                    break;
                case "Promotion":
                    str = Model.promotionModel.deletePromotion(0, true);
                    break;
                default:
                    break;
            }

            if (str == "success")
            {
                logs.log("*******SUCCESSFULLY DELETED FROM " + module + "*******");
                MessageBox.Show("Successfully delete.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                logs.log("*******ERROR FROM " + module + "*******");
                logs.log(str);
                MessageBox.Show(str, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
