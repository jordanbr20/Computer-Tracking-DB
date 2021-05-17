namespace ComputerTrackingDB
{
    partial class InventoryMove
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
            this.InventoryMovelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.NotesTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InventoryMoveGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryMoveGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventoryMovelbl
            // 
            this.InventoryMovelbl.BackColor = System.Drawing.Color.Transparent;
            this.InventoryMovelbl.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.InventoryMovelbl.Location = new System.Drawing.Point(-2, -2);
            this.InventoryMovelbl.Name = "InventoryMovelbl";
            this.InventoryMovelbl.Size = new System.Drawing.Size(1426, 120);
            this.InventoryMovelbl.TabIndex = 0;
            this.InventoryMovelbl.Text = "Move";
            this.InventoryMovelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.InventoryMovelbl);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(21, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 120);
            this.panel1.TabIndex = 5;
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Savebtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Savebtn.Font = new System.Drawing.Font("Arial", 14.25F);
            this.Savebtn.Location = new System.Drawing.Point(617, 490);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(261, 42);
            this.Savebtn.TabIndex = 34;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // LocationLock
            // 
            this.LocationLock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationLock.AutoSize = true;
            this.LocationLock.Font = new System.Drawing.Font("Arial", 14.25F);
            this.LocationLock.Location = new System.Drawing.Point(898, 306);
            this.LocationLock.Name = "LocationLock";
            this.LocationLock.Size = new System.Drawing.Size(102, 37);
            this.LocationLock.TabIndex = 339999;
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
            this.LocationCB.Location = new System.Drawing.Point(617, 304);
            this.LocationCB.Name = "LocationCB";
            this.LocationCB.Size = new System.Drawing.Size(260, 41);
            this.LocationCB.Sorted = true;
            this.LocationCB.TabIndex = 32;
            // 
            // TechIDTB
            // 
            this.TechIDTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TechIDTB.Font = new System.Drawing.Font("Arial", 14.25F);
            this.TechIDTB.Location = new System.Drawing.Point(617, 253);
            this.TechIDTB.Name = "TechIDTB";
            this.TechIDTB.ReadOnly = true;
            this.TechIDTB.Size = new System.Drawing.Size(260, 40);
            this.TechIDTB.TabIndex = 31;
            // 
            // DateTB
            // 
            this.DateTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTB.Font = new System.Drawing.Font("Arial", 14.25F);
            this.DateTB.Location = new System.Drawing.Point(617, 203);
            this.DateTB.Name = "DateTB";
            this.DateTB.ReadOnly = true;
            this.DateTB.Size = new System.Drawing.Size(260, 40);
            this.DateTB.TabIndex = 30;
            // 
            // SerialTB
            // 
            this.SerialTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SerialTB.Font = new System.Drawing.Font("Arial", 14.25F);
            this.SerialTB.Location = new System.Drawing.Point(617, 149);
            this.SerialTB.MaxLength = 12;
            this.SerialTB.Name = "SerialTB";
            this.SerialTB.Size = new System.Drawing.Size(260, 40);
            this.SerialTB.TabIndex = 29;
            this.SerialTB.TextChanged += new System.EventHandler(this.SerialTB_TextChanged);
            this.SerialTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SerialTB_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label4.Location = new System.Drawing.Point(478, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 33);
            this.label4.TabIndex = 28;
            this.label4.Text = "Location:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label3.Location = new System.Drawing.Point(489, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 33);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tech ID:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label2.Location = new System.Drawing.Point(527, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 33);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.Location = new System.Drawing.Point(401, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 33);
            this.label1.TabIndex = 25;
            this.label1.Text = "Serial Number:";
            // 
            // NotesTB
            // 
            this.NotesTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NotesTB.Font = new System.Drawing.Font("Arial", 14.25F);
            this.NotesTB.Location = new System.Drawing.Point(617, 355);
            this.NotesTB.Multiline = true;
            this.NotesTB.Name = "NotesTB";
            this.NotesTB.Size = new System.Drawing.Size(260, 126);
            this.NotesTB.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label5.Location = new System.Drawing.Point(513, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 33);
            this.label5.TabIndex = 35;
            this.label5.Text = "Notes:";
            // 
            // InventoryMoveGrid
            // 
            this.InventoryMoveGrid.AllowUserToAddRows = false;
            this.InventoryMoveGrid.AllowUserToDeleteRows = false;
            this.InventoryMoveGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.InventoryMoveGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InventoryMoveGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryMoveGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.InventoryMoveGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InventoryMoveGrid.Location = new System.Drawing.Point(0, 550);
            this.InventoryMoveGrid.Name = "InventoryMoveGrid";
            this.InventoryMoveGrid.RowTemplate.Height = 28;
            this.InventoryMoveGrid.Size = new System.Drawing.Size(1474, 279);
            this.InventoryMoveGrid.TabIndex = 37;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Serial";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 85;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tech Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 126;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Old Location";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 134;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "New Location";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 141;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Notes";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 87;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 92;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NotesTB);
            this.panel2.Controls.Add(this.label5);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1474, 550);
            this.panel2.TabIndex = 340000;
            // 
            // InventoryMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.InventoryMoveGrid);
            this.Controls.Add(this.panel2);
            this.Name = "InventoryMove";
            this.Size = new System.Drawing.Size(1474, 829);
            this.Load += new System.EventHandler(this.InventoryMove_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryMoveGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InventoryMovelbl;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.TextBox NotesTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView InventoryMoveGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel2;
    }
}
