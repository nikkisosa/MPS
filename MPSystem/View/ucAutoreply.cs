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

namespace MPSystem.View
{
    public partial class ucAutoreply : UserControl
    {
        private static ucAutoreply _instance;
        public static ucAutoreply Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAutoreply();
                return _instance;
            }
        }

        private static Boolean field = false;
        private static Boolean cancel = false;
        private static string buttons = "default";
        private static string str;
        private static int id;


        public ucAutoreply()
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
                
                loadContact();
            }
        }

        void backgroundworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
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

        /**
         * Load data from database
         */
        public void loadContact()
        {
            str = Model.autoreplyModel.getAutoReply();
            if (str == "success")
            {
                lvList.Items.Clear();

                for (int count = 0; count < config.records.Count; count++)
                {
                    ListViewItem item = new ListViewItem(config.records[count].id.ToString());
                    item.SubItems.Add(count.ToString());
                    item.SubItems.Add(config.records[count].command.ToString());
                    item.SubItems.Add(config.records[count].reply.ToString());
                    lvList.Items.Add(item);

                }
            }
            else
            {

            }

        }


        /**
         * Enable or disable input/text fields
         */
        private void Fields()
        {
            if (field == true)
            {
                txtCommand.Enabled = true;
                txtReply.Enabled = true;
            }
            else
            {
                txtCommand.Enabled = false;
                txtReply.Enabled = false;
            }
        }

        /**
         * Enable and Disable Specific button
         */
        private void Buttons()
        {
            if (buttons == "default")
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnAdd.Text = "Add a Command";
                btnEdit.Text = "Edit Command";
                btnDelete.Text = "Delete Command";
            }
            else if (buttons == "add")
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = false;
                btnAdd.Text = "Save Command";
                btnDelete.Text = "Cancel";
            }
            else if (buttons == "edit")
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnEdit.Text = "Update Command";
                btnDelete.Text = "Cancel";
            }
        }

        private void clearFields()
        {
            txtCommand.Clear();
            txtReply.Clear();
        }

        private void Autoreply_Load(object sender, EventArgs e)
        {
            Fields();
            Buttons();
            backgroundworker.RunWorkerAsync();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (field == false)
            {
                field = true;
                cancel = true;
                buttons = "add";
                Fields(); // enable fields
                Buttons();
            }
            else
            {
                if (field == true)
                {
                    string command = txtCommand.Text;
                    string reply = txtReply.Text;
                    if (command == "" || reply == "")
                    {
                        MessageBox.Show("Please enter command and reply", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        Entity.variables ent = new Entity.variables();
                        ent.command = command;
                        ent.reply = reply;
                        string str = Model.autoreplyModel.addAutoReply(ent);
                        if (str == "success")
                        {
                            MessageBox.Show("successfully added", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadContact();
                            field = false;
                            Fields();
                            buttons = "default";
                            Buttons();
                            cancel = false;
                            clearFields();
                        }
                        else
                        {
                            MessageBox.Show(str);
                        }
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cancel == true) // will clear textbox/input fields
            {
                field = false;
                Fields();
                buttons = "default";
                Buttons();
                clearFields();
            }
            else // delete selected record from listview
            {
                try
                {
                    int id = Convert.ToInt32(lvList.SelectedItems[0].Text);
                    DialogResult dr = MessageBox.Show("Are you sure want to delete this command?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        str = Model.autoreplyModel.deleteAutoReply(id);
                        if (str == "success")
                        {
                            lvList.Items.Remove(lvList.SelectedItems[0]);
                            MessageBox.Show("Successfully delete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please select the command you want to delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                id = Convert.ToInt32(lvList.SelectedItems[0].Text);
                if (field == false)
                {
                    field = true;
                    cancel = true;
                    buttons = "edit";
                    Fields(); // enable fields
                    Buttons();

                    txtCommand.Text = lvList.SelectedItems[0].SubItems[2].Text;
                    txtReply.Text = lvList.SelectedItems[0].SubItems[3].Text;
                }
                else
                {
                    if (field == true)
                    {
                        string command = txtCommand.Text;
                        string reply = txtReply.Text;
                        if (command == "" || reply == "")
                        {
                            MessageBox.Show("Please enter the command and reply", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            Entity.variables ent = new Entity.variables();
                            ent.command = command;
                            ent.reply = reply;
                            ent.id = id;
                            string str = Model.autoreplyModel.editAutoReply(ent);
                            if (str == "success")
                            {
                                MessageBox.Show("successfully update", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadContact();
                                field = false;
                                Fields();
                                buttons = "default";
                                Buttons();
                                cancel = false;
                                clearFields();
                            }
                            else
                            {
                                MessageBox.Show(str);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select the command you want to edit", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
