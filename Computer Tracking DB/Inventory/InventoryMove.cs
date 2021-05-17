using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using ComputerTrackingDB.Properties;
using System.Data.SqlClient;

namespace ComputerTrackingDB
{
    public partial class InventoryMove : UserControl
    {
        #region Inventory Move
        public InventoryMove()
        {
            InitializeComponent();
        }
        #region Call

        CTDBFunctions myFunc = new CTDBFunctions();
        Main main = new Main();

        #endregion

        System.Media.SoundPlayer ErrorSound = new System.Media.SoundPlayer(Properties.Resources.error);
        private void InventoryMove_Load(object sender, EventArgs e)
        {
            //this.Size = Settings.Default.PageSize;
            //this.MaximumSize = Settings.Default.PageSize;
            //this.MinimumSize = Settings.Default.PageSize;
            this.Dock = DockStyle.Fill;

            TechIDTB.Text = Settings.Default.TechID;
            TechIDTB.Enabled = false;
            DateTB.Text = DateTime.Now.ToShortDateString();
            DateTB.Enabled = false;

            main.AcceptButton = Savebtn;

            GetActiveLocations();
        }

        #endregion

        #region Lock
        private void LocationLock_CheckedChanged(object sender, EventArgs e)
        {
            if (LocationLock.Checked)
            {
                LocationCB.Enabled = false;
            }
            else
            {
                LocationCB.Enabled = true;

            }
        }

        #endregion

        #region Other Functions
        private void CheckTextBoxes()
        {
            if(myFunc.checkSerialExists(SerialTB.Text) == false)
            {
                ErrorSound.Play();
                MessageBox.Show("Serial " + SerialTB.Text + " does not exsist in Database.");
                return;
            }
            if(SerialTB.Text == "")
            {
                ErrorSound.Play();
                MessageBox.Show("Serial can not be empty.");
                return;
            }
            if (LocationCB.Text == "")
            {
                ErrorSound.Play();
                MessageBox.Show("Location can not be empty.");
                return;
            }
            CreateTransaction();
        }
        private void CreateTransaction()
        {
            try
            {
                string dateTime;
                string conn_string = Settings.Default.DBConnection;
                string Serial = SerialTB.Text;
                string techID = TechIDTB.Text.ToUpper();
                string TechName = myFunc.getTechName(techID);
                string Remarks = NotesTB.Text.ToUpper();
                string Status_Date = DateTime.Today.ToShortDateString();
                string Old_Location = myFunc.getOldLocation(Serial);
                string Location = LocationCB.Text;
                string UniID = myFunc.generateUniID();
                string Status = "Move";
                string Type = "Inventory";
                SqlConnection myConn = new SqlConnection(conn_string);


                string q = "USE ComputerTrackingDB ";
                q += "INSERT INTO Computers_Transaction(Serial, TechName, TechID, Notes, Transaction_Date, Old_Location, New_Location, Type, Status, UniID) ";
                q += "Values (@Serial,@TechName,@TechID, @Remarks, @Status_Date, @Old_Location, @location, @Type, @Status, @UniID)";

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
                UpdateComptuerStatus(Location, UniID);
                myConn.Open();
                cmd.CommandText = q;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                myConn.Close();
                dateTime = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                InventoryMoveGrid.Rows.Add(dateTime, Serial, TechName, Old_Location, Location, Remarks, "Success");
                if (InventoryMoveGrid.RowCount > 1)
                { this.InventoryMoveGrid.Sort(this.InventoryMoveGrid.Columns["Column1"], ListSortDirection.Descending); }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void UpdateComptuerStatus(string New_Location, string UniID)
        {
            try
            {
                string dateTime;
                string conn_string = Settings.Default.DBConnection;
                string Serial = SerialTB.Text;
                string Status_Date = DateTime.Today.ToShortDateString();
                string techID = TechIDTB.Text.ToUpper();
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
            Clear();
        }
        private void Clear()
        {
            SerialTB.Clear();
            if (LocationLock.Checked)
            {

            }
            else
            {
                LocationCB.Text = "";
            }
        }
        private void GetActiveLocations()
        {
            string conn_string = Settings.Default.DBConnection;
            string q = "";
            q = "USE ComputerTrackingDB ";
            q += "SELECT Location ";
            q += "FROM Locations ";
            q += "WHERE (Active = 1) ";
            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            SqlDataReader dbReader = cmd.ExecuteReader();
            string itemToAdd;

            while (dbReader.Read())
            {
                itemToAdd = dbReader.GetString(0);
                LocationCB.Items.Add(itemToAdd);
            }
            myConn.Close();
        }

        #endregion

        #region Buttons
        private void Savebtn_Click(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }

        #endregion

        #region Text Boxes
        private void SerialTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void SerialTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Savebtn.PerformClick();
            }
        }

        #endregion
    }
}
