using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using ComputerTrackingDB.Properties;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ComputerTrackingDB
{
    public partial class InventoryNew : UserControl
    {
        #region Inventory New
        public InventoryNew()
        {
            InitializeComponent();
        }
        CTDBFunctions myFunc = new CTDBFunctions();
        Main main = new Main();
        private void InventoryNew_Load(object sender, EventArgs e)
        {
            //this.Size = Settings.Default.PageSize;
            //this.MaximumSize = Settings.Default.PageSize;
            //this.MinimumSize = Settings.Default.PageSize;
            this.Dock = DockStyle.Fill;
            TechIDTextBox.Text = Settings.Default.TechID;
            TechIDTextBox.Enabled = false;
            GetActiveModels();
            GetActiveLocations();
        }


        #endregion

        #region GetActive
        private void GetActiveModels()
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
            string itemToAdd;

            while (dbReader.Read())
            {
                itemToAdd = dbReader.GetString(0);
                modelComboBox.Items.Add(itemToAdd);
            }
            myConn.Close();
        }
        private void GetActiveLocations()
        {
            string conn_string = Settings.Default.DBConnection;
            string q = "";
            q = "USE ComputerTrackingDB ";
            q += "SELECT Location ";
            q += "FROM Locations ";
            q += "WHERE (Active = 1) ";
            q += "EXCEPT ";
            q += "Select Location ";
            q += "FROM Locations ";
            q += "WHERE Location LIKE 'INSHELF%'";
            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            SqlDataReader dbReader = cmd.ExecuteReader();
            string itemToAdd;

            while (dbReader.Read())
            {
                itemToAdd = dbReader.GetString(0);
                LocationCombo.Items.Add(itemToAdd);
            }
            myConn.Close();
        }
        #endregion

        #region Locks
        private void MLockCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MLockCheckBox.Checked)
            {
                modelComboBox.Enabled = false;
            }
            else
            {
                modelComboBox.Enabled = true;
            }
        }
        private void LockLocationBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LockLocationBox.Checked)
            {
                LocationCombo.Enabled = false;
            }
            else
            {
                LocationCombo.Enabled = true;
            }
        }


        #endregion

        #region Textbox
        private void serialTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void serialTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Savebtn.PerformClick();
            }

        }
        private void TechIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LocationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Button
        private void Savebtn_Click(object sender, EventArgs e)
        {
            UpdateComputersALL();
            serialTextBox.Focus(); 
        }

        #endregion

        #region Checkboxes


        #endregion

        #region Other Functions

        private void UpdateComputersALL()
        {
            #region Check textboxes
            if(myFunc.checkSerialExists(serialTextBox.Text) == true)
            {
                MessageBox.Show("Serial Already exists in DataBase");
                return;
            }
            if (serialTextBox.TextLength == 0)
            {
                MessageBox.Show("Invalid Serial Number", "Error", MessageBoxButtons.OK);
                return;
            }

            if (Settings.Default.InventoryNew == "False" || Settings.Default.InventoryNew == "false")
            {
                MessageBox.Show(Settings.Default.TechName + ", Sorry but you do not have access.");
                return;
            }
            if (modelComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a Model");
                return;
            }
            if (modelComboBox.Text == "")
            {
                MessageBox.Show("Please enter a model!");
                return;
            }
            if (TechIDTextBox.Text == "")
            {
                MessageBox.Show("Please enter a TechID");
                return;
            }
            if (LocationCombo.Text == "")
            {
                MessageBox.Show("Please enter a Location!");
                return;
            }
            #endregion
            try
            {

                string conn_string = Settings.Default.DBConnection;
                string Serial = serialTextBox.Text;
                string Model = modelComboBox.Text;
                SqlConnection myConn = new SqlConnection(conn_string);

                string q = "USE ComputerTrackingDB INSERT INTO Computers_ALL(Serial, Model) Values (@Serial,@Model)";

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", Serial);
                cmd.Parameters.AddWithValue("@Model", Model);
                myConn.Open();
                cmd.CommandText = q;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                myConn.Close();
                AddtoAll(Model);
                serialTextBox.Clear();
                serialTextBox.Focus();
                if (MLockCheckBox.Checked)
                {

                }
                else
                {
                    modelComboBox.ResetText();
                }
                if (LockLocationBox.Checked)
                {

                }
                else
                {
                    LocationCombo.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void AddtoAll(string Model)
        {
            try
            {

                string conn_string = Settings.Default.DBConnection;
                string Serial = serialTextBox.Text;
                string EnteredDate = DateTime.Today.ToShortDateString();
                string datetimestring = DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                string Location = LocationCombo.Text;
                string TechID = TechIDTextBox.Text;
                string TechName = Settings.Default.TechName;
                SqlConnection myConn = new SqlConnection(conn_string);

                string q = "USE ComputerTrackingDB INSERT INTO Computers_Status(Serial, Entered_Date, Modified_Name, Modified_TechID, Location) Values (@Serial,@EnteredDate,@TechName,@TechID,@Location)";

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", Serial);
                cmd.Parameters.AddWithValue("@EnteredDate", EnteredDate);
                cmd.Parameters.AddWithValue("@Location", Location);
                cmd.Parameters.AddWithValue("@TechName", TechName);
                cmd.Parameters.AddWithValue("@TechID", TechID);

                myConn.Open();
                cmd.CommandText = q;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                myConn.Close();
                NewInventoryDataGrid.Rows.Add(datetimestring, Serial, Model, TechName, Location, "Success");
                string EmailSNModel = Serial + " - " + Model ;
                EmailGrid.Rows.Add(EmailSNModel);
                if (NewInventoryDataGrid.RowCount > 1)
                { this.NewInventoryDataGrid.Sort(this.NewInventoryDataGrid.Columns["DateTimeColumn"], ListSortDirection.Descending); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }
        #endregion

        #region Email
        /* Will use at a later time.
        private void SendEmail()
        {
            NewInventoryDataGrid.ClipboardCopyMode.ToString();
            string Email = Settings.Default.NewInventoryEmailTo;
            string NewInventoryCC = Settings.Default.NewInventoryEmailCC;

            Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();

            Microsoft.Office.Interop.Outlook.MailItem eMail = app.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
            eMail.Subject = "New Computers";
            eMail.To = Email;
            eMail.CC = NewInventoryCC;
            eMail.Body = "Hello," + Environment.NewLine + Environment.NewLine;
            eMail.Body += "Below are new Computers that have came in." + Environment.NewLine + Environment.NewLine;
            foreach (DataGridViewRow row in EmailGrid.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    eMail.Body += cell.Value + Environment.NewLine;
                }
            }
            eMail.Body += "Thank you," + Environment.NewLine;
            eMail.Body += Settings.Default.TechName;
            eMail.Display(false);
            //eMail.Send();

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
        */
        #endregion
    }
}