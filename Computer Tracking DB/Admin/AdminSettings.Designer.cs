namespace ComputerTrackingDB
{
    partial class AdminSettings
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
            this.ToggleAuditBtn = new System.Windows.Forms.Button();
            this.AuditStatuslbl = new System.Windows.Forms.Label();
            this.StationPasswordlbl = new System.Windows.Forms.Label();
            this.NewStationpwTB = new System.Windows.Forms.TextBox();
            this.SetStationpwBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StationUpdatedlbl = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.AuditTab = new System.Windows.Forms.TabPage();
            this.SerialsAuditDG = new System.Windows.Forms.DataGridView();
            this.Serials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationTab = new System.Windows.Forms.TabPage();
            this.DevTab = new System.Windows.Forms.TabPage();
            this.DevTechGrid = new System.Windows.Forms.DataGridView();
            this.impersonateTechCB = new System.Windows.Forms.ComboBox();
            this.impersonateBTN = new System.Windows.Forms.Button();
            this.EmailSystemTab = new System.Windows.Forms.TabPage();
            this.NewInventoryTOCCSavedlbl = new System.Windows.Forms.Label();
            this.NewInventoryTOCCbtn = new System.Windows.Forms.Button();
            this.NewInventoryCCListTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NewInventoryToTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NewTechSavedlbl = new System.Windows.Forms.Label();
            this.ModifyTechSavedlbl = new System.Windows.Forms.Label();
            this.NewTechCCbtn = new System.Windows.Forms.Button();
            this.ModifyTechCCbtn = new System.Windows.Forms.Button();
            this.NewTechCCListTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ModifyTechCCListTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DatabaseTab = new System.Windows.Forms.TabPage();
            this.BackupEDB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AuditTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SerialsAuditDG)).BeginInit();
            this.StationTab.SuspendLayout();
            this.DevTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DevTechGrid)).BeginInit();
            this.EmailSystemTab.SuspendLayout();
            this.DatabaseTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.InventoryMovelbl);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(17, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 79);
            this.panel1.TabIndex = 7;
            // 
            // InventoryMovelbl
            // 
            this.InventoryMovelbl.BackColor = System.Drawing.Color.Transparent;
            this.InventoryMovelbl.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.InventoryMovelbl.Location = new System.Drawing.Point(-1, -1);
            this.InventoryMovelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InventoryMovelbl.Name = "InventoryMovelbl";
            this.InventoryMovelbl.Size = new System.Drawing.Size(951, 78);
            this.InventoryMovelbl.TabIndex = 0;
            this.InventoryMovelbl.Text = "Settings";
            this.InventoryMovelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToggleAuditBtn
            // 
            this.ToggleAuditBtn.Font = new System.Drawing.Font("Arial", 14F);
            this.ToggleAuditBtn.Location = new System.Drawing.Point(24, 14);
            this.ToggleAuditBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToggleAuditBtn.Name = "ToggleAuditBtn";
            this.ToggleAuditBtn.Size = new System.Drawing.Size(127, 29);
            this.ToggleAuditBtn.TabIndex = 8;
            this.ToggleAuditBtn.Text = "Toggle Audit";
            this.ToggleAuditBtn.UseVisualStyleBackColor = true;
            this.ToggleAuditBtn.Click += new System.EventHandler(this.ToggleAuditBtn_Click);
            // 
            // AuditStatuslbl
            // 
            this.AuditStatuslbl.AutoSize = true;
            this.AuditStatuslbl.Font = new System.Drawing.Font("Arial", 14F);
            this.AuditStatuslbl.Location = new System.Drawing.Point(163, 18);
            this.AuditStatuslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuditStatuslbl.Name = "AuditStatuslbl";
            this.AuditStatuslbl.Size = new System.Drawing.Size(86, 22);
            this.AuditStatuslbl.TabIndex = 9;
            this.AuditStatuslbl.Text = "Unknown";
            // 
            // StationPasswordlbl
            // 
            this.StationPasswordlbl.AutoSize = true;
            this.StationPasswordlbl.Font = new System.Drawing.Font("Arial", 14F);
            this.StationPasswordlbl.Location = new System.Drawing.Point(64, 29);
            this.StationPasswordlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StationPasswordlbl.Name = "StationPasswordlbl";
            this.StationPasswordlbl.Size = new System.Drawing.Size(167, 22);
            this.StationPasswordlbl.TabIndex = 10;
            this.StationPasswordlbl.Text = "Station Password :";
            // 
            // NewStationpwTB
            // 
            this.NewStationpwTB.Font = new System.Drawing.Font("Arial", 14F);
            this.NewStationpwTB.Location = new System.Drawing.Point(233, 29);
            this.NewStationpwTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewStationpwTB.Name = "NewStationpwTB";
            this.NewStationpwTB.PasswordChar = '*';
            this.NewStationpwTB.Size = new System.Drawing.Size(163, 29);
            this.NewStationpwTB.TabIndex = 11;
            // 
            // SetStationpwBTN
            // 
            this.SetStationpwBTN.Font = new System.Drawing.Font("Arial", 14F);
            this.SetStationpwBTN.Location = new System.Drawing.Point(401, 29);
            this.SetStationpwBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SetStationpwBTN.Name = "SetStationpwBTN";
            this.SetStationpwBTN.Size = new System.Drawing.Size(73, 27);
            this.SetStationpwBTN.TabIndex = 12;
            this.SetStationpwBTN.Text = "Set";
            this.SetStationpwBTN.UseVisualStyleBackColor = true;
            this.SetStationpwBTN.Click += new System.EventHandler(this.SetStationpwBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(219, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password is case sensitive.";
            // 
            // StationUpdatedlbl
            // 
            this.StationUpdatedlbl.AutoSize = true;
            this.StationUpdatedlbl.Font = new System.Drawing.Font("Arial", 14F);
            this.StationUpdatedlbl.ForeColor = System.Drawing.Color.Red;
            this.StationUpdatedlbl.Location = new System.Drawing.Point(478, 31);
            this.StationUpdatedlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StationUpdatedlbl.Name = "StationUpdatedlbl";
            this.StationUpdatedlbl.Size = new System.Drawing.Size(88, 22);
            this.StationUpdatedlbl.TabIndex = 14;
            this.StationUpdatedlbl.Text = "Updated!";
            this.StationUpdatedlbl.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GeneralTab);
            this.tabControl1.Controls.Add(this.AuditTab);
            this.tabControl1.Controls.Add(this.StationTab);
            this.tabControl1.Controls.Add(this.DevTab);
            this.tabControl1.Controls.Add(this.EmailSystemTab);
            this.tabControl1.Controls.Add(this.DatabaseTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 89);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 450);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // GeneralTab
            // 
            this.GeneralTab.Location = new System.Drawing.Point(4, 27);
            this.GeneralTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GeneralTab.Size = new System.Drawing.Size(975, 419);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // AuditTab
            // 
            this.AuditTab.Controls.Add(this.SerialsAuditDG);
            this.AuditTab.Controls.Add(this.ToggleAuditBtn);
            this.AuditTab.Controls.Add(this.AuditStatuslbl);
            this.AuditTab.Location = new System.Drawing.Point(4, 27);
            this.AuditTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AuditTab.Name = "AuditTab";
            this.AuditTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AuditTab.Size = new System.Drawing.Size(975, 419);
            this.AuditTab.TabIndex = 1;
            this.AuditTab.Text = "Audit";
            this.AuditTab.UseVisualStyleBackColor = true;
            // 
            // SerialsAuditDG
            // 
            this.SerialsAuditDG.AllowUserToAddRows = false;
            this.SerialsAuditDG.AllowUserToDeleteRows = false;
            this.SerialsAuditDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SerialsAuditDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serials});
            this.SerialsAuditDG.Location = new System.Drawing.Point(832, 4);
            this.SerialsAuditDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SerialsAuditDG.Name = "SerialsAuditDG";
            this.SerialsAuditDG.ReadOnly = true;
            this.SerialsAuditDG.RowTemplate.Height = 28;
            this.SerialsAuditDG.Size = new System.Drawing.Size(110, 398);
            this.SerialsAuditDG.TabIndex = 11;
            this.SerialsAuditDG.Visible = false;
            // 
            // Serials
            // 
            this.Serials.HeaderText = "Column1";
            this.Serials.Name = "Serials";
            this.Serials.ReadOnly = true;
            // 
            // StationTab
            // 
            this.StationTab.Controls.Add(this.NewStationpwTB);
            this.StationTab.Controls.Add(this.StationUpdatedlbl);
            this.StationTab.Controls.Add(this.StationPasswordlbl);
            this.StationTab.Controls.Add(this.label1);
            this.StationTab.Controls.Add(this.SetStationpwBTN);
            this.StationTab.Location = new System.Drawing.Point(4, 27);
            this.StationTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StationTab.Name = "StationTab";
            this.StationTab.Size = new System.Drawing.Size(975, 419);
            this.StationTab.TabIndex = 2;
            this.StationTab.Text = "Station";
            this.StationTab.UseVisualStyleBackColor = true;
            // 
            // DevTab
            // 
            this.DevTab.Controls.Add(this.DevTechGrid);
            this.DevTab.Controls.Add(this.impersonateTechCB);
            this.DevTab.Controls.Add(this.impersonateBTN);
            this.DevTab.Location = new System.Drawing.Point(4, 27);
            this.DevTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DevTab.Name = "DevTab";
            this.DevTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DevTab.Size = new System.Drawing.Size(975, 419);
            this.DevTab.TabIndex = 3;
            this.DevTab.Text = "Dev";
            this.DevTab.UseVisualStyleBackColor = true;
            // 
            // DevTechGrid
            // 
            this.DevTechGrid.AllowUserToAddRows = false;
            this.DevTechGrid.AllowUserToDeleteRows = false;
            this.DevTechGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DevTechGrid.Location = new System.Drawing.Point(4, 337);
            this.DevTechGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DevTechGrid.Name = "DevTechGrid";
            this.DevTechGrid.ReadOnly = true;
            this.DevTechGrid.RowTemplate.Height = 28;
            this.DevTechGrid.Size = new System.Drawing.Size(938, 66);
            this.DevTechGrid.TabIndex = 3;
            // 
            // impersonateTechCB
            // 
            this.impersonateTechCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.impersonateTechCB.FormattingEnabled = true;
            this.impersonateTechCB.Location = new System.Drawing.Point(13, 4);
            this.impersonateTechCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.impersonateTechCB.Name = "impersonateTechCB";
            this.impersonateTechCB.Size = new System.Drawing.Size(199, 26);
            this.impersonateTechCB.TabIndex = 2;
            // 
            // impersonateBTN
            // 
            this.impersonateBTN.Location = new System.Drawing.Point(13, 31);
            this.impersonateBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.impersonateBTN.Name = "impersonateBTN";
            this.impersonateBTN.Size = new System.Drawing.Size(198, 25);
            this.impersonateBTN.TabIndex = 1;
            this.impersonateBTN.Text = "impersonate";
            this.impersonateBTN.UseVisualStyleBackColor = true;
            this.impersonateBTN.Click += new System.EventHandler(this.impersonateBTN_Click);
            // 
            // EmailSystemTab
            // 
            this.EmailSystemTab.Controls.Add(this.NewInventoryTOCCSavedlbl);
            this.EmailSystemTab.Controls.Add(this.NewInventoryTOCCbtn);
            this.EmailSystemTab.Controls.Add(this.NewInventoryCCListTB);
            this.EmailSystemTab.Controls.Add(this.label7);
            this.EmailSystemTab.Controls.Add(this.NewInventoryToTB);
            this.EmailSystemTab.Controls.Add(this.label6);
            this.EmailSystemTab.Controls.Add(this.NewTechSavedlbl);
            this.EmailSystemTab.Controls.Add(this.ModifyTechSavedlbl);
            this.EmailSystemTab.Controls.Add(this.NewTechCCbtn);
            this.EmailSystemTab.Controls.Add(this.ModifyTechCCbtn);
            this.EmailSystemTab.Controls.Add(this.NewTechCCListTB);
            this.EmailSystemTab.Controls.Add(this.label4);
            this.EmailSystemTab.Controls.Add(this.ModifyTechCCListTB);
            this.EmailSystemTab.Controls.Add(this.label2);
            this.EmailSystemTab.Location = new System.Drawing.Point(4, 27);
            this.EmailSystemTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailSystemTab.Name = "EmailSystemTab";
            this.EmailSystemTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailSystemTab.Size = new System.Drawing.Size(975, 419);
            this.EmailSystemTab.TabIndex = 4;
            this.EmailSystemTab.Text = "Email System";
            this.EmailSystemTab.UseVisualStyleBackColor = true;
            // 
            // NewInventoryTOCCSavedlbl
            // 
            this.NewInventoryTOCCSavedlbl.AutoSize = true;
            this.NewInventoryTOCCSavedlbl.ForeColor = System.Drawing.Color.Red;
            this.NewInventoryTOCCSavedlbl.Location = new System.Drawing.Point(537, 201);
            this.NewInventoryTOCCSavedlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewInventoryTOCCSavedlbl.Name = "NewInventoryTOCCSavedlbl";
            this.NewInventoryTOCCSavedlbl.Size = new System.Drawing.Size(68, 18);
            this.NewInventoryTOCCSavedlbl.TabIndex = 13;
            this.NewInventoryTOCCSavedlbl.Text = "Saved!!!";
            this.NewInventoryTOCCSavedlbl.Visible = false;
            // 
            // NewInventoryTOCCbtn
            // 
            this.NewInventoryTOCCbtn.Location = new System.Drawing.Point(501, 165);
            this.NewInventoryTOCCbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewInventoryTOCCbtn.Name = "NewInventoryTOCCbtn";
            this.NewInventoryTOCCbtn.Size = new System.Drawing.Size(141, 29);
            this.NewInventoryTOCCbtn.TabIndex = 12;
            this.NewInventoryTOCCbtn.Text = "Update";
            this.NewInventoryTOCCbtn.UseVisualStyleBackColor = true;
            this.NewInventoryTOCCbtn.Click += new System.EventHandler(this.NewInventoryTOCCbtn_Click);
            // 
            // NewInventoryCCListTB
            // 
            this.NewInventoryCCListTB.Location = new System.Drawing.Point(474, 89);
            this.NewInventoryCCListTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewInventoryCCListTB.Multiline = true;
            this.NewInventoryCCListTB.Name = "NewInventoryCCListTB";
            this.NewInventoryCCListTB.Size = new System.Drawing.Size(197, 70);
            this.NewInventoryCCListTB.TabIndex = 11;
            this.NewInventoryCCListTB.TextChanged += new System.EventHandler(this.NewInventoryCCListTB_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "New Inventory CC";
            // 
            // NewInventoryToTB
            // 
            this.NewInventoryToTB.Location = new System.Drawing.Point(474, 42);
            this.NewInventoryToTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewInventoryToTB.Name = "NewInventoryToTB";
            this.NewInventoryToTB.Size = new System.Drawing.Size(197, 26);
            this.NewInventoryToTB.TabIndex = 9;
            this.NewInventoryToTB.TextChanged += new System.EventHandler(this.NewInventoryToTB_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "New Inventory To";
            // 
            // NewTechSavedlbl
            // 
            this.NewTechSavedlbl.AutoSize = true;
            this.NewTechSavedlbl.ForeColor = System.Drawing.Color.Red;
            this.NewTechSavedlbl.Location = new System.Drawing.Point(311, 203);
            this.NewTechSavedlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewTechSavedlbl.Name = "NewTechSavedlbl";
            this.NewTechSavedlbl.Size = new System.Drawing.Size(68, 18);
            this.NewTechSavedlbl.TabIndex = 7;
            this.NewTechSavedlbl.Text = "Saved!!!";
            this.NewTechSavedlbl.Visible = false;
            // 
            // ModifyTechSavedlbl
            // 
            this.ModifyTechSavedlbl.AutoSize = true;
            this.ModifyTechSavedlbl.ForeColor = System.Drawing.Color.Red;
            this.ModifyTechSavedlbl.Location = new System.Drawing.Point(87, 203);
            this.ModifyTechSavedlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifyTechSavedlbl.Name = "ModifyTechSavedlbl";
            this.ModifyTechSavedlbl.Size = new System.Drawing.Size(68, 18);
            this.ModifyTechSavedlbl.TabIndex = 6;
            this.ModifyTechSavedlbl.Text = "Saved!!!";
            this.ModifyTechSavedlbl.Visible = false;
            // 
            // NewTechCCbtn
            // 
            this.NewTechCCbtn.Location = new System.Drawing.Point(275, 165);
            this.NewTechCCbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewTechCCbtn.Name = "NewTechCCbtn";
            this.NewTechCCbtn.Size = new System.Drawing.Size(141, 29);
            this.NewTechCCbtn.TabIndex = 5;
            this.NewTechCCbtn.Text = "Update";
            this.NewTechCCbtn.UseVisualStyleBackColor = true;
            this.NewTechCCbtn.Click += new System.EventHandler(this.NewTechCCbtn_Click);
            // 
            // ModifyTechCCbtn
            // 
            this.ModifyTechCCbtn.Location = new System.Drawing.Point(51, 165);
            this.ModifyTechCCbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifyTechCCbtn.Name = "ModifyTechCCbtn";
            this.ModifyTechCCbtn.Size = new System.Drawing.Size(141, 29);
            this.ModifyTechCCbtn.TabIndex = 4;
            this.ModifyTechCCbtn.Text = "Update";
            this.ModifyTechCCbtn.UseVisualStyleBackColor = true;
            this.ModifyTechCCbtn.Click += new System.EventHandler(this.ModifyTechCCbtn_Click);
            // 
            // NewTechCCListTB
            // 
            this.NewTechCCListTB.Location = new System.Drawing.Point(251, 42);
            this.NewTechCCListTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewTechCCListTB.Multiline = true;
            this.NewTechCCListTB.Name = "NewTechCCListTB";
            this.NewTechCCListTB.Size = new System.Drawing.Size(197, 118);
            this.NewTechCCListTB.TabIndex = 3;
            this.NewTechCCListTB.TextChanged += new System.EventHandler(this.NewTechCCListTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "New Tech CC list";
            // 
            // ModifyTechCCListTB
            // 
            this.ModifyTechCCListTB.Location = new System.Drawing.Point(26, 42);
            this.ModifyTechCCListTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifyTechCCListTB.Multiline = true;
            this.ModifyTechCCListTB.Name = "ModifyTechCCListTB";
            this.ModifyTechCCListTB.Size = new System.Drawing.Size(197, 118);
            this.ModifyTechCCListTB.TabIndex = 1;
            this.ModifyTechCCListTB.TextChanged += new System.EventHandler(this.ModifyTechCCListTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modify Tech CC list";
            // 
            // DatabaseTab
            // 
            this.DatabaseTab.Controls.Add(this.BackupEDB);
            this.DatabaseTab.Location = new System.Drawing.Point(4, 27);
            this.DatabaseTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DatabaseTab.Name = "DatabaseTab";
            this.DatabaseTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DatabaseTab.Size = new System.Drawing.Size(975, 419);
            this.DatabaseTab.TabIndex = 5;
            this.DatabaseTab.Text = "Database";
            this.DatabaseTab.UseVisualStyleBackColor = true;
            // 
            // BackupEDB
            // 
            this.BackupEDB.Location = new System.Drawing.Point(15, 13);
            this.BackupEDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackupEDB.Name = "BackupEDB";
            this.BackupEDB.Size = new System.Drawing.Size(223, 28);
            this.BackupEDB.TabIndex = 0;
            this.BackupEDB.Text = "Backup entire Database";
            this.BackupEDB.UseVisualStyleBackColor = true;
            this.BackupEDB.Click += new System.EventHandler(this.BackupEDB_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 89);
            this.panel2.TabIndex = 16;
            // 
            // AdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(983, 539);
            this.Name = "AdminSettings";
            this.Size = new System.Drawing.Size(983, 539);
            this.Load += new System.EventHandler(this.AdminSettings_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.AuditTab.ResumeLayout(false);
            this.AuditTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SerialsAuditDG)).EndInit();
            this.StationTab.ResumeLayout(false);
            this.StationTab.PerformLayout();
            this.DevTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DevTechGrid)).EndInit();
            this.EmailSystemTab.ResumeLayout(false);
            this.EmailSystemTab.PerformLayout();
            this.DatabaseTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label InventoryMovelbl;
        private System.Windows.Forms.Button ToggleAuditBtn;
        private System.Windows.Forms.Label AuditStatuslbl;
        private System.Windows.Forms.Label StationPasswordlbl;
        private System.Windows.Forms.TextBox NewStationpwTB;
        private System.Windows.Forms.Button SetStationpwBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StationUpdatedlbl;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.TabPage AuditTab;
        private System.Windows.Forms.TabPage StationTab;
        private System.Windows.Forms.TabPage DevTab;
        private System.Windows.Forms.TabPage EmailSystemTab;
        private System.Windows.Forms.TextBox ModifyTechCCListTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewTechCCListTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button NewTechCCbtn;
        private System.Windows.Forms.Button ModifyTechCCbtn;
        private System.Windows.Forms.Label NewTechSavedlbl;
        private System.Windows.Forms.Label ModifyTechSavedlbl;
        private System.Windows.Forms.Label NewInventoryTOCCSavedlbl;
        private System.Windows.Forms.Button NewInventoryTOCCbtn;
        private System.Windows.Forms.TextBox NewInventoryCCListTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NewInventoryToTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView SerialsAuditDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serials;
        private System.Windows.Forms.TabPage DatabaseTab;
        private System.Windows.Forms.Button BackupEDB;
        private System.Windows.Forms.ComboBox impersonateTechCB;
        private System.Windows.Forms.Button impersonateBTN;
        private System.Windows.Forms.DataGridView DevTechGrid;
        internal System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel2;
    }
}
