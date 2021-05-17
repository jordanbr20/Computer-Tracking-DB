using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ComputerTrackingDB.Properties;
using Microsoft.Office.Interop.Excel;

namespace ComputerTrackingDB
{
    public partial class InventoryAudit : UserControl
    {
        #region Inventory Audit
        public InventoryAudit()
        {
            InitializeComponent();
        }

        System.Media.SoundPlayer ErrorSound = new System.Media.SoundPlayer(Properties.Resources.error);
        CTDBFunctions myFunc = new CTDBFunctions();
        Main main = new Main();
        private void InventoryAudit_Load(object sender, EventArgs e)
        {
            //this.Size = Settings.Default.PageSize;
            //this.MaximumSize = Settings.Default.PageSize;
            //this.MinimumSize = Settings.Default.PageSize;
            this.Dock = DockStyle.Fill;

            DateTB.Text = DateTime.Now.ToShortDateString();
            DateTB.Enabled = false;
            TechIDTB.Text = Settings.Default.TechID;
            TechIDTB.Enabled = false;

            GetActiveLocations();

            main.AcceptButton = Savebtn;
        }

        #endregion

        #region Check Boxes
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

        #region Textboxes
        private void SerialTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Savebtn.PerformClick();
            }

        }

        #endregion

        #region Buttons
        private void Savebtn_Click(object sender, EventArgs e)
        {
            //CheckTextBoxes();
            AuditCountlbl.Text = activityGrid.Rows.Count.ToString();
            if (Settings.Default.AuditMode == true)
            {
                CheckTextBoxes();
            }
            else
            {
                ErrorSound.Play();
                MessageBox.Show("Audit Mode is currently inactive.");
                return;
                //CheckTextBoxes();
            }
        }
        private void ExportDataView_Click(object sender, EventArgs e)
        {
            ImportDataGridViewDataToExcelSheet();
        }

        #endregion

        #region Get Active

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
                LocationCB.Items.Add(itemToAdd);
            }
            myConn.Close();
        }

        #endregion

        #region Other Functions

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
            SerialTB.Focus();
        }

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

            CTDBFunctions myFunc = new CTDBFunctions();
            try
            {
                string conn_string = Settings.Default.DBConnection;
                string Serial = SerialTB.Text.ToUpper();
                string Date = DateTime.Today.ToShortDateString();
                string techID = TechIDTB.Text.ToUpper();
                string TechName = myFunc.getTechName(techID);
                string oldLocation = myFunc.getOldLocation(SerialTB.Text);
                string AuditLocation = LocationCB.Text.ToUpper();
                string UniID = myFunc.generateUniID();
                string Type = "Inventory";
                string Status = "Audit";
                string Correct;


                SqlConnection myConn = new SqlConnection(conn_string);

                string q = "USE ComputerTrackingDB ";
                q += "INSERT INTO Computers_Transaction ( Serial, TechName, TechID, Transaction_Date, Old_Location, New_Location, Type, Status, UniID ) ";
                q += "Values (@Serial, @TechName, @TechID, @Status_Date, @oldLocation, @AuditLocation, @Type, @Status, @UniID)";

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", Serial);
                cmd.Parameters.AddWithValue("@TechName", TechName);
                cmd.Parameters.AddWithValue("@TechID", techID);
                cmd.Parameters.AddWithValue("@Status_Date", Date);
                cmd.Parameters.AddWithValue("@oldLocation", oldLocation);
                cmd.Parameters.AddWithValue("@AuditLocation", AuditLocation);
                cmd.Parameters.AddWithValue("@Type", Type);
                cmd.Parameters.AddWithValue("@Status", Status);
                cmd.Parameters.AddWithValue("@UniID", UniID);

                myConn.Open();
                cmd.CommandText = q;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                if (oldLocation == AuditLocation)
                {
                    Correct = "Yes";
                }
                else
                {
                    Correct = "No";
                }

                string Time = DateTime.Now.ToLongTimeString();
                activityGrid.Rows.Add(Time, Date, Serial, TechName, oldLocation, AuditLocation, Correct, "Success");
                if (activityGrid.RowCount > 1)
                { this.activityGrid.Sort(this.activityGrid.Columns["Time"], ListSortDirection.Descending); }
                activityGrid.AutoResizeColumns();
                UpdateInventory(UniID);

                myConn.Close();
            }
            catch (Exception ex)
            {
                string Time = DateTime.Now.ToLongTimeString();
                string oldLocation = myFunc.getOldLocation(SerialTB.Text);
                string AuditLocation = LocationCB.Text.ToUpper();
                activityGrid.Rows.Add(Time, Date, Serial, TechName, oldLocation, AuditLocation, Correct, "Fail");
                if (activityGrid.RowCount > 1)
                { this.activityGrid.Sort(this.activityGrid.Columns["Time"], ListSortDirection.Descending); }
                activityGrid.AutoResizeColumns();
                MessageBox.Show("Error: " + ex);
            }
        }

        private void UpdateInventory(string UniID)
        {
            CTDBFunctions myFunc = new CTDBFunctions();
            try
            {

                string conn_string = Settings.Default.DBConnection;
                string Serial = SerialTB.Text.ToUpper();
                string Date = DateTime.Today.ToShortDateString();
                string techID = TechIDTB.Text.ToUpper();
                string TechName = myFunc.getTechName(techID);
                string AuditLocation = LocationCB.Text.ToUpper();

                SqlConnection myConn = new SqlConnection(conn_string);

                string q = "USE ComputerTrackingDB ";
                q += "UPDATE Computers_Status ";
                q += "SET Serial = @Serial, Modified_Date = @Status_Date, Modified_TechID = @TechID, Modified_Name = @TechName, Location = @Location, UniID = @UniID ";
                q += "WHERE Serial = @Serial";

                SqlCommand cmd = new SqlCommand(q, myConn);
                cmd.Parameters.AddWithValue("@Serial", Serial);
                cmd.Parameters.AddWithValue("@Status_Date", Date);
                cmd.Parameters.AddWithValue("@TechID", techID);
                cmd.Parameters.AddWithValue("@TechName", TechName);
                cmd.Parameters.AddWithValue("@Location", AuditLocation);
                cmd.Parameters.AddWithValue("@UniID", UniID);
                myConn.Open();
                cmd.CommandText = q;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Clear();
        }

        
        private void ImportDataGridViewDataToExcelSheet()
        {

            Microsoft.Office.Interop.Excel.Application xlApp;
            Workbook xlWorkBook;
            Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


            for (int x = 1; x < activityGrid.Columns.Count + 1; x++)
            {
                xlWorkSheet.Cells[1, x] = activityGrid.Columns[x - 1].HeaderText;
            }

            for (int i = 0; i < activityGrid.Rows.Count; i++)
            {
                for (int j = 0; j < activityGrid.Columns.Count; j++)
                {
                    xlWorkSheet.Cells[i + 2, j + 1] = activityGrid.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "ReportView";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                xlWorkBook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
         }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        #endregion
    }
}
