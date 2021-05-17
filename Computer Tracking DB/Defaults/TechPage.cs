using System;
using System.Windows.Forms;
using ComputerTrackingDB.Properties;

namespace ComputerTrackingDB
{
    public partial class TechPage : UserControl
    {
        #region TechPage
        public TechPage()
        {
            InitializeComponent();
        }

        Main main = new Main();

        private void TechPage_Load(object sender, EventArgs e)
        {
            string TechNameWWID = Settings.Default.TechName + " (" + Settings.Default.CurrentUser.ToUpper() + ")";
            TPTechNamelbl.Text = TechNameWWID;
            TPTechTitlelbl.Text = Settings.Default.TechRole;
            TPTechIDlbl.Text = Settings.Default.TechID;
            this.Dock = DockStyle.Fill;
            GetTechPermissions();

        }

        #endregion

        #region Other Functions
        private void GetTechPermissions()
        {
            if (Settings.Default.Station == "True")
            {
                PermissionsList.Items.Add("Station");   
            }
            if (Settings.Default.Admin == "True")
            {
                PermissionsList.Items.Add("Admin");
            }
            if (Settings.Default.InventoryControl == "True")
            {
                PermissionsList.Items.Add("Audit");
            }
            if (Settings.Default.InventoryMove == "True")
            {
                PermissionsList.Items.Add("Move");
            }
            if (Settings.Default.InventoryNew == "True")
            {
                PermissionsList.Items.Add("New Inventory");
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
