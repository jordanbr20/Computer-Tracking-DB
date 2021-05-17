namespace ComputerTrackingDB
{
    partial class AuditMode
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AuditModeActivedByLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 32F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1435, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Audit Mode Active";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 18F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(14, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1435, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please wait to update any assets until Audit is finshed.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(14, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1438, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Audit Mode Actived By :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuditModeActivedByLbl
            // 
            this.AuditModeActivedByLbl.Font = new System.Drawing.Font("Arial", 16F);
            this.AuditModeActivedByLbl.ForeColor = System.Drawing.Color.Red;
            this.AuditModeActivedByLbl.Location = new System.Drawing.Point(14, 492);
            this.AuditModeActivedByLbl.Name = "AuditModeActivedByLbl";
            this.AuditModeActivedByLbl.Size = new System.Drawing.Size(1438, 54);
            this.AuditModeActivedByLbl.TabIndex = 3;
            this.AuditModeActivedByLbl.Text = "TechName";
            this.AuditModeActivedByLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AuditModeActivedByLbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1475, 829);
            this.panel1.TabIndex = 4;
            // 
            // AuditMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.panel1);
            this.Name = "AuditMode";
            this.Size = new System.Drawing.Size(1475, 829);
            this.Load += new System.EventHandler(this.AuditMode_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AuditModeActivedByLbl;
        private System.Windows.Forms.Panel panel1;
    }
}
