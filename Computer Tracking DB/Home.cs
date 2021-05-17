using System;
using System.Windows.Forms;

namespace ComputerTrackingDB
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

        }
    }
}
