using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Remote_Control
{
    public partial class LightsPanel : UserControl
    {
        public static LightsPanel _instance;
        public static LightsPanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LightsPanel();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }

        string serialNum = null;

        //  Update DB on disconnecting
        void UpdateTable()
        {
            string sn = serialNum;
            string sqlQuery = "UPDATE Lights SET brightness = '"+ BrightnessValue.Text +"' WHERE sn = '"+ Device.serialNum +"' ";
            DataAccess.ExecuteSQL(sqlQuery);
            DataAccess.ConnectionClose();
        }

        public LightsPanel()
        {
            InitializeComponent();
        }

        public void LightsPanel_Load(object sender, EventArgs e)
        {
            BrightnessValue.Text = TableFill.brightness;
            nameLights.Text = TableFill.name;
            modelLights.Text = TableFill.model;
            DevConnected.Text = TableFill.inUse;
            serialNum = TableFill.sn;

            SwitchPanel.activePnl = true;
            Device.Naziv = Instance.Name;
        }

        private void LabelOnOff_Click(object sender, EventArgs e)
        {
            if (LabelOnOff.Text == "ON")
            {
                LabelOnOff.Text = "OFF";
                LabelOnOff.Left = 32;
                LabelOnOff.BackColor = Color.Red;
                OnOff.BorderColor = Color.Red;
                OnOff.FillColor = Color.Red;
            }
            else
            {
                LabelOnOff.Text = "ON";
                LabelOnOff.Left = 36;
                LabelOnOff.BackColor = Color.FromArgb(255,0,192,0);
                OnOff.BorderColor = Color.FromArgb(255, 0, 192, 0);
                OnOff.FillColor = Color.FromArgb(255, 0, 192, 0);
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            int Brightness = Int32.Parse(BrightnessValue.Text);
            if (Brightness > 0)
            {
                Brightness--;
                BrightnessValue.Text = Convert.ToString(Brightness);
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            int Brightness = Int32.Parse(BrightnessValue.Text);
            if(Brightness < 10)
            {
                Brightness++;
                BrightnessValue.Text = Convert.ToString(Brightness);
            }
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            UpdateTable();
            Instance.Hide();
            MessageBox.Show("Device was properly disconnected.");
            SwitchPanel.activePnl = false;
            MainForm.current();
        }
    }
}
