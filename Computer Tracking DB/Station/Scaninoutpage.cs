using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using ComputerTrackingDB.Properties;
using System.Data.SqlClient;

namespace ComputerTrackingDB
{
    public partial class Scaninoutpage : UserControl
    {
        #region ScanInOutPage
        public Scaninoutpage()
        {
            InitializeComponent();
        }
        private void Scaninoutpage_Load(object sender, EventArgs e)
        {
            //this.Size = Settings.Default.PageSize;
            //this.MaximumSize = Settings.Default.PageSize;
            //this.MinimumSize = Settings.Default.PageSize;
            this.Dock = DockStyle.Fill;
            ScanInDataGrid.Font = new Font("Arial", 8);
            ScanOutDataGrid.Font = new Font("Arial", 8);
            if (Settings.Default.TechName != "Station")
            {
                SITechIDTB.Text = Settings.Default.TechID;
                SITechIDTB.ReadOnly = true;
                SOTechIDTB.Text = Settings.Default.TechID;
                SOTechIDTB.ReadOnly = true;
                ScanOutLockTechIDCB.Visible = false;
                SILockTechIDCB.Visible = false;
            }
            if(Settings.Default.TechName == "Station")
            {
                SITechIDTB.Text = "";
                SITechIDTB.ReadOnly = false;
                SOTechIDTB.Text = "";
                SOTechIDTB.ReadOnly = false;
            }
        }
        #endregion

        #region Call_Forms
        System.Media.SoundPlayer ErrorSound = new System.Media.SoundPlayer(Properties.Resources.error);
        CTDBFunctions myFunc = new CTDBFunctions();
        Main main = new Main();
        #endregion

        #region ScanInSide

