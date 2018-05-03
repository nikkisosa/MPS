namespace MPSystem.View
{
    partial class ucDashboard
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
            this.dashGrid = new System.Windows.Forms.DataGridView();
            this.checkOption = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.load = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Network = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSos = new System.Windows.Forms.Button();
            this.btnCheckNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dashGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dashGrid
            // 
            this.dashGrid.AllowUserToAddRows = false;
            this.dashGrid.AllowUserToDeleteRows = false;
            this.dashGrid.BackgroundColor = System.Drawing.Color.White;
            this.dashGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dashGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dashGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dashGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dashGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkOption,
            this.comPort,
            this.mobileNumber,
            this.load,
            this.Network});
            this.dashGrid.Location = new System.Drawing.Point(8, 67);
            this.dashGrid.Name = "dashGrid";
            this.dashGrid.Size = new System.Drawing.Size(694, 424);
            this.dashGrid.TabIndex = 0;
            // 
            // checkOption
            // 
            this.checkOption.HeaderText = "";
            this.checkOption.Name = "checkOption";
            this.checkOption.Width = 50;
            // 
            // comPort
            // 
            this.comPort.HeaderText = "COMPORT";
            this.comPort.Name = "comPort";
            // 
            // mobileNumber
            // 
            this.mobileNumber.HeaderText = "Mobile Number";
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.Width = 200;
            // 
            // load
            // 
            this.load.HeaderText = "Load ";
            this.load.Name = "load";
            this.load.Width = 150;
            // 
            // Network
            // 
            this.Network.HeaderText = "Network";
            this.Network.Name = "Network";
            this.Network.ReadOnly = true;
            this.Network.Width = 150;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btnSos
            // 
            this.btnSos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnSos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSos.FlatAppearance.BorderSize = 0;
            this.btnSos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(214)))), ((int)(((byte)(151)))));
            this.btnSos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(214)))), ((int)(((byte)(151)))));
            this.btnSos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSos.ForeColor = System.Drawing.Color.White;
            this.btnSos.Location = new System.Drawing.Point(8, 505);
            this.btnSos.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnSos.MaximumSize = new System.Drawing.Size(75, 21);
            this.btnSos.MinimumSize = new System.Drawing.Size(75, 21);
            this.btnSos.Name = "btnSos";
            this.btnSos.Size = new System.Drawing.Size(75, 21);
            this.btnSos.TabIndex = 22;
            this.btnSos.Text = "SOS LOAD";
            this.btnSos.UseVisualStyleBackColor = false;
            // 
            // btnCheckNum
            // 
            this.btnCheckNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnCheckNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckNum.FlatAppearance.BorderSize = 0;
            this.btnCheckNum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(214)))), ((int)(((byte)(151)))));
            this.btnCheckNum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(214)))), ((int)(((byte)(151)))));
            this.btnCheckNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckNum.ForeColor = System.Drawing.Color.White;
            this.btnCheckNum.Location = new System.Drawing.Point(93, 505);
            this.btnCheckNum.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnCheckNum.MaximumSize = new System.Drawing.Size(95, 21);
            this.btnCheckNum.MinimumSize = new System.Drawing.Size(95, 21);
            this.btnCheckNum.Name = "btnCheckNum";
            this.btnCheckNum.Size = new System.Drawing.Size(95, 21);
            this.btnCheckNum.TabIndex = 23;
            this.btnCheckNum.Text = "Check Numbers";
            this.btnCheckNum.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Assign a dedicated Number/ Receiver";
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnCheckNum);
            this.Controls.Add(this.btnSos);
            this.Controls.Add(this.dashGrid);
            this.MaximumSize = new System.Drawing.Size(711, 536);
            this.MinimumSize = new System.Drawing.Size(711, 536);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(711, 536);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dashGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn comPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn load;
        private System.Windows.Forms.DataGridViewTextBoxColumn Network;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSos;
        private System.Windows.Forms.Button btnCheckNum;
        private System.Windows.Forms.Label label1;
    }
}
