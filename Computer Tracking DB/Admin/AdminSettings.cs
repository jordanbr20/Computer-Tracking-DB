using ComputerTrackingDB.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComputerTrackingDB
{
    public partial class AdminSettings : UserControl
    {
        #region AdminSettings
        public AdminSettings()
        {
            InitializeComponent();
        }

        CTDBFunctions myFunc = new CTDBFunctions();
        Main main = new Main();

        private void AdminSettings_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            GetCurrent();
        }
        #endregion

        #region Tab Controller

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Email System")
            {
                GetModifyTechEmailCC();
                ModifyTechCCListTB.Text = Settings.Default.AdminTechEmailCC;
                GetNewTechEmailCC();
                NewTechCCListTB.Text = Settings.Default.AdminAddTechEmailCC;
                GetNewInvEmailTO();
                NewInventoryToTB.Text = Settings.Default.NewInventoryEmailTo;
                GetNewInvEmailCC();
                NewInventoryCCListTB.Text = Settings.Default.NewInventoryEmailCC;
            }

            if (tabControl1.SelectedTab.Text == "Dev")
            {
                GetTechnicians();
            }
        }

        #endregion

        #region Get All Current
        private void GetCurrent()
        {
            if (Settings.Default.AuditMode == true)
            {
                AuditStatuslbl.Text = "Active";
            }
            else
            {
                AuditStatuslbl.Text = "Inactive";
            }
        }
        #endregion

        #region General Tab

        #endregion

        #region Audit Tab
        private void ToggleAuditMode()
        {
            try
            {
                #region SQL Info
                string conn_string = Settings.Default.DBConnection;
                string TechName = Settings.Default.TechName;
                bool CurrentStatus = Settings.Default.AuditMode;
                SqlConnection myConn = new SqlConnection(conn_string);
                #endregion

                #region SQL Toggle Audit

                if (CurrentStatus == true)
                {
                    string q = "USE ComputerTrackingDB ";
                    q += "UPDATE App_Settings ";
                    q += "Set Active = @Active, Detail = @TechName ";
                    q += "WHERE Setting = 'AuditMode'";

                    SqlCommand cmd = new SqlCommand(q, myConn);
                    cmd.Parameters.AddWithValue("@Active", "False");
                    cmd.Parameters.AddWithValue("@TechName", TechName);
                    myConn.Open();
                    cmd.CommandText = q;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                    Settings.Default.AuditMode = false;
                    AuditStatuslbl.Text = "Inactive";
                }
                else
                {
                    string q = "USE ComputerTrackingDB ";
                    q += "UPDATE App_Settings ";
                    q += "Set Active = @Active, Detail = @TechName ";
                    q += "WHERE Setting = 'AuditMode'";

                    SqlCommand cmd = new SqlCommand(q, myConn);
                    cmd.Parameters.AddWithValue("@Active", "True");
                    cmd.Parameters.AddWithValue("@TechName", TechName);
                    myConn.Open();
                    cmd.CommandText = q;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                    Settings.Default.AuditMode = true;
                    Settings.Default.AuditModeActivatedBy = TechName;
                    AuditStatuslbl.Text = "Active";
                }
                #endregion

                #region SQL Add Admin Transaction

                try
                {
                    string ModifierName = Settings.Default.TechName;
                    string Date = DateTime.Now.ToShortDateString();
                    string Modified = "Toggle";
                    string Type = "Audit";

                    string q = "USE ComputerTrackingDB ";
                    q += "INSERT INTO Admin_Transaction ";
                    q += "(TechName, Transaction_Date, Modified, Type) ";
                    q += "Values (@ModifierName, @Date, @Modified, @Type) ";

                    SqlCommand cmd = new SqlCommand(q, myConn);
                    cmd.Parameters.AddWithValue("@ModifierName", ModifierName);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@Modified", Modified);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void ToggleAuditBtn_Click(object sender, EventArgs e)
        {
            ToggleAuditMode();
        }

        #endregion

        #region Station Tab
        private void SetStationpwBTN_Click(object sender, EventArgs e)
        {
            #region SQL Add Admin Transaction

            try
            {
                string conn_string = Settings.Default.DBConnection;
                string ModifierName = Settings.Default.TechName;
                string Date = DateTime.Now.ToShortDateString();
                string Modified = "Station";
                string Type = "Password";

                SqlConnection myConn = new SqlConnection(conn_string);

                string q = "USE ComputerTrackingDB ";
                q += "INSERT INTO Admin_Transaction ";
                q += "(TechName, Transaction_Date, Modified, Type) ";
                q += "Values (@ModifierName, @Date, @Modified, @Type) ";

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@ModifierName", ModifierName);
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@Modified", Modified);
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

            #region SQL Set Station Password
            try
            {
                string conn_string = Settings.Default.DBConnection;
                SqlConnection myConn = new SqlConnection(conn_string);
                string NewStationPassword = NewStationpwTB.Text;

                string q = "USE ComputerTrackingDB ";
                q += "UPDATE App_Settings ";
                q += "Set Detail = @NewPW ";
                q += "WHERE Setting = 'Station'";

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@NewPW", NewStationPassword);
                myConn.Open();
                cmd.CommandText = q;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                myConn.Close();
                StationUpdatedlbl.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            #endregion

        }
        #endregion

        #region Dev Tab

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
                impersonateTechCB.Items.Add(itemToAdd);
            }
            myConn.Close();
        }

        public void fillDevTechDataGrid(string TechWWID)
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
                DevTechGrid.DataSource = dt;
                DevTechGrid.AutoResizeColumns();
                myConn.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void impersonateBTN_Click(object sender, EventArgs e)
        {
            if (Settings.Default.TechName == "Jordan Riley")
            {
                string ImpersonatingTechWWID = myFunc.getWWIDbyTechName(impersonateTechCB.Text);
                fillDevTechDataGrid(ImpersonatingTechWWID);
                Settings.Default.CurrentUser = DevTechGrid[1, 0].Value.ToString();
                Settings.Default.TechName = DevTechGrid[4, 0].Value.ToString();
                Settings.Default.TechRole = "Impersonating";
                Settings.Default.Station = DevTechGrid[7, 0].Value.ToString();
                Settings.Default.Admin = DevTechGrid[8, 0].Value.ToString();
                Settings.Default.InventoryControl = DevTechGrid[9, 0].Value.ToString();
                Settings.Default.InventoryMove = DevTechGrid[10, 0].Value.ToString();
                Settings.Default.InventoryNew = DevTechGrid[11, 0].Value.ToString();
                Settings.Default.TechID = DevTechGrid[3, 0].Value.ToString();

                main.TechInfoUpdater.Start();
            }
            else
            {
                MessageBox.Show("You are not allowed to do this!!!");
                return;
            }
        }

        #endregion

        #region Email System Tab

        #region Buttons

        private void NewTechCCbtn_Click(object sender, EventArgs e)
        {
            UpdateNewTechEmailCC();
            NewTechSavedlbl.Visible = true;
        }
        private void ModifyTechCCbtn_Click(object sender, EventArgs e)
        {
            UpdateModifyTechEmailCC();
            ModifyTechSavedlbl.Visible = true;
        }
        private void NewInventoryTOCCbtn_Click(object sender, EventArgs e)
        {
            UpdateNewInvEmailTO();
            UpdateNewInvEmailCC();
            NewInventoryTOCCSavedlbl.Visible = true;
        }

        #endregion

        #region TextBoxes

        private void ModifyTechCCListTB_TextChanged(object sender, EventArgs e)
        {
            ModifyTechSavedlbl.Visible = false;
        }

        private void NewTechCCListTB_TextChanged(object sender, EventArgs e)
        {
            NewTechSavedlbl.Visible = false;
        }

        private void NewInventoryToTB_TextChanged(object sender, EventArgs e)
        {
            NewInventoryTOCCSavedlbl.Visible = false;
        }

        private void NewInventoryCCListTB_TextChanged(object sender, EventArgs e)
        {
            NewInventoryTOCCSavedlbl.Visible = false;
        }

        #endregion

        #region SQL
        private void GetModifyTechEmailCC()
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

        private void UpdateModifyTechEmailCC()
        {
            string ModifyCCList = ModifyTechCCListTB.Text;
            Settings.Default.AdminTechEmailCC = ModifyCCList;
            string conn_string = Settings.Default.DBConnection;
            string q = "";

            q = "USE ComputerTrackingDB ";
            q += "UPDATE App_Settings ";
            q += "SET Detail = @CCList ";
            q += "WHERE Setting = 'AdminTechEmailCC' ";

            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            cmd.Parameters.AddWithValue("@CCList", ModifyCCList);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        private void GetNewTechEmailCC()
        {
            string conn_string = Settings.Default.DBConnection;
            string q = "";
            q = "USE ComputerTrackingDB ";
            q += "SELECT Detail ";
            q += "FROM App_Settings ";
            q += "WHERE Setting = 'AdminAddTechEmailCC' ";

            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            SqlDataReader dbReader = cmd.ExecuteReader();
            string GetNewEmail;

            while (dbReader.Read())
            {
                GetNewEmail = dbReader.GetString(0);
                Settings.Default.AdminAddTechEmailCC = GetNewEmail;
            }
            myConn.Close();
        }

        private void UpdateNewTechEmailCC()
        {
            string NewCCList = NewTechCCListTB.Text;
            Settings.Default.AdminTechEmailCC = NewCCList;
            string conn_string = Settings.Default.DBConnection;
            string q = "";

            q = "USE ComputerTrackingDB ";
            q += "UPDATE App_Settings ";
            q += "SET Detail = @CCList ";
            q += "WHERE Setting = 'AdminAddTechEmailCC' ";

            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            cmd.Parameters.AddWithValue("@CCList", NewCCList);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        private void GetNewInvEmailTO()
        {
            string conn_string = Settings.Default.DBConnection;
            string q = "";
            q = "USE ComputerTrackingDB ";
            q += "SELECT Detail ";
            q += "FROM App_Settings ";
            q += "WHERE Setting = 'NewInventoryEmailTo' ";

            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            SqlDataReader dbReader = cmd.ExecuteReader();
            string GetNewInvEmailTo;

            while (dbReader.Read())
            {
                GetNewInvEmailTo = dbReader.GetString(0);
                Settings.Default.NewInventoryEmailTo = GetNewInvEmailTo;
            }
            myConn.Close();
        }

        private void UpdateNewInvEmailTO()
        {
            string NewInvTo = NewInventoryToTB.Text;
            Settings.Default.NewInventoryEmailTo = NewInvTo;
            string conn_string = Settings.Default.DBConnection;
            string q = "";

            q = "USE ComputerTrackingDB ";
            q += "UPDATE App_Settings ";
            q += "SET Detail = @CCList ";
            q += "WHERE Setting = 'NewInventoryEmailTo' ";

            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            cmd.Parameters.AddWithValue("@CCList", NewInvTo);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }

        private void GetNewInvEmailCC()
        {
            string conn_string = Settings.Default.DBConnection;
            string q = "";
            q = "USE ComputerTrackingDB ";
            q += "SELECT Detail ";
            q += "FROM App_Settings ";
            q += "WHERE Setting = 'NewInventoryEmailCC' ";

            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            SqlDataReader dbReader = cmd.ExecuteReader();
            string GetNewInvEmailCC;

            while (dbReader.Read())
            {
                GetNewInvEmailCC = dbReader.GetString(0);
                Settings.Default.NewInventoryEmailCC = GetNewInvEmailCC;
            }
            myConn.Close();
        }

        private void UpdateNewInvEmailCC()
        {
            string NewInvCC = NewInventoryCCListTB.Text;
            Settings.Default.NewInventoryEmailCC = NewInvCC;
            string conn_string = Settings.Default.DBConnection;
            string q = "";

            q = "USE ComputerTrackingDB ";
            q += "UPDATE App_Settings ";
            q += "SET Detail = @CCList ";
            q += "WHERE Setting = 'NewInventoryEmailCC' ";

            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            cmd.Parameters.AddWithValue("@CCList", NewInvCC);
            cmd.ExecuteNonQuery();
            myConn.Close();
        }
        #endregion

        #endregion

        #region Database Tab

        private void BackupEDB_Click(object sender, EventArgs e)
        {
            //BACKUP DATABASE [ComputerTrackingDB] TO  DISK = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQL\MSSQL\Backup\ComputerTrackingDB.bak' WITH NOFORMAT, NOINIT,  NAME = N'ComputerTrackingDB-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
            //GO
        }



        #endregion
    }
}
