using System;
using System.Windows.Forms;
using ComputerTrackingDB.Properties;

namespace ComputerTrackingDB
{
    public partial class AuditMode : UserControl
    {
        public AuditMode()
        {
            InitializeComponent();
        }

        private void AuditMode_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            AuditModeActivedByLbl.Text = Settings.Default.AuditModeActivatedBy;
        }
    }
}
