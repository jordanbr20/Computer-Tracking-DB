namespace ComputerTrackingDB
{
    partial class LoginForm
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
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.TechPerms = new System.Windows.Forms.DataGridView();
            this.GetPermsBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TechPerms)).BeginInit();
            this.SuspendLayout();
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Font = new System.Drawing.Font("Arial", 10F);
            this.Usernamelbl.Location = new System.Drawing.Point(9, 13);
            this.Usernamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(80, 16);
            this.Usernamelbl.TabIndex = 0;
            this.Usernamelbl.Text = "Username :";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("Arial", 10F);
            this.Passwordlbl.Location = new System.Drawing.Point(12, 42);
            this.Passwordlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(77, 16);
            this.Passwordlbl.TabIndex = 1;
            this.Passwordlbl.Text = "Password :";
            // 
            // UsernameTB
            // 
            this.UsernameTB.Font = new System.Drawing.Font("Arial", 10F);
            this.UsernameTB.Location = new System.Drawing.Point(88, 11);
            this.UsernameTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(186, 23);
            this.UsernameTB.TabIndex = 0;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Arial", 10F);
            this.PasswordTB.Location = new System.Drawing.Point(88, 40);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(186, 23);
            this.PasswordTB.TabIndex = 1;
            // 
            // LoginBTN
            // 
            this.LoginBTN.Font = new System.Drawing.Font("Arial", 10F);
            this.LoginBTN.Location = new System.Drawing.Point(15, 65);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(127, 24);
            this.LoginBTN.TabIndex = 2;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBTN.Font = new System.Drawing.Font("Arial", 10F);
            this.ExitBTN.Location = new System.Drawing.Point(147, 65);
            this.ExitBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(127, 24);
            this.ExitBTN.TabIndex = 3;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // TechPerms
            // 
            this.TechPerms.AllowUserToAddRows = false;
            this.TechPerms.AllowUserToDeleteRows = false;
            this.TechPerms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TechPerms.Location = new System.Drawing.Point(322, 32);
            this.TechPerms.Margin = new System.Windows.Forms.Padding(2);
            this.TechPerms.Name = "TechPerms";
            this.TechPerms.ReadOnly = true;
            this.TechPerms.RowTemplate.Height = 28;
            this.TechPerms.Size = new System.Drawing.Size(447, 84);
            this.TechPerms.TabIndex = 5;
            this.TechPerms.Visible = false;
            // 
            // GetPermsBTN
            // 
            this.GetPermsBTN.Font = new System.Drawing.Font("Arial", 14F);
            this.GetPermsBTN.Location = new System.Drawing.Point(434, 132);
            this.GetPermsBTN.Margin = new System.Windows.Forms.Padding(2);
            this.GetPermsBTN.Name = "GetPermsBTN";
            this.GetPermsBTN.Size = new System.Drawing.Size(211, 87);
            this.GetPermsBTN.TabIndex = 6;
            this.GetPermsBTN.Text = "Get Perms";
            this.GetPermsBTN.UseVisualStyleBackColor = true;
            this.GetPermsBTN.Visible = false;
            this.GetPermsBTN.Click += new System.EventHandler(this.GetPermsBTN_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBTN;
            this.ClientSize = new System.Drawing.Size(285, 99);
            this.ControlBox = false;
            this.Controls.Add(this.GetPermsBTN);
            this.Controls.Add(this.TechPerms);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Usernamelbl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(301, 138);
            this.MinimumSize = new System.Drawing.Size(301, 138);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TechPerms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.DataGridView TechPerms;
        private System.Windows.Forms.Button GetPermsBTN;
    }
}