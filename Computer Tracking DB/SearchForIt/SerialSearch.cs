using ComputerTrackingDB.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComputerTrackingDB
{
    public partial class SerialSearch : UserControl
    {
        public SerialSearch()
        {
            InitializeComponent();
        }

        CTDBFunctions myFunc = new CTDBFunctions();

        Main main;
        private void SerialLBL_Click(object sender, EventArgs e)
        {

        }

        private void SearchForIt_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            string Serial = Settings.Default.SearchSerial;
            SerialLBL.Text = Serial;
            fillDataGrid();
            GetSerialInformation();
            fillTransactionGrid();
        }

        public void fillDataGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q;

                string stringB = this.Text;
                string Serial = SerialLBL.Text;

                SqlConnection myConn = new SqlConnection(conn_string);

                q = "USE ComputerTrackingDB ";
                q += "SELECT Computers_Status.Serial, Computers_Status.Entered_Date, Computers_Status.Modified_Date, Computers_Status.Modified_Name, Computers_Status.Location, Computers_ALL.Model ";
                q += "FROM Computers_Status INNER JOIN Computers_ALL ON Computers_Status.Serial = Computers_ALL.Serial ";
                q += "WHERE Computers_Status.Serial = @Serial";


                myConn.Open();

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", Serial);

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

        public void fillTransactionGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q;

                string stringB = this.Text;
                string Serial = SerialLBL.Text;

                SqlConnection myConn = new SqlConnection(conn_string);

                q = "USE ComputerTrackingDB ";
                q += "SELECT TechName, Transaction_Date, Old_Location, New_Location, Notes, Status ";
                q += "FROM Computers_Transaction ";
                q += "WHERE Serial = @Serial ";
                q += "ORDER BY ID DESC";


                myConn.Open();

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", Serial);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.SelectCommand = cmd;

                da.Fill(dt);
                TransactionGrid.DataSource = dt;
                TransactionGrid.AutoResizeColumns();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Cursor.Current = Cursors.Arrow;
        }

        public void GetSerialInformation()
        {
            EnteredDatelbl.Text = "Entered : " + SearchStatusDT[1, 0].Value.ToString();
            Locationlbl.Text = "Location : " + SearchStatusDT[4, 0].Value.ToString();
            LastModifiedlbl.Text = "Last Modified : " + SearchStatusDT[2, 0].Value.ToString() + " by " + SearchStatusDT[3, 0].Value.ToString();
            Modellbl.Text = SearchStatusDT[5, 0].Value.ToString();
        }

    }
}
