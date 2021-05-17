using System;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using ComputerTrackingDB.Properties;
using System.Data.SqlClient;
using System.Data;

namespace ComputerTrackingDB
{
    public partial class LoginForm : Form
    {
        #region LoginForm

        CTDBFunctions myFunc = new CTDBFunctions();
        Main Main = new Main();

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            UsernameTB.Focus();
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            this.Focus();
        }

        #endregion

        #region Buttons
        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Main MainClose = (Main)System.Windows.Forms.Application.OpenForms["Main"];
            MainClose.Close();
            this.Close();
        }

        public void fillDataGrid(string Username)
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
                q += "WHERE UserName = @Username";


                myConn.Open();

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Username", Username);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.SelectCommand = cmd;

                da.Fill(dt);
                TechPerms.DataSource = dt;
                TechPerms.AutoResizeColumns();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            //string domainname = "123.com";
            string WWID = UsernameTB.Text;
            string Password = PasswordTB.Text;

            if (WWID == "Station")
            {
                if(Environment.MachineName == "GAMING-PC" || Environment.MachineName == "Computer2" )
                {
                    if (myFunc.checkstationpassword() == PasswordTB.Text)
                    {
                        Settings.Default.CurrentUser = WWID;
                        Settings.Default.TechName = myFunc.getTechNamebyWWID(WWID);
                        Settings.Default.TechRole = myFunc.getRolebyWWID(WWID);
                        Settings.Default.TechID = myFunc.getTechID(WWID);
                        Settings.Default.Station = "True";
                        Settings.Default.LoginCompleted = "True";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Station Password");
                    }
                }
                else
                {
                    MessageBox.Show("Stations can only be logged in on certain machines.");
                }
            }
            else
            {
                #region Login using domain.
                /*
                using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domainname))
                {
                    bool isValid = pc.ValidateCredentials(WWID, Password);

                    if (isValid == true)
                    {
                        fillDataGrid(UsernameTB.Text);
                        try
                        {
                            if (TechPerms[5, 0].Value.ToString() == "True")
                            {
                                Settings.Default.CurrentUser = WWID;
                                Settings.Default.TechName = TechPerms[3, 0].Value.ToString();
                                Settings.Default.TechRole = TechPerms[4, 0].Value.ToString();
                                Settings.Default.Station = TechPerms[6, 0].Value.ToString();
                                Settings.Default.Validator = TechPerms[8, 0].Value.ToString();
                                Settings.Default.Admin = TechPerms[9, 0].Value.ToString();
                                Settings.Default.InventoryControl = TechPerms[10, 0].Value.ToString();
                                Settings.Default.InventoryMove = TechPerms[11, 0].Value.ToString();
                                Settings.Default.InventoryNew = TechPerms[12, 0].Value.ToString();
                                Settings.Default.CompuCOM = TechPerms[7, 0].Value.ToString();
                                Settings.Default.TechID = TechPerms[2, 0].Value.ToString();
                                Settings.Default.DepotTech = Convert.ToBoolean(TechPerms[13, 0].Value.ToString());
                                Settings.Default.LoginCompleted = "True";
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Sorry, The following WWID " + UsernameTB.Text + " does not have access.");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Sorry, The following WWID " + UsernameTB.Text + " does not have access.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Inncorrect LDAP Password.");
                    }
                }
                */
                #endregion

                #region Login using username and password
                if (UsernameTB.Text != myFunc.checkloginusername(UsernameTB.Text))
                {
                    MessageBox.Show("Username does not exsist.");
                    UsernameTB.Clear();
                }
                else
                {
                    if (PasswordTB.Text != myFunc.checkloginpassword(UsernameTB.Text))
                    {
                        MessageBox.Show("Password is incorrect");
                        PasswordTB.Clear();
                    }
                    else
                    {
                        fillDataGrid(UsernameTB.Text);
                        try
                        {
                            if (TechPerms[6, 0].Value.ToString() == "True")
                            {
                                Settings.Default.CurrentUser = WWID;
                                Settings.Default.TechName = TechPerms[4, 0].Value.ToString();
                                Settings.Default.TechRole = TechPerms[5, 0].Value.ToString();
                                Settings.Default.Station = TechPerms[6, 0].Value.ToString();
                                Settings.Default.Admin = TechPerms[8, 0].Value.ToString();
                                Settings.Default.InventoryControl = TechPerms[9, 0].Value.ToString();
                                Settings.Default.InventoryMove = TechPerms[10, 0].Value.ToString();
                                Settings.Default.InventoryNew = TechPerms[11, 0].Value.ToString();
                                Settings.Default.TechID = TechPerms[3, 0].Value.ToString();
                                Settings.Default.LoginCompleted = "True";
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Sorry, The following User " + UsernameTB.Text + " does not have access.");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Sorry, The following User " + UsernameTB.Text + " does not have access.");
                        }
                    }
                }
                
                #endregion
            }

        }

        private void GetPermsBTN_Click(object sender, EventArgs e)
        {
            fillDataGrid(UsernameTB.Text);
        }
        #endregion

    }
}
