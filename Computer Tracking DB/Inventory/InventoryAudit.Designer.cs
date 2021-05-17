namespace ComputerTrackingDB
{
    partial class InventoryAudit
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
            this.Auditlbl = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.LocationLock = new System.Windows.Forms.CheckBox();
            this.LocationCB = new System.Windows.Forms.ComboBox();
            this.TechIDTB = new System.Windows.Forms.TextBox();
            this.DateTB = new System.Windows.Forms.TextBox();
            this.SerialTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportDataView = new System.Windows.Forms.Button();
            this.activityGrid = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Old_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.New_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuccessFail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuditCountlbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Auditlbl);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(17, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(952, 79);
            this.panel1.MinimumSize = new System.Drawing.Size(952, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 79);
            this.panel1.TabIndex = 4;
            // 
            // Auditlbl
            // 
            this.Auditlbl.BackColor = System.Drawing.Color.Transparent;
            this.Auditlbl.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.Auditlbl.Location = new System.Drawing.Point(-1, -1);
            this.Auditlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Auditlbl.MaximumSize = new System.Drawing.Size(951, 78);
            this.Auditlbl.MinimumSize = new System.Drawing.Size(951, 78);
            this.Auditlbl.Name = "Auditlbl";
            this.Auditlbl.Size = new System.Drawing.Size(951, 78);
            this.Auditlbl.TabIndex = 0;
            this.Auditlbl.Text = "Audit";
            this.Auditlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Savebtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Savebtn.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Savebtn.Location = new System.Drawing.Point(415, 224);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(174, 27);
            this.Savebtn.TabIndex = 24;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // LocationLock
            // 
            this.LocationLock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationLock.AutoSize = true;
            this.LocationLock.Font = new System.Drawing.Font("Arial", 14.25F);
            this.LocationLock.Location = new System.Drawing.Point(602, 196);
            this.LocationLock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LocationLock.Name = "LocationLock";
            this.LocationLock.Size = new System.Drawing.Size(70, 26);
            this.LocationLock.TabIndex = 23;
            this.LocationLock.Text = "Lock";
            this.LocationLock.UseVisualStyleBackColor = true;
            this.LocationLock.CheckedChanged += new System.EventHandler(this.LocationLock_CheckedChanged);
            // 
            // LocationCB
            // 
            this.LocationCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationCB.DisplayMember = "Location";
            this.LocationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationCB.Font = new System.Drawing.Font("Arial", 14.25F);
            this.LocationCB.FormattingEnabled = true;
            this.LocationCB.Location = new System.Drawing.Point(415, 194);
            this.LocationCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LocationCB.Name = "LocationCB";
            this.LocationCB.Size = new System.Drawing.Size(175, 30);
            this.LocationCB.Sorted = true;
            this.LocationCB.TabIndex = 21;
            // 
            // TechIDTB
            // 
            this.TechIDTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TechIDTB.Font = new System.Drawing.Font("Arial", 14.25F);
            this.TechIDTB.Location = new System.Drawing.Point(415, 161);
            this.TechIDTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TechIDTB.Name = "TechIDTB";
            this.TechIDTB.ReadOnly = true;
            this.TechIDTB.Size = new System.Drawing.Size(175, 29);
            this.TechIDTB.TabIndex = 20;
            // 
            // DateTB
            // 
            this.DateTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTB.Font = new System.Drawing.Font("Arial", 14.25F);
            this.DateTB.Location = new System.Drawing.Point(415, 129);
            this.DateTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DateTB.Name = "DateTB";
            this.DateTB.ReadOnly = true;
            this.DateTB.Size = new System.Drawing.Size(175, 29);
            this.DateTB.TabIndex = 19;
            // 
            // SerialTB
            // 
            this.SerialTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SerialTB.Font = new System.Drawing.Font("Arial", 14.25F);
            this.SerialTB.Location = new System.Drawing.Point(415, 94);
            this.SerialTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SerialTB.MaxLength = 12;
            this.SerialTB.Name = "SerialTB";
            this.SerialTB.Size = new System.Drawing.Size(175, 29);
            this.SerialTB.TabIndex = 18;
            this.SerialTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SerialTB_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label4.Location = new System.Drawing.Point(322, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Location:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label3.Location = new System.Drawing.Point(329, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tech ID:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label2.Location = new System.Drawing.Point(355, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.Location = new System.Drawing.Point(271, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Serial Number:";
            // 
            // ExportDataView
            // 
            this.ExportDataView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExportDataView.Font = new System.Drawing.Font("Arial", 14.25F);
            this.ExportDataView.Location = new System.Drawing.Point(827, 144);
            this.ExportDataView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExportDataView.Name = "ExportDataView";
            this.ExportDataView.Size = new System.Drawing.Size(107, 66);
            this.ExportDataView.TabIndex = 25;
            this.ExportDataView.Text = "Audit Export";
            this.ExportDataView.UseVisualStyleBackColor = true;
            this.ExportDataView.Click += new System.EventHandler(this.ExportDataView_Click);
            // 
            // activityGrid
            // 
            this.activityGrid.AllowUserToAddRows = false;
            this.activityGrid.AllowUserToDeleteRows = false;
            this.activityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Date,
            this.Serial,
            this.TechName,
            this.Old_Location,
            this.New_Location,
            this.Correct,
            this.SuccessFail});
            this.activityGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityGrid.Location = new System.Drawing.Point(0, 307);
            this.activityGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activityGrid.Name = "activityGrid";
            this.activityGrid.ReadOnly = true;
            this.activityGrid.RowTemplate.Height = 28;
            this.activityGrid.Size = new System.Drawing.Size(983, 231);
            this.activityGrid.TabIndex = 27;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Serial
            // 
            this.Serial.HeaderText = "Serial";
            this.Serial.Name = "Serial";
            this.Serial.ReadOnly = true;
            // 
            // TechName
            // 
            this.TechName.HeaderText = "TechName";
            this.TechName.Name = "TechName";
            this.TechName.ReadOnly = true;
            // 
            // Old_Location
            // 
            this.Old_Location.HeaderText = "Old_Location";
            this.Old_Location.Name = "Old_Location";
            this.Old_Location.ReadOnly = true;
            // 
            // New_Location
            // 
            this.New_Location.HeaderText = "New_Location";
            this.New_Location.Name = "New_Location";
            this.New_Location.ReadOnly = true;
            // 
            // Correct
            // 
            this.Correct.HeaderText = "Correct";
            this.Correct.Name = "Correct";
            this.Correct.ReadOnly = true;
            // 
            // SuccessFail
            // 
            this.SuccessFail.HeaderText = "Success/Fail";
            this.SuccessFail.Name = "SuccessFail";
            this.SuccessFail.ReadOnly = true;
            // 
            // AuditCountlbl
            // 
            this.AuditCountlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuditCountlbl.AutoSize = true;
            this.AuditCountlbl.Font = new System.Drawing.Font("Arial", 14F);
            this.AuditCountlbl.Location = new System.Drawing.Point(488, 273);
            this.AuditCountlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuditCountlbl.Name = "AuditCountlbl";
            this.AuditCountlbl.Size = new System.Drawing.Size(21, 22);
            this.AuditCountlbl.TabIndex = 29;
            this.AuditCountlbl.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AuditCountlbl);
            this.panel2.Controls.Add(this.ExportDataView);
            this.panel2.Controls.Add(this.Savebtn);
            this.panel2.Controls.Add(this.LocationLock);
            this.panel2.Controls.Add(this.LocationCB);
            this.panel2.Controls.Add(this.TechIDTB);
            this.panel2.Controls.Add(this.DateTB);
            this.panel2.Controls.Add(this.SerialTB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 307);
            this.panel2.TabIndex = 30;
            // 
            // InventoryAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.activityGrid);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InventoryAudit";
            this.Size = new System.Drawing.Size(983, 538);
            this.Load += new System.EventHandler(this.InventoryAudit_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activityGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Auditlbl;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.CheckBox LocationLock;
        private System.Windows.Forms.ComboBox LocationCB;
        private System.Windows.Forms.TextBox TechIDTB;
        private System.Windows.Forms.TextBox DateTB;
        private System.Windows.Forms.TextBox SerialTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExportDataView;
        private System.Windows.Forms.DataGridView activityGrid;
        private System.Windows.Forms.Label AuditCountlbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Old_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn New_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correct;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuccessFail;
    }
}
