using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;
namespace MPSystem.View
{
    public partial class frmDumpContact : Form
    {
        public frmDumpContact()
        {
            InitializeComponent();
        }

        private void btnDump_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDumpContact_Load(object sender, EventArgs e)
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

        private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
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
                _serial.WriteLine("AT+CPBR=1,255\r");
                Thread.Sleep(100);
                _serial.Write(new byte[] { 26 }, 0, 1);
                Thread.Sleep(100);

                Regex regEx = new Regex(@"\+CPBR: (\w),""(\d+)"",(\w),(\w)\r\n");
                Match match = regEx.Match(_serial.ReadExisting());
                MessageBox.Show(_serial.ReadExisting());
                lblNetwork.Text = match.Groups[2].Value;
                logs.log(match.Groups[0].Value);
                _serial.Close();
            }
            catch(Exception ex)
            {
                logs.log(ex.Message);
            }
        } 
    }
}
