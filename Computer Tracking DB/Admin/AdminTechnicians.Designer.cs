namespace ComputerTrackingDB
{
    partial class AdminTechnicians
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
            this.InventoryMovelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TechniciansCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserTB = new System.Windows.Forms.TextBox();
            this.TechIDTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RoleTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ActiveCheck = new System.Windows.Forms.CheckBox();
            this.AdminCB = new System.Windows.Forms.CheckBox();
            this.InventoryAuditCB = new System.Windows.Forms.CheckBox();
            this.InventoryMoveCB = new System.Windows.Forms.CheckBox();
            this.InventoryNewCB = new System.Windows.Forms.CheckBox();
            this.Inventorylbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SavedLBL = new System.Windows.Forms.Label();
            this.TechPerms = new System.Windows.Forms.DataGridView();
            this.ScanInOutCB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailTestBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TechNameTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TechPerms)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.InventoryMovelbl);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(17, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 79);
            this.panel1.TabIndex = 6;
            // 
            // InventoryMovelbl
            // 
            this.InventoryMovelbl.BackColor = System.Drawing.Color.Transparent;
            this.InventoryMovelbl.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.InventoryMovelbl.Location = new System.Drawing.Point(-1, -1);
            this.InventoryMovelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InventoryMovelbl.Name = "InventoryMovelbl";
            this.InventoryMovelbl.Size = new System.Drawing.Size(951, 79);
            this.InventoryMovelbl.TabIndex = 0;
            this.InventoryMovelbl.Text = "Technicians";
            this.InventoryMovelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.5F);
            this.label1.Location = new System.Drawing.Point(335, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Technician :";
            // 
            // TechniciansCB
            // 
            this.TechniciansCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TechniciansCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TechniciansCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TechniciansCB.Font = new System.Drawing.Font("Arial", 14.5F);
            this.TechniciansCB.FormattingEnabled = true;
            this.TechniciansCB.Location = new System.Drawing.Point(453, 5);
            this.TechniciansCB.Margin = new System.Windows.Forms.Padding(2);
            this.TechniciansCB.MaxDropDownItems = 99;
            this.TechniciansCB.Name = "TechniciansCB";
            this.TechniciansCB.Size = new System.Drawing.Size(208, 30);
            this.TechniciansCB.Sorted = true;
            this.TechniciansCB.TabIndex = 8;
            this.TechniciansCB.SelectedIndexChanged += new System.EventHandler(this.TechniciansCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.5F);
            this.label2.Location = new System.Drawing.Point(253, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "UserName :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UserTB
            // 
            this.UserTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserTB.Font = new System.Drawing.Font("Arial", 14.5F);
            this.UserTB.Location = new System.Drawing.Point(371, 44);
            this.UserTB.Margin = new System.Windows.Forms.Padding(2);
            this.UserTB.Name = "UserTB";
            this.UserTB.Size = new System.Drawing.Size(138, 30);
            this.UserTB.TabIndex = 10;
            this.UserTB.TextChanged += new System.EventHandler(this.UserTB_TextChanged);
            // 
            // TechIDTB
            // 
            this.TechIDTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TechIDTB.Enabled = false;
            this.TechIDTB.Font = new System.Drawing.Font("Arial", 14.5F);
            this.TechIDTB.Location = new System.Drawing.Point(611, 43);
            this.TechIDTB.Margin = new System.Windows.Forms.Padding(2);
            this.TechIDTB.Name = "TechIDTB";
            this.TechIDTB.Size = new System.Drawing.Size(153, 30);
            this.TechIDTB.TabIndex = 12;
            this.TechIDTB.TextChanged += new System.EventHandler(this.TechIDTB_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.5F);
            this.label3.Location = new System.Drawing.Point(526, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "TechID :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RoleTB
            // 
            this.RoleTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoleTB.Font = new System.Drawing.Font("Arial", 14.5F);
            this.RoleTB.Location = new System.Drawing.Point(611, 82);
            this.RoleTB.Margin = new System.Windows.Forms.Padding(2);
            this.RoleTB.Name = "RoleTB";
            this.RoleTB.Size = new System.Drawing.Size(153, 30);
            this.RoleTB.TabIndex = 14;
            this.RoleTB.TextChanged += new System.EventHandler(this.RoleTB_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.5F);
            this.label4.Location = new System.Drawing.Point(545, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Role :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ActiveCheck
            // 
            this.ActiveCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActiveCheck.AutoSize = true;
            this.ActiveCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ActiveCheck.Font = new System.Drawing.Font("Arial", 14.5F);
            this.ActiveCheck.Location = new System.Drawing.Point(295, 188);
            this.ActiveCheck.Margin = new System.Windows.Forms.Padding(2);
            this.ActiveCheck.Name = "ActiveCheck";
            this.ActiveCheck.Size = new System.Drawing.Size(82, 27);
            this.ActiveCheck.TabIndex = 15;
            this.ActiveCheck.Text = "Active";
            this.ActiveCheck.UseVisualStyleBackColor = true;
            this.ActiveCheck.CheckedChanged += new System.EventHandler(this.ActiveCheck_CheckedChanged);
            // 
            // AdminCB
            // 
            this.AdminCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminCB.AutoSize = true;
            this.AdminCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdminCB.Font = new System.Drawing.Font("Arial", 14.5F);
            this.AdminCB.Location = new System.Drawing.Point(637, 188);
            this.AdminCB.Margin = new System.Windows.Forms.Padding(2);
            this.AdminCB.Name = "AdminCB";
            this.AdminCB.Size = new System.Drawing.Size(83, 27);
            this.AdminCB.TabIndex = 18;
            this.AdminCB.Text = "Admin";
            this.AdminCB.UseVisualStyleBackColor = true;
            this.AdminCB.CheckedChanged += new System.EventHandler(this.AdminCB_CheckedChanged);
            // 
            // InventoryAuditCB
            // 
            this.InventoryAuditCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InventoryAuditCB.AutoSize = true;
            this.InventoryAuditCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InventoryAuditCB.Font = new System.Drawing.Font("Arial", 14.5F);
            this.InventoryAuditCB.Location = new System.Drawing.Point(462, 188);
            this.InventoryAuditCB.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryAuditCB.Name = "InventoryAuditCB";
            this.InventoryAuditCB.Size = new System.Drawing.Size(73, 27);
            this.InventoryAuditCB.TabIndex = 19;
            this.InventoryAuditCB.Text = "Audit";
            this.InventoryAuditCB.UseVisualStyleBackColor = true;
            this.InventoryAuditCB.CheckedChanged += new System.EventHandler(this.InventoryAuditCB_CheckedChanged);
            // 
            // InventoryMoveCB
            // 
            this.InventoryMoveCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InventoryMoveCB.AutoSize = true;
            this.InventoryMoveCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InventoryMoveCB.Font = new System.Drawing.Font("Arial", 14.5F);
            this.InventoryMoveCB.Location = new System.Drawing.Point(462, 218);
            this.InventoryMoveCB.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryMoveCB.Name = "InventoryMoveCB";
            this.InventoryMoveCB.Size = new System.Drawing.Size(77, 27);
            this.InventoryMoveCB.TabIndex = 20;
            this.InventoryMoveCB.Text = "Move";
            this.InventoryMoveCB.UseVisualStyleBackColor = true;
            this.InventoryMoveCB.CheckedChanged += new System.EventHandler(this.InventoryMoveCB_CheckedChanged);
            // 
            // InventoryNewCB
            // 
            this.InventoryNewCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InventoryNewCB.AutoSize = true;
            this.InventoryNewCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InventoryNewCB.Font = new System.Drawing.Font("Arial", 14.5F);
            this.InventoryNewCB.Location = new System.Drawing.Point(467, 247);
            this.InventoryNewCB.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryNewCB.Name = "InventoryNewCB";
            this.InventoryNewCB.Size = new System.Drawing.Size(68, 27);
            this.InventoryNewCB.TabIndex = 21;
            this.InventoryNewCB.Text = "New";
            this.InventoryNewCB.UseVisualStyleBackColor = true;
            this.InventoryNewCB.CheckedChanged += new System.EventHandler(this.InventoryNewCB_CheckedChanged);
            // 
            // Inventorylbl
            // 
            this.Inventorylbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Inventorylbl.AutoSize = true;
            this.Inventorylbl.Font = new System.Drawing.Font("Arial", 14.5F);
            this.Inventorylbl.Location = new System.Drawing.Point(458, 158);
            this.Inventorylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Inventorylbl.Name = "Inventorylbl";
            this.Inventorylbl.Size = new System.Drawing.Size(90, 23);
            this.Inventorylbl.TabIndex = 22;
            this.Inventorylbl.Text = "Inventory";
            this.Inventorylbl.Click += new System.EventHandler(this.Inventorylbl_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(413, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 49);
            this.button1.TabIndex = 23;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SavedLBL
            // 
            this.SavedLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SavedLBL.AutoSize = true;
            this.SavedLBL.Font = new System.Drawing.Font("Arial", 14F);
            this.SavedLBL.ForeColor = System.Drawing.Color.Red;
            this.SavedLBL.Location = new System.Drawing.Point(455, 338);
            this.SavedLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SavedLBL.Name = "SavedLBL";
            this.SavedLBL.Size = new System.Drawing.Size(76, 22);
            this.SavedLBL.TabIndex = 24;
            this.SavedLBL.Text = "Saved!!";
            this.SavedLBL.Visible = false;
            // 
            // TechPerms
            // 
            this.TechPerms.AllowUserToAddRows = false;
            this.TechPerms.AllowUserToDeleteRows = false;
            this.TechPerms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TechPerms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TechPerms.Location = new System.Drawing.Point(17, 465);
            this.TechPerms.Margin = new System.Windows.Forms.Padding(2);
            this.TechPerms.Name = "TechPerms";
            this.TechPerms.ReadOnly = true;
            this.TechPerms.RowTemplate.Height = 28;
            this.TechPerms.Size = new System.Drawing.Size(951, 62);
            this.TechPerms.TabIndex = 25;
            // 
            // ScanInOutCB
            // 
            this.ScanInOutCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScanInOutCB.AutoSize = true;
            this.ScanInOutCB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ScanInOutCB.Font = new System.Drawing.Font("Arial", 14.5F);
            this.ScanInOutCB.Location = new System.Drawing.Point(235, 216);
            this.ScanInOutCB.Margin = new System.Windows.Forms.Padding(2);
            this.ScanInOutCB.Name = "ScanInOutCB";
            this.ScanInOutCB.Size = new System.Drawing.Size(145, 27);
            this.ScanInOutCB.TabIndex = 26;
            this.ScanInOutCB.Text = "Scan In / Out";
            this.ScanInOutCB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.5F);
            this.label5.Location = new System.Drawing.Point(633, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Modules";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.5F);
            this.label6.Location = new System.Drawing.Point(271, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Permissions";
            // 
            // EmailTestBTN
            // 
            this.EmailTestBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailTestBTN.Location = new System.Drawing.Point(734, 295);
            this.EmailTestBTN.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTestBTN.Name = "EmailTestBTN";
            this.EmailTestBTN.Size = new System.Drawing.Size(82, 34);
            this.EmailTestBTN.TabIndex = 30;
            this.EmailTestBTN.Text = "Email Test";
            this.EmailTestBTN.UseVisualStyleBackColor = true;
            this.EmailTestBTN.Visible = false;
            this.EmailTestBTN.Click += new System.EventHandler(this.EmailTestBTN_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 94);
            this.panel2.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TechNameTB);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.PasswordTB);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.EmailTestBTN);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.ScanInOutCB);
            this.panel3.Controls.Add(this.SavedLBL);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Inventorylbl);
            this.panel3.Controls.Add(this.InventoryNewCB);
            this.panel3.Controls.Add(this.InventoryMoveCB);
            this.panel3.Controls.Add(this.InventoryAuditCB);
            this.panel3.Controls.Add(this.AdminCB);
            this.panel3.Controls.Add(this.ActiveCheck);
            this.panel3.Controls.Add(this.RoleTB);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TechIDTB);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.UserTB);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.TechniciansCB);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(983, 369);
            this.panel3.TabIndex = 32;
            // 
            // TechNameTB
            // 
            this.TechNameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TechNameTB.Font = new System.Drawing.Font("Arial", 14.5F);
            this.TechNameTB.Location = new System.Drawing.Point(371, 122);
            this.TechNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.TechNameTB.Name = "TechNameTB";
            this.TechNameTB.Size = new System.Drawing.Size(209, 30);
            this.TechNameTB.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.5F);
            this.label8.Location = new System.Drawing.Point(294, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Name :";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTB.Font = new System.Drawing.Font("Arial", 14.5F);
            this.PasswordTB.Location = new System.Drawing.Point(371, 83);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(138, 30);
            this.PasswordTB.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.5F);
            this.label7.Location = new System.Drawing.Point(257, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Password :";
            // 
            // AdminTechnicians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TechPerms);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminTechnicians";
            this.Size = new System.Drawing.Size(983, 539);
            this.Load += new System.EventHandler(this.AdminTechnicians_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TechPerms)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label InventoryMovelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TechniciansCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserTB;
        private System.Windows.Forms.TextBox TechIDTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoleTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ActiveCheck;
        private System.Windows.Forms.CheckBox AdminCB;
        private System.Windows.Forms.CheckBox InventoryAuditCB;
        private System.Windows.Forms.CheckBox InventoryMoveCB;
        private System.Windows.Forms.CheckBox InventoryNewCB;
        private System.Windows.Forms.Label Inventorylbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SavedLBL;
        private System.Windows.Forms.DataGridView TechPerms;
        private System.Windows.Forms.CheckBox ScanInOutCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EmailTestBTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TechNameTB;
        private System.Windows.Forms.Label label8;
    }
}
