namespace ComputerTrackingDB
{
    partial class AdminModels
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
            this.ModelCB = new System.Windows.Forms.ComboBox();
            this.ActiveCB = new System.Windows.Forms.CheckBox();
            this.TypeTB = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.Savedlbl = new System.Windows.Forms.Label();
            this.NewModelTB = new System.Windows.Forms.TextBox();
            this.ModelTypelbl = new System.Windows.Forms.Label();
            this.Modellbl = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(23, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 120);
            this.panel1.TabIndex = 6;
            // 
            // InventoryMovelbl
            // 
            this.InventoryMovelbl.BackColor = System.Drawing.Color.Transparent;
            this.InventoryMovelbl.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.InventoryMovelbl.Location = new System.Drawing.Point(-2, -2);
            this.InventoryMovelbl.Name = "InventoryMovelbl";
            this.InventoryMovelbl.Size = new System.Drawing.Size(1426, 122);
            this.InventoryMovelbl.TabIndex = 0;
            this.InventoryMovelbl.Text = "Models";
            this.InventoryMovelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelCB
            // 
            this.ModelCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModelCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelCB.Font = new System.Drawing.Font("Arial", 14F);
            this.ModelCB.FormattingEnabled = true;
            this.ModelCB.Location = new System.Drawing.Point(592, 8);
            this.ModelCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModelCB.MaxDropDownItems = 99;
            this.ModelCB.Name = "ModelCB";
            this.ModelCB.Size = new System.Drawing.Size(266, 40);
            this.ModelCB.TabIndex = 7;
            this.ModelCB.SelectedIndexChanged += new System.EventHandler(this.ModelCB_SelectedIndexChanged);
            // 
            // ActiveCB
            // 
            this.ActiveCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActiveCB.AutoSize = true;
            this.ActiveCB.Font = new System.Drawing.Font("Arial", 14F);
            this.ActiveCB.Location = new System.Drawing.Point(661, 117);
            this.ActiveCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ActiveCB.Name = "ActiveCB";
            this.ActiveCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ActiveCB.Size = new System.Drawing.Size(116, 36);
            this.ActiveCB.TabIndex = 8;
            this.ActiveCB.Text = "Active";
            this.ActiveCB.UseVisualStyleBackColor = true;
            // 
            // TypeTB
            // 
            this.TypeTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeTB.Font = new System.Drawing.Font("Arial", 14F);
            this.TypeTB.Location = new System.Drawing.Point(592, 64);
            this.TypeTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TypeTB.Name = "TypeTB";
            this.TypeTB.Size = new System.Drawing.Size(266, 40);
            this.TypeTB.TabIndex = 9;
            // 
            // Update
            // 
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update.Font = new System.Drawing.Font("Arial", 14F);
            this.Update.Location = new System.Drawing.Point(592, 167);
            this.Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(268, 49);
            this.Update.TabIndex = 10;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Savedlbl
            // 
            this.Savedlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Savedlbl.AutoSize = true;
            this.Savedlbl.Font = new System.Drawing.Font("Arial", 14F);
            this.Savedlbl.ForeColor = System.Drawing.Color.Red;
            this.Savedlbl.Location = new System.Drawing.Point(660, 242);
            this.Savedlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Savedlbl.Name = "Savedlbl";
            this.Savedlbl.Size = new System.Drawing.Size(117, 32);
            this.Savedlbl.TabIndex = 11;
            this.Savedlbl.Text = "Saved!!!";
            this.Savedlbl.Visible = false;
            // 
            // NewModelTB
            // 
            this.NewModelTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewModelTB.Font = new System.Drawing.Font("Arial", 14F);
            this.NewModelTB.Location = new System.Drawing.Point(1177, 377);
            this.NewModelTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewModelTB.Name = "NewModelTB";
            this.NewModelTB.Size = new System.Drawing.Size(266, 40);
            this.NewModelTB.TabIndex = 12;
            this.NewModelTB.Visible = false;
            // 
            // ModelTypelbl
            // 
            this.ModelTypelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModelTypelbl.AutoSize = true;
            this.ModelTypelbl.Font = new System.Drawing.Font("Arial", 14F);
            this.ModelTypelbl.Location = new System.Drawing.Point(412, 68);
            this.ModelTypelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModelTypelbl.Name = "ModelTypelbl";
            this.ModelTypelbl.Size = new System.Drawing.Size(163, 32);
            this.ModelTypelbl.TabIndex = 13;
            this.ModelTypelbl.Text = "Model Type:";
            // 
            // Modellbl
            // 
            this.Modellbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modellbl.AutoSize = true;
            this.Modellbl.Font = new System.Drawing.Font("Arial", 14F);
            this.Modellbl.Location = new System.Drawing.Point(1060, 382);
            this.Modellbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Modellbl.Name = "Modellbl";
            this.Modellbl.Size = new System.Drawing.Size(106, 32);
            this.Modellbl.TabIndex = 14;
            this.Modellbl.Text = "Model :";
            this.Modellbl.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1474, 139);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Modellbl);
            this.panel3.Controls.Add(this.ModelTypelbl);
            this.panel3.Controls.Add(this.NewModelTB);
            this.panel3.Controls.Add(this.Savedlbl);
            this.panel3.Controls.Add(this.Update);
            this.panel3.Controls.Add(this.TypeTB);
            this.panel3.Controls.Add(this.ActiveCB);
            this.panel3.Controls.Add(this.ModelCB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1474, 443);
            this.panel3.TabIndex = 16;
            // 
            // AdminModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminModels";
            this.Size = new System.Drawing.Size(1474, 829);
            this.Load += new System.EventHandler(this.AdminModels_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label InventoryMovelbl;
        private System.Windows.Forms.ComboBox ModelCB;
        private System.Windows.Forms.CheckBox ActiveCB;
        private System.Windows.Forms.TextBox TypeTB;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label Savedlbl;
        private System.Windows.Forms.TextBox NewModelTB;
        private System.Windows.Forms.Label ModelTypelbl;
        private System.Windows.Forms.Label Modellbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
