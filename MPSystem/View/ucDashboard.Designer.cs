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
            this.btnUpdateLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dashGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dashGrid
            // 
            this.dashGrid.BackgroundColor = System.Drawing.Color.White;
            this.dashGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dashGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dashGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dashGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dashGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkOption,
            this.comPort,
            this.mobileNumber,
            this.load});
            this.dashGrid.Location = new System.Drawing.Point(8, 61);
            this.dashGrid.Name = "dashGrid";
            this.dashGrid.Size = new System.Drawing.Size(694, 462);
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
            this.comPort.ReadOnly = true;
            this.comPort.Width = 200;
            // 
            // mobileNumber
            // 
            this.mobileNumber.HeaderText = "Mobile Number";
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.ReadOnly = true;
            this.mobileNumber.Width = 200;
            // 
            // load
            // 
            this.load.HeaderText = "Load ";
            this.load.Name = "load";
            this.load.ReadOnly = true;
            this.load.Width = 200;
            // 
            // btnUpdateLoad
            // 
            this.btnUpdateLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnUpdateLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateLoad.FlatAppearance.BorderSize = 0;
            this.btnUpdateLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLoad.Font = new System.Drawing.Font("Helvetica-Normal", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLoad.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLoad.Location = new System.Drawing.Point(8, 6);
            this.btnUpdateLoad.Name = "btnUpdateLoad";
            this.btnUpdateLoad.Size = new System.Drawing.Size(166, 33);
            this.btnUpdateLoad.TabIndex = 1;
            this.btnUpdateLoad.Text = "Update load balance";
            this.btnUpdateLoad.UseVisualStyleBackColor = false;
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateLoad);
            this.Controls.Add(this.dashGrid);
            this.MaximumSize = new System.Drawing.Size(711, 536);
            this.MinimumSize = new System.Drawing.Size(711, 536);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(711, 536);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dashGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn comPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn load;
        public System.Windows.Forms.Button btnUpdateLoad;
    }
}
