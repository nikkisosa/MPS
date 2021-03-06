﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MPSystem.View;
namespace MPSystem
{
    public partial class ucContacts : UserControl
    {
        private static ucContacts _instance;
        public static ucContacts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucContacts();
                return _instance;
            }
        }


        private static Boolean field,fieldGroup = false;
        private static Boolean cancel, cancelGroup = false;
        private static string buttons,buttonsGroup = "default";
        private static string str;
        private static int id;
        private static int pageNumber = 1;
        private static int item_new_id = 0;
        private static int item_old_id = 0;
        private static int totalCount = 0;
        private static int totalPage = 0;
        public ucContacts()
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
                loadGroup();
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
        public void loadContact(string filter = "All",string search = "All")
        {
            str = Model.contactModel.getContacts(pageNumber,filter,search);
            if (str == "success")
            {
                totalCount = config.records.Count;
                lvContact.Items.Clear();
                if (totalCount > 0)
                {
                    

                    for (int count = 0; count < config.records.Count; count++)
                    {
                        ListViewItem item = new ListViewItem(config.records[count].id.ToString());
                        item.SubItems.Add(count.ToString());
                        item.SubItems.Add(config.records[count].mobile_no.ToString());
                        item.SubItems.Add(config.records[count].network.ToString());
                        item.SubItems.Add(config.records[count].group.ToString());
                        lvContact.Items.Add(item);
                        item_new_id = config.records[count].id;
                    }

                    Model.contactModel.getTotalPage();
                    Entity.variables variables = new Entity.variables();


                    if (item_new_id == item_old_id)
                    {

                    }
                    else
                    {
                        item_old_id = item_new_id;
                        totalPage = ((config.records[0].totalpage / Entity.variables.pageSize) + 1);
                        lblPages.Text = "Page " + pageNumber + " of " + ((config.records[0].totalpage / Entity.variables.pageSize)+1).ToString();
                    }
                }
            }
            else
            {
                logs.log(str);
            }

        }
        /**
         * Enable or disable input/text fields
         */
        private void Fields()
        {
            if (field == true)
            {
                txtContact.Enabled = true;
                cboGroup.Enabled = true;
                cboNetwork.Enabled = true;
            }
            else
            {
                txtContact.Enabled = false;
                cboGroup.Enabled = false;
                cboNetwork.Enabled = false;
            }
        }

        /**
         * Enable and Disable Specific button
         */
        private void Buttons()
        {
            if(buttons == "default")
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnAdd.Text = "Add a Contact";
                btnEdit.Text = "Edit Contact";
                btnDelete.Text = "Delete Contact";
            }
            else if(buttons == "add")
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = false;
                btnAdd.Text = "Save Contact";
                btnDelete.Text = "Cancel";
            }
            else if(buttons == "edit")
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnEdit.Text = "Update Contact";
                btnDelete.Text = "Cancel";
            }
        }

        private void clearFields()
        {
            txtContact.Clear();
            cboNetwork.Items.Clear();
            cboNetwork.Items.Add("Globe");
            cboNetwork.Items.Add("Touch Mobile");
            cboGroup.Items.Clear();
        }

        private void ucContacts_Load(object sender, EventArgs e)
        {
            Fields();
            Buttons();
            FieldsGroup();
            ButtonsGroup();
            backgroundworker.RunWorkerAsync();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(field == false)
            {
                field = true;
                cancel = true;
                buttons = "add";
                Fields(); // enable fields
                Buttons();
            }
            else
            {
                if(field == true)
                {
                    string mobile_no = txtContact.Text.Trim();
                    string network = cboNetwork.Text;
                    string group = cboGroup.Text;
                    if (mobile_no == "" || network == "")
                    {
                        MessageBox.Show("Please enter the number and network", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        Entity.variables ent = new Entity.variables();
                        ent.mobile_no = mobile_no;
                        ent.network = network;
                        ent.group = group;
                        string str = Model.contactModel.addContact(ent);
                        if (str == "success")
                        {
                            loadContact();
                            
                            MessageBox.Show("successfully added", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            field = false;
                            Fields();
                            buttons = "default";
                            Buttons();
                            cancel = false;
                            clearFields();
                            loadGroup();
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
            if(cancel == true) // will clear textbox/input fields
            {
                field = false;
                Fields();
                buttons = "default";
                Buttons();
                clearFields();
                id = 0;
                loadGroup();
            }
            else // delete selected record from listview
            {
                try
                {
                    int id = Convert.ToInt32(lvContact.SelectedItems[0].Text);
                    DialogResult dr = MessageBox.Show("Are you sure want to delete this number?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        
                        str = Model.contactModel.deleteContact(id);
                        if (str == "success")
                        {
                            lvContact.Items.Remove(lvContact.SelectedItems[0]);
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
                catch(Exception)
                {
                    MessageBox.Show("Please select the number you want to delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            try
            {
                id = Convert.ToInt32(lvContact.SelectedItems[0].Text);
                if (field == false)
                {
                    field = true;
                    cancel = true;
                    buttons = "edit";
                    Fields(); // enable fields
                    Buttons();

                    txtContact.Text = lvContact.SelectedItems[0].SubItems[2].Text;
                    cboNetwork.Text = lvContact.SelectedItems[0].SubItems[3].Text;
                    cboGroup.Text = lvContact.SelectedItems[0].SubItems[4].Text;
                }
                else
                {
                    if (field == true)
                    {
                        string mobile_no = txtContact.Text.Trim();
                        string network = cboNetwork.Text;
                        string group = cboGroup.Text;
                        if (mobile_no == "" || network == "")
                        {
                            MessageBox.Show("Please enter the number and network", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            Entity.variables ent = new Entity.variables();
                            ent.mobile_no = mobile_no;
                            ent.network = network;
                            ent.group = group;
                            ent.id = id;
                            string str = Model.contactModel.editContact(ent);
                            if (str == "success")
                            {
                                loadContact();
                                
                                MessageBox.Show("successfully update", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                field = false;
                                Fields();
                                buttons = "default";
                                Buttons();
                                cancel = false;
                                clearFields();
                                loadGroup();
                            }
                            else
                            {
                                MessageBox.Show(str);
                            }
                        }
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please select the number you want to edit", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    loadContact();
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
                    loadContact();
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
                    loadContact();
                }
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8) //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.BringToFront();
            lvContact.Enabled = false;
        }

        //Group

        /**
         * Enable or disable input/text fields
         */
        private void FieldsGroup()
        {
            if (fieldGroup == true)
            {
                txtGroup.Enabled = true;
            }
            else
            {
                txtGroup.Enabled = false;
            }
        }

        /**
         * Enable and Disable Specific button
         */
        private void ButtonsGroup()
        {
            if (buttonsGroup == "default")
            {
                btnGroupAdd.Enabled = true;
                btnGroupDelete.Enabled = true;
                btnGroupEdit.Enabled = true;
                btnGroupAdd.Text = "Add a Group";
                btnGroupEdit.Text = "Edit Group";
                btnGroupDelete.Text = "Delete Group";
            }
            else if (buttonsGroup == "add")
            {
                btnGroupAdd.Enabled = true;
                btnGroupDelete.Enabled = true;
                btnGroupEdit.Enabled = false;
                btnGroupAdd.Text = "Save Group";
                btnGroupDelete.Text = "Cancel";
            }
            else if (buttonsGroup == "edit")
            {
                btnGroupAdd.Enabled = false;
                btnGroupDelete.Enabled = true;
                btnGroupEdit.Enabled = true;
                btnGroupEdit.Text = "Update Group";
                btnGroupDelete.Text = "Cancel";
            }
        }

        private void clearFieldsGroup()
        {
            txtGroup.Clear();
        }

        public void loadGroup()
        {
            str = Model.groupModel.getGroups();
            if (str == "success")
            {
                lvGroup.Items.Clear();
                cboGroup.Items.Clear();
                for (int count = 0; count < config.records.Count; count++)
                {
                    ListViewItem item = new ListViewItem(config.records[count].id.ToString());
                    item.SubItems.Add(count.ToString());
                    item.SubItems.Add(config.records[count].group.ToString());
                    lvGroup.Items.Add(item);
                    cboGroup.Items.Add(config.records[count].group.ToString()); // add item in combobox
                }
            }
            else
            {

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.SendToBack();
            lvContact.Enabled = true;
            fieldGroup = false;
            FieldsGroup();
            buttonsGroup = "default";
            ButtonsGroup();
            cancelGroup = false;
            clearFieldsGroup();
        }

        private void btnGroupAdd_Click(object sender, EventArgs e)
        {
            if (fieldGroup == false)
            {
                fieldGroup = true;
                cancelGroup = true;
                buttonsGroup = "add";
                FieldsGroup(); // enable fields
                ButtonsGroup();
            }
            else
            {
                if (fieldGroup == true)
                {
                    string group = txtGroup.Text;
                    if (group == "")
                    {
                        MessageBox.Show("Please enter group name", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        Entity.variables ent = new Entity.variables();
                        ent.group = group;
                        string str = Model.groupModel.addGroup(ent);
                        if (str == "success")
                        {
                            loadGroup();
                            MessageBox.Show("successfully added", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            fieldGroup = false;
                            FieldsGroup();
                            buttonsGroup = "default";
                            ButtonsGroup();
                            cancelGroup = false;
                            clearFieldsGroup();
                        }
                        else
                        {
                            MessageBox.Show(str);
                        }
                    }
                }
            }
        }

        private void btnGroupEdit_Click(object sender, EventArgs e)
        {
            
            try
            {
                id = Convert.ToInt32(lvGroup.SelectedItems[0].SubItems[0].Text);
                if (fieldGroup == false)
                {
                    fieldGroup = true;
                    cancelGroup = true;
                    buttonsGroup = "edit";
                    FieldsGroup(); // enable fields
                    ButtonsGroup();

                    txtGroup.Text = lvGroup.SelectedItems[0].SubItems[2].Text;
                }
                else
                {
                    if (fieldGroup == true)
                    {
                        string group = txtGroup.Text;
                        if (group == "")
                        {
                            MessageBox.Show("Please enter the group name", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            Entity.variables ent = new Entity.variables();
                            ent.group = group;
                            ent.id = id;
                            string str = Model.groupModel.editGroup(ent);
                            if (str == "success")
                            {
                                loadGroup();
                                MessageBox.Show("successfully update", "MPS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                fieldGroup = false;
                                FieldsGroup();
                                buttonsGroup = "default";
                                ButtonsGroup();
                                cancelGroup = false;
                                clearFieldsGroup();
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
                MessageBox.Show("Please select the group name you want to edit", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGroupDelete_Click(object sender, EventArgs e)
        {
            if (cancelGroup == true) // will clear textbox/input fields
            {
                fieldGroup = false;
                buttonsGroup = "default";
                FieldsGroup(); // enable fields
                ButtonsGroup();
                clearFieldsGroup();
            }
            else // delete selected record from listview
            {
                
                try
                {
                    id = Convert.ToInt32(lvGroup.SelectedItems[0].SubItems[0].Text);
                    
                    DialogResult dr = MessageBox.Show("Are you sure want to delete this group?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        str = Model.groupModel.deleteGroup(id);
                        if (str == "success")
                        {
                            lvGroup.Items.Remove(lvGroup.SelectedItems[0]);
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
                    MessageBox.Show("Please select the group name you want to delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length < 1)
            {
                loadContact("All", "All");
            }
            else
            {
                loadContact(cboFilter.Text, txtSearch.Text.Trim());
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!backgroundworker.IsBusy)
                backgroundworker.RunWorkerAsync();
        }
    }
}
