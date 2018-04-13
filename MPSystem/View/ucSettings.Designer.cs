namespace MPSystem.View
{
    partial class ucSettings
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
            this.pnlDump = new System.Windows.Forms.Panel();
            this.btnDump = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNetwork = new System.Windows.Forms.Label();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundworker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlClearData = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboModule = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkClearData = new System.Windows.Forms.CheckBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.pnlDump.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlClearData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDump
            // 
            this.pnlDump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.pnlDump.Controls.Add(this.btnDump);
            this.pnlDump.Controls.Add(this.label5);
            this.pnlDump.Controls.Add(this.label4);
            this.pnlDump.Controls.Add(this.lblNetwork);
            this.pnlDump.Controls.Add(this.cboPorts);
            this.pnlDump.Controls.Add(this.checkBox1);
            this.pnlDump.Controls.Add(this.label2);
            this.pnlDump.Location = new System.Drawing.Point(15, 34);
            this.pnlDump.Name = "pnlDump";
            this.pnlDump.Size = new System.Drawing.Size(676, 55);
            this.pnlDump.TabIndex = 1;
            // 
            // btnDump
            // 
            this.btnDump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnDump.FlatAppearance.BorderSize = 0;
            this.btnDump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDump.ForeColor = System.Drawing.Color.White;
            this.btnDump.Location = new System.Drawing.Point(281, 87);
            this.btnDump.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnDump.MaximumSize = new System.Drawing.Size(97, 23);
            this.btnDump.MinimumSize = new System.Drawing.Size(97, 23);
            this.btnDump.Name = "btnDump";
            this.btnDump.Size = new System.Drawing.Size(97, 23);
            this.btnDump.TabIndex = 12;
            this.btnDump.Text = "Start Dump";
            this.btnDump.UseVisualStyleBackColor = false;
            this.btnDump.Click += new System.EventHandler(this.btnDump_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Network Provider:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Port Name:";
            // 
            // lblNetwork
            // 
            this.lblNetwork.AutoSize = true;
            this.lblNetwork.ForeColor = System.Drawing.Color.White;
            this.lblNetwork.Location = new System.Drawing.Point(153, 92);
            this.lblNetwork.Name = "lblNetwork";
            this.lblNetwork.Size = new System.Drawing.Size(49, 13);
            this.lblNetwork.TabIndex = 9;
            this.lblNetwork.Text = "--------------";
            // 
            // cboPorts
            // 
            this.cboPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.cboPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPorts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(156, 60);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(222, 21);
            this.cboPorts.TabIndex = 5;
            this.cboPorts.SelectedIndexChanged += new System.EventHandler(this.cboPorts_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.checkBox1.Location = new System.Drawing.Point(103, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(12, 11);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dump Contacts";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 55);
            this.panel1.TabIndex = 2;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(58, 18);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(57, 21);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Logs";
            // 
            // pnlClearData
            // 
            this.pnlClearData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlClearData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.pnlClearData.Controls.Add(this.btnClearData);
            this.pnlClearData.Controls.Add(this.chkClearData);
            this.pnlClearData.Controls.Add(this.label6);
            this.pnlClearData.Controls.Add(this.cboModule);
            this.pnlClearData.Controls.Add(this.label3);
            this.pnlClearData.Location = new System.Drawing.Point(15, 156);
            this.pnlClearData.Name = "pnlClearData";
            this.pnlClearData.Size = new System.Drawing.Size(676, 55);
            this.pnlClearData.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clear Data";
            // 
            // cboModule
            // 
            this.cboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModule.FormattingEnabled = true;
            this.cboModule.Items.AddRange(new object[] {
            "Contact",
            "Message",
            "Promotion",
            "Auto Reply",
            "USSD Command"});
            this.cboModule.Location = new System.Drawing.Point(55, 75);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(235, 21);
            this.cboModule.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Choose Module";
            // 
            // chkClearData
            // 
            this.chkClearData.AutoSize = true;
            this.chkClearData.FlatAppearance.BorderSize = 0;
            this.chkClearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkClearData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.chkClearData.Location = new System.Drawing.Point(80, 23);
            this.chkClearData.Name = "chkClearData";
            this.chkClearData.Size = new System.Drawing.Size(12, 11);
            this.chkClearData.TabIndex = 13;
            this.chkClearData.UseVisualStyleBackColor = true;
            this.chkClearData.CheckedChanged += new System.EventHandler(this.chkClearData_CheckedChanged);
            // 
            // btnClearData
            // 
            this.btnClearData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnClearData.FlatAppearance.BorderSize = 0;
            this.btnClearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearData.ForeColor = System.Drawing.Color.White;
            this.btnClearData.Location = new System.Drawing.Point(296, 74);
            this.btnClearData.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(82, 21);
            this.btnClearData.TabIndex = 6;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = false;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlClearData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDump);
            this.MaximumSize = new System.Drawing.Size(711, 536);
            this.MinimumSize = new System.Drawing.Size(711, 536);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(711, 536);
            this.Load += new System.EventHandler(this.ucSettings_Load);
            this.pnlDump.ResumeLayout(false);
            this.pnlDump.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlClearData.ResumeLayout(false);
            this.pnlClearData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDump;
        private System.Windows.Forms.Button btnDump;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNetwork;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundworker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel pnlClearData;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.CheckBox chkClearData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboModule;
        private System.Windows.Forms.Label label3;
    }
}
