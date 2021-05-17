using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComputerTrackingDB.Properties;

namespace ComputerTrackingDB
{
    public partial class PrintLabels : UserControl
    {
        #region PrintLabelsForm
        public PrintLabels()
        {
            InitializeComponent();
        }

        CTDBFunctions myFunc = new CTDBFunctions();
        Main main = new Main();
        #endregion


        #region Fill
        private void FillTechID()
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
                FillCB.Items.Add(itemToAdd);
            }
            myConn.Close();
        }

        private void FillLocation()
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
                FillCB.Items.Add(itemToAdd);
            }
            myConn.Close();
        }

        private void FillModel()
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
                FillCB.Items.Add(itemToAdd);
            }
            myConn.Close();
        }
        #endregion

        #region TextBoxes
        private void SerialTB_TextChanged(object sender, EventArgs e)
        {
            if(SerialTB.TextLength == 7 || SerialTB.TextLength == 12)
            {
                if (myFunc.checkSerialExists(SerialTB.Text))
                {
                    ModelLbl.Text = myFunc.getModel(SerialTB.Text);
                    ModelLbl.Visible = true;
                    //PrintBtn.Location = new System.Drawing.Point(406, 251);
                    PrintBtn.Location = new Point(ModelLbl.Location.X, ModelLbl.Location.Y + 45);
                    PrintBtn.Visible = true;
                }
                else
                {
                    ModelLbl.Visible = false;
                    PrintBtn.Visible = false;
                    MessageBox.Show("Serial " + SerialTB.Text + " does not exist in Database.");
                }
            }
        }

        #endregion

        #region ComboBoxes
        private void FillCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeCB.Text != "TechID")
            {
                PrintBtn.Location = ModelLbl.Location;
            }
            else
            {
                TechIDLbl.Text = myFunc.getTechIDbyName(FillCB.Text);
                TechIDLbl.Location = ModelLbl.Location;
                TechIDLbl.Visible = true;
            }
            PrintBtn.Visible = true;
        }

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeCB.Text == "Serial Number")
            {
                FillCB.Visible = false;
                SerialTB.Location = FillCB.Location;
                FillCB.Items.Clear();
                SerialTB.Clear();
                FillCB.Text = "";
                ModelLbl.Visible = false;
                PrintBtn.Visible = false;
                TechIDLbl.Visible = false;
                SerialTB.Visible = true;
                SerialTB.Focus();
            }
            if (TypeCB.Text == "TechID")
            {
                SerialTB.Visible = false;
                FillCB.Visible = true;
                FillCB.Items.Clear();
                SerialTB.Clear();
                FillCB.Text = "";
                ModelLbl.Visible = false;
                TechIDLbl.Visible = false;
                PrintBtn.Visible = false;
                FillTechID();
            }
            if (TypeCB.Text == "Location")
            {
                SerialTB.Visible = false;
                FillCB.Visible = true;
                FillCB.Items.Clear();
                SerialTB.Clear();
                FillCB.Text = "";
                ModelLbl.Visible = false;
                PrintBtn.Visible = false;
                TechIDLbl.Visible = false;
                FillLocation();
            }
            if (TypeCB.Text == "Model")
            {
                SerialTB.Visible = false;
                FillCB.Visible = true;
                FillCB.Items.Clear();
                SerialTB.Clear();
                FillCB.Text = "";
                ModelLbl.Visible = false;
                PrintBtn.Visible = false;
                TechIDLbl.Visible = false;
                FillModel();
            }
        }

        #endregion

        private void PrintLabels_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            main.AcceptButton = PrintBtn;
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if (Settings.Default.DymoPrinterEnabled == "False")
            {
                if (myFunc.testForLabelWriter() == true)
                {
                    Settings.Default.DymoPrinterEnabled = "True";
                }
                else
                {
                    Settings.Default.DymoPrinterEnabled = "False";
                    MessageBox.Show("Dymo Printer Not Connected!");
                    return;
                }
                
            }
            //Cannot do else, as if its false and gets set to true it will not auto print the button would have to be clicked again.
            // Hints no else.
            if (Settings.Default.DymoPrinterEnabled == "True")
            {
                if (TypeCB.Text == "Serial Number")
                {
                    if (SerialTB.TextLength == 7)
                    {
                        //myFunc.PrintBarcode(SerialTB.Text);
                        myFunc.PrintBarcode(SerialTB.Text);
                        SerialTB.Clear();
                        SerialTB.Focus();
                        main.AcceptButton = PrintBtn;
                    }
                    else if(SerialTB.TextLength == 12)
                    {
                        myFunc.PrintSeperationBarcode(SerialTB.Text);
                        SerialTB.Clear();
                        SerialTB.Focus();
                        main.AcceptButton = PrintBtn;
                    }
                }
                if (TypeCB.Text == "TechID")
                {
                    myFunc.printTechBarcode(FillCB.Text, TechIDLbl.Text);
                }
                if (TypeCB.Text == "Location")
                {
                    MessageBox.Show("Not Setup");
                }
                if (TypeCB.Text == "Model")
                {
                    myFunc.printModelBarcode(FillCB.Text);
                }
            }
        }

        private void SerialTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                PrintBtn.PerformClick();
            }
        }
    }
}
