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
    public partial class ucUssd : UserControl
    {
        private static ucUssd _instance;
        public static ucUssd Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucUssd();
                return _instance;
            }
        }

        private static Boolean field = false;
        private static Boolean cancel = false;
        private static string buttons = "default";
        private static string str;
        private static int id;
        private static int pageNumber = 1;
        private static int itemNewId = 0;
        private static int itemOldId = 0;
        private static int totalCount = 0;
        private static int totalPage = 0;
        private static int onClickCount = 0;
        public ucUssd()
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

                loadData();
            }
        }

        void backgroundworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //throw new NotImplementedException();
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
        public void loadData()
        {
            str = Model.ussdModel.getUssdCommand(pageNumber);
            if (str == "success")
            {

                totalCount = config.records.Count;
                if (totalCount > 0)
                {
                    lvList.Items.Clear();
                    for (int count = 0; count < config.records.Count; count++)
                    {
                        ListViewItem item = new ListViewItem(config.records[count].id.ToString());
                        item.SubItems.Add(count.ToString());
                        item.SubItems.Add(config.records[count].command.ToString());
                        item.SubItems.Add(config.records[count].details.ToString());
                        lvList.Items.Add(item);
                        itemNewId = config.records[count].id;

                    }

                    Model.ussdModel.getTotalPage();
                    Entity.variables variables = new Entity.variables();


                    if (itemNewId == itemOldId)
                    {

                    }
                    else
                    {
                        itemOldId = itemNewId;
                        totalPage = ((config.records[0].totalpage / Entity.variables.pageSize) + 1);
                        lblPages.Text = "Page " + pageNumber + " of " + ((config.records[0].totalpage / Entity.variables.pageSize) + 1).ToString();
                    }
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
                txtDescription.Enabled = true;
            }
            else
            {
                txtCommand.Enabled = false;
                txtDescription.Enabled = false;
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
            txtDescription.Clear();
        }

        private void ucUssd_Load(object sender, EventArgs e)
        {
            Fields();
            Buttons();
            backgroundworker.RunWorkerAsync();
            panel2.Visible = false;
            panel2.SendToBack();
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
                    string description = txtDescription.Text;
                    if (command == "" || description == "")
                    {
                        MessageBox.Show("Please enter command and description", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        Entity.variables ent = new Entity.variables();
                        ent.command = command;
                        ent.details = description;
                        string str = Model.ussdModel.addUssdCommand(ent);
                        if (str == "success")
                        {
                            loadData();
                            MessageBox.Show("successfully added", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                        str = Model.ussdModel.deleteUssdCommand(id);
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
                    txtDescription.Text = lvList.SelectedItems[0].SubItems[3].Text;
                }
                else
                {
                    if (field == true)
                    {
                        string command = txtCommand.Text;
                        string details = txtDescription.Text;
                        if (command == "" || details == "")
                        {
                            MessageBox.Show("Please enter the command and reply", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            Entity.variables ent = new Entity.variables();
                            ent.command = command;
                            ent.details = details;
                            ent.id = id;
                            string str = Model.ussdModel.editUssdCommand(ent);
                            if (str == "success")
                            {
                                loadData();
                                MessageBox.Show("successfully update", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (totalCount > 0)
            {
                if (totalPage == pageNumber)
                {

                }
                else
                {
                    pageNumber = pageNumber + 1;

                    loadData();
                }

            }
            else
            {
                //leave empty
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

            if (totalCount != 0)
            {
                if (pageNumber == 1)
                {

                }
                else
                {
                    pageNumber = pageNumber - 1;
                    loadData();
                }

            }
            else
            {
                if (pageNumber == 1)
                {

                }
                else
                {
                    pageNumber = pageNumber - 1;
                    loadData();
                }
            }
        }

        private void lvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(lvList.SelectedItems[0].SubItems[0].Text);
                if (onClickCount == 0)
                {
                    onClickCount = 1;
                }
                else if (onClickCount == 1 && id.ToString() == id.ToString())
                {
                    onClickCount = 2;
                    if(onClickCount == 2)
                    {
                        panel2.Visible = true;
                        panel2.BringToFront();
                        lblDescription.Text = lvList.SelectedItems[0].SubItems[3].Text;
                        txtCommandBox.Text = lvList.SelectedItems[0].SubItems[2].Text;
                    }
                    
                }
            }
            catch(Exception)
            {

            }
            
        }

        private void btnCloseUssdPanel_Click(object sender, EventArgs e)
        {
            onClickCount = 0;
            panel2.Visible = false;
            panel2.SendToBack();
        }
    }
}
