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
    public partial class AirConPanel : UserControl
    {
        public static AirConPanel _instance;
        public static AirConPanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AirConPanel();
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

        private string serialNum = null;

        //  Timer in_use
        int sec = 0;
        int min = 0;
        int hr = 0;
        
        // Timer
        int Tsec = 60;
        int Tmin = 0;
        bool inProgress = false;
        bool StartinProgress = false;

        //------------  Kraj bloka  ------------//
        //-------------------------------------//

        public AirConPanel()
        {
            InitializeComponent();
        }
        public void AirCondPanel_Load(object sender, EventArgs e)
        {
            TemperatureValue.Text = TableFill.temp;
            FanValue.Text = TableFill.fan_speed;
            nameAirCon.Text = TableFill.name;
            modelAirCon.Text = TableFill.model;
            DevConnected.Text = TableFill.inUse;
            serialNum = TableFill.sn;

            PanelFunction.activePnl = true;
            Device.Naziv = nameAirCon.Text;
        }

        //------------------------------------------------------//
        //------------  Update DB on disconnecting ------------//
        void UpdateTable()
        {
            string sn = serialNum;
            string sqlQuery = "UPDATE AirCon SET temp = '" + TemperatureValue.Text + "', fan_speed = '" + FanValue.Text + "' WHERE sn = '" + Device.serialNum + "' ";
            DataAccess.ExecuteSQL(sqlQuery);
            DataAccess.ConnectionClose();
        }
        //------------  Kraj bloka  ------------//
        //-------------------------------------//


        //-------------------------------------//
        //----------    Tajmeri     ----------//

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
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                if(inProgress == true)
                {
                    Tsec--;
                    timerTick.Text = Tmin + " : " + ((Tsec % 60) >= 10 ? (Tsec % 60).ToString() : "0" + (Tsec % 60));

                    if (Tsec < 1)
                    {
                        Tsec = 60;
                        Tmin--;
                    }
                    if (Tmin < 0)
                    {
                        timer2.Stop();
                        OnOff.BackgroundImage = Properties.Resources.on;
                        startStopbtn.BackgroundImage = Properties.Resources.start;
                        Device.On = false;
                        MessageBox.Show("Device is turned off.");
                    }
                }
                else
                {
                    Tsec--;
                    lblStart.Text = Tmin + " : " + ((Tsec % 60) >= 10 ? (Tsec % 60).ToString() : "0" + (Tsec % 60));

                    if (Tsec < 1)
                    {
                        Tsec = 60;
                        Tmin--;
                    }
                    if (Tmin < 0)
                    {
                        timer2.Stop();
                        OnOff.BackgroundImage = Properties.Resources.off;
                        startStopbtn.BackgroundImage = Properties.Resources.start;
                        Device.On = true;
                        MessageBox.Show("Device is turned on.");
                    }
                }
            }
        }

        //----------    Kraj bloka     ----------//
        //--------------------------------------//

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
                timer2.Stop();
                OnOff.BackgroundImage = Properties.Resources.off;
                Device.On = false;
            }
        }

        //----------------------------------------------------//
        //---------------    Buttons     --------------------//

        private void startStopbtn_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                if (StartinProgress == false && inProgress == false)
                {
                    if (cbOffTimer.Text.Equals("") || cbOffTimer.Text.Equals("None"))
                        return;
                    else
                    {
                        Tmin = int.Parse(cbStart.Text);
                        Tmin--;
                        timer2.Start();
                        startStopbtn.BackgroundImage = Properties.Resources.stop;
                        OnOff.BackgroundImage = Properties.Resources.off;
                        inProgress = true;
                    }
                }
                else
                {
                    timer2.Stop();
                    startStopbtn.BackgroundImage = Properties.Resources.start;
                    inProgress = false;
                }
            }
        }
        private void timerBtnStartStop_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                if (inProgress == false && StartinProgress == false)
                {
                    if (cbOffTimer.Text.Equals("") || cbOffTimer.Text.Equals("None"))
                        return;
                    else
                    {
                        Tmin = int.Parse(cbStart.Text);
                        Tmin--;
                        timer2.Start();
                        startStopbtn.BackgroundImage = Properties.Resources.stop;
                        OnOff.BackgroundImage = Properties.Resources.off;
                        inProgress = true;
                    }
                }
                else
                {
                    timer2.Stop();
                    timerBtnStartStop.BackgroundImage = Properties.Resources.start;
                    inProgress = false;
                }
            }
        }
        private void Minus1_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                int Temperature = Int32.Parse(TemperatureValue.Text);
                if (Temperature > 0)
                {
                    Temperature--;
                    TemperatureValue.Text = Convert.ToString(Temperature);
                }
            }
        }
        private void Plus1_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                int Temperature = Int32.Parse(TemperatureValue.Text);
                if (Temperature < 10)
                {
                    Temperature++;
                    TemperatureValue.Text = Convert.ToString(Temperature);
                }
            }
        }
        private void Minus2_Click(object sender, EventArgs e)
        {
            int Fan = Int32.Parse(FanValue.Text);
            if (Fan > 0)
            {
                Fan--;
                FanValue.Text = Convert.ToString(Fan);
            }
        }
        private void Plus2_Click(object sender, EventArgs e)
        {
            int Fan = Int32.Parse(FanValue.Text);
            if (Fan < 4)
            {
                Fan++;
                FanValue.Text = Convert.ToString(Fan);
            }
        }

        //-------------------------     Kraj bloka      -------------------------//
        //----------------------------------------------------------------------//


        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            UpdateTable();
            Instance.Hide();
            MessageBox.Show("Device was properly disconnected.");
            PanelFunction.activePnl = false;
        }
    }
}
