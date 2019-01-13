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
    public partial class WasMachinePanel : UserControl
    {
        public static WasMachinePanel _instance;
        public static WasMachinePanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WasMachinePanel();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }

        public WasMachinePanel()
        {
            InitializeComponent();
        }

        private void WasMachinePanel_Load(object sender, EventArgs e)
        {
            nameWM.Text = TableFill.name;
            modelWM.Text = TableFill.model;
            DevConnected.Text = TableFill.inUse;
        }

        private void StovePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void TimerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
