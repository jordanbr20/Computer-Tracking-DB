using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using ComputerTrackingDB.Properties;
using System.Data.SqlClient;

namespace ComputerTrackingDB
{
    public partial class AdminLocations : UserControl
    {
        #region Locations Form
        public AdminLocations()
        {
            InitializeComponent();
        }

        CTDBFunctions myFunc = new CTDBFunctions();
        private void AdminLocations_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            GetModels();
        }

        #endregion

        #region Other Functions

        private void MoveOriginal()
        {
            NewLocation.Visible = false;
            Locationlbl.Visible = false;
            ActiveCB.Location = new Point(LocationsCB.Location.X, LocationsCB.Location.Y + 35);
            Update.Location = new Point(ActiveCB.Location.X, ActiveCB.Location.Y + 35);
            Savedlbl.Location = new Point(Update.Location.X, Update.Location.Y + 35);
        }

        private void MoveNew()
        {
            NewLocation.Visible = true;
            NewLocation.Location = new Point(LocationsCB.Location.X, LocationsCB.Location.Y + 40);
            Locationlbl.Visible = true;
            Locationlbl.Location = new Point(NewLocation.Location.X - 100, NewLocation.Location.Y + 2);
            ActiveCB.Location = new Point(NewLocation.Location.X, NewLocation.Location.Y + 40);
            Update.Location = new Point(ActiveCB.Location.X, ActiveCB.Location.Y + 35);
            Savedlbl.Location = new Point(Update.Location.X, Update.Location.Y + 35);
        }

        private void GetModels()
        {
            string conn_string = Settings.Default.DBConnection;
            string q = "";
            q = "USE ComputerTrackingDB ";
            q += "SELECT Location ";
            q += "FROM Locations ";
            q += "ORDER BY Location ";
            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            SqlDataReader dbReader = cmd.ExecuteReader();
            string itemToAdd;

            while (dbReader.Read())
            {
                itemToAdd = dbReader.GetString(0);
                LocationsCB.Items.Add(itemToAdd);
            }
            myConn.Close();
            int ItemsNumber = LocationsCB.Items.Count;
            LocationsCB.Items.Insert(ItemsNumber, "New...");
        }

        #endregion

        #region ComboBox
        private void LocationsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewLocation.Clear();
            ActiveCB.Checked = false;
            Savedlbl.Visible = false;
            if(LocationsCB.Text == "New...")
            {
                MoveNew();
            }
            else
            {
                MoveOriginal();
                ActiveCB.Checked = myFunc.checkLocationExists(LocationsCB.Text);
            }
        }

        #endregion

        #region Buttons
        private void Update_Click(object sender, EventArgs e)
        {
            if (LocationsCB.Text == "New...")
            {
                #region Check NewLocation Box

                if (NewLocation.Text == "")
                {
                    MessageBox.Show("Please enter a location!");
                    return;
                }

                #endregion

                #region Check Location Exsists
                if (myFunc.checkLocationExists(NewLocation.Text) == true)
                {
                    MessageBox.Show("Location already exsists.");
                    return;
                }
                #endregion

                #region SQL Add Admin Transaction

                try
                {
                    string conn_string = Settings.Default.DBConnection;
                    string ModifierName = Settings.Default.TechName;
                    string Date = DateTime.Now.ToShortDateString();
                    string NewLocaiton = NewLocation.Text;
                    string Type = "New Location";

                    SqlConnection myConn = new SqlConnection(conn_string);

                    string q = "USE ComputerTrackingDB ";
                    q += "INSERT INTO Admin_Transaction ";
                    q += "(TechName, Transaction_Date, Modified, Type) ";
                    q += "Values (@ModifierName, @Date, @NewLocaiton, @Type) ";

                    SqlCommand cmd = new SqlCommand(q, myConn);
                    cmd.Parameters.AddWithValue("@ModifierName", ModifierName);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@NewLocaiton", NewLocaiton);
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

                #region SQL Add New Locaiton
                try
                {
                    string Location = NewLocation.Text;
                    bool LocationActive = ActiveCB.Checked;

                    string q = "USE ComputerTrackingDB ";
                    q += "INSERT INTO Locations (Location, Active) ";
                    q += "VALUES (@Location, @LocationActive) ";

                    string conn_string = Settings.Default.DBConnection;
                    SqlConnection myConn = new SqlConnection(conn_string);
                    SqlCommand cmd = new SqlCommand(q, myConn);
                    cmd.Parameters.AddWithValue("@Location", Location);
                    cmd.Parameters.AddWithValue("@LocationActive", LocationActive);
                    myConn.Open();
                    cmd.CommandText = q;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                    Savedlbl.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Failed to Add new Location.");
                }
                #endregion
            }
            else
            {
                #region SQL Add Admin Transaction

                try
                {
                    string conn_string = Settings.Default.DBConnection;
                    string ModifierName = Settings.Default.TechName;
                    string Date = DateTime.Now.ToShortDateString();
                    string Location = LocationsCB.Text;
                    string Type = "Location";

                    SqlConnection myConn = new SqlConnection(conn_string);

                    string q = "USE ComputerTrackingDB ";
                    q += "INSERT INTO Admin_Transaction ";
                    q += "(TechName, Transaction_Date, Modified, Type) ";
                    q += "Values (@ModifierName, @Date, @Location, @Type) ";

                    SqlCommand cmd = new SqlCommand(q, myConn);
                    cmd.Parameters.AddWithValue("@ModifierName", ModifierName);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@Location", Location);
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

                #region SQL Update Location

                try
                {
                    string Location = LocationsCB.Text;
                    bool LocationActive = ActiveCB.Checked;

                    string q = "USE ComputerTrackingDB ";
                    q += "UPDATE Locations ";
                    q += "SET Active = @LocationActive ";
                    q += "WHERE Location = @Location";

                    string conn_string = Settings.Default.DBConnection;
                    SqlConnection myConn = new SqlConnection(conn_string);
                    SqlCommand cmd = new SqlCommand(q, myConn);
                    cmd.Parameters.AddWithValue("@Location", Location);
                    cmd.Parameters.AddWithValue("@LocationActive", LocationActive);
                    myConn.Open();
                    cmd.CommandText = q;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                    Savedlbl.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Failed to modify Location.");
                    return;
                }
                #endregion
            }
        }

        #endregion
    }
}
