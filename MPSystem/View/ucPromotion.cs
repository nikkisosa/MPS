using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO.Ports;
using System.Collections;
namespace MPSystem.View
{
    public partial class ucPromotion : UserControl
    {
        private static ucPromotion _instance;
        public static ucPromotion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucPromotion();
                return _instance;
            }
        }

        public ucPromotion()
        {
            InitializeComponent();
            backgroundworker.DoWork += backgroundworker_DoWork;
            backgroundworker.ProgressChanged += backgroundworker_ProgressChanged;
            backgroundworker.RunWorkerCompleted += backgroundworker_RunWorkerCompleted;
            backgroundworker.WorkerReportsProgress = true;
            backgroundworker.WorkerSupportsCancellation = true;
        }

        Button btnEdit;
        Button btnDelete;
        Label lblTitle;
        private static int id;
        private static string str;
        private static string buttons = "default";
        private static Boolean field = false;
        private static string delimiter = "@";

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
                loadPromotion();
                loadGroup();
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

        private void clearFields()
        {
            txtTitle.Clear();
            txtDetails.Clear();
        }

        private void Fields()
        {
            if (field == true)
            {
                txtTitle.Enabled = true;
                txtDetails.Enabled = true;
                cboSendTo.Enabled = true;
            }
            else
            {
                txtTitle.Enabled = false;
                txtDetails.Enabled = false;
                cboSendTo.Enabled = false;
            }
        }

        private void Buttons()
        {
            if(buttons == "default")
            {
                btnAdd.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
            }
            else if(buttons == "edit")
            {
                btnAdd.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
            else if (buttons == "add")
            {
                btnAdd.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
            }
            
        }

       
        void loadPromotion()
        {
            str = Model.promotionModel.getPromotion();
            if (str == "success")
            {
                flpPromotion.Controls.Clear();
                for (int count = 0; count < config.records.Count; count++)
                {
                    btnEdit = new Button();
                    btnEdit.Click += btnEdit_Click;
                    btnEdit.BackColor = Color.FromArgb(41, 41, 41);
                    btnEdit.Size = new Size(34, 34);
                    btnEdit.FlatStyle = FlatStyle.Flat;
                    btnEdit.FlatAppearance.BorderColor = Color.FromArgb(41, 41, 41);
                    btnEdit.Location = new Point(122, 0);
                    btnEdit.Margin = new Padding(0, 0, 0, 0);
                    btnEdit.Padding = new Padding(20, 20, 20, 20);
                    btnEdit.Text = config.records[count].id.ToString() + "@" + config.records[count].promotionTitle.ToString() + "@" + config.records[count].details.ToString() + "@" + config.records[count].sendTo.ToString();
                    btnEdit.TextAlign = ContentAlignment.MiddleCenter;
                    btnEdit.BackgroundImage = new System.Drawing.Bitmap(MPSystem.Properties.Resources.btnpromopencil);
                    btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
                    btnEdit.TextImageRelation = TextImageRelation.Overlay;

                    btnDelete = new Button();
                    btnDelete.Click += btnDelete_Click;
                    btnDelete.BackColor = Color.FromArgb(41, 41, 41);
                    btnDelete.Size = new Size(34, 34);
                    btnDelete.FlatStyle = FlatStyle.Flat;
                    btnDelete.FlatAppearance.BorderColor = Color.FromArgb(41, 41, 41);
                    btnDelete.Location = new Point(162, 0);
                    btnDelete.Margin = new Padding(0, 0, 0, 0);
                    btnDelete.Padding = new Padding(20, 20, 20, 20);
                    btnDelete.Text = config.records[count].id.ToString();
                    btnDelete.TextAlign = ContentAlignment.MiddleCenter;
                    btnDelete.BackgroundImage = new System.Drawing.Bitmap(MPSystem.Properties.Resources.btnspromodelete);
                    btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
                    btnDelete.TextImageRelation = TextImageRelation.Overlay;

                    lblTitle = new Label();
                    lblTitle.Size = new Size(82, 13);
                    lblTitle.ForeColor = Color.White;
                    lblTitle.BackColor = Color.FromArgb(41, 41, 41);
                    lblTitle.AutoEllipsis = true;
                    lblTitle.AutoSize = false;
                    lblTitle.Font = new Font(FontFamily.GenericSansSerif, Convert.ToInt32(8.25));
                    lblTitle.Location = new Point(14, 11);
                    lblTitle.Margin = new Padding(3, 0, 3, 0);
                    lblTitle.Text = config.records[count].promotionTitle.ToString();

                    Panel pnlContainer = new Panel();
                    pnlContainer.BackColor = Color.FromArgb(41, 41, 41);
                    pnlContainer.Font = new Font(FontFamily.GenericSansSerif, Convert.ToInt32(8.25));
                    pnlContainer.Location = new Point(0, 3);
                    pnlContainer.Margin = new Padding(0, 3, 0, 0);
                    pnlContainer.Size = new System.Drawing.Size(200, 37);

                    pnlContainer.Controls.Add(lblTitle);
                    pnlContainer.Controls.Add(btnEdit);
                    pnlContainer.Controls.Add(btnDelete);
                    flpPromotion.Controls.Add(pnlContainer);

                }

            }
            else
            {

            }
           
        }

        public void loadGroup()
        {
            str = Model.groupModel.getGroups();
            if (str == "success")
            {
                cboSendTo.Items.Clear();
                for (int count = 0; count < config.records.Count; count++)
                {
                    cboSendTo.Items.Add(config.records[count].group.ToString()); // add item in combobox
                }
            }
            else
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete = (Button)sender;
            field = true;
            Fields();
            buttons = "delete";
            id = Convert.ToInt32(btnDelete.Text);
            DialogResult dr = MessageBox.Show("Are you sure want to delete this promotion?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                str = Model.promotionModel.deletePromotion(id);
                if (str == "success")
                {
                    loadPromotion();
                    MessageBox.Show("successfully deleted", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    buttons = "default";
                }
                else
                {
                    MessageBox.Show(str);
                }
            }
            else
            {

            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit = (Button)sender;
            field = true;
            Fields();

            buttons = "edit";

            string data = btnEdit.Text;
            string[] splitted = Regex.Split(data,delimiter);
            id = Convert.ToInt32(splitted[0].ToString());
            txtTitle.Text = splitted[1].ToString();
            txtDetails.Text = splitted[2].ToString();
            cboSendTo.Text = splitted[3].ToString();
            Buttons();
        }

        private void ucPromotion_Load(object sender, EventArgs e)
        {
            Fields();
            Buttons();
            backgroundworker.RunWorkerAsync();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            field = true;
            Fields();
            buttons = "add";
            Buttons();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (field == false)
            {
                field = true;
                Fields(); // enable fields
            }
            else
            {
                if (field == true)
                {
                    action();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            field = false;
            Fields();
            clearFields();
            buttons = "default";
            Buttons();
            loadGroup();
        }

        private void action()
        {
            string message = "";
            string title = txtTitle.Text;
            string details = txtDetails.Text;
            string sendto = cboSendTo.Text;
            if (title == "" || title == "" || sendto == "")
            {
                MessageBox.Show("Please fill-up all fields", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                Entity.variables ent = new Entity.variables();
                ent.promotionTitle = title;
                ent.details = details;
                ent.sendTo = sendto;
                switch (buttons)
                {
                    case "add":
                        message = "added";
                        str = Model.promotionModel.addPromotion(ent);
                        break;
                    case "edit":
                        message = "update";
                        ent.id = id;
                        str = Model.promotionModel.editPromotion(ent);
                        break;
                    default:
                        break;
                }
                
                if (str == "success")
                {
                    loadPromotion();
                    MessageBox.Show("successfully "+message, "MPS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    field = false;
                    Fields();
                    clearFields();
                    buttons = "default";
                    Buttons();
                    loadGroup();
                }
                else
                {
                    MessageBox.Show(str);
                }
            }
        }

        private void btnSendPromo_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string group = cboSendTo.Text;
            if (title == "")
            {
                MessageBox.Show("Please select a promo.", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (group == "")
            {
                MessageBox.Show("Please select a group.", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
           
         
                //string[] ports = SerialPort.GetPortNames();
                getActivePorts();
                pnlPortsToSend.Visible = true;
                //sendPromo(mobileNumbers);
               
            
            

        }


        public void sendPromo(string port,List<string> mobileNumbers,string promoDetails)
        {
            //foreach (string mobileNumber in mobileNumbers)
            //{
            //    MessageBox.Show(mobileNumber);
            //}
          
            //logs.log("Started checking : " + string.Join(",", ports));
            //Model.splashModel.deleteAvailablePorts();
            
                try
                {
                    //Serial Ports Setting
                    SerialPort sp = new SerialPort();
                    sp.PortName = port;
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
                    Task task = Task.Factory.StartNew(() =>
                    {

                        if (sp.IsOpen)
                        {
                            
                            sp.WriteLine("AT+CMGF=1\r");
                            Thread.Sleep(500);
                            sp.WriteLine("AT+CMGD=1\r");
                            Thread.Sleep(500);
                            sp.WriteLine("AT+CMGW=\"" + mobileNumbers[0] + "\"\r");
                            Thread.Sleep(500);
                            sp.WriteLine(promoDetails+ "\x1a");
                            Thread.Sleep(500);
                            foreach (string mobileNumber in mobileNumbers)
                            {
                                
                                sp.WriteLine("AT+CMSS=1,\"" + mobileNumber + "\"\r");
                                Thread.Sleep(4000);

                            }
                            sp.WriteLine("AT+CMGD=1\r");
                            Thread.Sleep(500);


                        }
                    });


                }
                catch (Exception exception)
                {
                    //Log the Error
                    logs.log("Exception: " + exception.Message);
                }
            
        }


        public void getActivePorts()
        {

            lstGrid.Rows.Clear();
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

                       lstGrid.Rows.Add(row.ToArray());


                    }
               

                }
            }
        }

        private void btnPClose_Click(object sender, EventArgs e)
        {
            pnlPortsToSend.Visible = false;
        }

        private void btnPSend_Click(object sender, EventArgs e)
        {
           

            for (int i = 0; i < lstGrid.Rows.Count; i++)
            {
                bool isChecked = (bool)lstGrid.Rows[i].Cells[0].Value;

                if (isChecked)
                {
                    string selectedPort = lstGrid.Rows[i].Cells[1].Value.ToString();
                    str = Model.promotionModel.getGroupMembersNumber(cboSendTo.Text);
                    if (str == "success")
                    {
                        List<string> mobileNumbers = new List<string>();
                
                        for (int count = 0; count < config.records.Count; count++)
                        {
                            mobileNumbers.Add(config.records[count].mobile_no.ToString());
                        }
                        //MessageBox.Show(lstGrid.Rows[i].Cells[1].Value.ToString());
                        sendPromo(selectedPort, mobileNumbers, txtDetails.Text);
                        pnlPortsToSend.Visible = false;
                        MessageBox.Show("The Promo has been sent to group :" + cboSendTo.Text);
                    }

                }
            }
        }

 

        
    }
}
