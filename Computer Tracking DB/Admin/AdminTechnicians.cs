using System;
using System.Data;
using System.Windows.Forms;
using ComputerTrackingDB.Properties;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Outlook;

namespace ComputerTrackingDB
{
    public partial class AdminTechnicians : UserControl
    {
        #region AdminTechnicians
        public AdminTechnicians()
        {
            InitializeComponent();
        }

        CTDBFunctions myFunc = new CTDBFunctions();
        System.Media.SoundPlayer ErrorSound = new System.Media.SoundPlayer(Properties.Resources.error);
        private void AdminTechnicians_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            GetTechnicians();
            GetEmailCC();
            UserTB.Enabled = false;
            TechIDTB.Enabled = false;
            RoleTB.Enabled = false;
            //ActiveCheck.Enabled = false;
            SavedLBL.Visible = false;
        }

        #endregion

        #region Get Functions
        private void GetTechnicians()
        {
            string conn_string = Settings.Default.DBConnection;
            string q = "";
            q = "USE ComputerTrackingDB ";
            q += "SELECT TechName ";
            q += "FROM Tech_Accounts ";
            q += "WHERE Role != 'Station' ";

            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            SqlDataReader dbReader = cmd.ExecuteReader();
            string itemToAdd;

            while (dbReader.Read())
            {
                itemToAdd = dbReader.GetString(0);
                TechniciansCB.Items.Add(itemToAdd);
            }
            myConn.Close();

            int ItemsNumber = TechniciansCB.Items.Count;
            TechniciansCB.Items.Insert(ItemsNumber, "New...");
        }

        private void GetEmailCC()
        {
            string conn_string = Settings.Default.DBConnection;
            string q = "";
            q = "USE ComputerTrackingDB ";
            q += "SELECT Detail ";
            q += "FROM App_Settings ";
            q += "WHERE Setting = 'AdminTechEmailCC' ";

            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            SqlDataReader dbReader = cmd.ExecuteReader();
            string GetEmail;

            while (dbReader.Read())
            {
                GetEmail = dbReader.GetString(0);
                Settings.Default.AdminTechEmailCC = GetEmail;
            }
            myConn.Close();
        }

        public void fillDataGrid(string TechWWID)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q;

                string stringB = this.Text;

                SqlConnection myConn = new SqlConnection(conn_string);

                q = "USE ComputerTrackingDB ";
                q += "SELECT * ";
                q += "FROM Tech_Accounts ";
                q += "WHERE UserName = @TechWWID";


                myConn.Open();

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@TechWWID", TechWWID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.SelectCommand = cmd;

