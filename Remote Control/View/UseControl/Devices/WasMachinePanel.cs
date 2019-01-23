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

        //-----------------------------------------------//
        //------------  privatni atributi  -------------//

        private string serialNum = null;
        private int washingTime = 59;
        private int function = 0;

        //  Timer in_use
        int sec = 0;
        int min = 0;
        int hr = 0;

        //  Countdown Off timer
        int Tsec = 60;
        int Dmin = 0;
        int Tmin = 0;
        private bool inProgress = false;
        private bool StartinProgress = false;

        //------------  Kraj bloka  ------------//
        //-------------------------------------//

        public WasMachinePanel()
        {
            InitializeComponent();

            //Temperatura
            cbTemp.DisplayMember = "Description";
            cbTemp.ValueMember = "Value";
            cbTemp.DataSource = Enum.GetValues(typeof(ClassLibrary.Klase.Enumeracija.TemperaturaPranja))
                .Cast<Enum>().Select(
                    value => new
                    {
                        (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                        value
                    }).OrderBy(item => item.value).ToList();
        }
        public void WasMachinePanel_Load(object sender, EventArgs e)
        {
            nameWM.Text = TableFill.name;
            modelWM.Text = TableFill.model;
            DevConnected.Text = TableFill.inUse;
            serialNum = TableFill.sn;

            PanelFunction.activePnl = true;
            Device.Naziv = nameWM.Text;
        }

        //------------------------------------------------------//
        //------------  Update DB on disconnecting ------------//
        void UpdateTable()
        {
            string sn = serialNum;
            //string sqlQuery = "UPDATE WasMachine SET temp = '" + cbTemp.Text + "' WHERE sn = '" + Device.serialNum + "' ";
            //DataAccess.ExecuteSQL(sqlQuery);
            DataAccess.ConnectionClose();
        }
        //------------  Kraj bloka  ------------//
        //-------------------------------------//
        
        //-------------------------------------//
        //----------    Tajmeri     ----------//

        private void inUse_Tick(object sender, EventArgs e)
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
        private void delay_Tick(object sender, EventArgs e)
        {
            if (StartinProgress == true)
            {
                Tsec--;
                lblStart.Text = Dmin + " : " + ((Tsec % 60) >= 10 ? (Tsec % 60).ToString() : "0" + (Tsec % 60));

                if (Tsec < 1)
                {
                    Tsec = 60;
                    Dmin--;
                }
                if (Dmin < 0)
                {
                    delay.Stop();
                    StartinProgress = false;
                    inProgress = true;
                    Tmin = washingTime;
                    washing.Start();
                }
            }
        }
        private void washing_Tick(object sender, EventArgs e)
        {
            if (inProgress == true)
            {
                Tsec--;
                lblWashingTime.Text = Tmin + " : " + ((Tsec % 60) >= 10 ? (Tsec % 60).ToString() : "0" + (Tsec % 60));
                if (Tsec < 1)
                {
                    Tsec = 60;
                    Tmin--;
                }
                if (Tmin < 0)
                {
                    washing.Stop();
                    inProgress = false;
                    MessageBox.Show("Done!");
                    startStopbtn.BackgroundImage = Properties.Resources.start;
                    pauseBtn.BackgroundImage = Properties.Resources.pause;
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
                delay.Stop();
                washing.Stop();
                OnOff.BackgroundImage = Properties.Resources.off;
                Device.On = false;
            }
        }

        //----------------------------------------------------//
        //---------------    Buttons     --------------------//

        private void btnSetStop_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true && inProgress == false && StartinProgress == false)
            {
                if (cbStart.Text.Equals("") || cbStart.Text.Equals("None"))
                    Dmin = 0;
                else
                    Dmin = int.Parse(cbStart.Text);
                Dmin--;
            }
            else
                MessageBox.Show("Device is off or already working!\nWait until its done to set time again.");
        }
        //  Stopira program ako je u pranju, a ako je odgoda pranja onda pauzira vrijeme
        private void startStopbtn_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                if (Dmin > 0)
                {
                    if (StartinProgress == false)
                    {
                        StartinProgress = true;
                        delay.Start();
                        startStopbtn.BackgroundImage = Properties.Resources.stop;
                    }
                    else
                    {
                        StartinProgress = false;
                        delay.Stop();
                        startStopbtn.BackgroundImage = Properties.Resources.start;
                    }
                }
                else if (StartinProgress == false)
                {
                    if (inProgress == false)
                    {
                        inProgress = true;
                        Tmin = washingTime;
                        washing.Start();
                        startStopbtn.BackgroundImage = Properties.Resources.stop;
                    }
                    else
                    {
                        inProgress = false;
                        washing.Stop();
                        lblWashingTime.Text = "";
                        startStopbtn.BackgroundImage = Properties.Resources.start;
                    }
                }
            }
        }
        //  Pauza radi kada perilica vec krene prati
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true && StartinProgress == false)
            {
                if (inProgress == false)
                {
                    inProgress = true;
                    washing.Start();
                    pauseBtn.BackgroundImage = Properties.Resources.pause;
                }
                else
                {
                    inProgress = false;
                    washing.Stop();
                    pauseBtn.BackgroundImage = Properties.Resources.resume;
                }
            }
        }
        private void rbWhite_CheckedChanged(object sender, EventArgs e)
        {
            washingTime = 90;
            washingTime += function - 1;   
        }

        private void rbWool_CheckedChanged(object sender, EventArgs e)
        {
            washingTime = 120;
            washingTime += function - 1;
        }

        private void rbSnickers_CheckedChanged(object sender, EventArgs e)
        {
            washingTime = 45;
            washingTime += function - 1;
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            washingTime = 60;
            washingTime += function - 1;
        }

        private void rbJeans_CheckedChanged(object sender, EventArgs e)
        {
            washingTime = 120;
            washingTime += function - 1;
        }
        private void rbCentrifuga_CheckedChanged(object sender, EventArgs e)
        {
            function = 15;
            washingTime += function - 1;
        }
        private void rbWaterDown_CheckedChanged(object sender, EventArgs e)
        {
            function = 5;
            washingTime += function - 1;
        }
        private void rbRisen_CheckedChanged(object sender, EventArgs e)
        {
            function = 20;
            washingTime += function - 1;
        }
        private void cbTemp_TextChanged(object sender, EventArgs e)
        {
            lblTemp.Text = cbTemp.Text;
        }

        //-------------------------     Kraj bloka      -------------------------//
        //----------------------------------------------------------------------//


        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            lblWashingTime.Text = "";
            lblStart.Text = "";
            UpdateTable();
            Instance.Hide();
            MessageBox.Show("Device was properly disconnected.");
            PanelFunction.activePnl = false;
            Device.favorit = false;
        }
    }
}
