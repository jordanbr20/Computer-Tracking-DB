using ComputerTrackingDB.Properties;

namespace ComputerTrackingDB
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TechInfoUpdater = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.CheckDB = new System.Windows.Forms.Timer(this.components);
            this.CheckAudit = new System.Windows.Forms.Timer(this.components);
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.SignOutBTN = new System.Windows.Forms.Button();
            this.PrintLabelsBTN = new System.Windows.Forms.Button();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.SettingsBTN = new System.Windows.Forms.Button();
            this.ExportsBTN = new System.Windows.Forms.Button();
            this.LocationsBTN = new System.Windows.Forms.Button();
            this.ModelsBTN = new System.Windows.Forms.Button();
            this.TechniciansBTN = new System.Windows.Forms.Button();
            this.AdminBTN = new System.Windows.Forms.Button();
            this.InventoryPanel = new System.Windows.Forms.Panel();
            this.INVMoveBTN = new System.Windows.Forms.Button();
            this.INVAuditBTN = new System.Windows.Forms.Button();
            this.INVNewBTN = new System.Windows.Forms.Button();
            this.InventoryBTN = new System.Windows.Forms.Button();
            this.ScanMachineBTN = new System.Windows.Forms.Button();
            this.HomeBTN = new System.Windows.Forms.Button();
            this.TechPanel = new System.Windows.Forms.Panel();
            this.ComputerTrackingDBTitlelbl = new System.Windows.Forms.Label();
            this.TechNamelbl = new System.Windows.Forms.Label();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.ComputerTrackingDBLabel = new System.Windows.Forms.Label();
            this.ConnectionPanel = new System.Windows.Forms.Panel();
            this.ConStatusLBL = new System.Windows.Forms.Label();
            this.ConNameLBL = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.InventoryPanel.SuspendLayout();
            this.TechPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.ConnectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TechInfoUpdater
            // 
            this.TechInfoUpdater.Enabled = true;
            this.TechInfoUpdater.Interval = 1000;
            this.TechInfoUpdater.Tick += new System.EventHandler(this.TechInfoUpdater_Tick);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(188, 37);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.MinimumSize = new System.Drawing.Size(1011, 567);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1015, 578);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.Leave += new System.EventHandler(this.MainPanel_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(188, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.MinimumSize = new System.Drawing.Size(983, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 37);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SearchTB);
            this.panel1.Location = new System.Drawing.Point(213, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 37);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search :";
            // 
            // SearchTB
            // 
            this.SearchTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchTB.Font = new System.Drawing.Font("Arial", 10F);
            this.SearchTB.Location = new System.Drawing.Point(74, 7);
            this.SearchTB.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(470, 23);
            this.SearchTB.TabIndex = 0;
            this.SearchTB.TextChanged += new System.EventHandler(this.SearchTB_TextChanged);
            this.SearchTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTB_KeyDown);
            // 
            // CheckDB
            // 
            this.CheckDB.Enabled = true;
            this.CheckDB.Interval = 300000;
            this.CheckDB.Tick += new System.EventHandler(this.CheckDB_Tick);
            // 
            // CheckAudit
            // 
            this.CheckAudit.Enabled = true;
            this.CheckAudit.Interval = 300000;
            this.CheckAudit.Tick += new System.EventHandler(this.CheckAudit_Tick);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.MenuPanel.Controls.Add(this.ButtonPanel);
            this.MenuPanel.Controls.Add(this.TechPanel);
            this.MenuPanel.Controls.Add(this.LogoPanel);
            this.MenuPanel.Controls.Add(this.ConnectionPanel);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(188, 615);
            this.MenuPanel.TabIndex = 5;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.AutoScroll = true;
            this.ButtonPanel.Controls.Add(this.ExitBTN);
            this.ButtonPanel.Controls.Add(this.SignOutBTN);
            this.ButtonPanel.Controls.Add(this.PrintLabelsBTN);
            this.ButtonPanel.Controls.Add(this.AdminPanel);
            this.ButtonPanel.Controls.Add(this.AdminBTN);
            this.ButtonPanel.Controls.Add(this.InventoryPanel);
            this.ButtonPanel.Controls.Add(this.InventoryBTN);
            this.ButtonPanel.Controls.Add(this.ScanMachineBTN);
            this.ButtonPanel.Controls.Add(this.HomeBTN);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 86);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(188, 495);
            this.ButtonPanel.TabIndex = 2;
            // 
            // ExitBTN
            // 
            this.ExitBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExitBTN.FlatAppearance.BorderSize = 0;
            this.ExitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ExitBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitBTN.Location = new System.Drawing.Point(0, 411);
            this.ExitBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(188, 29);
            this.ExitBTN.TabIndex = 13;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // SignOutBTN
            // 
            this.SignOutBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.SignOutBTN.FlatAppearance.BorderSize = 0;
            this.SignOutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOutBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.SignOutBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.SignOutBTN.Location = new System.Drawing.Point(0, 382);
            this.SignOutBTN.Margin = new System.Windows.Forms.Padding(2);
            this.SignOutBTN.Name = "SignOutBTN";
            this.SignOutBTN.Size = new System.Drawing.Size(188, 29);
            this.SignOutBTN.TabIndex = 12;
            this.SignOutBTN.Text = "Signout";
            this.SignOutBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignOutBTN.UseVisualStyleBackColor = true;
            this.SignOutBTN.Click += new System.EventHandler(this.SignOutBTN_Click);
            // 
            // PrintLabelsBTN
            // 
            this.PrintLabelsBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrintLabelsBTN.FlatAppearance.BorderSize = 0;
            this.PrintLabelsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintLabelsBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.PrintLabelsBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.PrintLabelsBTN.Location = new System.Drawing.Point(0, 353);
            this.PrintLabelsBTN.Margin = new System.Windows.Forms.Padding(2);
            this.PrintLabelsBTN.Name = "PrintLabelsBTN";
            this.PrintLabelsBTN.Size = new System.Drawing.Size(188, 29);
            this.PrintLabelsBTN.TabIndex = 10;
            this.PrintLabelsBTN.Text = "Print Labels";
            this.PrintLabelsBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintLabelsBTN.UseVisualStyleBackColor = true;
            this.PrintLabelsBTN.Click += new System.EventHandler(this.PrintLabelsBTN_Click);
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.SettingsBTN);
            this.AdminPanel.Controls.Add(this.ExportsBTN);
            this.AdminPanel.Controls.Add(this.LocationsBTN);
            this.AdminPanel.Controls.Add(this.ModelsBTN);
            this.AdminPanel.Controls.Add(this.TechniciansBTN);
            this.AdminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminPanel.Location = new System.Drawing.Point(0, 206);
            this.AdminPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(188, 147);
            this.AdminPanel.TabIndex = 8;
            this.AdminPanel.Visible = false;
            // 
            // SettingsBTN
            // 
            this.SettingsBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsBTN.FlatAppearance.BorderSize = 0;
            this.SettingsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.SettingsBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.SettingsBTN.Location = new System.Drawing.Point(0, 116);
            this.SettingsBTN.Margin = new System.Windows.Forms.Padding(2);
            this.SettingsBTN.Name = "SettingsBTN";
            this.SettingsBTN.Size = new System.Drawing.Size(188, 29);
            this.SettingsBTN.TabIndex = 14;
            this.SettingsBTN.Text = "Settings";
            this.SettingsBTN.UseVisualStyleBackColor = true;
            this.SettingsBTN.Click += new System.EventHandler(this.SettingsBTN_Click);
            // 
            // ExportsBTN
            // 
            this.ExportsBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExportsBTN.FlatAppearance.BorderSize = 0;
            this.ExportsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportsBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ExportsBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.ExportsBTN.Location = new System.Drawing.Point(0, 87);
            this.ExportsBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ExportsBTN.Name = "ExportsBTN";
            this.ExportsBTN.Size = new System.Drawing.Size(188, 29);
            this.ExportsBTN.TabIndex = 13;
            this.ExportsBTN.Text = "Exports";
            this.ExportsBTN.UseVisualStyleBackColor = true;
            this.ExportsBTN.Click += new System.EventHandler(this.ExportsBTN_Click);
            // 
            // LocationsBTN
            // 
            this.LocationsBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocationsBTN.FlatAppearance.BorderSize = 0;
            this.LocationsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocationsBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.LocationsBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.LocationsBTN.Location = new System.Drawing.Point(0, 58);
            this.LocationsBTN.Margin = new System.Windows.Forms.Padding(2);
            this.LocationsBTN.Name = "LocationsBTN";
            this.LocationsBTN.Size = new System.Drawing.Size(188, 29);
            this.LocationsBTN.TabIndex = 12;
            this.LocationsBTN.Text = "Locations";
            this.LocationsBTN.UseVisualStyleBackColor = true;
            this.LocationsBTN.Click += new System.EventHandler(this.LocationsBTN_Click);
            // 
            // ModelsBTN
            // 
            this.ModelsBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ModelsBTN.FlatAppearance.BorderSize = 0;
            this.ModelsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModelsBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ModelsBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.ModelsBTN.Location = new System.Drawing.Point(0, 29);
            this.ModelsBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ModelsBTN.Name = "ModelsBTN";
            this.ModelsBTN.Size = new System.Drawing.Size(188, 29);
            this.ModelsBTN.TabIndex = 11;
            this.ModelsBTN.Text = "Models";
            this.ModelsBTN.UseVisualStyleBackColor = true;
            this.ModelsBTN.Click += new System.EventHandler(this.ModelsBTN_Click);
            // 
            // TechniciansBTN
            // 
            this.TechniciansBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.TechniciansBTN.FlatAppearance.BorderSize = 0;
            this.TechniciansBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TechniciansBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.TechniciansBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.TechniciansBTN.Location = new System.Drawing.Point(0, 0);
            this.TechniciansBTN.Margin = new System.Windows.Forms.Padding(2);
            this.TechniciansBTN.Name = "TechniciansBTN";
            this.TechniciansBTN.Size = new System.Drawing.Size(188, 29);
            this.TechniciansBTN.TabIndex = 8;
            this.TechniciansBTN.Text = "Technicians";
            this.TechniciansBTN.UseVisualStyleBackColor = true;
            this.TechniciansBTN.Click += new System.EventHandler(this.TechniciansBTN_Click);
            // 
            // AdminBTN
            // 
            this.AdminBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminBTN.FlatAppearance.BorderSize = 0;
            this.AdminBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.AdminBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.AdminBTN.Location = new System.Drawing.Point(0, 177);
            this.AdminBTN.Margin = new System.Windows.Forms.Padding(2);
            this.AdminBTN.Name = "AdminBTN";
            this.AdminBTN.Size = new System.Drawing.Size(188, 29);
            this.AdminBTN.TabIndex = 7;
            this.AdminBTN.Text = "Admin";
            this.AdminBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminBTN.UseVisualStyleBackColor = true;
            this.AdminBTN.Click += new System.EventHandler(this.AdminBTN_Click);
            // 
            // InventoryPanel
            // 
            this.InventoryPanel.Controls.Add(this.INVMoveBTN);
            this.InventoryPanel.Controls.Add(this.INVAuditBTN);
            this.InventoryPanel.Controls.Add(this.INVNewBTN);
            this.InventoryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryPanel.Location = new System.Drawing.Point(0, 87);
            this.InventoryPanel.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryPanel.Name = "InventoryPanel";
            this.InventoryPanel.Size = new System.Drawing.Size(188, 90);
            this.InventoryPanel.TabIndex = 4;
            this.InventoryPanel.Visible = false;
            // 
            // INVMoveBTN
            // 
            this.INVMoveBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.INVMoveBTN.FlatAppearance.BorderSize = 0;
            this.INVMoveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.INVMoveBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.INVMoveBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.INVMoveBTN.Location = new System.Drawing.Point(0, 58);
            this.INVMoveBTN.Margin = new System.Windows.Forms.Padding(2);
            this.INVMoveBTN.Name = "INVMoveBTN";
            this.INVMoveBTN.Size = new System.Drawing.Size(188, 29);
            this.INVMoveBTN.TabIndex = 7;
            this.INVMoveBTN.Text = "Move";
            this.INVMoveBTN.UseVisualStyleBackColor = true;
            this.INVMoveBTN.Click += new System.EventHandler(this.INVMoveBTN_Click);
            // 
            // INVAuditBTN
            // 
            this.INVAuditBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.INVAuditBTN.FlatAppearance.BorderSize = 0;
            this.INVAuditBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.INVAuditBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.INVAuditBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.INVAuditBTN.Location = new System.Drawing.Point(0, 29);
            this.INVAuditBTN.Margin = new System.Windows.Forms.Padding(2);
            this.INVAuditBTN.Name = "INVAuditBTN";
            this.INVAuditBTN.Size = new System.Drawing.Size(188, 29);
            this.INVAuditBTN.TabIndex = 6;
            this.INVAuditBTN.Text = "Audit";
            this.INVAuditBTN.UseVisualStyleBackColor = true;
            this.INVAuditBTN.Click += new System.EventHandler(this.INVAuditBTN_Click);
            // 
            // INVNewBTN
            // 
            this.INVNewBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.INVNewBTN.FlatAppearance.BorderSize = 0;
            this.INVNewBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.INVNewBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.INVNewBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.INVNewBTN.Location = new System.Drawing.Point(0, 0);
            this.INVNewBTN.Margin = new System.Windows.Forms.Padding(2);
            this.INVNewBTN.Name = "INVNewBTN";
            this.INVNewBTN.Size = new System.Drawing.Size(188, 29);
            this.INVNewBTN.TabIndex = 5;
            this.INVNewBTN.Text = "New";
            this.INVNewBTN.UseVisualStyleBackColor = true;
            this.INVNewBTN.Click += new System.EventHandler(this.INVNewBTN_Click);
            // 
            // InventoryBTN
            // 
            this.InventoryBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryBTN.FlatAppearance.BorderSize = 0;
            this.InventoryBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InventoryBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.InventoryBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.InventoryBTN.Location = new System.Drawing.Point(0, 58);
            this.InventoryBTN.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryBTN.Name = "InventoryBTN";
            this.InventoryBTN.Size = new System.Drawing.Size(188, 29);
            this.InventoryBTN.TabIndex = 3;
            this.InventoryBTN.Text = "Inventory";
            this.InventoryBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryBTN.UseVisualStyleBackColor = true;
            this.InventoryBTN.Click += new System.EventHandler(this.InventoryBTN_Click);
            // 
            // ScanMachineBTN
            // 
            this.ScanMachineBTN.BackColor = System.Drawing.Color.DarkBlue;
            this.ScanMachineBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ScanMachineBTN.FlatAppearance.BorderSize = 0;
            this.ScanMachineBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScanMachineBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ScanMachineBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.ScanMachineBTN.Location = new System.Drawing.Point(0, 29);
            this.ScanMachineBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ScanMachineBTN.Name = "ScanMachineBTN";
            this.ScanMachineBTN.Size = new System.Drawing.Size(188, 29);
            this.ScanMachineBTN.TabIndex = 0;
            this.ScanMachineBTN.Text = "Scan Machines";
            this.ScanMachineBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScanMachineBTN.UseVisualStyleBackColor = false;
            this.ScanMachineBTN.Click += new System.EventHandler(this.ScanMachineBTN_Click);
            // 
            // HomeBTN
            // 
            this.HomeBTN.BackColor = System.Drawing.Color.DarkBlue;
            this.HomeBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBTN.FlatAppearance.BorderSize = 0;
            this.HomeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBTN.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.HomeBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.HomeBTN.Location = new System.Drawing.Point(0, 0);
            this.HomeBTN.Margin = new System.Windows.Forms.Padding(2);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(188, 29);
            this.HomeBTN.TabIndex = 15;
            this.HomeBTN.Text = "Home";
            this.HomeBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBTN.UseVisualStyleBackColor = false;
            this.HomeBTN.Visible = false;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
            // 
            // TechPanel
            // 
            this.TechPanel.Controls.Add(this.ComputerTrackingDBTitlelbl);
            this.TechPanel.Controls.Add(this.TechNamelbl);
            this.TechPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TechPanel.Location = new System.Drawing.Point(0, 37);
            this.TechPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TechPanel.Name = "TechPanel";
            this.TechPanel.Size = new System.Drawing.Size(188, 49);
            this.TechPanel.TabIndex = 1;
            this.TechPanel.Click += new System.EventHandler(this.UserPanel_Click);
            // 
            // ComputerTrackingDBTitlelbl
            // 
            this.ComputerTrackingDBTitlelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComputerTrackingDBTitlelbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ComputerTrackingDBTitlelbl.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ComputerTrackingDBTitlelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.ComputerTrackingDBTitlelbl.Location = new System.Drawing.Point(0, 26);
            this.ComputerTrackingDBTitlelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ComputerTrackingDBTitlelbl.Name = "ComputerTrackingDBTitlelbl";
            this.ComputerTrackingDBTitlelbl.Size = new System.Drawing.Size(188, 23);
            this.ComputerTrackingDBTitlelbl.TabIndex = 6;
            this.ComputerTrackingDBTitlelbl.Text = "Title";
            this.ComputerTrackingDBTitlelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ComputerTrackingDBTitlelbl.Click += new System.EventHandler(this.ComputerTrackingDBTitlelbl_Click);
            // 
            // TechNamelbl
            // 
            this.TechNamelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TechNamelbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TechNamelbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.TechNamelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.TechNamelbl.Location = new System.Drawing.Point(0, 0);
            this.TechNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TechNamelbl.Name = "TechNamelbl";
            this.TechNamelbl.Size = new System.Drawing.Size(188, 26);
            this.TechNamelbl.TabIndex = 5;
            this.TechNamelbl.Text = "Tech Name";
            this.TechNamelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TechNamelbl.TextChanged += new System.EventHandler(this.TechNamelbl_TextChanged);
            this.TechNamelbl.Click += new System.EventHandler(this.TechNamelbl_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.ComputerTrackingDBLabel);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(188, 37);
            this.LogoPanel.TabIndex = 0;
            // 
            // ComputerTrackingDBLabel
            // 
            this.ComputerTrackingDBLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComputerTrackingDBLabel.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.ComputerTrackingDBLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ComputerTrackingDBLabel.Location = new System.Drawing.Point(0, 0);
            this.ComputerTrackingDBLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ComputerTrackingDBLabel.Name = "ComputerTrackingDBLabel";
            this.ComputerTrackingDBLabel.Size = new System.Drawing.Size(188, 37);
            this.ComputerTrackingDBLabel.TabIndex = 0;
            this.ComputerTrackingDBLabel.Text = "Computer Tracking DB";
            this.ComputerTrackingDBLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComputerTrackingDBLabel.Click += new System.EventHandler(this.Versionlbl_Click);
            // 
            // ConnectionPanel
            // 
            this.ConnectionPanel.Controls.Add(this.ConStatusLBL);
            this.ConnectionPanel.Controls.Add(this.ConNameLBL);
            this.ConnectionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConnectionPanel.Location = new System.Drawing.Point(0, 581);
            this.ConnectionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectionPanel.Name = "ConnectionPanel";
            this.ConnectionPanel.Size = new System.Drawing.Size(188, 34);
            this.ConnectionPanel.TabIndex = 3;
            // 
            // ConStatusLBL
            // 
            this.ConStatusLBL.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConStatusLBL.ForeColor = System.Drawing.SystemColors.Control;
            this.ConStatusLBL.Location = new System.Drawing.Point(0, 0);
            this.ConStatusLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConStatusLBL.Name = "ConStatusLBL";
            this.ConStatusLBL.Size = new System.Drawing.Size(188, 16);
            this.ConStatusLBL.TabIndex = 8;
            this.ConStatusLBL.Text = "ConnectionStatus";
            // 
            // ConNameLBL
            // 
            this.ConNameLBL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConNameLBL.ForeColor = System.Drawing.SystemColors.Control;
            this.ConNameLBL.Location = new System.Drawing.Point(0, 16);
            this.ConNameLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConNameLBL.Name = "ConNameLBL";
            this.ConNameLBL.Size = new System.Drawing.Size(188, 18);
            this.ConNameLBL.TabIndex = 9;
            this.ConNameLBL.Text = "ConnectionName";
            // 
            // Main
            // 
            this.AccessibleName = "MainMenu";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1203, 615);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1219, 654);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Tracking Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.AdminPanel.ResumeLayout(false);
            this.InventoryPanel.ResumeLayout(false);
            this.TechPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.ConnectionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer CheckDB;
        private System.Windows.Forms.Timer CheckAudit;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Panel MainPanel;
        internal System.Windows.Forms.Timer TechInfoUpdater;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel TechPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel ConnectionPanel;
        private System.Windows.Forms.Label ComputerTrackingDBLabel;
        private System.Windows.Forms.Label ComputerTrackingDBTitlelbl;
        public System.Windows.Forms.Label TechNamelbl;
        private System.Windows.Forms.Label ConStatusLBL;
        private System.Windows.Forms.Label ConNameLBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button SignOutBTN;
        private System.Windows.Forms.Button PrintLabelsBTN;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Button SettingsBTN;
        private System.Windows.Forms.Button ExportsBTN;
        private System.Windows.Forms.Button LocationsBTN;
        private System.Windows.Forms.Button ModelsBTN;
        private System.Windows.Forms.Button TechniciansBTN;
        private System.Windows.Forms.Button AdminBTN;
        private System.Windows.Forms.Panel InventoryPanel;
        private System.Windows.Forms.Button INVMoveBTN;
        private System.Windows.Forms.Button INVAuditBTN;
        private System.Windows.Forms.Button INVNewBTN;
        private System.Windows.Forms.Button InventoryBTN;
        private System.Windows.Forms.Button ScanMachineBTN;
        private System.Windows.Forms.Button HomeBTN;
    }
}

