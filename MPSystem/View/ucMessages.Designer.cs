namespace MPSystem.View
{
    partial class ucMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMessages));
            this.lvList = new System.Windows.Forms.ListView();
            this.msgID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.promo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPages = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.backgroundworker = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlDialog = new System.Windows.Forms.Panel();
            this.btnCloseDialogMessage = new System.Windows.Forms.Button();
            this.flpDialog = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUssdReply = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.pnlDialog.SuspendLayout();
            this.flpDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.msgID,
            this.contactNumber,
            this.Message,
            this.dateTime,
            this.promo});
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(3, 62);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(705, 422);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvList_MouseDoubleClick);
            // 
            // msgID
            // 
            this.msgID.Text = "ID";
            this.msgID.Width = 0;
            // 
            // contactNumber
            // 
            this.contactNumber.Text = "Contact Number";
            this.contactNumber.Width = 113;
            // 
            // Message
            // 
            this.Message.Text = "Message";
            this.Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Message.Width = 231;
            // 
            // dateTime
            // 
            this.dateTime.Text = "Date/Time";
            this.dateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateTime.Width = 147;
            // 
            // promo
            // 
            this.promo.Text = "Promo";
            this.promo.Width = 202;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.ForeColor = System.Drawing.Color.White;
            this.lblPages.Location = new System.Drawing.Point(6, 501);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(83, 13);
            this.lblPages.TabIndex = 18;
            this.lblPages.Text = "Page: 0 out of 0";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(654, 496);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 23);
            this.btnNext.TabIndex = 17;
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
            this.btnPrev.Location = new System.Drawing.Point(594, 496);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(54, 23);
            this.btnPrev.TabIndex = 16;
            this.btnPrev.Text = "prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(470, 8);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnSearch.MaximumSize = new System.Drawing.Size(56, 21);
            this.btnSearch.MinimumSize = new System.Drawing.Size(56, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 21);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(175, 8);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.txtSearch.MaximumSize = new System.Drawing.Size(288, 21);
            this.txtSearch.MinimumSize = new System.Drawing.Size(288, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(288, 20);
            this.txtSearch.TabIndex = 20;
            // 
            // backgroundworker
            // 
            this.backgroundworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundworker_DoWork);
            this.backgroundworker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundworker_ProgressChanged);
            this.backgroundworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundworker_RunWorkerCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(621, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Refresh data";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(594, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(21, 23);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlDialog
            // 
            this.pnlDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.pnlDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDialog.Controls.Add(this.lblFrom);
            this.pnlDialog.Controls.Add(this.label1);
            this.pnlDialog.Controls.Add(this.btnCloseDialogMessage);
            this.pnlDialog.Controls.Add(this.flpDialog);
            this.pnlDialog.Location = new System.Drawing.Point(197, 137);
            this.pnlDialog.Name = "pnlDialog";
            this.pnlDialog.Size = new System.Drawing.Size(316, 263);
            this.pnlDialog.TabIndex = 24;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "From:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(60, 10);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(0, 13);
            this.lblFrom.TabIndex = 7;
            // 
            // ucMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDialog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lvList);
            this.MaximumSize = new System.Drawing.Size(711, 536);
            this.MinimumSize = new System.Drawing.Size(711, 536);
            this.Name = "ucMessages";
            this.Size = new System.Drawing.Size(711, 536);
            this.Load += new System.EventHandler(this.ucMessages_Load);
            this.pnlDialog.ResumeLayout(false);
            this.pnlDialog.PerformLayout();
            this.flpDialog.ResumeLayout(false);
            this.flpDialog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader contactNumber;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.ColumnHeader dateTime;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ColumnHeader promo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.ComponentModel.BackgroundWorker backgroundworker;
        private System.Windows.Forms.ColumnHeader msgID;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDialog;
        private System.Windows.Forms.Button btnCloseDialogMessage;
        private System.Windows.Forms.FlowLayoutPanel flpDialog;
        private System.Windows.Forms.Label lblUssdReply;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label label1;
    }
}
