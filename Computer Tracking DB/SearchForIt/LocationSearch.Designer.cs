namespace ComputerTrackingDB.SearchForIt
{
    partial class LocationSearch
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
            this.ActiveLBL = new System.Windows.Forms.Label();
            this.LocationLBL = new System.Windows.Forms.Label();
            this.SearchStatusDT = new System.Windows.Forms.DataGridView();
            this.ComptuerStatusDT = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStatusDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComptuerStatusDT)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ActiveLBL);
            this.panel1.Controls.Add(this.LocationLBL);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(25, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 121);
            this.panel1.TabIndex = 5;
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
            // LocationLBL
            // 
            this.LocationLBL.BackColor = System.Drawing.Color.Transparent;
            this.LocationLBL.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.LocationLBL.Location = new System.Drawing.Point(-1, -1);
            this.LocationLBL.Name = "LocationLBL";
            this.LocationLBL.Size = new System.Drawing.Size(1427, 117);
            this.LocationLBL.TabIndex = 0;
            this.LocationLBL.Text = "Location";
            this.LocationLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchStatusDT
            // 
            this.SearchStatusDT.AllowUserToAddRows = false;
            this.SearchStatusDT.AllowUserToDeleteRows = false;
            this.SearchStatusDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchStatusDT.Location = new System.Drawing.Point(25, 709);
            this.SearchStatusDT.Name = "SearchStatusDT";
            this.SearchStatusDT.ReadOnly = true;
            this.SearchStatusDT.RowTemplate.Height = 28;
            this.SearchStatusDT.Size = new System.Drawing.Size(1427, 78);
            this.SearchStatusDT.TabIndex = 10;
            this.SearchStatusDT.Visible = false;
            // 
            // ComptuerStatusDT
            // 
            this.ComptuerStatusDT.AllowUserToAddRows = false;
            this.ComptuerStatusDT.AllowUserToDeleteRows = false;
            this.ComptuerStatusDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComptuerStatusDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComptuerStatusDT.Location = new System.Drawing.Point(25, 153);
            this.ComptuerStatusDT.Name = "ComptuerStatusDT";
            this.ComptuerStatusDT.ReadOnly = true;
            this.ComptuerStatusDT.RowTemplate.Height = 28;
            this.ComptuerStatusDT.Size = new System.Drawing.Size(1427, 623);
            this.ComptuerStatusDT.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1475, 147);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1475, 795);
            this.panel3.TabIndex = 13;
            // 
            // LocationSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.ComptuerStatusDT);
            this.Controls.Add(this.SearchStatusDT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(1475, 795);
            this.Name = "LocationSearch";
            this.Size = new System.Drawing.Size(1475, 795);
            this.Load += new System.EventHandler(this.LocationSearch_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchStatusDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComptuerStatusDT)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ActiveLBL;
        private System.Windows.Forms.Label LocationLBL;
        private System.Windows.Forms.DataGridView SearchStatusDT;
        private System.Windows.Forms.DataGridView ComptuerStatusDT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
