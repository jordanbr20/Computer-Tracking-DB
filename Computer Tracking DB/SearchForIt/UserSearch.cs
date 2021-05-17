using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerTrackingDB.Properties;
using System.Data.SqlClient;

namespace ComputerTrackingDB
{
    public partial class UserSearch : UserControl
    {
        public UserSearch()
        {
            InitializeComponent();
        }

        private void UserSearch_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            TechLBL.Text = Settings.Default.UserSearch;
            fillDataGrid();
            GetTechInormation();
            fillScanInDataGrid();
        }

        public void fillDataGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q;

                string stringB = this.Text;
                string TechName = TechLBL.Text;

                SqlConnection myConn = new SqlConnection(conn_string);

                q = "USE ComputerTrackingDB ";
                q += "SELECT * ";
                q += "FROM Tech_Accounts ";
                q += "WHERE TechName = @TechName";


                myConn.Open();

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@TechName", TechName);

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

        public void fillScanInDataGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string q;

                string stringB = this.Text;
                string TechName = TechLBL.Text;

                SqlConnection myConn = new SqlConnection(conn_string);

                q = "USE ComputerTrackingDB ";
                q += "SELECT TOP 100 Serial, TechName, Transaction_Date, Old_Location, New_Location, Type, Notes, Status ";
                q += "FROM Computers_Transaction ";
                q += "WHERE TechName = @TechName ";
                q += "ORDER BY ID DESC ";


                myConn.Open();

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@TechName", TechName);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.SelectCommand = cmd;

                da.Fill(dt);
                TransactionsDT.DataSource = dt;
                TransactionsDT.AutoResizeColumns();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Cursor.Current = Cursors.Arrow;
        }

        public void GetTechInormation()
        {
            ActiveLBL.Text = "Active : " + SearchStatusDT[5, 0].Value.ToString();
            RoleLBL.Text = SearchStatusDT[4, 0].Value.ToString();
        }
    }
}
