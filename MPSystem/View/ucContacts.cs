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


        private static Boolean field = false;
        private static Boolean cancel = false;
        private static string buttons = "default";
        private static string str;
        private static int id;

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
                Fields();
                Buttons();
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
            str = Model.contactModel.getContacts();
            if (str == "success")
            {
                lvContact.Items.Clear();

                for (int count = 0; count < config.records.Count; count++)
                {
                    ListViewItem item = new ListViewItem(config.records[count].id.ToString());
                    item.SubItems.Add(count.ToString());
                    item.SubItems.Add(config.records[count].mobile_no.ToString());
                    item.SubItems.Add(config.records[count].network.ToString());
                    item.SubItems.Add(config.records[count].group.ToString());
                    lvContact.Items.Add(item);

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
            if(cancel == true) // will clear textbox/input fields
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
            catch(Exception)
            {
                MessageBox.Show("Please select the number you want to edit", "Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}