using System;
using System.Data;
using System.Windows.Forms;
using ComputerTrackingDB.Properties;
using System.Data.SqlClient;

namespace ComputerTrackingDB.SearchForIt
{
    public partial class LocationSearch : UserControl
    {
        #region Location Search
        public LocationSearch()
        {
            InitializeComponent();
        }
        private void LocationSearch_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            LocationLBL.Text = Settings.Default.LocationSearch;
            fillScanInDataGrid();
            UpdateInformation();
            fillComptuerStatusDT();
        }
        #endregion

        #region Fill DataGrids
        public void fillScanInDataGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q;

                string stringB = this.Text;
                string Location = LocationLBL.Text;

                SqlConnection myConn = new SqlConnection(conn_string);

                q = "USE ComputerTrackingDB ";
                q += "SELECT * ";
                q += "FROM Locations ";
                q += "WHERE Location = @Location ";


                myConn.Open();

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Location", Location);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.SelectCommand = cmd;

                da.Fill(dt);
                SearchStatusDT.DataSource = dt;
                SearchStatusDT.AutoResizeColumns();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Cursor.Current = Cursors.Arrow;
        }
        public void fillComptuerStatusDT()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q;

                string stringB = this.Text;
                string Location = LocationLBL.Text;

                SqlConnection myConn = new SqlConnection(conn_string);

                q = "USE ComputerTrackingDB ";
                q += "SELECT Computers_Status.Serial, Computers_ALL.Model, Computers_Status.Entered_Date, Computers_Status.Modified_Date, Computers_Status.Modified_Name ";
                q += "FROM Computers_Status INNER JOIN Computers_ALL ON Computers_Status.Serial = Computers_ALL.Serial ";
                q += "WHERE Computers_Status.Location = @Location";


                myConn.Open();

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Location", Location);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.SelectCommand = cmd;

                da.Fill(dt);
                ComptuerStatusDT.DataSource = dt;
                ComptuerStatusDT.AutoResizeColumns();
                myConn.Close();
                /*
                if (ComptuerStatusDT.RowCount > 1)
                { this.ComptuerStatusDT.Sort(this.ComptuerStatusDT.Columns["Transaction_Date"], ListSortDirection.Descending); }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Cursor.Current = Cursors.Arrow;
        }
        #endregion

        #region Update Information
        public void UpdateInformation()
        {
            ActiveLBL.Text = "Active :" + SearchStatusDT[2, 0].Value.ToString();
        }
        #endregion

    }
}