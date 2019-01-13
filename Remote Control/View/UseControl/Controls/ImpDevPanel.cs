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
    public partial class ImpDevPanel : UserControl
    {
        public static ImpDevPanel _instance;
        public static ImpDevPanel Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ImpDevPanel();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }

        public ImpDevPanel()
        {
            InitializeComponent();
        }

        //  BringToFront Panel za podizanje ImpPropPanela
        public static void BtfPanel()
        {
            if (!Instance.Controls.Contains(ImpPropPanel.Instance))
            {
                Instance.Controls.Add(ImpPropPanel.Instance);
                ImpPropPanel.Instance.Dock = DockStyle.Fill;
                ImpPropPanel.Instance.BringToFront();
            }
            else
            {
                ImpPropPanel.Instance.BringToFront();
                ImpPropPanel.Instance.Show();
            }
            ImpPropPanel.Instance.cbType.Enabled = false;
            MainForm.Instance.listPanel.Add(MainForm.Instance.lastPnl);
        }

        public static void QuickBtfPanel()
        {
            BtfPanel();
            ImpPropPanel.Instance.cbType.Enabled = true ;
        }

        private void PicLight_Click(object sender, EventArgs e)
        {
            BtfPanel();
            ImpPropPanel.Instance.cbType.Text = "Lights";
        }

        private void picTV_Click(object sender, EventArgs e)
        {
            BtfPanel();
            ImpPropPanel.Instance.cbType.Text = "TV";
        }

        private void picAC_Click(object sender, EventArgs e)
        {
            BtfPanel();
            ImpPropPanel.Instance.cbType.Text = "Air Conditioner";
            
        }

        private void picWH_Click(object sender, EventArgs e)
        {
            BtfPanel();
            ImpPropPanel.Instance.cbType.Text = "Water Heater";
        }

        private void picWM_Click(object sender, EventArgs e)
        {

            BtfPanel();
            ImpPropPanel.Instance.cbType.Text = "Washing Machine";
        }

        private void picDW_Click(object sender, EventArgs e)
        {
            BtfPanel();
            ImpPropPanel.Instance.cbType.Text = "Dishwasher";
        }

        private void picStove_Click(object sender, EventArgs e)
        {
            BtfPanel();
            ImpPropPanel.Instance.cbType.Text = "Stove";
        }

        private void picRefri_Click(object sender, EventArgs e)
        {
            BtfPanel();
            ImpPropPanel.Instance.cbType.Text = "Refrigerator";
            
        }
    }
}
