using ComputerTrackingDB.Properties;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ComputerTrackingDB
{
    class CTDBFunctions
    {
        #region DBConnection
        public bool checkDBConnection()
        {
            string conn_string = Settings.Default.DBConnection;
            SqlConnection DBConn;
            DBConn = new SqlConnection(conn_string);
            try
            {
                DBConn.Open();
                DBConn.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion

        #region GetInformation

        public string getTechName(string TechID)
        {
            try
            {
                string read = null;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT TechName FROM Tech_Accounts WHERE Tech_Accounts.TechID = @TechID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@TechID", TechID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read;
                }
                else
                {
                    myConn.Close();
                    return read;
                }
            }
            catch
            {
                return null;
            }


        }

        public string getTechNamebyWWID(string WWID)
        {
            try
            {
                string read = null;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT TechName FROM Tech_Accounts WHERE Tech_Accounts.UserName = @WWID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@WWID", WWID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read;
                }
                else
                {
                    myConn.Close();
                    return read;
                }
            }
            catch
            {
                return null;
            }


        }

        public string getWWIDbyTechName(string TechName)
        {
            try
            {
                string read = null;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT UserName FROM Tech_Accounts WHERE Tech_Accounts.TechName = @TechName";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@TechName", TechName);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read;
                }
                else
                {
                    myConn.Close();
                    return read;
                }
            }
            catch
            {
                return null;
            }


        }

        public string getTechID(string WWID)
        {
            try
            {
                string read = null;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT TechID FROM Tech_Accounts WHERE Tech_Accounts.UserName = @WWID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@WWID", WWID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read;
                }
                else
                {
                    myConn.Close();
                    return read;
                }
            }
            catch
            {
                return null;
            }


        }

        public string getTechIDbyName(string TechName)
        {
            try
            {
                string read = null;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT TechID FROM Tech_Accounts WHERE Tech_Accounts.TechName = @TechName";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@TechName", TechName);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read;
                }
                else
                {
                    myConn.Close();
                    return read;
                }
            }
            catch
            {
                return null;
            }


        }

        public string getRolebyWWID(string WWID)
        {
            try
            {
                string read = null;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Role FROM Tech_Accounts WHERE Tech_Accounts.UserName = @WWID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@WWID", WWID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read;
                }
                else
                {
                    myConn.Close();
                    return read;
                }
            }
            catch
            {
                return null;
            }


        }

        public string getOldLocation(string Serial)
        {
            try
            {
                string read = null;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Location FROM Computers_Status WHERE Serial = @Serial";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", Serial);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read;
                }
                else
                {
                    myConn.Close();
                    return read;
                }
            }
            catch
            {
                return null;
            }
        }

        public string GetCurrentUniqID(string Serial)
        {
            try
            {
                string read = null;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT UniID FROM Computers_Status WHERE Serial = @Serial";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", Serial);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read;
                }
                else
                {
                    myConn.Close();
                    return read;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
            return null;
        }

        public string CheckIntern(string UniID)
        {
            try
            {
                string read = null;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Type FROM Computers_Transaction WHERE UniID = @UniID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@UniID", UniID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    if (read == "Intern")
                    {
                        return "true";
                    }
                    else
                    {
                        return "false";
                    }
                }
                else
                {
                    myConn.Close();
                    return read;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }

        public string getModel(string serial)
        {
            try
            {
                string read = null;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Model FROM Computers_ALL WHERE Computers_ALL.Serial = @Serial";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", serial);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read;
                }
                else
                {
                    myConn.Close();
                    return read;
                }
            }
            catch
            {
                return null;
            }

        }

        public string getModelType(string Model)
        {
            try
            {
                string read = null;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Type FROM Computers_Models WHERE Computers_Models.Model = @Model";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Model", Model);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read;
                }
                else
                {
                    myConn.Close();
                    return read;
                }
            }
            catch
            {
                return null;
            }


        }

        #endregion

        #region Check Permissions

        public string checkStationAccess(string WWID)
        {
            try
            {
                bool read;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Station FROM Tech_Accounts WHERE Tech_Accounts.UserName = @WWID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@WWID", WWID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
                else
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string checkValidatorAccess(string WWID)
        {
            try
            {
                bool read;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Validator FROM Tech_Accounts WHERE Tech_Accounts.UserName = @WWID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@WWID", WWID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
                else
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string checkAdminAccess(string WWID)
        {
            try
            {
                bool read;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Admin FROM Tech_Accounts WHERE Tech_Accounts.UserName = @WWID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@WWID", WWID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
                else
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string checkInventoryControlAccess(string WWID)
        {
            try
            {
                bool read;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Inventory_Control FROM Tech_Accounts WHERE Tech_Accounts.UserName = @WWID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@WWID", WWID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
                else
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string checkInventoryMoveAccess(string WWID)
        {
            try
            {
                bool read;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Inventory_Move FROM Tech_Accounts WHERE Tech_Accounts.UserName = @WWID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@WWID", WWID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
                else
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string checkInventoryNewAccess(string WWID)
        {
            try
            {
                bool read;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Inventory_New FROM Tech_Accounts WHERE Tech_Accounts.UserName = @WWID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@WWID", WWID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
                else
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string checkCompuCOM(string WWID)
        {
            try
            {
                bool read;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT CompuCOM FROM Tech_Accounts WHERE Tech_Accounts.UserName = @WWID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@WWID", WWID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
                else
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string checkComputerTrackingDBAccess(string WWID)
        {
            try
            {
                bool read;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Active FROM Tech_Accounts WHERE Tech_Accounts.UserName = @WWID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@WWID", WWID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
                else
                {
                    read = datareader.GetBoolean(0);
                    myConn.Close();
                    return read.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public (string, string, string, string, string, string, string, string) checkUserAccess(string WWID)
        {
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Active, Station, CompuCOM, Validator, Admin, Inventory_Control, Inventory_Move, Inventory_new FROM Tech_Accounts WHERE Tech_Accounts.UserName = @WWID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@WWID", WWID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                bool reader = datareader.Read();

                
                
                string Active = Convert.ToString(datareader["Active"]);
                string Station = Convert.ToString(datareader["Station"]);
                string CompuCOM = Convert.ToString(datareader["CompuCOM"]);
                string Validator = Convert.ToString(datareader["Validator"]);
                string Admin = Convert.ToString(datareader["Admin"]);
                string Audit = Convert.ToString(datareader["Inventory_Control"]);
                string Move = Convert.ToString(datareader["Inventory_Move"]);
                string New = Convert.ToString(datareader["Inventory_new"]);

                return (Active, Station, CompuCOM, Validator, Admin, Audit, Move, New);
            }
            catch (Exception ex)
            {
                return (ex.ToString(),"","","","","","","");
            }
        }

        #endregion

        #region Generator

        public string generateTechID()
        {

            char[] xCharArray = "ABCDEFGHIJKLMNOPQRSTUCWXYZ".ToCharArray();
            char[] xNumArray = "0123456789".ToCharArray();
            System.Random xGen = new System.Random();
            string xStr = String.Empty;
            xStr += xCharArray[xGen.Next(0, xCharArray.Length)];
            while (xStr.Length < 9)
            {
                xStr += xNumArray[xGen.Next(0, xNumArray.Length)];
            }

            return xStr;
        }

        public string generateUniID()
        {

            char[] xCharArray = "ABCDEFGHIJKLMNOPQRSTUCWXYZ".ToCharArray();
            char[] xNumArray = "0123456789".ToCharArray();
            System.Random xGen = new System.Random();
            string UniID = String.Empty;
            UniID += xCharArray[xGen.Next(0, xCharArray.Length)];
            while (UniID.Length < 50)
            {
                UniID += xNumArray[xGen.Next(0, xNumArray.Length)];
            }

            return UniID;
        }

        #endregion

        #region Check_Others

        public bool checkSerialExists(string serial)
        {
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT * FROM Computers_ALL WHERE Computers_ALL.Serial = @Serial";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", serial);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();

                if (datareader.HasRows)
                {
                    myConn.Close();
                    return true;
                }
                else
                {
                    myConn.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool checkWWIDExists(string WWID)
        {
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT UserName FROM Tech_Accounts WHERE Tech_Accounts.UserName = @WWID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@WWID", WWID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();

                if (datareader.HasRows)
                {
                    myConn.Close();
                    return true;
                }
                else
                {
                    myConn.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool checkTechIDExists(string TechID)
        {
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT TechID FROM Tech_Accounts WHERE Tech_Accounts.TechID = @TechID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@TechID", TechID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();

                if (datareader.HasRows)
                {
                    myConn.Close();
                    return true;
                }
                else
                {
                    myConn.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool checkModelExists(string Model)
        {
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Model FROM Computers_Models WHERE Computers_Models.Model = @Model";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Model", Model);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();

                if (datareader.HasRows)
                {
                    myConn.Close();
                    return true;
                }
                else
                {
                    myConn.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool checkLocationExists(string Location)
        {
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Location FROM Locations WHERE Locations.Location = @Location";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Location", Location);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();

                if (datareader.HasRows)
                {
                    myConn.Close();
                    return true;
                }
                else
                {
                    myConn.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool checkTechNameExists(string TechName)
        {
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT TechName FROM Tech_Accounts WHERE Tech_Accounts.TechName = @TechName";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@TechName", TechName);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();

                if (datareader.HasRows)
                {
                    myConn.Close();
                    return true;
                }
                else
                {
                    myConn.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool checkTechStatus(string TechID)
        {
            try
            {
                bool activeTech = false;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Active FROM Tech_Accounts WHERE Tech_Accounts.TechID = @TechID";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@TechID", TechID);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    activeTech = datareader.GetBoolean(0);
                    myConn.Close();
                    return activeTech;
                }
                else
                {
                    myConn.Close();
                    return activeTech;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool checkAudit()
        {
            try
            {
                bool Audit = false;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Active FROM App_Settings WHERE App_Settings.Setting = 'AuditMode'";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    Audit = datareader.GetBoolean(0);
                    myConn.Close();
                    return Audit;
                }
                else
                {
                    myConn.Close();
                    return Audit;
                }
            }
            catch
            {
                return false;
            }
        }
        public string checkWhoStartedAudit()
        {
            try
            {
                string AuditStartedBy = null;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Detail FROM App_Settings WHERE App_Settings.Setting = 'AuditMode'";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    AuditStartedBy = datareader.GetString(0);
                    myConn.Close();
                    return AuditStartedBy;
                }
                else
                {
                    myConn.Close();
                    return AuditStartedBy;
                }
            }
            catch
            {
                return null;
            }
        }
        public string checkstationpassword()
        {
            try
            {
                string read;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB ";
                q += "SELECT Detail ";
                q += "FROM App_Settings ";
                q += "WHERE Setting = 'Station'";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read.ToString();
                }
                else
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string checkSerialType(string Model)
        {
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string read;
                string q = "USE ComputerTrackingDB SELECT Type FROM Computers_Models WHERE Computers_Models.Model = @Model";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Model", Model);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read;
                }
                else
                {
                    myConn.Close();
                    return "Error";
                }
            }
            catch
            {
                return "Error";
            }
        }
        public bool checkmodelactive(string Model)
        {
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Active FROM Computers_Models WHERE Computers_Models.Model = @Model";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Model", Model);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();

                if (datareader.HasRows)
                {
                    myConn.Close();
                    return true;
                }
                else
                {
                    myConn.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool checkSerialTagged(string Serial)
        {
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB SELECT Tagged FROM Computers_ALL WHERE Computers_ALL.Serial = @Serial";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", Serial);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                datareader.Read();

                string test = datareader["Tagged"].ToString();
                if(test == "True" || test == "1")
                {
                    myConn.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public string checkSerialTaggedBy(string Serial)
        {
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string read;
                string q = "USE ComputerTrackingDB SELECT TaggedBy FROM Computers_ALL WHERE Computers_ALL.Serial = @Serial";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", Serial);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read;
                }
                else
                {
                    myConn.Close();
                    return "Error";
                }
            }
            catch
            {
                return "Error";
            }
        }

        #endregion

        #region Login Check
        public string checkloginusername(string username)
        {
            try
            {
                string read;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB ";
                q += "SELECT UserName ";
                q += "FROM Tech_Accounts ";
                q += "WHERE UserName = @Username";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Username", username);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read.ToString();
                }
                else
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string checkloginpassword(string username)
        {
            try
            {
                string read;
                string conn_string = Settings.Default.DBConnection;
                string q = "USE ComputerTrackingDB ";
                q += "SELECT Password ";
                q += "FROM Tech_Accounts ";
                q += "WHERE UserName = @Username";
                SqlConnection myConn;

                myConn = new SqlConnection(conn_string);

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Username", username);
                myConn.Open();
                SqlDataReader datareader = cmd.ExecuteReader();
                if (datareader.Read() == true)
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read.ToString();
                }
                else
                {
                    read = datareader.GetString(0);
                    myConn.Close();
                    return read.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        #endregion

        #region Dymo

        public void PrintBarcode(string Serial)
        {
            string ModelNum;
            Dymo.DymoAddIn _dymoAddin = new Dymo.DymoAddIn();
            Dymo.DymoLabels _Label = new Dymo.DymoLabels();
            // Text to UPPER CASE
            Serial = Serial.ToUpper();
            ModelNum = getModel(Serial);

            if ((ModelNum == "Latitude E7440") || (ModelNum == "Latitude E7450") || (ModelNum == "Precision M6800"))
            {
                // Load the Label Definition into the Label Object
                _dymoAddin.Open("depot.label");
            }
            else
            {
                _dymoAddin.Open("linkhere");
            }
            // Set the Label Text    
            _Label.SetField("MODEL", ModelNum);
            _Label.SetField("BCText", Serial);

            string[] printers = _dymoAddin.GetDymoPrinters().Split(new char[] { '|' });
            if (printers.Count() > 0)
            {
                if (_dymoAddin.SelectPrinter(printers[0]))
                {
                    if (_dymoAddin.IsTwinTurboPrinter(printers[0]))
                    {
                        _dymoAddin.Print2(1, false, 0);
                    }
                    else
                    {
                        _dymoAddin.Print(1, false);
                    }
                }
            }




        }
        public void printTechBarcode(string techName, string techID)
        {
            Dymo.DymoAddIn _dymoAddin = new Dymo.DymoAddIn();
            Dymo.DymoLabels _Label = new Dymo.DymoLabels();
            // Text to UPPER CASE
            //techName = techName.ToUpper();
            techID = techID.ToUpper();

            // Load the Label Definition into the Label Object
            _dymoAddin.Open("linkhere");

            // Set the Label Text
            _Label.SetField("NAME", techName);
            _Label.SetField("Barcode", techID);

            string[] printers = _dymoAddin.GetDymoPrinters().Split(new char[] { '|' });
            if (printers.Count() > 0)
            {
                if (_dymoAddin.SelectPrinter(printers[0]))
                {
                    if (_dymoAddin.IsTwinTurboPrinter(printers[0]))
                    {
                        _dymoAddin.Print2(1, false, 0);
                    }
                    else
                    {
                        _dymoAddin.Print(1, false);
                    }
                }
            }
        }
        public void printModelBarcode(string Model)
        {
            Dymo.DymoAddIn _dymoAddin = new Dymo.DymoAddIn();
            Dymo.DymoLabels _Label = new Dymo.DymoLabels();
            // Text to UPPER CASE
            //Model = Model.ToUpper();

            // Load the Label Definition into the Label Object
            _dymoAddin.Open("linkhere");

            // Set the Label Text
            _Label.SetField("ModelName", Model);
            _Label.SetField("Barcode", Model);

            string[] printers = _dymoAddin.GetDymoPrinters().Split(new char[] { '|' });
            if (printers.Count() > 0)
            {
                if (_dymoAddin.SelectPrinter(printers[0]))
                {
                    if (_dymoAddin.IsTwinTurboPrinter(printers[0]))
                    {
                        _dymoAddin.Print2(1, false, 0);
                    }
                    else
                    {
                        _dymoAddin.Print(1, false);
                    }
                }
            }
        }
        public void PrintSeperationBarcode(string Serial)
        {
            string ModelNum;
            string Date = DateTime.Now.ToLongDateString();
            Dymo.DymoAddIn _dymoAddin = new Dymo.DymoAddIn();
            Dymo.DymoLabels _Label = new Dymo.DymoLabels();
            // Text to UPPER CASE
            Serial = Serial.ToUpper();
            ModelNum = getModel(Serial);

            if ((ModelNum == "Latitude E7440") || (ModelNum == "Latitude E7450") || (ModelNum == "Precision M6800"))
            {
                // Load the Label Definition into the Label Object
                _dymoAddin.Open("seperationLabel.label");
            }
            else
            {
                _dymoAddin.Open("linkhere");
            }
            // Set the Label Text    
            //_Label.SetField("DateTEXT", Date);
            _Label.SetField("MODEL", ModelNum);
            _Label.SetField("BCText", Serial);

            string[] printers = _dymoAddin.GetDymoPrinters().Split(new char[] { '|' });
            if (printers.Count() > 0)
            {
                if (_dymoAddin.SelectPrinter(printers[0]))
                {
                    if (_dymoAddin.IsTwinTurboPrinter(printers[0]))
                    {
                        _dymoAddin.Print2(1, false, 0);
                    }
                    else
                    {
                        _dymoAddin.Print(1, false);
                    }
                }
            }




        }
        public bool testForLabelWriter()
        {
            /*
            string PrinterNames = DymoAddin.GetDymoPrinters();
            if (PrinterNames != null)
            {
                return true;
            }
            else
            {
                return false;
            }
            */
            var DymoAddin = new Dymo.DymoAddIn();
            string[] printers = DymoAddin.GetDymoPrinters().Split(new char[] { '|' });
            bool pOnline;
            pOnline = DymoAddin.IsPrinterOnline(printers[0]);
            if (pOnline)
            {
                // LabelWriter printer is connected
                return true;
            }
            else
            {
                // LabelWriter printer is not connected.
                MessageBox.Show("Not Connected.");
                return false;
            }
        }
        #endregion

        #region Active Sql Functions

        public string GetActiveModels()
        {
            string conn_string = Settings.Default.DBConnection;
            string q = "";
            q = "USE ComputerTrackingDB ";
            q += "SELECT Model ";
            q += "FROM Computers_Models WHERE Active = 'True'";
            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            SqlDataReader dbReader = cmd.ExecuteReader();

            while (dbReader.Read())
            {
                return dbReader.GetString(0);
            }
            return null;
        }

        #endregion

        #region Other_Functions
        public bool isNumeric(string inStr)
        {
            int result;
            if (int.TryParse(inStr, out result))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Mid(string s, int a, int b)
        {
            try
            {
                string temp = s.Substring(a - 1, b);
                return temp;
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}