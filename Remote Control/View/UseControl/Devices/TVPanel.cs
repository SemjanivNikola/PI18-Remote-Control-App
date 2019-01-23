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
    public partial class TVPanel : UserControl
    {
        public static TVPanel _instance;
        public static TVPanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TVPanel();
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
        
        int currVolLineWidth = 1;

        //  Countdown Off timer
        int Tsec = 60;
        int Tmin = 0;
        bool inProgress = false;

        //------------  Kraj bloka  ------------//
        //-------------------------------------//

        public TVPanel()
        {
            InitializeComponent();
        }
        public void TVPanel_Load(object sender, EventArgs e)
        {
            lblCurrVol.Text = TableFill.vol;
            tbChannel.Text = TableFill.program;
            nameTV.Text = TableFill.name;
            modelTV.Text = TableFill.model;
            DevConnected.Text = TableFill.inUse;
            serialNum = TableFill.sn;

            currVolLineWidth = int.Parse(lblCurrVol.Text);
            currVolLineWidth *= 3;
            currVolLine.Size = new Size(currVolLineWidth, 28);

            PanelFunction.activePnl = true;
            Device.Naziv = nameTV.Text;
        }
        
        //------------------------------------------------------//
        //------------  Update DB on disconnecting ------------//
        void UpdateTable()
        {
            string sn = serialNum;
            string sqlQuery = "UPDATE TV SET  vol = '" + lblCurrVol.Text + "', program = '" + tbChannel.Text + "' WHERE sn = '" + Device.serialNum + "' ";
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
                    Device.On = false;
                    MessageBox.Show("Device is turned off.");
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

        private void pbMute_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                if (TV.MuteMet() == true)
                {
                    pbMute.Image = Properties.Resources.muted;
                    muteDisplay.FillColor = Color.Red;
                }
                else
                {
                    pbMute.Image = Properties.Resources.volume;
                    muteDisplay.FillColor = Color.Lime;
                }
            }
        }
        private void Minus1_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                TV.currentState = int.Parse(tbChannel.Text);
                if (TV.currentState > 0)
                {
                    TV.currentState--;
                    tbChannel.Text = TV.currentState--.ToString();
                }
            }
        }
        private void Plus1_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                TV.currentState = int.Parse(tbChannel.Text);
                if (TV.currentState < 80)
                {
                    TV.currentState++;
                    tbChannel.Text = TV.currentState.ToString();
                }
            }
        }
        private void Minus2_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                TV.currentState = int.Parse(lblCurrVol.Text);
                if (TV.currentState > 0)
                {
                    TV.currentState--;
                    lblCurrVol.Text = TV.currentState.ToString();
                    currVolLineWidth -= 3;
                    currVolLine.Size = new Size(currVolLineWidth, 28);
                }
            }
        }
        private void Plus2_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                TV.currentState = int.Parse(lblCurrVol.Text);
                if (TV.currentState < 68)
                {
                    TV.currentState++;
                    lblCurrVol.Text = TV.currentState.ToString();
                    currVolLineWidth += 3;
                    currVolLine.Size = new Size(currVolLineWidth, 28);
                }
            }
        }
        private void startStopbtn_Click(object sender, EventArgs e)
        {
            if(Device.CheckOnOff() == true)
            {
                if (inProgress == false)
                {
                    if(cbOffTimer.Text.Equals("") || cbOffTimer.Text.Equals("None"))
                        return;
                    else
                    {
                        Tmin = int.Parse(cbOffTimer.Text);
                        Tmin--;
                        timer2.Start();
                        startStopbtn.BackgroundImage = Properties.Resources.stop;
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

        //-------------------------     Kraj bloka      -------------------------//
        //----------------------------------------------------------------------//

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            UpdateTable();
            Instance.Hide();
            MessageBox.Show("Device was properly disconnected.");
            PanelFunction.activePnl = false;
            Device.On = false;
        }
    }
}