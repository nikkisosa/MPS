namespace MPSystem.View
{
    partial class ucAutoreply
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
            this.lvList = new System.Windows.Forms.ListView();
            this.autoid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Command = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reply = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtReply = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.backgroundworker = new System.ComponentModel.BackgroundWorker();
            this.lblPages = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pnlDialog = new System.Windows.Forms.Panel();
            this.lblCommand = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseDialogMessage = new System.Windows.Forms.Button();
            this.flpDialog = new System.Windows.Forms.FlowLayoutPanel();
            this.lblmessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlDialog.SuspendLayout();
            this.flpDialog.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.autoid,
            this.ID,
            this.Command,
            this.Reply});
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(15, 112);
            this.lvList.MaximumSize = new System.Drawing.Size(681, 376);
            this.lvList.MinimumSize = new System.Drawing.Size(681, 376);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(681, 376);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvList_MouseDoubleClick);
            // 
            // autoid
            // 
            this.autoid.Text = "id";
            this.autoid.Width = 0;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 0;
            // 
            // Command
            // 
            this.Command.Text = "Command";
            this.Command.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Command.Width = 220;
            // 
            // Reply
            // 
            this.Reply.Text = "Reply";
            this.Reply.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Reply.Width = 455;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.txtReply);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCommand);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(15, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 91);
            this.panel1.TabIndex = 6;
            // 
            // txtReply
            // 
            this.txtReply.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReply.Location = new System.Drawing.Point(202, 53);
            this.txtReply.MaxLength = 550;
            this.txtReply.Name = "txtReply";
            this.txtReply.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtReply.Size = new System.Drawing.Size(459, 29);
            this.txtReply.TabIndex = 6;
            this.txtReply.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(139, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reply";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Command";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(202, 22);
            this.txtCommand.MaxLength = 160;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(459, 20);
            this.txtCommand.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(18, 59);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.btnDelete.MaximumSize = new System.Drawing.Size(97, 23);
            this.btnDelete.MinimumSize = new System.Drawing.Size(97, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Command";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(18, 35);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnEdit.MaximumSize = new System.Drawing.Size(97, 23);
            this.btnEdit.MinimumSize = new System.Drawing.Size(97, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Command";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(18, 11);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnAdd.MaximumSize = new System.Drawing.Size(97, 23);
            this.btnAdd.MinimumSize = new System.Drawing.Size(97, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add a Command";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.ForeColor = System.Drawing.Color.White;
            this.lblPages.Location = new System.Drawing.Point(12, 499);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(65, 13);
            this.lblPages.TabIndex = 12;
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
            this.btnNext.Location = new System.Drawing.Point(642, 494);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 23);
            this.btnNext.TabIndex = 11;
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
            this.btnPrev.Location = new System.Drawing.Point(582, 494);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(54, 23);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.Text = "prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // pnlDialog
            // 
            this.pnlDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.pnlDialog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDialog.Controls.Add(this.lblCommand);
            this.pnlDialog.Controls.Add(this.label1);
            this.pnlDialog.Controls.Add(this.btnCloseDialogMessage);
            this.pnlDialog.Controls.Add(this.flpDialog);
            this.pnlDialog.Location = new System.Drawing.Point(197, 137);
            this.pnlDialog.Name = "pnlDialog";
            this.pnlDialog.Size = new System.Drawing.Size(316, 263);
            this.pnlDialog.TabIndex = 25;
            this.pnlDialog.Visible = false;
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommand.ForeColor = System.Drawing.Color.White;
            this.lblCommand.Location = new System.Drawing.Point(78, 10);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(0, 13);
            this.lblCommand.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Commad:";
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
            this.flpDialog.Controls.Add(this.lblmessage);
            this.flpDialog.Location = new System.Drawing.Point(24, 29);
            this.flpDialog.Name = "flpDialog";
            this.flpDialog.Padding = new System.Windows.Forms.Padding(3);
            this.flpDialog.Size = new System.Drawing.Size(268, 214);
            this.flpDialog.TabIndex = 4;
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ForeColor = System.Drawing.Color.White;
            this.lblmessage.Location = new System.Drawing.Point(6, 3);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 13);
            this.lblmessage.TabIndex = 0;
            // 
            // ucAutoreply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDialog);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvList);
            this.MaximumSize = new System.Drawing.Size(711, 536);
            this.MinimumSize = new System.Drawing.Size(711, 536);
            this.Name = "ucAutoreply";
            this.Size = new System.Drawing.Size(711, 536);
            this.Load += new System.EventHandler(this.Autoreply_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDialog.ResumeLayout(false);
            this.pnlDialog.PerformLayout();
            this.flpDialog.ResumeLayout(false);
            this.flpDialog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Command;
        private System.Windows.Forms.ColumnHeader Reply;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.ComponentModel.BackgroundWorker backgroundworker;
        private System.Windows.Forms.ColumnHeader autoid;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.RichTextBox txtReply;
        private System.Windows.Forms.Panel pnlDialog;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseDialogMessage;
        private System.Windows.Forms.FlowLayoutPanel flpDialog;
        private System.Windows.Forms.Label lblmessage;
    }
}
