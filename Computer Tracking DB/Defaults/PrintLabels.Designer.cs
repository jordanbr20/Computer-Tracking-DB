namespace ComputerTrackingDB
{
    partial class PrintLabels
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
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.FillCB = new System.Windows.Forms.ComboBox();
            this.SerialTB = new System.Windows.Forms.TextBox();
            this.ModelLbl = new System.Windows.Forms.Label();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.TechIDLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(26, 9);
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
            this.InventoryMovelbl.Size = new System.Drawing.Size(1426, 120);
            this.InventoryMovelbl.TabIndex = 0;
            this.InventoryMovelbl.Text = "Print Labels";
            this.InventoryMovelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Arial", 14.5F);
            this.label1.Location = new System.Drawing.Point(26, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1428, 65);
            this.label1.TabIndex = 7;
            this.label1.Text = "Label Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeCB
            // 
            this.TypeCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TypeCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCB.Font = new System.Drawing.Font("Arial", 14.5F);
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Items.AddRange(new object[] {
            "Serial Number",
            "TechID",
            "Location",
            "Model"});
            this.TypeCB.Location = new System.Drawing.Point(609, 199);
            this.TypeCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(253, 41);
            this.TypeCB.TabIndex = 8;
            this.TypeCB.SelectedIndexChanged += new System.EventHandler(this.TypeCB_SelectedIndexChanged);
            // 
            // FillCB
            // 
            this.FillCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FillCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.FillCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FillCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FillCB.Font = new System.Drawing.Font("Arial", 14.5F);
            this.FillCB.FormattingEnabled = true;
            this.FillCB.Items.AddRange(new object[] {
            "Serial Number",
            "Tech ID",
            "Location",
            "Model"});
            this.FillCB.Location = new System.Drawing.Point(609, 271);
            this.FillCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FillCB.Name = "FillCB";
            this.FillCB.Size = new System.Drawing.Size(253, 41);
            this.FillCB.TabIndex = 9;
            this.FillCB.Visible = false;
            this.FillCB.SelectedIndexChanged += new System.EventHandler(this.FillCB_SelectedIndexChanged);
            // 
            // SerialTB
            // 
            this.SerialTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SerialTB.Font = new System.Drawing.Font("Arial", 14.5F);
            this.SerialTB.Location = new System.Drawing.Point(933, 271);
            this.SerialTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SerialTB.MaxLength = 12;
            this.SerialTB.Name = "SerialTB";
            this.SerialTB.Size = new System.Drawing.Size(253, 41);
            this.SerialTB.TabIndex = 10;
            this.SerialTB.Visible = false;
            this.SerialTB.TextChanged += new System.EventHandler(this.SerialTB_TextChanged);
            this.SerialTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SerialTB_KeyDown);
            // 
            // ModelLbl
            // 
            this.ModelLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModelLbl.Font = new System.Drawing.Font("Arial", 14.5F);
            this.ModelLbl.Location = new System.Drawing.Point(609, 331);
            this.ModelLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModelLbl.Name = "ModelLbl";
            this.ModelLbl.Size = new System.Drawing.Size(255, 48);
            this.ModelLbl.TabIndex = 11;
            this.ModelLbl.Text = "Model";
            this.ModelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ModelLbl.Visible = false;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintBtn.Font = new System.Drawing.Font("Arial", 14.5F);
            this.PrintBtn.Location = new System.Drawing.Point(609, 383);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(255, 48);
            this.PrintBtn.TabIndex = 12;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Visible = false;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // TechIDLbl
            // 
            this.TechIDLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TechIDLbl.Font = new System.Drawing.Font("Arial", 14.5F);
            this.TechIDLbl.Location = new System.Drawing.Point(933, 331);
            this.TechIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TechIDLbl.Name = "TechIDLbl";
            this.TechIDLbl.Size = new System.Drawing.Size(255, 48);
            this.TechIDLbl.TabIndex = 13;
            this.TechIDLbl.Text = "TechID";
            this.TechIDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TechIDLbl.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(26, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 64);
            this.label2.TabIndex = 14;
            this.label2.Text = "If you do not have a Dymo printer \r\ndo not attempt to print!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TechIDLbl);
            this.panel2.Controls.Add(this.PrintBtn);
            this.panel2.Controls.Add(this.ModelLbl);
            this.panel2.Controls.Add(this.SerialTB);
            this.panel2.Controls.Add(this.FillCB);
            this.panel2.Controls.Add(this.TypeCB);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1474, 518);
            this.panel2.TabIndex = 15;
            // 
            // PrintLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PrintLabels";
            this.Size = new System.Drawing.Size(1474, 829);
            this.Load += new System.EventHandler(this.PrintLabels_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label InventoryMovelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.ComboBox FillCB;
        private System.Windows.Forms.TextBox SerialTB;
        private System.Windows.Forms.Label ModelLbl;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Label TechIDLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}
