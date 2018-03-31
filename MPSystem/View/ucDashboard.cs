using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;

namespace MPSystem.View
{
    public partial class ucDashboard : UserControl
    {
        private static ucDashboard _instance;
        public static ucDashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDashboard();
                return _instance;
            }
        }

        public ucDashboard()
        {
            InitializeComponent();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            string result = Model.dashBoardModel.getActivePorts();
            if (result == "success")
            {
                // Check if the records contains data.
                if (config.records.Count > 0)
                {
                    for (int i = 0; i < config.records.Count; i++)
                    {
                        //Add the fields to the DataGridView
                        ArrayList row = new ArrayList();
                        row.Add(false);
                        row.Add(config.records[i].port);
                        row.Add(config.records[i].mobile_no);
                        row.Add(config.records[i].balance);
                        dashGrid.Rows.Add(row.ToArray());

                        
                    }
                    
                    //Only the checbox will be editable.
                    dashGrid.ReadOnly = false;
                    dashGrid.Columns[1].ReadOnly = true;
                    dashGrid.Columns[2].ReadOnly = true;
                    dashGrid.Columns[2].ReadOnly = true;
                    
                }
            }
        }

        private void btnUpdateLoad_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dashGrid.Rows.Count; i++)
            {
                bool isChecked = (bool)dashGrid.Rows[i].Cells[0].Value;

                if (isChecked)
                {
                    //onhold
                    //checkPortBalance(dashGrid.Rows[i].Cells[1].Value.ToString(), dashGrid.Rows[i].Cells[2].Value.ToString(), i);

                }
            }
        }

        //public async void checkPortBalance(string port,string mobileNo,int row)
        //{
        //    try
        //    {
        //        //Serial Ports Setting
        //        SerialPort sp = new SerialPort();
        //        sp.PortName = port;
        //        sp.BaudRate = 115200;
        //        sp.Parity = Parity.None;
        //        sp.StopBits = StopBits.One;
        //        sp.DataBits = 8;
        //        sp.Handshake = Handshake.None;
        //        sp.RtsEnable = true;
        //        sp.NewLine = "\n";
               
        //        //sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);


        //        sp.Open();


        //        //Creating a task to check for the available ports.
        //        Task task = Task.Factory.StartNew(() =>
        //        {

        //            if (sp.IsOpen)
        //            {
                        
        //                string portName = sp.PortName;

        //                sp.WriteLine("AT\r");
        //                Thread.Sleep(2000);

        //                if (sp.ReadExisting().Contains("OK"))
        //                {
                            
        //                    sp.WriteLine("AT+CMGF=1\r");
        //                    Thread.Sleep(1000);
                            
        //                    if (sp.ReadExisting().Contains("OK"))
        //                    {
        //                        sp.WriteLine("AT+CMGS=\"222\"\r\n");
        //                        Thread.Sleep(1000);
        //                        sp.WriteLine("BAL\x1a");
        //                        Thread.Sleep(5000);
        //                        sp.WriteLine("AT+CMGL=\"REC UNREAD\"\r");
        //                        Thread.Sleep(3000);
        //                        Regex regEx = new Regex(@"\+CMGL: (\d+),""(.+)"",""(.+)"",(.*),""(.+)""\r\n(.+)\r\n");
        //                        Match match = regEx.Match(sp.ReadExisting());
        //                        while(match.Success){
        //                            string inboxID = match.Groups[1].Value;
        //                            string inboxStatus = match.Groups[2].Value;
        //                            string inboxSender = match.Groups[3].Value;
        //                            string inboxDateAndTime = match.Groups[4].Value;
        //                            string inboxBlank = match.Groups[5].Value;
        //                            string inboxData = match.Groups[6].Value;

        //                            Action<string> updateDataGridBalance = balance =>
        //                            {
        //                                dashGrid.Rows[row].Cells[3].Value = balance;
        //                            };
        //                            this.Invoke(updateDataGridBalance, inboxData);
        //                            logs.log(inboxData);

        //                            match = match.NextMatch();

        //                        }

        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Failed, Checking of balance. Please try again later when the modem is not busy.");
        //                        logs.log("Checking of balance failed for :" +port+ ", port might be busy.");
        //                    }
                           
        //                }
        //                sp.Close();
        //            }


        //        });


        //    }
        //    catch (Exception exception)
        //    {

        //        //Log the Error
                
        //    }

        //}
    }
}
