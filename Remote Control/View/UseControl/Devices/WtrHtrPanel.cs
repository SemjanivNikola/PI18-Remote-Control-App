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
    public partial class WtrHtrPanel : UserControl
    {
        public static WtrHtrPanel _instance;
        public static WtrHtrPanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WtrHtrPanel();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }

        public WtrHtrPanel()
        {
            InitializeComponent();
        }

        private void WaterHeaterPanel_Load(object sender, EventArgs e)
        {
            nameWH.Text = TableFill.name;
            modelWH.Text = TableFill.model;
            DevConnected.Text = TableFill.inUse;
        }

        private void Plate1_Click(object sender, EventArgs e)
        {

        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
