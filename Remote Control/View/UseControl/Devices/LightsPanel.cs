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

        //-----------------------------------------------//
        //------------  privatni atributi  -------------//

        int sec = 0;
        int min = 0;
        int hr = 0;

        string serialNum = null;

        //------------  Kraj bloka  ------------//
        //-------------------------------------//
        
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

            PanelFunction.activePnl = true;
            Device.Naziv = nameLights.Text;
        }

        //------------------------------------------------------//
        //------------  Update DB on disconnecting ------------//
        void UpdateTable()
        {
            string sn = serialNum;
            string sqlQuery = "UPDATE Lights SET brightness = '" + BrightnessValue.Text + "' WHERE sn = '" + Device.serialNum + "' ";
            DataAccess.ExecuteSQL(sqlQuery);
            DataAccess.ConnectionClose();
        }
        //------------  Kraj bloka  ------------//
        //-------------------------------------//

        //-------------------------------------//
        //----------    Tajmer     -----------//

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec > 59)
            {
                sec = 0;
                min++;
            }
            if (min > 59)
            {
                hr++;
                min = 0;
            }
            DevConnected.Text = ((hr % 60) >= 10 ? (hr % 60).ToString() : "0" + (hr % 60)) + " : " + ((min % 60) >= 10 ? (min % 60).ToString() : "0" + (min % 60)) + " : " + ((sec % 60) >= 10 ? (sec % 60).ToString() : "0" + (sec % 60));
        }

        //---------------------------------------//
        //------------  ON / OFF    ------------//
        private void OnOff_Click(object sender, EventArgs e)
        {
            if (Device.On == false)
            {
                OnOff.BackgroundImage = Properties.Resources.on;
                Device.On = true;
            }
            else
            {
                OnOff.BackgroundImage = Properties.Resources.off;
                Device.On = false;
            }
        }

        //----------------------------------------------------//
        //---------------    Buttons     --------------------//
        private void Minus_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                int Brightness = Int32.Parse(BrightnessValue.Text);
                if (Brightness > 0)
                {
                    Brightness--;
                    BrightnessValue.Text = Convert.ToString(Brightness);
                }
            }
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                int Brightness = Int32.Parse(BrightnessValue.Text);
                if (Brightness < 10)
                {
                    Brightness++;
                    BrightnessValue.Text = Convert.ToString(Brightness);
                }
            }
        }
        
        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            UpdateTable();
            Instance.Hide();
            MessageBox.Show("Device was properly disconnected.");
            PanelFunction.activePnl = false;
            Device.favorit = false;
        }
    }
}