                da.Fill(dt);
                TechPerms.DataSource = dt;
                TechPerms.AutoResizeColumns();
                myConn.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Cursor.Current = Cursors.Arrow;
        }
        
        #endregion

        #region ComboBox
        private void TechniciansCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TechniciansCB.Text == "New...")
            {
                UserTB.Clear();
                TechIDTB.Clear();
                PasswordTB.Clear();
                RoleTB.Clear();
                TechNameTB.Clear();
                ActiveCheck.Checked = false;
                ScanInOutCB.Checked = false;
                InventoryAuditCB.Checked = false;
                InventoryMoveCB.Checked = false;
                InventoryNewCB.Checked = false;
                AdminCB.Checked = false;
                string newTechID = myFunc.generateTechID();
                TechIDTB.Text = newTechID;
                return;
            }
            if (TechniciansCB.Text == "Station")
            {
                MessageBox.Show("Stations can only be modified by Code / Database.");
                return;
            }
            else
            {
                SavedLBL.Visible = false;
                UserTB.Enabled = true;
                TechIDTB.Enabled = false;
                RoleTB.Enabled = true;
                ActiveCheck.Enabled = true;
                UserTB.Text = myFunc.getWWIDbyTechName(TechniciansCB.Text);
                fillDataGrid(UserTB.Text);
                PasswordTB.Text = TechPerms[2, 0].Value.ToString();
                TechNameTB.Text = TechPerms[4, 0].Value.ToString();
                TechIDTB.Text = TechPerms[3, 0].Value.ToString();
                RoleTB.Text = TechPerms[5, 0].Value.ToString();

                #region Get Permissions
                if (TechPerms[6, 0].Value.ToString() == "True")
                {
                    ActiveCheck.Checked = true;
                }
                else
                {
                    ActiveCheck.Checked = false;
                }
                if (TechPerms[7, 0].Value.ToString() == "True")
                {
                    ScanInOutCB.Checked = true;
                }
                else
                {
                    ScanInOutCB.Checked = false;
                }
                if (TechPerms[8, 0].Value.ToString() == "True")
                {
                    AdminCB.Checked = true;
                }
                else
                {
                    AdminCB.Checked = false;
                }
                if (TechPerms[9, 0].Value.ToString() == "True")
                {
                    InventoryAuditCB.Checked = true;
                }
                else
                {
                    InventoryAuditCB.Checked = false;
                }
                if (TechPerms[10, 0].Value.ToString() == "True")
                {
                    InventoryMoveCB.Checked = true;
                }
                else
                {
                    InventoryMoveCB.Checked = false;
                }
                if (TechPerms[11, 0].Value.ToString() == "True")
                {
                    InventoryNewCB.Checked = true;
                }
                else
                {
                    InventoryNewCB.Checked = false;
                }
                #endregion

                #region Testing
                /*
                while (myFunc.checkUserAccess(UserTB.Text))
                {

                }
                */
                #endregion
            }
        }

        #endregion

        #region Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            if(TechniciansCB.Text == "New...")
            {
                Newtech();
                return;
            }
            #region SQL Add Admin Transaction

            try
            {
                string conn_string = Settings.Default.DBConnection;
                string ModifierName = Settings.Default.TechName;
                string Date = DateTime.Now.ToShortDateString();
                string Tech = TechniciansCB.Text;
                string Type = "Modify Tech";

                SqlConnection myConn = new SqlConnection(conn_string);

                string q = "USE ComputerTrackingDB ";
                q += "INSERT INTO Admin_Transaction ";
                q += "(TechName, Transaction_Date, Modified, Type) ";
                q += "Values (@ModifierName, @Date, @Tech, @Type) ";

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@ModifierName", ModifierName);
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@Tech", Tech);
                cmd.Parameters.AddWithValue("@Type", Type);
                myConn.Open();
                cmd.CommandText = q;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                myConn.Close();
            }
            catch
            {
                MessageBox.Show("Failed to Add Admin Transaction.");
                return;
            }

            #endregion

            #region SQL Update Technician
            try
            {
                SavedLBL.Visible = false;
                string TechName = TechniciansCB.Text;
                string UserName = UserTB.Text;
                string TechID = TechIDTB.Text;
                string Role = RoleTB.Text;
                string Active = ActiveCheck.Checked.ToString();
                string Station = ScanInOutCB.Checked.ToString();
                string Admin = AdminCB.Checked.ToString();
                string InventoryAudit = InventoryAuditCB.Checked.ToString();
                string InventoryMove = InventoryMoveCB.Checked.ToString();
                string InventoryNew = InventoryNewCB.Checked.ToString();
                string Password = PasswordTB.Text;
                string TechNameEdit = TechNameTB.Text;

                string q = "USE ComputerTrackingDB ";
                q += "UPDATE Tech_Accounts ";
                q += "SET UserName = @UserName, Password = @Password, TechID = @TechID, TechName = @TechNameEdit, Role = @Role, Active = @Active, Station = @Station, Admin = @Admin, Inventory_Control = @InventoryAudit, Inventory_Move = @InventoryMove, Inventory_New = @InventoryNew ";
                q += "WHERE TechName = @TechName";

                string conn_string = Settings.Default.DBConnection;
                SqlConnection myConn = new SqlConnection(conn_string);
                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@TechName", TechName);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@TechID", TechID);
                cmd.Parameters.AddWithValue("@TechNameEdit", TechNameEdit);
                cmd.Parameters.AddWithValue("@Role", Role);
                cmd.Parameters.AddWithValue("@Active", Active);
                cmd.Parameters.AddWithValue("@Station", Station);
                cmd.Parameters.AddWithValue("@Admin", Admin);
                cmd.Parameters.AddWithValue("@InventoryAudit", InventoryAudit);
                cmd.Parameters.AddWithValue("@InventoryMove", InventoryMove);
                cmd.Parameters.AddWithValue("@InventoryNew", InventoryNew);
                myConn.Open();
                cmd.CommandText = q;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                myConn.Close();
                //SendEmail();
                SavedLBL.Visible = true;
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Failed to update Tech.");
                return;
            }

            #endregion
        }
        private void EmailTestBTN_Click(object sender, EventArgs e)
        {
            SendEmail();
        }

        #endregion

        #region Email

        private void SendEmail()
        {
            string Name = TechniciansCB.Text;
            string WWID = UserTB.Text;
            string Email = WWID + "@domain.com";
            string TechID = TechIDTB.Text;
            string Role = RoleTB.Text;
            string modTech = myFunc.getWWIDbyTechName(Settings.Default.TechName);
            string modTechEmail = modTech + "@domain.com";
            string AdminTechEmailCC = Settings.Default.AdminTechEmailCC;
            bool Active = ActiveCheck.Checked;
            bool ScanInOut = ScanInOutCB.Checked;
            bool Audit = InventoryAuditCB.Checked;
            bool Move = InventoryMoveCB.Checked;
            bool New = InventoryNewCB.Checked;
            bool Admin = AdminCB.Checked;

            Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();

            Microsoft.Office.Interop.Outlook.MailItem eMail = app.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
            eMail.Subject = "Computer Tracking DB - Permissions Update";
            eMail.To = Email;
            eMail.CC = AdminTechEmailCC + modTechEmail;
            eMail.Body = "Hello," + Environment.NewLine + Environment.NewLine +
            "Your permissions for Computer Tracking DB have been modified by " + Settings.Default.TechName + ". Please see information below." + Environment.NewLine + Environment.NewLine +
            "Name : " + Name + Environment.NewLine +
            "WWID : " + WWID + Environment.NewLine +
            "TechID : " + TechID + Environment.NewLine +
            "Role : " + Role + Environment.NewLine + Environment.NewLine +
            "Permissions –" + Environment.NewLine +
            "• Active (Scan in/out) - " + Active + Environment.NewLine +
            "• Scan In / Out at own machine - " + ScanInOut + Environment.NewLine +
            "• Inventory Control - " + Audit + Environment.NewLine +
            "• Inventory Move - " + Move + Environment.NewLine +
            "• Inventory New - " + New + Environment.NewLine +
            "• Admin - " + Admin + Environment.NewLine + Environment.NewLine +
            "If you require any additional permissions or have any questions please reply all." + Environment.NewLine + Environment.NewLine +
            "Thank you," + Environment.NewLine +
            Settings.Default.TechName;
            eMail.Display(false);
            eMail.Send();

        }

        #endregion

        private void Newtech()
        {
            #region SQL Add Admin Transaction

            try
            {
                string conn_string = Settings.Default.DBConnection;
                string ModifierName = Settings.Default.TechName;
                string Date = DateTime.Now.ToShortDateString();
                string NewTech = TechNameTB.Text;
                string Type = "New Tech";

                SqlConnection myConn = new SqlConnection(conn_string);

                string q = "USE ComputerTrackingDB ";
                q += "INSERT INTO Admin_Transaction ";
                q += "(TechName, Transaction_Date, Modified, Type) ";
                q += "Values (@ModifierName, @Date, @NewTech, @Type) ";

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@ModifierName", ModifierName);
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@NewTech", NewTech);
                cmd.Parameters.AddWithValue("@Type", Type);
                myConn.Open();
                cmd.CommandText = q;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                myConn.Close();
            }
            catch
            {
                MessageBox.Show("Failed to Add Admin Transaction.");
                return;
            }

            #endregion

            #region SQL Add New Tech
            try
            {
                string Username = UserTB.Text;
                string TechID = TechIDTB.Text;
                string Password = PasswordTB.Text;
                string Role = RoleTB.Text;
                string Name = TechNameTB.Text;
                bool Active = ActiveCheck.Checked;
                bool Station = ScanInOutCB.Checked;
                bool Audit = InventoryAuditCB.Checked;
                bool Move = InventoryMoveCB.Checked;
                bool New = InventoryNewCB.Checked;
                bool Admin = AdminCB.Checked;

                string q = "USE ComputerTrackingDB ";
                q += "INSERT INTO Tech_Accounts (Username, Password, TechID, TechName, Role, Active, Station, Admin, Inventory_Control, Inventory_Move, Inventory_New ) ";
                q += "VALUES (@Username, @Password, @TechID, @Name, @Role, @Active, @Station, @Admin, @Audit, @Move, @New ) ";

                string conn_string = Settings.Default.DBConnection;
                SqlConnection myConn = new SqlConnection(conn_string);
                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@TechID", TechID);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Role", Role);
                cmd.Parameters.AddWithValue("@Active", Active);
                cmd.Parameters.AddWithValue("@Station", Station);
                cmd.Parameters.AddWithValue("@Admin", Admin);
                cmd.Parameters.AddWithValue("@Audit", Audit);
                cmd.Parameters.AddWithValue("@Move", Move);
                cmd.Parameters.AddWithValue("@New", New);
                myConn.Open();
                cmd.CommandText = q;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                myConn.Close();
                SavedLBL.Visible = true;
            }
            catch
            {
                MessageBox.Show("Failed to add new tech.");
                return;
            }
            #endregion
        }

        #region Why did I do this?

        #region Check Boxes
        private void ActiveCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdminCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CompuComCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ValidatorCB_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void InventoryAuditCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InventoryMoveCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InventoryNewCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Label Click
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Inventorylbl_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Textboxes
        private void RoleTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void TechIDTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void UserTB_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion
    }
}
