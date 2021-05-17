namespace ComputerTrackingDB
{
    partial class SerialSearch
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
            this.TaggedDataGrid = new System.Windows.Forms.DataGridView();
            this.Modellbl = new System.Windows.Forms.Label();
            this.EnteredDatelbl = new System.Windows.Forms.Label();
            this.SerialLBL = new System.Windows.Forms.Label();
            this.Locationlbl = new System.Windows.Forms.Label();
            this.LastModifiedlbl = new System.Windows.Forms.Label();
            this.SearchStatusDT = new System.Windows.Forms.DataGridView();
            this.TransactionGrid = new System.Windows.Forms.DataGridView();
            this.Transactionslbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaggedDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStatusDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TaggedDataGrid);
            this.panel1.Controls.Add(this.Modellbl);
            this.panel1.Controls.Add(this.EnteredDatelbl);
            this.panel1.Controls.Add(this.SerialLBL);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(17, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 79);
            this.panel1.TabIndex = 3;
            // 
            // TaggedDataGrid
            // 
            this.TaggedDataGrid.AllowUserToAddRows = false;
            this.TaggedDataGrid.AllowUserToDeleteRows = false;
            this.TaggedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaggedDataGrid.Location = new System.Drawing.Point(235, 2);
            this.TaggedDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TaggedDataGrid.Name = "TaggedDataGrid";
            this.TaggedDataGrid.ReadOnly = true;
            this.TaggedDataGrid.RowTemplate.Height = 28;
            this.TaggedDataGrid.Size = new System.Drawing.Size(178, 15);
            this.TaggedDataGrid.TabIndex = 14;
            this.TaggedDataGrid.Visible = false;
            // 
            // Modellbl
            // 
            this.Modellbl.Font = new System.Drawing.Font("Arial", 14F);
            this.Modellbl.Location = new System.Drawing.Point(787, 55);
            this.Modellbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Modellbl.Name = "Modellbl";
            this.Modellbl.Size = new System.Drawing.Size(161, 21);
            this.Modellbl.TabIndex = 10;
            this.Modellbl.Text = "Unknown";
            this.Modellbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EnteredDatelbl
            // 
            this.EnteredDatelbl.Font = new System.Drawing.Font("Arial", 14F);
            this.EnteredDatelbl.Location = new System.Drawing.Point(2, 55);
            this.EnteredDatelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnteredDatelbl.Name = "EnteredDatelbl";
            this.EnteredDatelbl.Size = new System.Drawing.Size(211, 21);
            this.EnteredDatelbl.TabIndex = 9;
            this.EnteredDatelbl.Text = "Unknown";
            // 
            // SerialLBL
            // 
            this.SerialLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SerialLBL.BackColor = System.Drawing.Color.Transparent;
            this.SerialLBL.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.SerialLBL.Location = new System.Drawing.Point(-1, -1);
            this.SerialLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SerialLBL.Name = "SerialLBL";
            this.SerialLBL.Size = new System.Drawing.Size(951, 76);
            this.SerialLBL.TabIndex = 0;
            this.SerialLBL.Text = "Serial";
            this.SerialLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SerialLBL.Click += new System.EventHandler(this.SerialLBL_Click);
            // 
            // Locationlbl
            // 
            this.Locationlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Locationlbl.Font = new System.Drawing.Font("Arial", 14F);
            this.Locationlbl.Location = new System.Drawing.Point(19, 91);
            this.Locationlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Locationlbl.Name = "Locationlbl";
            this.Locationlbl.Size = new System.Drawing.Size(469, 21);
            this.Locationlbl.TabIndex = 5;
            this.Locationlbl.Text = "Unknown";
            // 
            // LastModifiedlbl
            // 
            this.LastModifiedlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastModifiedlbl.Font = new System.Drawing.Font("Arial", 14F);
            this.LastModifiedlbl.Location = new System.Drawing.Point(577, 91);
            this.LastModifiedlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastModifiedlbl.Name = "LastModifiedlbl";
            this.LastModifiedlbl.Size = new System.Drawing.Size(391, 21);
            this.LastModifiedlbl.TabIndex = 7;
            this.LastModifiedlbl.Text = "Unknown";
            this.LastModifiedlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchStatusDT
            // 
            this.SearchStatusDT.AllowUserToAddRows = false;
            this.SearchStatusDT.AllowUserToDeleteRows = false;
            this.SearchStatusDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchStatusDT.Location = new System.Drawing.Point(17, 499);
            this.SearchStatusDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchStatusDT.Name = "SearchStatusDT";
            this.SearchStatusDT.ReadOnly = true;
            this.SearchStatusDT.RowTemplate.Height = 28;
            this.SearchStatusDT.Size = new System.Drawing.Size(952, 16);
            this.SearchStatusDT.TabIndex = 8;
            this.SearchStatusDT.Visible = false;
            // 
            // TransactionGrid
            // 
            this.TransactionGrid.AllowUserToAddRows = false;
            this.TransactionGrid.AllowUserToDeleteRows = false;
            this.TransactionGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TransactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionGrid.Location = new System.Drawing.Point(17, 166);
            this.TransactionGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TransactionGrid.Name = "TransactionGrid";
            this.TransactionGrid.ReadOnly = true;
            this.TransactionGrid.RowTemplate.Height = 28;
            this.TransactionGrid.Size = new System.Drawing.Size(951, 329);
            this.TransactionGrid.TabIndex = 9;
            // 
            // Transactionslbl
            // 
            this.Transactionslbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Transactionslbl.AutoSize = true;
            this.Transactionslbl.Font = new System.Drawing.Font("Arial", 14F);
            this.Transactionslbl.Location = new System.Drawing.Point(442, 133);
            this.Transactionslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Transactionslbl.Name = "Transactionslbl";
            this.Transactionslbl.Size = new System.Drawing.Size(117, 22);
            this.Transactionslbl.TabIndex = 10;
            this.Transactionslbl.Text = "Transactions";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 124);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 124);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(983, 393);
            this.panel3.TabIndex = 15;
            // 
            // SerialSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.Transactionslbl);
            this.Controls.Add(this.TransactionGrid);
            this.Controls.Add(this.SearchStatusDT);
            this.Controls.Add(this.LastModifiedlbl);
            this.Controls.Add(this.Locationlbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(983, 517);
            this.Name = "SerialSearch";
            this.Size = new System.Drawing.Size(983, 517);
            this.Load += new System.EventHandler(this.SearchForIt_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaggedDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchStatusDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SerialLBL;
        private System.Windows.Forms.Label Locationlbl;
        private System.Windows.Forms.Label LastModifiedlbl;
        private System.Windows.Forms.Label EnteredDatelbl;
        private System.Windows.Forms.DataGridView SearchStatusDT;
        private System.Windows.Forms.Label Modellbl;
        private System.Windows.Forms.DataGridView TransactionGrid;
        private System.Windows.Forms.Label Transactionslbl;
        private System.Windows.Forms.DataGridView TaggedDataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
