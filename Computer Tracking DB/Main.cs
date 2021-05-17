using ComputerTrackingDB.Properties;
using ComputerTrackingDB.SearchForIt;
using Dymo;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace ComputerTrackingDB
{
    public partial class Main : Form
    {
        #region MainForm
        CTDBFunctions myFunc = new CTDBFunctions();
        System.Media.SoundPlayer ErrorSound = new System.Media.SoundPlayer(Properties.Resources.error);
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            //this.Size = Settings.Default.MainSize;

            #region DB Connection
            if (Settings.Default.ConnectionType == "Live") { Settings.Default.DBConnection = Settings.Default.LiveDBConnection; };
            if (Settings.Default.ConnectionType == "Test") { Settings.Default.DBConnection = Settings.Default.TestDBConnection; };
            CTDBFunctions DBFunc = new CTDBFunctions();
            if (DBFunc.checkDBConnection() == true)
            {
                //MessageBox.Show("Connection successful.");
            }
            else
            {
                MessageBox.Show("Not able to connect to DB.");
                this.Close();
                return;
            }

            if (Settings.Default.DBConnection == Settings.Default.LiveDBConnection)
            {
                ConStatusLBL.Text = "Connected to -";
                ConNameLBL.Text = "Live Database";
            }
            else
            {
                ConStatusLBL.Text = "Connected to -";
                ConNameLBL.Text = "Test Database";
            }

            #endregion

            #region Check Audit Status
            if (myFunc.checkAudit() == true)
            {
                Settings.Default.AuditMode = true;
                if (Settings.Default.AuditModeActivatedBy == "TechName")
                {
                    Settings.Default.AuditModeActivatedBy = myFunc.checkWhoStartedAudit();
                }
            }
            else
            {
                Settings.Default.AuditMode = false;
            }
            #endregion

            #region Show Login Form
            if (TechNamelbl.Text == "Tech Name")
            {
                LoginForm login = new LoginForm();
                login.Show();
            }
            else
            {
                return;
            }

            #endregion

            #region UpdateLBLs

            GetVersion();
            checkversion();

            #endregion

            #region Load new menu

            HideButtons();

            #endregion

            ButtonPanel.VerticalScroll.Visible = false;

        }

        #endregion

        private void HideButtons()
        {
            #region Scan-In

            ScanMachineBTN.Hide();

            #endregion

            #region Inventory

            InventoryBTN.Hide();
            INVNewBTN.Hide();
            INVAuditBTN.Hide();
            INVMoveBTN.Hide();

            #endregion

            #region Admin

            AdminBTN.Hide();
            TechniciansBTN.Hide();
            ModelsBTN.Hide();
            LocationsBTN.Hide();
            ExportsBTN.Hide();
            SettingsBTN.Hide();

            #endregion
        }
        #region Left Side Menu

        private void UpdateButtons()
        {
            if(TechNamelbl.Text != "Tech Name")
            {
                HomeBTN.Show();
            }
            if(Settings.Default.Station == "True")
            {
                ScanMachineBTN.Show();
            }
            if(Settings.Default.InventoryNew == "True" || Settings.Default.InventoryControl == "True" || Settings.Default.InventoryMove == "True")
            {
                InventoryBTN.Show();
                if(Settings.Default.InventoryNew == "True")
                {
                    INVNewBTN.Show();
                }
                if(Settings.Default.InventoryControl == "True")
                {
                    INVAuditBTN.Show();
                }
                if(Settings.Default.InventoryMove == "True")
                {
                    INVMoveBTN.Show();
                }
            }
            if(Settings.Default.Admin == "True")
            {
                AdminBTN.Show();
                TechniciansBTN.Show();
                ModelsBTN.Show();
                LocationsBTN.Show();
                ExportsBTN.Show();
                SettingsBTN.Show();
            }

        }

        #endregion

        #region Update Information
        private void Versionlbl_Click(object sender, EventArgs e)
        {
            var AboutBox = new About();
            AboutBox.Show();

        }
        public void GetVersion()
        {
            ComputerTrackingDBLabel.Text = " Computer Tracking DB " + "(Version " + Settings.Default.Version + ")";
        }
        public void GetDate()
        {
            string Date = DateTime.Now.ToShortDateString();
            //Datelbl.Text = Date;
        }
        private void TechInfoUpdater_Tick(object sender, EventArgs e)
        {
            if (Settings.Default.DevPerms == true)
            {
                Settings.Default.DevPerms = false;
            }
            if(Settings.Default.Impersonating == true)
            {
                Settings.Default.Impersonating = false;
                TechNamelbl.Text = Settings.Default.TechName;
                ComputerTrackingDBTitlelbl.Text = Settings.Default.TechRole;
                HideButtons();
                UpdateButtons();
                //Loadhomepage();


            }
            if (TechNamelbl.Text == "Tech Name")
            {
                TechNamelbl.Text = Settings.Default.TechName;
                ComputerTrackingDBTitlelbl.Text = Settings.Default.TechRole;
                UpdateButtons();
            }
            else
            {
                return;
            }
        }
        #endregion

        #region TechPanel

        private void TechNamelbl_Click(object sender, EventArgs e)
        {
            TechSelected();
        }
        private void ComputerTrackingDBTitlelbl_Click(object sender, EventArgs e)
        {
            TechSelected();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TechSelected();
        }
        private void UserPanel_Click(object sender, EventArgs e)
        {
            TechSelected();
        }
        private void TechSelected()
        {
            if (Settings.Default.CurrentUser == "Station" || Settings.Default.CurrentUser == "station")
            {
                return;
            }
            else
            {
                MainPanel.Controls.Clear();
                var TechPageControl = new TechPage();
                MainPanel.Controls.Add(TechPageControl);
                TechPanel.BackColor = Color.RoyalBlue;
            }
        }

        #endregion

        #region Check DB
        private void CheckDB_Tick(object sender, EventArgs e)
        {
            /*
            if (Settings.Default.FailedDBNoticeSent == false)
            {
                if (myFunc.checkDBConnection() == false)
                {
                    ErrorSound.Play();
                    MessageBox.Show("You are no longer Connected to the Database!!");
                    ConnectionStatuslbl.Text = "Connection Failed!";
                    ConnectionNamelbl.Text = "";
                    Settings.Default.FailedDBNoticeSent = true;
                }
            }
            if (Settings.Default.FailedDBNoticeSent == true)
            {
                if(myFunc.checkDBConnection() == false)
                {
                    return;
                }
                else
                {
                    Settings.Default.FailedDBNoticeSent = false;
                }
            }
            */
        }

        #endregion

        #region Textboxs
        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            //this.AcceptButton = Searchbtn;
        }
        private void SearchTB_KeyDown(object sender, KeyEventArgs e)
        {
            SerialSearch SerialSearchForm = new SerialSearch();
            UserSearch UserSearchForm = new UserSearch();
            LocationSearch LocationSearchForm = new LocationSearch();
            if (e.KeyData == Keys.Enter)
            {
                if (Settings.Default.TechName == "Tech Name")
                {
                    //MessageBox.Show("You must be logged in.");
                }
                else
                {
                    if (myFunc.checkSerialExists(SearchTB.Text) == true)
                    {
                        Settings.Default.SearchSerial = SearchTB.Text;
                        MainPanel.Controls.Clear();
                        MainPanel.Controls.Add(SerialSearchForm);
                    }
                    else if (myFunc.checkTechIDExists(SearchTB.Text) == true)
                    {
                        Settings.Default.UserSearch = myFunc.getTechName(SearchTB.Text);
                        MainPanel.Controls.Clear();
                        MainPanel.Controls.Add(UserSearchForm);
                    }
                    else if (myFunc.checkTechNameExists(SearchTB.Text) == true)
                    {
                        Settings.Default.UserSearch = SearchTB.Text;
                        MainPanel.Controls.Clear();
                        MainPanel.Controls.Add(UserSearchForm);
                    }
                    else if (myFunc.checkWWIDExists(SearchTB.Text) == true)
                    {
                        Settings.Default.UserSearch = myFunc.getTechNamebyWWID(SearchTB.Text);
                        MainPanel.Controls.Clear();
                        MainPanel.Controls.Add(UserSearchForm);
                    }
                    else if (myFunc.checkLocationExists(SearchTB.Text) == true)
                    {
                        Settings.Default.LocationSearch = SearchTB.Text;
                        MainPanel.Controls.Clear();
                        MainPanel.Controls.Add(LocationSearchForm);
                    }
                    else
                    {
                        MessageBox.Show("Serial / TechID / TechName / WWID / Location does not exsist.");
                    }
                }

            }
        }
        #endregion

        #region Buttons

        #endregion

        #region Others
        private void CheckAudit_Tick(object sender, EventArgs e)
        {
            if (myFunc.checkAudit() == true)
            {
                var AuditModePage = new AuditMode();
                var InventoryAuditPage = new AuditMode();
                Settings.Default.AuditMode = true;
                if (Settings.Default.AuditModeActivatedBy == "TechName")
                {
                    Settings.Default.AuditModeActivatedBy = myFunc.checkWhoStartedAudit();
                    MainPanel.Controls.Clear();
                    if (Settings.Default.InventoryControl == "True")
                    {
                        MainPanel.Controls.Add(InventoryAuditPage);
                        return;
                    }
                    else
                    {
                        MainPanel.Controls.Add(AuditModePage);
                        return;
                    }
                }
                return;
            }
            else
            {
                Settings.Default.AuditMode = false;
                return;
            }

        }

        private void checkversion()
        {
            string conn_string = Settings.Default.DBConnection;
            string q;
            string VersionNumberSt;

            SqlConnection myConn = new SqlConnection(conn_string);

            q = "USE ComputerTrackingDB ";
            q += "Select Detail FROM App_Settings ";
            q += "WHERE Setting = 'Version'";

            myConn.Open();

            SqlCommand cmd = new SqlCommand(q, myConn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                VersionNumberSt = Convert.ToString(reader["Detail"]) as string;
                Settings.Default.DBVersion = VersionNumberSt;
                break;
            }
            if (Settings.Default.Version == Settings.Default.DBVersion)
            {
                return;
            }
            else
            {
                string CurrentVersion = Settings.Default.Version;
                string DBVersion = Settings.Default.DBVersion;
                MessageBox.Show("Please update Computer Tracking DB." + " \r\nCurrent Version " + DBVersion + " \r\nYour Version " + CurrentVersion);
                this.Close();
            }
            myConn.Close();
        }   
        private void MainPanel_Leave(object sender, EventArgs e)
        {

        }
        #endregion

        #region New Left Menu

        #region Menu Buttons

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            var HomePage = new Home();
            MainPanel.Controls.Add(HomePage);
            UnselectAllButtons();
            HomeBTN.BackColor = Color.Blue;
        }
        private void ScanMachineBTN_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AuditMode == true)
            {
                MainPanel.Controls.Clear();
                var AuditModePage = new AuditMode();
                MainPanel.Controls.Add(AuditModePage);
            }
            else
            {
                MainPanel.Controls.Clear();
                var ScanMachinesPage = new Scaninoutpage();
                MainPanel.Controls.Add(ScanMachinesPage);
                UnselectAllButtons();
                ScanMachineBTN.BackColor = Color.Blue;
            }

        }

        private void InventoryBTN_Click(object sender, EventArgs e)
        {
            if (InventoryPanel.Visible == false)
            {
                InventoryPanel.Visible = true;
            }
            else
            {
                InventoryPanel.Visible = false;
            }
        }

        private void AdminBTN_Click(object sender, EventArgs e)
        {
            if (AdminPanel.Visible == false)
            {
                AdminPanel.Visible = true;
                AdminPanel.Height = 150;
                //MessageBox.Show(AdminPanel.Height.ToString());
            }
            else
            {
                AdminPanel.Visible = false;
            }
        }

        private void TechniciansBTN_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            var AdminTechniciansPage = new AdminTechnicians();
            MainPanel.Controls.Add(AdminTechniciansPage);
            UnselectAllButtons();
            TechniciansBTN.BackColor = Color.Blue;
        }

        private void PrintLabelsBTN_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            var PrintLabelsPage = new PrintLabels();
            MainPanel.Controls.Add(PrintLabelsPage);
            UnselectAllButtons();
            PrintLabelsBTN.BackColor = Color.Blue;
        }
        private void SignOutBTN_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            HideAllPanels();
            UnselectAllButtons();
            //Set all settings to false.
            Settings.Default.CurrentUser = "WWID";
            Settings.Default.TechName = "Tech Name";
            Settings.Default.TechRole = "Tech Role";
            Settings.Default.LoginCompleted = "False";
            Settings.Default.Admin = "False";
            Settings.Default.InventoryControl = "False";
            Settings.Default.InventoryMove = "False";
            Settings.Default.InventoryNew = "False";
            Settings.Default.Station = "False";
            Settings.Default.TechID = "Unknown";

            //Clear tech information.
            TechNamelbl.Text = Settings.Default.TechName;
            ComputerTrackingDBTitlelbl.Text = Settings.Default.TechRole;
            HideButtons();

            //Get loginform.
            LoginForm Login = new LoginForm();
            Login.Show();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            System.Windows.Forms.Application.Exit();
        }

        #endregion

        #region Sub-Menu Buttons

        #region Inventory
        private void INVNewBTN_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            var InventoryNewPage = new InventoryNew();
            MainPanel.Controls.Add(InventoryNewPage);
            UnselectAllButtons();
            INVNewBTN.BackColor = Color.Blue;
        }

        private void INVAuditBTN_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            var InventoryAuditPage = new InventoryAudit();
            MainPanel.Controls.Add(InventoryAuditPage);
            UnselectAllButtons();
            INVAuditBTN.BackColor = Color.Blue;
        }

        private void INVMoveBTN_Click(object sender, EventArgs e)
        {
            if (Settings.Default.AuditMode == true)
            {
                MainPanel.Controls.Clear();
                var AuditModePage = new AuditMode();
                MainPanel.Controls.Add(AuditModePage);
            }
            else
            {
                MainPanel.Controls.Clear();
                var InventoryMovePage = new InventoryMove();
                MainPanel.Controls.Add(InventoryMovePage);
                UnselectAllButtons();
                INVMoveBTN.BackColor = Color.Blue;
            }
        }


        #endregion

        #region Admin
        private void ModelsBTN_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            var AdminModelsPage = new AdminModels();
            MainPanel.Controls.Add(AdminModelsPage);
            UnselectAllButtons();
            ModelsBTN.BackColor = Color.Blue;
        }

        private void LocationsBTN_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            var AdminLocationsPage = new AdminLocations();
            MainPanel.Controls.Add(AdminLocationsPage);
            UnselectAllButtons();
            LocationsBTN.BackColor = Color.Blue;
        }

        private void ExportsBTN_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            var AdminExportsPage = new AdminExports();
            MainPanel.Controls.Add(AdminExportsPage);
            UnselectAllButtons();
            ExportsBTN.BackColor = Color.Blue;
        }

        private void SettingsBTN_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            var AdminSettingsPage = new AdminSettings();
            MainPanel.Controls.Add(AdminSettingsPage);
            UnselectAllButtons();
            SettingsBTN.BackColor = Color.Blue;
        }

        #endregion

        #endregion

        #region Signout

        private void UnselectAllButtons()
        {
            HomeBTN.BackColor = Color.DarkBlue;
            ScanMachineBTN.BackColor = Color.DarkBlue;
            INVNewBTN.BackColor = Color.DarkBlue;
            INVAuditBTN.BackColor = Color.DarkBlue;
            INVMoveBTN.BackColor = Color.DarkBlue;
            TechniciansBTN.BackColor = Color.DarkBlue;
            ModelsBTN.BackColor = Color.DarkBlue;
            LocationsBTN.BackColor = Color.DarkBlue;
            ExportsBTN.BackColor = Color.DarkBlue;
            SettingsBTN.BackColor = Color.DarkBlue;
            PrintLabelsBTN.BackColor = Color.DarkBlue;
            SignOutBTN.BackColor = Color.DarkBlue;
            ExitBTN.BackColor = Color.DarkBlue;

        }

        private void HideAllPanels()
        {
            ScanMachineBTN.Hide();
            InventoryPanel.Hide();
            AdminPanel.Hide();
        }

        #endregion

        #endregion

        private void Loadhomepage()
        {
            MainPanel.Controls.Clear();
            var HomePage = new Home();
            MainPanel.Controls.Add(HomePage);
            UnselectAllButtons();
            HomeBTN.BackColor = Color.Blue;
        }

        private void TechNamelbl_TextChanged(object sender, EventArgs e)
        {
            Loadhomepage();
        }


    }
}