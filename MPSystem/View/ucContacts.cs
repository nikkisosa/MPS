using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public ucContacts()
        {
            InitializeComponent();
        }

        /**
         * Load data from database
         */
        public void loadContact()
        {
            string str = Model.contactModel.getContacts();
            if (str == "success")
            {
                lvContact.Items.Clear();

                for (int count = 0; count < config.records.Count; count++)
                {
                    ListViewItem item = new ListViewItem(count.ToString());
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
                btnDelete.Text = "Edit Contact";
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
            loadContact();
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
                        Entity.Contacts ent = new Entity.Contacts();
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

            }
        }
    }
}
