namespace MPSystem.View
{
    partial class ucUssd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPages = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.backgroundworker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlUSD = new System.Windows.Forms.Panel();
            this.btnCloseUssdPanel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendUSSD = new System.Windows.Forms.Button();
            this.txtCommandBox = new System.Windows.Forms.TextBox();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.lvList = new System.Windows.Forms.ListView();
            this.ussdid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Command = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UssdDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlDialog = new System.Windows.Forms.Panel();
            this.btnCloseDialogMessage = new System.Windows.Forms.Button();
            this.flpDialog = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUssdReply = new System.Windows.Forms.Label();
            this.lvHistory = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlUSD.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlDialog.SuspendLayout();
            this.flpDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCommand);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(26, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 97);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(267, 52);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(289, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(177, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Command";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(267, 24);
            this.txtCommand.MaxLength = 50;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(289, 20);
            this.txtCommand.TabIndex = 7;
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
            this.btnDelete.Text = "Delete Command";
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
            this.btnEdit.Text = "Edit Command";
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
            this.btnAdd.Text = "Add a Command";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.ForeColor = System.Drawing.Color.White;
            this.lblPages.Location = new System.Drawing.Point(23, 504);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(65, 13);
            this.lblPages.TabIndex = 16;
            this.lblPages.Text = "Page: 0 of 0";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(630, 498);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(570, 498);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(54, 23);
            this.btnPrev.TabIndex = 14;
            this.btnPrev.Text = "prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 375);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlUSD);
            this.tabPage1.Controls.Add(this.lvList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "USSD Command";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlUSD
            // 
            this.pnlUSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.pnlUSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUSD.Controls.Add(this.btnCloseUssdPanel);
            this.pnlUSD.Controls.Add(this.flowLayoutPanel1);
            this.pnlUSD.Controls.Add(this.label4);
            this.pnlUSD.Controls.Add(this.label3);
            this.pnlUSD.Controls.Add(this.btnSendUSSD);
            this.pnlUSD.Controls.Add(this.txtCommandBox);
            this.pnlUSD.Controls.Add(this.cboPort);
            this.pnlUSD.Location = new System.Drawing.Point(176, 24);
            this.pnlUSD.Name = "pnlUSD";
            this.pnlUSD.Size = new System.Drawing.Size(316, 263);
            this.pnlUSD.TabIndex = 19;
            this.pnlUSD.Visible = false;
            // 
            // btnCloseUssdPanel
            // 
            this.btnCloseUssdPanel.BackgroundImage = global::MPSystem.Properties.Resources.closeBlack;
            this.btnCloseUssdPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseUssdPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseUssdPanel.FlatAppearance.BorderSize = 0;
            this.btnCloseUssdPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseUssdPanel.Location = new System.Drawing.Point(265, 3);
            this.btnCloseUssdPanel.Name = "btnCloseUssdPanel";
            this.btnCloseUssdPanel.Size = new System.Drawing.Size(46, 20);
            this.btnCloseUssdPanel.TabIndex = 5;
            this.btnCloseUssdPanel.UseVisualStyleBackColor = true;
            this.btnCloseUssdPanel.Click += new System.EventHandler(this.btnCloseUssdPanel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblDescription);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 117);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(268, 69);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(6, 3);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Command";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "COMPORT";
            // 
            // btnSendUSSD
            // 
            this.btnSendUSSD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnSendUSSD.FlatAppearance.BorderSize = 0;
            this.btnSendUSSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendUSSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendUSSD.ForeColor = System.Drawing.Color.White;
            this.btnSendUSSD.Location = new System.Drawing.Point(24, 196);
            this.btnSendUSSD.Name = "btnSendUSSD";
            this.btnSendUSSD.Size = new System.Drawing.Size(268, 46);
            this.btnSendUSSD.TabIndex = 2;
            this.btnSendUSSD.Text = "Send";
            this.btnSendUSSD.UseVisualStyleBackColor = false;
            this.btnSendUSSD.Click += new System.EventHandler(this.btnSendUSSD_Click);
            // 
            // txtCommandBox
            // 
            this.txtCommandBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandBox.Location = new System.Drawing.Point(96, 77);
            this.txtCommandBox.Name = "txtCommandBox";
            this.txtCommandBox.Size = new System.Drawing.Size(196, 21);
            this.txtCommandBox.TabIndex = 1;
            // 
            // cboPort
            // 
            this.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(96, 41);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(196, 21);
            this.cboPort.TabIndex = 0;
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ussdid,
            this.columnHeader1,
            this.Command,
            this.UssdDescription});
            this.lvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(3, 3);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(644, 343);
            this.lvList.TabIndex = 18;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvList_MouseDoubleClick);
            // 
            // ussdid
            // 
            this.ussdid.Text = "id";
            this.ussdid.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 47;
            // 
            // Command
            // 
            this.Command.Text = "USSD Command";
            this.Command.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Command.Width = 188;
            // 
            // UssdDescription
            // 
            this.UssdDescription.Text = "Description";
            this.UssdDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UssdDescription.Width = 394;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlDialog);
            this.tabPage2.Controls.Add(this.lvHistory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(650, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "USSD History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlDialog
            // 
            this.pnlDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.pnlDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDialog.Controls.Add(this.btnCloseDialogMessage);
            this.pnlDialog.Controls.Add(this.flpDialog);
            this.pnlDialog.Location = new System.Drawing.Point(167, 43);
            this.pnlDialog.Name = "pnlDialog";
            this.pnlDialog.Size = new System.Drawing.Size(316, 263);
            this.pnlDialog.TabIndex = 20;
            this.pnlDialog.Visible = false;
            // 
            // btnCloseDialogMessage
            // 
            this.btnCloseDialogMessage.BackgroundImage = global::MPSystem.Properties.Resources.closeBlack;
            this.btnCloseDialogMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseDialogMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseDialogMessage.FlatAppearance.BorderSize = 0;
            this.btnCloseDialogMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDialogMessage.Location = new System.Drawing.Point(265, 3);
            this.btnCloseDialogMessage.Name = "btnCloseDialogMessage";
            this.btnCloseDialogMessage.Size = new System.Drawing.Size(46, 20);
            this.btnCloseDialogMessage.TabIndex = 5;
            this.btnCloseDialogMessage.UseVisualStyleBackColor = true;
            this.btnCloseDialogMessage.Click += new System.EventHandler(this.btnCloseDialogMessage_Click);
            // 
            // flpDialog
            // 
            this.flpDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDialog.Controls.Add(this.lblUssdReply);
            this.flpDialog.Location = new System.Drawing.Point(24, 29);
            this.flpDialog.Name = "flpDialog";
            this.flpDialog.Padding = new System.Windows.Forms.Padding(3);
            this.flpDialog.Size = new System.Drawing.Size(268, 214);
            this.flpDialog.TabIndex = 4;
            // 
            // lblUssdReply
            // 
            this.lblUssdReply.AutoSize = true;
            this.lblUssdReply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUssdReply.ForeColor = System.Drawing.Color.White;
            this.lblUssdReply.Location = new System.Drawing.Point(6, 3);
            this.lblUssdReply.Name = "lblUssdReply";
            this.lblUssdReply.Size = new System.Drawing.Size(0, 13);
            this.lblUssdReply.TabIndex = 0;
            // 
            // lvHistory
            // 
            this.lvHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHistory.FullRowSelect = true;
            this.lvHistory.GridLines = true;
            this.lvHistory.Location = new System.Drawing.Point(3, 3);
            this.lvHistory.Name = "lvHistory";
            this.lvHistory.Size = new System.Drawing.Size(644, 343);
            this.lvHistory.TabIndex = 19;
            this.lvHistory.UseCompatibleStateImageBehavior = false;
            this.lvHistory.View = System.Windows.Forms.View.Details;
            this.lvHistory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvHistory_MouseDoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ussd Reply";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 416;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "System Receive DateTime";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 185;
            // 
            // ucUssd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(711, 536);
            this.MinimumSize = new System.Drawing.Size(711, 536);
            this.Name = "ucUssd";
            this.Size = new System.Drawing.Size(711, 536);
            this.Load += new System.EventHandler(this.ucUssd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlUSD.ResumeLayout(false);
            this.pnlUSD.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlDialog.ResumeLayout(false);
            this.flpDialog.ResumeLayout(false);
            this.flpDialog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.ComponentModel.BackgroundWorker backgroundworker;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlUSD;
        private System.Windows.Forms.Button btnCloseUssdPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendUSSD;
        private System.Windows.Forms.TextBox txtCommandBox;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader ussdid;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Command;
        private System.Windows.Forms.ColumnHeader UssdDescription;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlDialog;
        private System.Windows.Forms.Button btnCloseDialogMessage;
        private System.Windows.Forms.FlowLayoutPanel flpDialog;
        private System.Windows.Forms.Label lblUssdReply;
        private System.Windows.Forms.ListView lvHistory;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;

    }
}
