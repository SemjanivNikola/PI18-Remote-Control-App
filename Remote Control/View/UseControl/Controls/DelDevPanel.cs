using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_Control
{
    public partial class DelDevPanel : UserControl
    {
        public static DelDevPanel _instance;
        public static DelDevPanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DelDevPanel();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }

        public DelDevPanel()
        {
            InitializeComponent();
        }

        public static void ListPanel()
        {
            if (!Instance.Controls.Contains(ListDevPanel.Instance))
            {
                Instance.Controls.Add(ListDevPanel.Instance);
                ListDevPanel.Instance.Dock = DockStyle.Fill;
                ListDevPanel.Instance.BringToFront();
                ListDevPanel.Instance.Show();
            }
            else
            {
                ListDevPanel.Instance.BringToFront();
                ListDevPanel.Instance.Show();
            }

        }

        private void picLight_Click(object sender, EventArgs e)
        {
            ListPanel();
            ListDevPanel.Instance.cbType.Text = "Lights";
            string sqlQuery = " SELECT * FROM Lights_view";
            ListDevPanel.Instance.listTable.DataSource = DataAccess.GetDataTableView(sqlQuery);
        }

        private void picTV_Click(object sender, EventArgs e)
        {
            ListPanel();
            ListDevPanel.Instance.cbType.Text = "TV";
            string sqlQuery = " SELECT * FROM TV_view";
            ListDevPanel.Instance.listTable.DataSource = DataAccess.GetDataTableView(sqlQuery);
        }

        private void picAC_Click(object sender, EventArgs e)
        {
            ListPanel();
            ListDevPanel.Instance.cbType.Text = "Air Conditioner";
            string sqlQuery = " SELECT * FROM AirCon_view";
            ListDevPanel.Instance.listTable.DataSource = DataAccess.GetDataTableView(sqlQuery);
        }

        private void picWH_Click(object sender, EventArgs e)
        {
            ListPanel();
            ListDevPanel.Instance.cbType.Text = "Water Heater";
            string sqlQuery = " SELECT * FROM WtrHtr_view";
            ListDevPanel.Instance.listTable.DataSource = DataAccess.GetDataTableView(sqlQuery);
        }

        private void picWM_Click(object sender, EventArgs e)
        {
            ListPanel();
            ListDevPanel.Instance.cbType.Text = "Washing Machine";
            string sqlQuery = " SELECT * FROM WasMachine_view";
            ListDevPanel.Instance.listTable.DataSource = DataAccess.GetDataTableView(sqlQuery);
        }

        private void picDW_Click(object sender, EventArgs e)
        {
            ListPanel();
            ListDevPanel.Instance.cbType.Text = "Dishwasher";
            string sqlQuery = " SELECT * FROM Dishwasher_view";
            ListDevPanel.Instance.listTable.DataSource = DataAccess.GetDataTableView(sqlQuery);
        }

        private void picStove_Click(object sender, EventArgs e)
        {
            ListPanel();
            ListDevPanel.Instance.cbType.Text = "Stove";
            string sqlQuery = " SELECT * FROM Stove_view";
            ListDevPanel.Instance.listTable.DataSource = DataAccess.GetDataTableView(sqlQuery);
        }

        private void picRefri_Click(object sender, EventArgs e)
        {
            ListPanel();
            ListDevPanel.Instance.cbType.Text = "Refrigerator";
            string sqlQuery = " SELECT * FROM Refrigerator_view";
            ListDevPanel.Instance.listTable.DataSource = DataAccess.GetDataTableView(sqlQuery);
        }
    }
}
