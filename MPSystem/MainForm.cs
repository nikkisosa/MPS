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

namespace MPSystem
{
    public partial class MMS : Form
    {
        public MMS()
        {
            InitializeComponent();
        }

        private bool mouseDown;
        private Point lastLocation;

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
            checkForIncommingMessage();

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

            string[] ports = SerialPort.GetPortNames();
            logs.log("Started checking : " + string.Join(",", ports));
            //Model.splashModel.deleteAvailablePorts();
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

                    sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    sp.Open();
                    //sp.WriteLine("AT\r");
                    Task task = Task.Factory.StartNew(() =>
                   {

                       if (sp.IsOpen)
                       {
                           string portName = sp.PortName;

                           sp.WriteLine("AT\r");
                           Thread.Sleep(1000);
                
                       }
                   });
                    

                }
                catch (Exception exception)
                {
                    //Log the Error
                    logs.log("Exception: " + exception.Message);
                }
            }
        }

        private static void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            if(sp.ReadExisting().Contains("+CMTI:")){
                //New Message Received
                MessageBox.Show(indata);
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
    }
}
