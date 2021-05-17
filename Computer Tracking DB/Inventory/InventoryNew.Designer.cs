namespace ComputerTrackingDB
{
    partial class InventoryNew
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
            this.NewInventorylbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LockLocationBox = new System.Windows.Forms.CheckBox();
            this.LocationCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TechIDlbl = new System.Windows.Forms.Label();
            this.TechIDTextBox = new System.Windows.Forms.TextBox();
            this.MLockCheckBox = new System.Windows.Forms.CheckBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.NewInventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.DateTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FailedSuccessColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailGrid = new System.Windows.Forms.DataGridView();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewInventoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewInventorylbl
            // 
            this.NewInventorylbl.BackColor = System.Drawing.Color.Transparent;
            this.NewInventorylbl.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.NewInventorylbl.Location = new System.Drawing.Point(-1, -1);
            this.NewInventorylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewInventorylbl.Name = "NewInventorylbl";
            this.NewInventorylbl.Size = new System.Drawing.Size(951, 78);
            this.NewInventorylbl.TabIndex = 999999;
            this.NewInventorylbl.Text = "New Inventory";
            this.NewInventorylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NewInventorylbl);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(17, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 79);
            this.panel1.TabIndex = 999999;
            // 
            // LockLocationBox
            // 
            this.LockLocationBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LockLocationBox.AutoSize = true;
            this.LockLocationBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.LockLocationBox.Location = new System.Drawing.Point(601, 215);
            this.LockLocationBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LockLocationBox.Name = "LockLocationBox";
            this.LockLocationBox.Size = new System.Drawing.Size(70, 26);
            this.LockLocationBox.TabIndex = 999999;
            this.LockLocationBox.Text = "Lock";
            this.LockLocationBox.UseVisualStyleBackColor = true;
            this.LockLocationBox.CheckedChanged += new System.EventHandler(this.LockLocationBox_CheckedChanged);
            // 
            // LocationCombo
            // 
            this.LocationCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationCombo.Font = new System.Drawing.Font("Arial", 14.25F);
            this.LocationCombo.FormattingEnabled = true;
            this.LocationCombo.Location = new System.Drawing.Point(385, 216);
            this.LocationCombo.MaxDropDownItems = 50;
            this.LocationCombo.Name = "LocationCombo";
            this.LocationCombo.Size = new System.Drawing.Size(205, 30);
            this.LocationCombo.Sorted = true;
            this.LocationCombo.TabIndex = 4;
            this.LocationCombo.SelectedIndexChanged += new System.EventHandler(this.LocationCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label3.Location = new System.Drawing.Point(285, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 999999;
            this.label3.Text = "Location:";
            // 
            // TechIDlbl
            // 
            this.TechIDlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TechIDlbl.AutoSize = true;
            this.TechIDlbl.Font = new System.Drawing.Font("Arial", 14.25F);
            this.TechIDlbl.Location = new System.Drawing.Point(301, 149);
            this.TechIDlbl.Name = "TechIDlbl";
            this.TechIDlbl.Size = new System.Drawing.Size(76, 22);
            this.TechIDlbl.TabIndex = 999999;
            this.TechIDlbl.Text = "TechID:";
            // 
            // TechIDTextBox
            // 
            this.TechIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TechIDTextBox.Enabled = false;
            this.TechIDTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.TechIDTextBox.Location = new System.Drawing.Point(385, 147);
            this.TechIDTextBox.MaxLength = 10;
            this.TechIDTextBox.Name = "TechIDTextBox";
            this.TechIDTextBox.Size = new System.Drawing.Size(205, 29);
            this.TechIDTextBox.TabIndex = 2;
            this.TechIDTextBox.TextChanged += new System.EventHandler(this.TechIDTextBox_TextChanged);
            // 
            // MLockCheckBox
            // 
            this.MLockCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MLockCheckBox.AutoSize = true;
            this.MLockCheckBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.MLockCheckBox.Location = new System.Drawing.Point(601, 182);
            this.MLockCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MLockCheckBox.Name = "MLockCheckBox";
            this.MLockCheckBox.Size = new System.Drawing.Size(70, 26);
            this.MLockCheckBox.TabIndex = 999999;
            this.MLockCheckBox.Text = "Lock";
            this.MLockCheckBox.UseVisualStyleBackColor = true;
            this.MLockCheckBox.CheckedChanged += new System.EventHandler(this.MLockCheckBox_CheckedChanged);
            // 
            // modelComboBox
            // 
            this.modelComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modelComboBox.DisplayMember = "Model";
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(385, 180);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(205, 30);
            this.modelComboBox.Sorted = true;
            this.modelComboBox.TabIndex = 3;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label2.Location = new System.Drawing.Point(307, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 999999;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.Location = new System.Drawing.Point(307, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 999999;
            this.label1.Text = "Serial: ";
            // 
            // serialTextBox
            // 
            this.serialTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serialTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.serialTextBox.Location = new System.Drawing.Point(385, 114);
            this.serialTextBox.MaxLength = 12;
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(205, 29);
            this.serialTextBox.TabIndex = 1;
            this.serialTextBox.TextChanged += new System.EventHandler(this.serialTextBox_TextChanged);
            this.serialTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serialTextBox_KeyDown);
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Savebtn.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Savebtn.Location = new System.Drawing.Point(385, 254);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(204, 31);
            this.Savebtn.TabIndex = 5;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // NewInventoryDataGrid
            // 
            this.NewInventoryDataGrid.AllowUserToAddRows = false;
            this.NewInventoryDataGrid.AllowUserToDeleteRows = false;
            this.NewInventoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.NewInventoryDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.NewInventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewInventoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTimeColumn,
            this.SerialColumn,
            this.ModelColumn,
            this.TechNameColumn,
            this.LocationColumn,
            this.FailedSuccessColumn});
            this.NewInventoryDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewInventoryDataGrid.Location = new System.Drawing.Point(0, 309);
            this.NewInventoryDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewInventoryDataGrid.Name = "NewInventoryDataGrid";
            this.NewInventoryDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.NewInventoryDataGrid.RowTemplate.Height = 28;
            this.NewInventoryDataGrid.Size = new System.Drawing.Size(983, 230);
            this.NewInventoryDataGrid.TabIndex = 999999;
            // 
            // DateTimeColumn
            // 
            this.DateTimeColumn.HeaderText = "Date/Time";
            this.DateTimeColumn.Name = "DateTimeColumn";
            this.DateTimeColumn.ReadOnly = true;
            this.DateTimeColumn.Width = 83;
            // 
            // SerialColumn
            // 
            this.SerialColumn.HeaderText = "Serial";
            this.SerialColumn.Name = "SerialColumn";
            this.SerialColumn.ReadOnly = true;
            this.SerialColumn.Width = 58;
            // 
            // ModelColumn
            // 
            this.ModelColumn.HeaderText = "Model";
            this.ModelColumn.Name = "ModelColumn";
            this.ModelColumn.ReadOnly = true;
            this.ModelColumn.Width = 61;
            // 
            // TechNameColumn
            // 
            this.TechNameColumn.HeaderText = "TechName";
            this.TechNameColumn.Name = "TechNameColumn";
            this.TechNameColumn.ReadOnly = true;
            this.TechNameColumn.Width = 85;
            // 
            // LocationColumn
            // 
            this.LocationColumn.HeaderText = "Location";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.ReadOnly = true;
            this.LocationColumn.Width = 73;
            // 
            // FailedSuccessColumn
            // 
            this.FailedSuccessColumn.HeaderText = "Failed/Success";
            this.FailedSuccessColumn.Name = "FailedSuccessColumn";
            this.FailedSuccessColumn.ReadOnly = true;
            this.FailedSuccessColumn.Width = 106;
            // 
            // EmailGrid
            // 
            this.EmailGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmailGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial});
            this.EmailGrid.Location = new System.Drawing.Point(10, 311);
            this.EmailGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailGrid.Name = "EmailGrid";
            this.EmailGrid.RowTemplate.Height = 28;
            this.EmailGrid.Size = new System.Drawing.Size(160, 97);
            this.EmailGrid.TabIndex = 1000002;
            this.EmailGrid.Visible = false;
            // 
            // Serial
            // 
            this.Serial.HeaderText = "Serial";
            this.Serial.Name = "Serial";
            this.Serial.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Savebtn);
            this.panel2.Controls.Add(this.LockLocationBox);
            this.panel2.Controls.Add(this.LocationCombo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TechIDlbl);
            this.panel2.Controls.Add(this.TechIDTextBox);
            this.panel2.Controls.Add(this.MLockCheckBox);
            this.panel2.Controls.Add(this.modelComboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.serialTextBox);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 309);
            this.panel2.TabIndex = 1000003;
            // 
            // InventoryNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.NewInventoryDataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EmailGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InventoryNew";
            this.Size = new System.Drawing.Size(983, 539);
            this.Load += new System.EventHandler(this.InventoryNew_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NewInventoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NewInventorylbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox LockLocationBox;
        private System.Windows.Forms.ComboBox LocationCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TechIDlbl;
        private System.Windows.Forms.TextBox TechIDTextBox;
        private System.Windows.Forms.CheckBox MLockCheckBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.DataGridView NewInventoryDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FailedSuccessColumn;
        private System.Windows.Forms.DataGridView EmailGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.Panel panel2;
    }
}
