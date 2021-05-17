namespace ComputerTrackingDB
{
    partial class AdminLocations
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
            this.NewLocation = new System.Windows.Forms.TextBox();
            this.Savedlbl = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.ActiveCB = new System.Windows.Forms.CheckBox();
            this.LocationsCB = new System.Windows.Forms.ComboBox();
            this.Locationlbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(26, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 120);
            this.panel1.TabIndex = 7;
            // 
            // InventoryMovelbl
            // 
            this.InventoryMovelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InventoryMovelbl.BackColor = System.Drawing.Color.Transparent;
            this.InventoryMovelbl.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.InventoryMovelbl.Location = new System.Drawing.Point(-1, 0);
            this.InventoryMovelbl.Name = "InventoryMovelbl";
            this.InventoryMovelbl.Size = new System.Drawing.Size(1419, 118);
            this.InventoryMovelbl.TabIndex = 0;
            this.InventoryMovelbl.Text = "Locations";
            this.InventoryMovelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewLocation
            // 
            this.NewLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewLocation.Font = new System.Drawing.Font("Arial", 14F);
            this.NewLocation.Location = new System.Drawing.Point(593, 63);
            this.NewLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewLocation.Name = "NewLocation";
            this.NewLocation.Size = new System.Drawing.Size(351, 40);
            this.NewLocation.TabIndex = 18;
            this.NewLocation.Visible = false;
            // 
            // Savedlbl
            // 
            this.Savedlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Savedlbl.AutoSize = true;
            this.Savedlbl.Font = new System.Drawing.Font("Arial", 14F);
            this.Savedlbl.ForeColor = System.Drawing.Color.Red;
            this.Savedlbl.Location = new System.Drawing.Point(709, 167);
            this.Savedlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Savedlbl.Name = "Savedlbl";
            this.Savedlbl.Size = new System.Drawing.Size(117, 32);
            this.Savedlbl.TabIndex = 17;
            this.Savedlbl.Text = "Saved!!!";
            this.Savedlbl.Visible = false;
            // 
            // Update
            // 
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update.Font = new System.Drawing.Font("Arial", 14F);
            this.Update.Location = new System.Drawing.Point(628, 113);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(268, 49);
            this.Update.TabIndex = 16;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // ActiveCB
            // 
            this.ActiveCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActiveCB.AutoSize = true;
            this.ActiveCB.Font = new System.Drawing.Font("Arial", 14F);
            this.ActiveCB.Location = new System.Drawing.Point(691, 65);
            this.ActiveCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ActiveCB.Name = "ActiveCB";
            this.ActiveCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ActiveCB.Size = new System.Drawing.Size(116, 36);
            this.ActiveCB.TabIndex = 14;
            this.ActiveCB.Text = "Active";
            this.ActiveCB.UseVisualStyleBackColor = true;
            // 
            // LocationsCB
            // 
            this.LocationsCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LocationsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationsCB.Font = new System.Drawing.Font("Arial", 14F);
            this.LocationsCB.FormattingEnabled = true;
            this.LocationsCB.Location = new System.Drawing.Point(593, 9);
            this.LocationsCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LocationsCB.MaxDropDownItems = 99;
            this.LocationsCB.Name = "LocationsCB";
            this.LocationsCB.Size = new System.Drawing.Size(351, 40);
            this.LocationsCB.TabIndex = 13;
            this.LocationsCB.SelectedIndexChanged += new System.EventHandler(this.LocationsCB_SelectedIndexChanged);
            // 
            // Locationlbl
            // 
            this.Locationlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Locationlbl.AutoSize = true;
            this.Locationlbl.Font = new System.Drawing.Font("Arial", 14F);
            this.Locationlbl.Location = new System.Drawing.Point(443, 69);
            this.Locationlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Locationlbl.Name = "Locationlbl";
            this.Locationlbl.Size = new System.Drawing.Size(136, 32);
            this.Locationlbl.TabIndex = 19;
            this.Locationlbl.Text = "Location :";
            this.Locationlbl.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1475, 158);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Locationlbl);
            this.panel3.Controls.Add(this.NewLocation);
            this.panel3.Controls.Add(this.Savedlbl);
            this.panel3.Controls.Add(this.Update);
            this.panel3.Controls.Add(this.ActiveCB);
            this.panel3.Controls.Add(this.LocationsCB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1475, 302);
            this.panel3.TabIndex = 21;
            // 
            // AdminLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminLocations";
            this.Size = new System.Drawing.Size(1475, 829);
            this.Load += new System.EventHandler(this.AdminLocations_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label InventoryMovelbl;
        private System.Windows.Forms.TextBox NewLocation;
        private System.Windows.Forms.Label Savedlbl;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.CheckBox ActiveCB;
        private System.Windows.Forms.ComboBox LocationsCB;
        private System.Windows.Forms.Label Locationlbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
