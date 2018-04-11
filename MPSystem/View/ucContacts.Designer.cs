namespace MPSystem
{
    partial class ucContacts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvContact = new System.Windows.Forms.ListView();
            this.dbID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mobile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Network = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGroup = new System.Windows.Forms.Button();
            this.cboNetwork = new System.Windows.Forms.ComboBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.backgroundworker = new System.ComponentModel.BackgroundWorker();
            this.lblPages = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvGroup = new System.Windows.Forms.ListView();
            this.ids = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGroupDelete = new System.Windows.Forms.Button();
            this.btnGroupEdit = new System.Windows.Forms.Button();
            this.btnGroupAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter";
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Items.AddRange(new object[] {
            "All",
            "Mobile No",
            "Network",
            "Group"});
            this.cboFilter.Location = new System.Drawing.Point(64, 10);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(122, 21);
            this.cboFilter.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(196, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.txtSearch.MaximumSize = new System.Drawing.Size(288, 21);
            this.txtSearch.MinimumSize = new System.Drawing.Size(288, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(288, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(214)))), ((int)(((byte)(151)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(214)))), ((int)(((byte)(151)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(491, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnSearch.MaximumSize = new System.Drawing.Size(56, 21);
            this.btnSearch.MinimumSize = new System.Drawing.Size(56, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 21);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lvContact
            // 
            this.lvContact.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dbID,
            this.ID,
            this.Mobile,
            this.Network,
            this.Group});
            this.lvContact.FullRowSelect = true;
            this.lvContact.GridLines = true;
            this.lvContact.Location = new System.Drawing.Point(26, 152);
            this.lvContact.Name = "lvContact";
            this.lvContact.Size = new System.Drawing.Size(659, 344);
            this.lvContact.TabIndex = 4;
            this.lvContact.UseCompatibleStateImageBehavior = false;
            this.lvContact.View = System.Windows.Forms.View.Details;
            // 
            // dbID
            // 
            this.dbID.Text = "ID";
            this.dbID.Width = 0;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 123;
            // 
            // Mobile
            // 
            this.Mobile.Text = "Contact Number";
            this.Mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mobile.Width = 216;
            // 
            // Network
            // 
            this.Network.Text = "Network";
            this.Network.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Network.Width = 145;
            // 
            // Group
            // 
            this.Group.Text = "Group";
            this.Group.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Group.Width = 171;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.btnGroup);
            this.panel1.Controls.Add(this.cboNetwork);
            this.panel1.Controls.Add(this.cboGroup);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(26, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 97);
            this.panel1.TabIndex = 5;
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnGroup.BackgroundImage = global::MPSystem.Properties.Resources.addbtn;
            this.btnGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGroup.FlatAppearance.BorderSize = 0;
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGroup.ForeColor = System.Drawing.Color.White;
            this.btnGroup.Location = new System.Drawing.Point(535, 63);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(21, 21);
            this.btnGroup.TabIndex = 10;
            this.btnGroup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // cboNetwork
            // 
            this.cboNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNetwork.FormattingEnabled = true;
            this.cboNetwork.Items.AddRange(new object[] {
            "Globe",
            "Touch Mobile"});
            this.cboNetwork.Location = new System.Drawing.Point(267, 36);
            this.cboNetwork.Name = "cboNetwork";
            this.cboNetwork.Size = new System.Drawing.Size(289, 21);
            this.cboNetwork.TabIndex = 8;
            // 
            // cboGroup
            // 
            this.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(267, 63);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(266, 21);
            this.cboGroup.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(177, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Assign to group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(177, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Network";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(177, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact Number";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(267, 12);
            this.txtContact.MaxLength = 11;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(289, 20);
            this.txtContact.TabIndex = 7;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(17, 62);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.btnDelete.MaximumSize = new System.Drawing.Size(97, 23);
            this.btnDelete.MinimumSize = new System.Drawing.Size(97, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Contact";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(17, 37);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnEdit.MaximumSize = new System.Drawing.Size(97, 23);
            this.btnEdit.MinimumSize = new System.Drawing.Size(97, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit Contact";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(17, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnAdd.MaximumSize = new System.Drawing.Size(97, 23);
            this.btnAdd.MinimumSize = new System.Drawing.Size(97, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add a Contact";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.ForeColor = System.Drawing.Color.White;
            this.lblPages.Location = new System.Drawing.Point(23, 507);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(68, 13);
            this.lblPages.TabIndex = 15;
            this.lblPages.Text = "Page: 0 of  0";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(631, 502);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(571, 502);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(54, 23);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(14, 112);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.txtGroup);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lvGroup);
            this.panel2.Controls.Add(this.btnGroupDelete);
            this.panel2.Controls.Add(this.btnGroupEdit);
            this.panel2.Controls.Add(this.btnGroupAdd);
            this.panel2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.panel2.Location = new System.Drawing.Point(43, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 348);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // txtGroup
            // 
            this.txtGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroup.Location = new System.Drawing.Point(215, 24);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(300, 21);
            this.txtGroup.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Group Name";
            // 
            // lvGroup
            // 
            this.lvGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ids,
            this.IDx,
            this.grpName});
            this.lvGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGroup.FullRowSelect = true;
            this.lvGroup.GridLines = true;
            this.lvGroup.Location = new System.Drawing.Point(142, 64);
            this.lvGroup.Name = "lvGroup";
            this.lvGroup.Size = new System.Drawing.Size(373, 269);
            this.lvGroup.TabIndex = 1;
            this.lvGroup.UseCompatibleStateImageBehavior = false;
            this.lvGroup.View = System.Windows.Forms.View.Details;
            // 
            // ids
            // 
            this.ids.Text = "IDS";
            this.ids.Width = 0;
            // 
            // IDx
            // 
            this.IDx.Text = "ID";
            // 
            // grpName
            // 
            this.grpName.Text = "Group Name";
            this.grpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.grpName.Width = 303;
            // 
            // btnGroupDelete
            // 
            this.btnGroupDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnGroupDelete.FlatAppearance.BorderSize = 0;
            this.btnGroupDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupDelete.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnGroupDelete.ForeColor = System.Drawing.Color.White;
            this.btnGroupDelete.Location = new System.Drawing.Point(14, 83);
            this.btnGroupDelete.Name = "btnGroupDelete";
            this.btnGroupDelete.Size = new System.Drawing.Size(99, 23);
            this.btnGroupDelete.TabIndex = 0;
            this.btnGroupDelete.Text = "Delete";
            this.btnGroupDelete.UseVisualStyleBackColor = false;
            this.btnGroupDelete.Click += new System.EventHandler(this.btnGroupDelete_Click);
            // 
            // btnGroupEdit
            // 
            this.btnGroupEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnGroupEdit.FlatAppearance.BorderSize = 0;
            this.btnGroupEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupEdit.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnGroupEdit.ForeColor = System.Drawing.Color.White;
            this.btnGroupEdit.Location = new System.Drawing.Point(14, 54);
            this.btnGroupEdit.Name = "btnGroupEdit";
            this.btnGroupEdit.Size = new System.Drawing.Size(99, 23);
            this.btnGroupEdit.TabIndex = 0;
            this.btnGroupEdit.Text = "Edit";
            this.btnGroupEdit.UseVisualStyleBackColor = false;
            this.btnGroupEdit.Click += new System.EventHandler(this.btnGroupEdit_Click);
            // 
            // btnGroupAdd
            // 
            this.btnGroupAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnGroupAdd.FlatAppearance.BorderSize = 0;
            this.btnGroupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupAdd.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnGroupAdd.ForeColor = System.Drawing.Color.White;
            this.btnGroupAdd.Location = new System.Drawing.Point(14, 25);
            this.btnGroupAdd.Name = "btnGroupAdd";
            this.btnGroupAdd.Size = new System.Drawing.Size(99, 23);
            this.btnGroupAdd.TabIndex = 0;
            this.btnGroupAdd.Text = "Add";
            this.btnGroupAdd.UseVisualStyleBackColor = false;
            this.btnGroupAdd.Click += new System.EventHandler(this.btnGroupAdd_Click);
            // 
            // ucContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvContact);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(711, 536);
            this.MinimumSize = new System.Drawing.Size(711, 536);
            this.Name = "ucContacts";
            this.Size = new System.Drawing.Size(711, 536);
            this.Load += new System.EventHandler(this.ucContacts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvContact;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.ColumnHeader Mobile;
        private System.Windows.Forms.ColumnHeader Network;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ComboBox cboNetwork;
        private System.Windows.Forms.ColumnHeader dbID;
        private System.ComponentModel.BackgroundWorker backgroundworker;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvGroup;
        private System.Windows.Forms.ColumnHeader ids;
        private System.Windows.Forms.ColumnHeader IDx;
        private System.Windows.Forms.ColumnHeader grpName;
        private System.Windows.Forms.Button btnGroupDelete;
        private System.Windows.Forms.Button btnGroupEdit;
        private System.Windows.Forms.Button btnGroupAdd;
    }
}
