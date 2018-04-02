namespace MPSystem.View
{
    partial class ucPromotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPromotion));
            this.flpPromotion = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSendTo = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSendPromo = new System.Windows.Forms.Button();
            this.backgroundworker = new System.ComponentModel.BackgroundWorker();
            this.pnlPortsToSend = new System.Windows.Forms.Panel();
            this.lstGrid = new System.Windows.Forms.DataGridView();
            this.checkOption = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPClose = new System.Windows.Forms.Button();
            this.btnPSend = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.flpPromotion.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pnlPortsToSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // flpPromotion
            // 
            this.flpPromotion.AutoScroll = true;
            this.flpPromotion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.flpPromotion.Controls.Add(this.panel2);
            this.flpPromotion.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPromotion.Location = new System.Drawing.Point(18, 41);
            this.flpPromotion.Name = "flpPromotion";
            this.flpPromotion.Size = new System.Drawing.Size(200, 492);
            this.flpPromotion.TabIndex = 0;
            this.flpPromotion.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 37);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(162, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 34);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(125, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 34);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Promo Title";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(18, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+ Add a Promo";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Promo Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(331, 15);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(353, 14);
            this.txtTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(242, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Promo Details";
            // 
            // txtDetails
            // 
            this.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(331, 44);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(353, 172);
            this.txtDetails.TabIndex = 4;
            this.txtDetails.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(242, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Send to";
            // 
            // cboSendTo
            // 
            this.cboSendTo.BackColor = System.Drawing.Color.White;
            this.cboSendTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSendTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSendTo.FormattingEnabled = true;
            this.cboSendTo.Location = new System.Drawing.Point(331, 236);
            this.cboSendTo.Name = "cboSendTo";
            this.cboSendTo.Size = new System.Drawing.Size(327, 23);
            this.cboSendTo.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnSave);
            this.flowLayoutPanel2.Controls.Add(this.btnCancel);
            this.flowLayoutPanel2.Controls.Add(this.btnSendPromo);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(331, 289);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(353, 52);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(110, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSendPromo
            // 
            this.btnSendPromo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnSendPromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendPromo.FlatAppearance.BorderSize = 0;
            this.btnSendPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendPromo.ForeColor = System.Drawing.Color.White;
            this.btnSendPromo.Location = new System.Drawing.Point(220, 0);
            this.btnSendPromo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btnSendPromo.Name = "btnSendPromo";
            this.btnSendPromo.Size = new System.Drawing.Size(107, 34);
            this.btnSendPromo.TabIndex = 1;
            this.btnSendPromo.Text = "Send";
            this.btnSendPromo.UseVisualStyleBackColor = false;
            this.btnSendPromo.Click += new System.EventHandler(this.btnSendPromo_Click);
            // 
            // pnlPortsToSend
            // 
            this.pnlPortsToSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.pnlPortsToSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPortsToSend.Controls.Add(this.lstGrid);
            this.pnlPortsToSend.Controls.Add(this.btnPClose);
            this.pnlPortsToSend.Controls.Add(this.btnPSend);
            this.pnlPortsToSend.Location = new System.Drawing.Point(254, 129);
            this.pnlPortsToSend.Name = "pnlPortsToSend";
            this.pnlPortsToSend.Size = new System.Drawing.Size(349, 258);
            this.pnlPortsToSend.TabIndex = 18;
            this.pnlPortsToSend.Visible = false;
            // 
            // lstGrid
            // 
            this.lstGrid.AllowUserToAddRows = false;
            this.lstGrid.AllowUserToDeleteRows = false;
            this.lstGrid.BackgroundColor = System.Drawing.Color.White;
            this.lstGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.lstGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.lstGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkOption,
            this.comPort});
            this.lstGrid.Location = new System.Drawing.Point(8, 45);
            this.lstGrid.Name = "lstGrid";
            this.lstGrid.Size = new System.Drawing.Size(333, 151);
            this.lstGrid.TabIndex = 7;
            // 
            // checkOption
            // 
            this.checkOption.HeaderText = "";
            this.checkOption.Name = "checkOption";
            this.checkOption.Width = 90;
            // 
            // comPort
            // 
            this.comPort.HeaderText = "COMPORT";
            this.comPort.Name = "comPort";
            this.comPort.Width = 200;
            // 
            // btnPClose
            // 
            this.btnPClose.BackgroundImage = global::MPSystem.Properties.Resources.closeBlack;
            this.btnPClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPClose.FlatAppearance.BorderSize = 0;
            this.btnPClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPClose.Location = new System.Drawing.Point(295, 3);
            this.btnPClose.Name = "btnPClose";
            this.btnPClose.Size = new System.Drawing.Size(46, 20);
            this.btnPClose.TabIndex = 5;
            this.btnPClose.UseVisualStyleBackColor = true;
            this.btnPClose.Click += new System.EventHandler(this.btnPClose_Click);
            // 
            // btnPSend
            // 
            this.btnPSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnPSend.FlatAppearance.BorderSize = 0;
            this.btnPSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSend.ForeColor = System.Drawing.Color.White;
            this.btnPSend.Location = new System.Drawing.Point(8, 210);
            this.btnPSend.Name = "btnPSend";
            this.btnPSend.Size = new System.Drawing.Size(333, 33);
            this.btnPSend.TabIndex = 2;
            this.btnPSend.Text = "Send";
            this.btnPSend.UseVisualStyleBackColor = false;
            this.btnPSend.Click += new System.EventHandler(this.btnPSend_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(144)))));
            this.btnRefresh.BackgroundImage = global::MPSystem.Properties.Resources.Refresh_20px;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(664, 236);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(21, 23);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ucPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlPortsToSend);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.cboSendTo);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.flpPromotion);
            this.MaximumSize = new System.Drawing.Size(711, 536);
            this.MinimumSize = new System.Drawing.Size(711, 536);
            this.Name = "ucPromotion";
            this.Size = new System.Drawing.Size(711, 536);
            this.Load += new System.EventHandler(this.ucPromotion_Load);
            this.flpPromotion.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pnlPortsToSend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPromotion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSendTo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundworker;
        private System.Windows.Forms.Button btnSendPromo;
        private System.Windows.Forms.Panel pnlPortsToSend;
        private System.Windows.Forms.Button btnPClose;
        private System.Windows.Forms.Button btnPSend;
        private System.Windows.Forms.DataGridView lstGrid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn comPort;
        private System.Windows.Forms.Button btnRefresh;
    }
}
