namespace ComputerTrackingDB
{
    partial class UserSearch
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
            this.RoleLBL = new System.Windows.Forms.Label();
            this.ActiveLBL = new System.Windows.Forms.Label();
            this.TechLBL = new System.Windows.Forms.Label();
            this.SearchStatusDT = new System.Windows.Forms.DataGridView();
            this.TransactionsDT = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStatusDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RoleLBL);
            this.panel1.Controls.Add(this.ActiveLBL);
            this.panel1.Controls.Add(this.TechLBL);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(25, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 121);
            this.panel1.TabIndex = 4;
            // 
            // RoleLBL
            // 
            this.RoleLBL.Font = new System.Drawing.Font("Arial", 14F);
            this.RoleLBL.Location = new System.Drawing.Point(936, 84);
            this.RoleLBL.Name = "RoleLBL";
            this.RoleLBL.Size = new System.Drawing.Size(486, 32);
            this.RoleLBL.TabIndex = 10;
            this.RoleLBL.Text = "Unknown";
            this.RoleLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ActiveLBL
            // 
            this.ActiveLBL.Font = new System.Drawing.Font("Arial", 14F);
            this.ActiveLBL.Location = new System.Drawing.Point(3, 84);
            this.ActiveLBL.Name = "ActiveLBL";
            this.ActiveLBL.Size = new System.Drawing.Size(317, 32);
            this.ActiveLBL.TabIndex = 9;
            this.ActiveLBL.Text = "Unknown";
            // 
            // TechLBL
            // 
            this.TechLBL.BackColor = System.Drawing.Color.Transparent;
            this.TechLBL.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.TechLBL.Location = new System.Drawing.Point(-1, -1);
            this.TechLBL.Name = "TechLBL";
            this.TechLBL.Size = new System.Drawing.Size(1427, 121);
            this.TechLBL.TabIndex = 0;
            this.TechLBL.Text = "Tech";
            this.TechLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchStatusDT
            // 
            this.SearchStatusDT.AllowUserToAddRows = false;
            this.SearchStatusDT.AllowUserToDeleteRows = false;
            this.SearchStatusDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchStatusDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchStatusDT.Location = new System.Drawing.Point(25, 693);
            this.SearchStatusDT.Name = "SearchStatusDT";
            this.SearchStatusDT.ReadOnly = true;
            this.SearchStatusDT.RowTemplate.Height = 28;
            this.SearchStatusDT.Size = new System.Drawing.Size(1427, 90);
            this.SearchStatusDT.TabIndex = 9;
            // 
            // TransactionsDT
            // 
            this.TransactionsDT.AllowUserToAddRows = false;
            this.TransactionsDT.AllowUserToDeleteRows = false;
            this.TransactionsDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TransactionsDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TransactionsDT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TransactionsDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsDT.Location = new System.Drawing.Point(25, 157);
            this.TransactionsDT.Name = "TransactionsDT";
            this.TransactionsDT.ReadOnly = true;
            this.TransactionsDT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TransactionsDT.RowTemplate.Height = 28;
            this.TransactionsDT.Size = new System.Drawing.Size(1427, 520);
            this.TransactionsDT.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1475, 148);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1475, 647);
            this.panel3.TabIndex = 12;
            // 
            // UserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.TransactionsDT);
            this.Controls.Add(this.SearchStatusDT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(1475, 795);
            this.Name = "UserSearch";
            this.Size = new System.Drawing.Size(1475, 795);
            this.Load += new System.EventHandler(this.UserSearch_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchStatusDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RoleLBL;
        private System.Windows.Forms.Label ActiveLBL;
        private System.Windows.Forms.Label TechLBL;
        private System.Windows.Forms.DataGridView SearchStatusDT;
        private System.Windows.Forms.DataGridView TransactionsDT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
