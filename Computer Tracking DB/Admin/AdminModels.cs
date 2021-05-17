using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using ComputerTrackingDB.Properties;
using System.Data.SqlClient;

namespace ComputerTrackingDB
{
    public partial class AdminModels : UserControl
    {
        #region Models
        public AdminModels()
        {
            InitializeComponent();
        }

        CTDBFunctions myFunc = new CTDBFunctions();

        private void AdminModels_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            GetModels();
        }

        #endregion

        #region Other Functions
        private void GetModels()
        {
            string conn_string = Settings.Default.DBConnection;
            string q = "";
            q = "USE ComputerTrackingDB ";
            q += "SELECT Model ";
            q += "FROM Computers_Models ";
            q += "ORDER BY Model ";
            SqlConnection myConn;
            myConn = new SqlConnection(conn_string);
            SqlCommand cmd = new SqlCommand(q, myConn);
            myConn.Open();
            SqlDataReader dbReader = cmd.ExecuteReader();
            string itemToAdd;

            while (dbReader.Read())
            {
                itemToAdd = dbReader.GetString(0);
                ModelCB.Items.Add(itemToAdd);
            }
            myConn.Close();
            int ItemsNumber = ModelCB.Items.Count;
            ModelCB.Items.Insert(ItemsNumber, "New...");
        }

        private void MoveOriginal()
        {
            NewModelTB.Visible = false;
            Modellbl.Visible = false;
            TypeTB.Location = new Point(ModelCB.Location.X, ModelCB.Location.Y + 40);
            ModelTypelbl.Location = new Point(ModelCB.Location.X - 120, ModelCB.Location.Y + 40);
            ActiveCB.Location = new Point(TypeTB.Location.X, TypeTB.Location.Y + 40);
            Update.Location = new Point(ActiveCB.Location.X, ActiveCB.Location.Y + 35);
            Savedlbl.Location = new Point(Update.Location.X, Update.Location.Y + 40);
        }

        private void MoveNew()
        {
            NewModelTB.Visible = true;
            Modellbl.Visible = true;
            NewModelTB.Location = new Point(ModelCB.Location.X, ModelCB.Location.Y + 40);
            Modellbl.Location = new Point(ModelCB.Location.X - 78, ModelCB.Location.Y + 40);
            TypeTB.Location = new Point(NewModelTB.Location.X, NewModelTB.Location.Y + 40);
            ModelTypelbl.Location = new Point(NewModelTB.Location.X - 120, NewModelTB.Location.Y + 40);
            ActiveCB.Location = new Point(TypeTB.Location.X, TypeTB.Location.Y + 40);
            Update.Location = new Point(ActiveCB.Location.X, ActiveCB.Location.Y + 35);
            Savedlbl.Location = new Point(Update.Location.X, Update.Location.Y + 40);
        }

        #endregion

        #region ComboBox
        private void ModelCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewModelTB.Clear();
            TypeTB.Clear();
            ActiveCB.Checked = false;
            Savedlbl.Visible = false;
            if (ModelCB.Text == "New...")
            {
                MoveNew();
            }
            else
            {
                MoveOriginal();
                ActiveCB.Checked = myFunc.checkmodelactive(ModelCB.Text);
                TypeTB.Text = myFunc.getModelType(ModelCB.Text);
            }
        }

        #endregion

        #region Buttons
        private void Update_Click(object sender, EventArgs e)
        {
            if (ModelCB.Text == "New...")
            {
                #region Check Model Exsists
                if(myFunc.checkModelExists(NewModelTB.Text) == true)
                {
                    MessageBox.Show("Model already exsists.");
                    return;
                }
                #endregion

                #region SQL Add Admin Transaction

                try
                {
                    string conn_string = Settings.Default.DBConnection;
                    string ModifierName = Settings.Default.TechName;
                    string Date = DateTime.Now.ToShortDateString();
                    string NewModel = NewModelTB.Text;
                    string Type = "New Model";

                    SqlConnection myConn = new SqlConnection(conn_string);

                    string q = "USE ComputerTrackingDB ";
                    q += "INSERT INTO Admin_Transaction ";
                    q += "(TechName, Transaction_Date, Modified, Type) ";
                    q += "Values (@ModifierName, @Date, @NewModel, @Type) ";

                    SqlCommand cmd = new SqlCommand(q, myConn);
                    cmd.Parameters.AddWithValue("@ModifierName", ModifierName);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@NewModel", NewModel);
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

                #region SQL Add New Model
                try
                {
                    string Model = NewModelTB.Text;
                    string ModelType = TypeTB.Text;
                    bool ModelActive = ActiveCB.Checked;

                    string q = "USE ComputerTrackingDB ";
                    q += "INSERT INTO Computers_Models (Model, Type, Active) ";
                    q += "VALUES (@Model, @ModelType, @ModelActive) ";

                    string conn_string = Settings.Default.DBConnection;
                    SqlConnection myConn = new SqlConnection(conn_string);
                    SqlCommand cmd = new SqlCommand(q, myConn);
                    cmd.Parameters.AddWithValue("@Model", Model);
                    cmd.Parameters.AddWithValue("@ModelType", ModelType);
                    cmd.Parameters.AddWithValue("@ModelActive", ModelActive);
                    myConn.Open();
                    cmd.CommandText = q;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                    Savedlbl.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Failed to add new model.");
                    return;
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
                    string ModelModified = ModelCB.Text;
                    string Type = "Model";

                    SqlConnection myConn = new SqlConnection(conn_string);

                    string q = "USE ComputerTrackingDB ";
                    q += "INSERT INTO Admin_Transaction ";
                    q += "(TechName, Transaction_Date, Modified, Type) ";
                    q += "Values (@ModifierName, @Date, @ModelModified, @Type) ";

                    SqlCommand cmd = new SqlCommand(q, myConn);
                    cmd.Parameters.AddWithValue("@ModifierName", ModifierName);
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@ModelModified", ModelModified);
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

                #region SQL New Model
                try
                {
                    string Model = ModelCB.Text;
                    string ModelType = TypeTB.Text;
                    bool ModelActive = ActiveCB.Checked;

                    string q = "USE ComputerTrackingDB ";
                    q += "UPDATE Computers_Models ";
                    q += "SET Type = @ModelType, Active = @ModelActive ";
                    q += "WHERE Model = @Model";

                    string conn_string = Settings.Default.DBConnection;
                    SqlConnection myConn = new SqlConnection(conn_string);
                    SqlCommand cmd = new SqlCommand(q, myConn);
                    cmd.Parameters.AddWithValue("@Model", Model);
                    cmd.Parameters.AddWithValue("@ModelType", ModelType);
                    cmd.Parameters.AddWithValue("@ModelActive", ModelActive);
                    myConn.Open();
                    cmd.CommandText = q;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    myConn.Close();
                    Savedlbl.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Failed to update model.");
                    return;
                }
                #endregion
            }
        }

        #endregion
    }
}
