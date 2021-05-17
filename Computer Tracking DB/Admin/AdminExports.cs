using System;
using System.Windows.Forms;
using ComputerTrackingDB.Properties;
using System.Data.SqlClient;

namespace ComputerTrackingDB
{
    public partial class AdminExports : UserControl
    {
        #region Admin Exports
        public AdminExports()
        {
            InitializeComponent();
        }

        private void AdminExports_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            GetActiveLocations();
            GetTechName();
        }

        #endregion

        #region Other functions
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
                AuditByLocationCB.Items.Add(itemToAdd);
            }
            myConn.Close();
        }

        private void GetTechName()
        {
            string conn_string = Settings.Default.DBConnection;
            string q = "";
            q = "USE ComputerTrackingDB ";
            q += "SELECT TechName ";
            q += "FROM Tech_Accounts WHERE Active = 'True'";
            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            SqlDataReader dbReader = cmd.ExecuteReader();
            string itemToAdd;

            while (dbReader.Read())
            {
                itemToAdd = dbReader.GetString(0);
                AuditByTechCB.Items.Add(itemToAdd);
                ScanOutTechCB.Items.Add(itemToAdd);
                TransactionTechCB.Items.Add(itemToAdd);
            }
            myConn.Close();
        }

        private void SQLToCSV(string q)
        {
            string AuditDate = AuditDateTB.Text;
            string SerialTransExport = SerialTransTB.Text;
            string TechName = AuditByTechCB.Text;
            string NewLocation = AuditByLocationCB.Text;
            string ScanOutTechName = ScanOutTechCB.Text;
            string ScanOutStartDate = ScanOutDate1TB.Text;
            string ScanOutEndDate = ScanOutDate2TB.Text;
            string TransactionTechName = TransactionTechCB.Text;
            string TransactionStartDate = TranscationDate1TB.Text;
            string TransactionEndDate = TranscationDate2TB.Text;
            string conn_string = Settings.Default.DBConnection;
            SqlConnection conn = new SqlConnection(conn_string);
            SaveFileDialog sfd = new SaveFileDialog();

            conn.Open();
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.Parameters.AddWithValue("@Serial", SerialTransExport);
            cmd.Parameters.AddWithValue("@AuditDate", AuditDate);
            cmd.Parameters.AddWithValue("@TechName", TechName);
            cmd.Parameters.AddWithValue("@NewLocation", NewLocation);
            cmd.Parameters.AddWithValue("@ScanOutStartDate", ScanOutStartDate);
            cmd.Parameters.AddWithValue("@ScanOutEndDate", ScanOutEndDate);
            cmd.Parameters.AddWithValue("@TransactionStartDate", TransactionStartDate);
            cmd.Parameters.AddWithValue("@TransactionEndDate", TransactionEndDate);
            cmd.Parameters.AddWithValue("@ScanOutTechName", ScanOutTechName);
            cmd.Parameters.AddWithValue("@TransactionTechName", TransactionTechName);
            SqlDataReader dr = cmd.ExecuteReader();
            sfd.FileName = "Export";
            sfd.Filter = "Excel | *.csv";
            sfd.Title = "Save Export";
            sfd.DefaultExt = ".csv";
            sfd.ShowDialog();

            using (System.IO.StreamWriter fs = new System.IO.StreamWriter(sfd.FileName))
            {
                // Loop through the fields and add headers
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    string name = dr.GetName(i);
                    if (name.Contains(","))
                        name = "\"" + name + "\"";

                    fs.Write(name + ",");
                }
                fs.WriteLine();

                // Loop through the rows and output the data
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(","))
                            value = "\"" + value + "\"";

                        fs.Write(value + ",");
                    }
                    fs.WriteLine();
                }

                fs.Close();
            }
        }

        #endregion

        #region Button Clicks

        private void ExportAllStatus_Click(object sender, EventArgs e)
        {
            string q;

            q = "SELECT Computers_Status.Serial, Computers_ALL.Model, Computers_Status.Entered_Date, Computers_Status.Modified_Date, Computers_Status.Modified_Name, Computers_Status.Modified_TechID, Computers_Status.Location ";
            q += "FROM Computers_Status INNER JOIN Computers_ALL ON Computers_Status.Serial = Computers_ALL.Serial ";

            SQLToCSV(q);
        }

        private void LoginHistorryBtn_Click(object sender, EventArgs e)
        {
            string q;

            q = "USE ComputerTrackingDB ";
            q += "SELECT * FROM dbo.Admin_Transaction";

            SQLToCSV(q);
        }

        private void SerialTransExportBtn_Click(object sender, EventArgs e)
        {
            string q;

            q = "USE ComputerTrackingDB ";
            q += "Select * FROM dbo.Computers_Transaction ";
            q += "WHERE Serial = @Serial";

            SQLToCSV(q);
        }

        private void ScanOutByDateBtn_Click(object sender, EventArgs e)
        {
            string q;

            q = "USE ComputerTrackingDB ";
            q += "Select * FROM dbo.Computers_Transaction ";
            q += "WHERE Type = 'Scan-Out' AND Transaction_Date BETWEEN @ScanOutStartDate AND @ScanOutEndDate";

            SQLToCSV(q);
        }

        private void ScanOutByDateTechBtn_Click(object sender, EventArgs e)
        {
            string q;

            q = "USE ComputerTrackingDB ";
            q += "Select * FROM dbo.Computers_Transaction ";
            q += "WHERE Type = 'Scan-Out' AND Transaction_Date BETWEEN @ScanOutStartDate AND @ScanOutEndDate AND TechName = @ScanOutTechName";

            SQLToCSV(q);
        }

        private void TransactionsByDateBtn_Click(object sender, EventArgs e)
        {
            string q;

            q = "USE ComputerTrackingDB ";
            q += "Select * FROM dbo.Computers_Transaction ";
            q += "WHERE Status != 'Audit' AND Transaction_Date BETWEEN @TransactionStartDate AND @TransactionEndDate";

            SQLToCSV(q);
        }

        private void TransactionsByDateandTechBtn_Click(object sender, EventArgs e)
        {
            string q;

            q = "USE ComputerTrackingDB ";
            q += "Select * FROM dbo.Computers_Transaction ";
            q += "WHERE Status != 'Audit' AND Transaction_Date BETWEEN @TransactionStartDate AND @TransactionEndDate AND TechName = @TransactionTechName";

            SQLToCSV(q);
        }

        private void AuditByTechBtn_Click(object sender, EventArgs e)
        {
            string q;

            q = "USE ComputerTrackingDB ";
            q += "Select * FROM dbo.Computers_Transaction ";
            q += "WHERE Status = 'Audit' AND TechName = @TechName";

            SQLToCSV(q);
        }

        private void AuditbyDateBtn_Click(object sender, EventArgs e)
        {
            string q;

            q = "USE ComputerTrackingDB ";
            q += "Select * FROM dbo.Computers_Transaction ";
            q += "WHERE Status = 'Audit' AND Transaction_Date = @AuditDate";

            SQLToCSV(q);
        }

        private void AuditByLocationBtn_Click(object sender, EventArgs e)
        {
            string q;

            q = "USE ComputerTrackingDB ";
            q += "Select * FROM dbo.Computers_Transaction ";
            q += "WHERE Status = 'Audit' AND New_Location = @NewLocation";

            SQLToCSV(q);
        }

        private void AuditByAll_Click(object sender, EventArgs e)
        {
            string q;

            q = "USE ComputerTrackingDB ";
            q += "Select * FROM dbo.Computers_Transaction ";
            q += "WHERE Status = 'Audit' AND New_Location = @NewLocation AND TechName = @TechName AND Transaction_Date = @AuditDate";

            SQLToCSV(q);
        }

        private void AuditByDateLocationBtn_Click(object sender, EventArgs e)
        {
            string q;

            q = "USE ComputerTrackingDB ";
            q += "Select * FROM dbo.Computers_Transaction ";
            q += "WHERE Status = 'Audit' AND New_Location = @NewLocation AND Transaction_Date = @AuditDate";

            SQLToCSV(q);
        }

        private void AuditByTechLocationBtn_Click(object sender, EventArgs e)
        {
            string q;

            q = "USE ComputerTrackingDB ";
            q += "Select * FROM dbo.Computers_Transaction ";
            q += "WHERE Status = 'Audit' AND New_Location = @NewLocation AND TechName = @TechName ";

            SQLToCSV(q);
        }

        private void AuditByTechDate_Click(object sender, EventArgs e)
        {
            string q;

            q = "USE ComputerTrackingDB ";
            q += "Select * FROM dbo.Computers_Transaction ";
            q += "WHERE Status = 'Audit' AND TechName = @TechName AND Transaction_Date = @AuditDate";

            SQLToCSV(q);
        }

        #endregion

    }
}