        #region ScanInSQL
        private void SIsaveData()
        {
            // Save Data from form to database
            try
            {
                string dateTime;
                string conn_string = Settings.Default.DBConnection;
                string Serial = SISerialTB.Text;
                string techID = SITechIDTB.Text.ToUpper();
                string TechName = myFunc.getTechName(techID);
                string Remarks = SINotesTB.Text.ToUpper();
                string Status_Date = DateTime.Today.ToShortDateString();
                string Old_Location = myFunc.getOldLocation(Serial);
                string Type = "Scan-In";
                string Location = "Default";
                string Status = "Scan-In";
                string UniID = myFunc.generateUniID();

                SqlConnection myConn = new SqlConnection(conn_string);


                string q = "USE ComputerTrackingDB INSERT INTO Computers_Transaction(Serial, TechName, TechID, Notes, Transaction_Date, Old_Location, New_Location, Type, Status, UniID) Values (@Serial,@TechName,@TechID, @Remarks, @Status_Date, @Old_Location, @location, @Type, @Status, @UniID)";

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", Serial);
                cmd.Parameters.AddWithValue("@TechName", TechName);
                cmd.Parameters.AddWithValue("@TechID", techID);
                cmd.Parameters.AddWithValue("@Remarks", Remarks);
                cmd.Parameters.AddWithValue("@Status_Date", Status_Date);
                cmd.Parameters.AddWithValue("@Old_Location", Old_Location);
                cmd.Parameters.AddWithValue("@Location", Location);
                cmd.Parameters.AddWithValue("@Type", Type);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@UniID", UniID);
                SIUpdateComptuerStatus(Location, UniID);
                myConn.Open();
                cmd.CommandText = q;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                myConn.Close();
                dateTime = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                ScanInDataGrid.Rows.Add(dateTime, Serial, TechName, Status, "Success");
                if (ScanInDataGrid.RowCount > 1)
                { this.ScanInDataGrid.Sort(this.ScanInDataGrid.Columns["Column0"], ListSortDirection.Descending); }

            }
            catch (Exception ex)
            {
                ErrorSound.Play();
                MessageBox.Show("Error: " + ex);
            }
        }
        private void SIUpdateComptuerStatus(string New_Location, string UniID)
        {
            // Save Data from form to database
            try
            {
                string dateTime;
                string conn_string = Settings.Default.DBConnection;
                string Serial = SISerialTB.Text;
                string Status_Date = DateTime.Today.ToShortDateString();
                string techID = SITechIDTB.Text.ToUpper();
                string TechName = myFunc.getTechName(techID);
                SqlConnection myConn = new SqlConnection(conn_string);


                string q = "USE ComputerTrackingDB ";
                q += "UPDATE Computers_Status ";
                q += "SET Serial = @Serial, Modified_Date = @Status_Date, Modified_TechID = @TechID, Modified_Name = @TechName, Location = @Location, UniID = @UniID ";
                q += "WHERE Serial = @Serial";

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", Serial);
                cmd.Parameters.AddWithValue("@Status_Date", Status_Date);
                cmd.Parameters.AddWithValue("@TechID", techID);
                cmd.Parameters.AddWithValue("@TechName", TechName);
                cmd.Parameters.AddWithValue("@Location", New_Location);
                cmd.Parameters.AddWithValue("@UniID", UniID);
                myConn.Open();
                cmd.CommandText = q;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                myConn.Close();
                dateTime = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            main.AcceptButton = null;
        }
        #endregion

        #region Save Button
        private void SISavebtn_Click(object sender, EventArgs e)
        {
            if(myFunc.checkSerialExists(SISerialTB.Text) == false)
            {
                ErrorSound.Play();
                MessageBox.Show("Serial does not exist.");
                return;
            }
            if (myFunc.checkTechIDExists(SITechIDTB.Text) == false)
            {
                ErrorSound.Play();
                MessageBox.Show("TechID Does not exist.");
                return;
            }
            if (SITechIDTB.Text == "Station1")
            {
                ErrorSound.Play();
                MessageBox.Show("You are not allowed to use the Stations TechID");
                return;
            }
            SIsaveData();
            SISerialTB.Clear();
            if(Settings.Default.TechName == "Station")
            {
                if (SILockTechIDCB.Checked == false)
                {
                    SITechIDTB.Clear();
                }
            }
            SINotesTB.Clear();
            SISerialTB.Focus();
        }
        #endregion

        #region SISerialTB
        private void SISerialTB_Leave(object sender, EventArgs e)
        {
            //Used in a different way.
        }
        private void SISerialTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
        #endregion

        #region SITechIDTB
        private void SITechIDTB_TextChanged(object sender, EventArgs e)
        {
            //moved
        }
        private void SITechIDTB_Leave(object sender, EventArgs e)
        {
            if (SITechIDTB.TextLength == 0)
                return;
            SITechIDTB.Text = SITechIDTB.Text.ToUpper();
            if ((SITechIDTB.TextLength == 9) || (SITechIDTB.TextLength == 5))
            {
                string tid;
                tid = SITechIDTB.Text;

                if ((myFunc.checkTechIDExists(tid) == false) || (myFunc.checkTechStatus(tid) == false))
                {
                    ErrorSound.Play();
                    MessageBox.Show("TechID is inactive or does not exist in the database.  Please verify that the TechID has been entered correctly or add new Tech into database using Admin Tools", "TechID Not Authorized", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SITechIDTB.Focus();
                    SITechIDTB.SelectAll();
                }
            }
        }
        private void SITechIDTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
        private void SISerialTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void SILockTechIDCB_CheckedChanged(object sender, EventArgs e)
        {
            if (SILockTechIDCB.Checked == true)
            {
                SITechIDTB.Enabled = false;
                SITechIDTB.ReadOnly = true;
            }
            if (SILockTechIDCB.Checked == false)
            {
                SITechIDTB.Enabled = true;
                SITechIDTB.ReadOnly = false;
            }
        }
        #endregion

        #endregion

        #region ScanOutSide

        #region ScanOutSQL
        private void SOsaveData()
        {
            #region Check Text Boxes
            if (SITechIDTB.Text == "Station1" || SITechIDTB.Text == "Station2" || SITechIDTB.Text == "Station3")
            {
                MessageBox.Show("You are not allowed to use the Stations TechID");
                return;
            }
            if (myFunc.checkSerialExists(SOSerialTB.Text) == false)
            {
                MessageBox.Show("Serial does not exsist.");
                return;
            }
            if (myFunc.checkTechIDExists(SOTechIDTB.Text) == false)
            {
                MessageBox.Show("TechID does not exsist.");
                return;
            }
            #endregion
            try
            {
                string dateTime;
                string conn_string = Settings.Default.DBConnection;
                string Serial = SOSerialTB.Text;
                string techID = SOTechIDTB.Text.ToUpper();
                string TechName = myFunc.getTechName(techID);
                string Remarks = SONotesTB.Text.ToUpper();
                string Status_Date = DateTime.Today.ToShortDateString();
                string Old_Location = myFunc.getOldLocation(Serial);
                string Type = "Scan-Out";
                string Location = "Default";
                string Status = "Scan-Out";
                //string INC = "INC000000000000";
                string UniID = myFunc.generateUniID();

                SqlConnection myConn;
                myConn = new SqlConnection(conn_string);

                string q = "USE ComputerTrackingDB ";
                q += "INSERT INTO Computers_Transaction(Serial, TechName, TechID, Notes, Transaction_Date, Old_Location, New_Location, Type, Status, UniID) ";
                q += "Values (@Serial,@TechName,@TechID, @Remarks, @Status_Date, @Old_Location, @Location, @Type, @Status, @UniID)";

                SqlCommand cmd = new SqlCommand(q, myConn);

                cmd.Parameters.AddWithValue("@Serial", Serial);
                cmd.Parameters.AddWithValue("@TechName", TechName);
                cmd.Parameters.AddWithValue("@TechID", techID);
                cmd.Parameters.AddWithValue("@Remarks", Remarks);
                cmd.Parameters.AddWithValue("@Status_Date", Status_Date);
                cmd.Parameters.AddWithValue("@Old_Location", Old_Location);
                cmd.Parameters.AddWithValue("@Location", Location);
                cmd.Parameters.AddWithValue("@Type", Type);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@UniID", UniID);

                SOUpdateComptuerStatus(Location, UniID);

                myConn.Open();
                cmd.CommandText = q;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                myConn.Close();
                dateTime = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                ScanOutDataGrid.Rows.Add(dateTime, Serial, TechName, Status, "Success");
                if (ScanOutDataGrid.RowCount > 1)
                { this.ScanOutDataGrid.Sort(this.ScanOutDataGrid.Columns["dataGridViewTextBoxColumn1"], ListSortDirection.Descending); }
            }
            catch (Exception ex)
            {
                ErrorSound.Play();
                MessageBox.Show("Error: " + ex);
            }
        }
        private void SOUpdateComptuerStatus(string New_Location, string UniID)
        {

            // Save Data from form to database
            try
            {
                string dateTime;
                string conn_string = Settings.Default.DBConnection;
                string Serial = SOSerialTB.Text;
                string Status_Date = DateTime.Today.ToShortDateString();
                string techID = SOTechIDTB.Text.ToUpper();
                string TechName = myFunc.getTechName(techID);
                SqlConnection myConn = new SqlConnection(conn_string);


                string q = "USE ComputerTrackingDB ";
                q += "UPDATE Computers_Status ";
                q += "SET Serial = @Serial, Modified_Date = @Status_Date, Modified_TechID = @TechID, Modified_Name = @TechName, Location = @Location, UniID = @UniID ";
                q += "WHERE Serial = @Serial";

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", Serial);
                cmd.Parameters.AddWithValue("@Status_Date", Status_Date);
                cmd.Parameters.AddWithValue("@TechID", techID);
                cmd.Parameters.AddWithValue("@TechName", TechName);
                cmd.Parameters.AddWithValue("@Location", New_Location);
                cmd.Parameters.AddWithValue("@UniID", UniID);
                myConn.Open();
                cmd.CommandText = q;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                myConn.Close();
                dateTime = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

            }
            catch (Exception ex)
            {
                ErrorSound.Play();
                MessageBox.Show("Error: " + ex);
            }
        }
        #endregion
        private void ScanOutLockTechIDCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ScanOutLockTechIDCB.Checked)
            {
                SOTechIDTB.Enabled = false;
            }
            else
            {
                SOTechIDTB.Enabled = true;
            }
        }
        private void SOSavebtn_Click(object sender, EventArgs e)
        {
            SOsaveData();
            SOSerialTB.Clear();
            if (ScanOutLockTechIDCB.Checked)
            {

            }
            else
            {
                if (Settings.Default.TechName == "Station")
                {
                    SOTechIDTB.Clear();
                }
            }
            SONotesTB.Clear();
            SOSerialTB.Focus();
        }

        #region SOSerialTB
        private void SOSerialTB_Leave(object sender, EventArgs e)
        {
            SOSerialTB.Text = SOSerialTB.Text.ToUpper();
        }
        private void SOSerialTB_TextChanged(object sender, EventArgs e)
        {
            //moved
        }
        private void SOSerialTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (ScanOutLockTechIDCB.Checked)
                {
                    SOSavebtn.PerformClick();
                }
                else
                {
                    e.SuppressKeyPress = true;
                    SelectNextControl(ActiveControl, true, true, true, true);
                }
            }
        }
        #endregion

        #region SOTechIDTB
        private void SOTechIDTB_TextChanged(object sender, EventArgs e)
        {
            main.AcceptButton = SOSavebtn;
        }
        private void SOTechIDTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SOSavebtn.PerformClick();
            }
        }
        private void SOTechIDTB_Leave(object sender, EventArgs e)
        {
            if (SOTechIDTB.TextLength == 0)
                return;
            SOTechIDTB.Text = SOTechIDTB.Text.ToUpper();
            if ((SOTechIDTB.TextLength == 9) || (SOTechIDTB.TextLength == 5))
            {
                string tid;
                tid = SOTechIDTB.Text;

                if ((myFunc.checkTechIDExists(tid) == false) || (myFunc.checkTechStatus(tid) == false))
                {
                    ErrorSound.Play();
                    MessageBox.Show("TechID is inactive or does not exist in the database.  Please verify that the TechID has been entered correctly or add new Tech into database using Admin Tools", "TechID Not Authorized", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SOTechIDTB.Focus();
                    SOTechIDTB.SelectAll();
                }
            }
        }
        #endregion

        #endregion
    }
}