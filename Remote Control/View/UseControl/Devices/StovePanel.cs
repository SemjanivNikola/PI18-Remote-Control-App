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
    public partial class StovePanel : UserControl
    {
        public static StovePanel _instance;
        public static StovePanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StovePanel();
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
        private bool tempUp = true;
        int plate = 0;

        //  Timer in_use
        int sec = 0;
        int min = 0;
        int hr = 0;

        //  Countdown Off timer
        int Tsec = 60;
        int Tmin = 0;
        bool inProgress = false;

        //------------  Kraj bloka  ------------//
        //-------------------------------------//

        public StovePanel()
        {
            InitializeComponent();

            // Timer Combo Box - cita description u padajuci izbornik
            cbTimer.DisplayMember = "Description";
            cbTimer.ValueMember = "Value";
            cbTimer.DataSource = Enum.GetValues(typeof(ClassLibrary.Klase.Enumeracija.TimerPecnica))
                .Cast<Enum>().Select(
                    value => new
                    {
                        (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                        value
                    }).OrderBy(item => item.value).ToList();

            // Stove Combo Box
            cbTempStove.DisplayMember = "Description";
            cbTempStove.ValueMember = "Value";
            cbTempStove.DataSource = Enum.GetValues(typeof(ClassLibrary.Klase.Enumeracija.TemperaturaPecnica))
                .Cast<Enum>().Select(
                    value => new
                    {
                        (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                        value
                    }).OrderBy(item => item.value).ToList();
        }
        public void StovePanel_Load(object sender, EventArgs e)
        {
            PlateValue1.Text = TableFill.p1Temp;
            PlateValue2.Text = TableFill.p2Temp;
            PlateValue3.Text = TableFill.p3Temp;
            PlateValue4.Text = TableFill.p4Temp;
            PlateValue5.Text = TableFill.p5Temp;
            nameStove.Text = TableFill.name;
            modelStove.Text = TableFill.model;
            DevConnected.Text = TableFill.inUse;
            serialNum = TableFill.sn;

            PanelFunction.activePnl = true;
            Device.Naziv = nameStove.Text;
        }

        //------------------------------------------------------//
        //------------  Update DB on disconnecting ------------//
        void UpdateTable()
        {
            string sn = serialNum;
            string sqlQuery = "UPDATE Stove SET p1Temp = '" + PlateValue1.Text + "', p2Temp = '" + PlateValue2.Text + "', p3Temp = '" + PlateValue3.Text + "', p4Temp = '" + PlateValue4.Text + "', p5Temp = '" + PlateValue5.Text +"'  WHERE sn = '" + Device.serialNum + "' ";
            DataAccess.ExecuteSQL(sqlQuery);
            DataAccess.ConnectionClose();
        }
        //------------  Kraj bloka  ------------//
        //-------------------------------------//

        //------------------------------------//
        //----------    Metoda      ---------//
        private void TmpChange(TextBox tbPlate)
        {
            plate = int.Parse(tbPlate.Text);
            if (tempUp == true)
            {
                plate++;
                tbPlate.Text = Convert.ToString(plate);
            }
            else if (tempUp == false)
            {
                plate--;
                tbPlate.Text = Convert.ToString(plate);
            }
        }

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
            if (Device.CheckOnOff() == true && inProgress == true)
            {
                Tsec--;
                timerTick.Text = Tmin + " : " + ((Tsec % 60) >= 10 ? (Tsec % 60).ToString() : "0" + (Tsec % 60));

                if (Tsec < 1)
                {
                    Tsec = 60;
                    Tmin--;
                }
                if (Tmin < 0)
                    timer2.Stop();
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
        //---------------    Button     ---------------------//

        private void Minus1_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                tempUp = false;
                TmpChange(PlateValue1);
            }
        }
        private void Plus1_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                tempUp = true;
                TmpChange(PlateValue1);
            }
        }
        private void Minus2_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                tempUp = false;
                TmpChange(PlateValue2);
            }
        }
        private void Plus2_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                tempUp = true;
                TmpChange(PlateValue2);
            }
        }
        private void Minus3_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                tempUp = false;
                TmpChange(PlateValue3);
            }
        }
        private void Plus3_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                tempUp = true;
                TmpChange(PlateValue3);
            }
        }
        private void Minus4_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                tempUp = false;
                TmpChange(PlateValue4);
            }
        }
        private void Plus4_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                tempUp = true;
                TmpChange(PlateValue4);
            }
        }
        private void Minus5_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                tempUp = false;
                TmpChange(PlateValue5);
            }
        }
        private void Plus5_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                tempUp = true;
                TmpChange(PlateValue5);
            }
        }
        private void startStopbtn_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                if (inProgress == false)
                {
                    Tmin = int.Parse(cbTimer.Text);
                    timer2.Start();
                    startStopbtn.BackgroundImage = Properties.Resources.stop;
                    inProgress = true;
                }
                else
                {
                    timer2.Stop();
                    startStopbtn.BackgroundImage = Properties.Resources.start;
                    inProgress = false;
                }
                Tmin--;
            }
        }
        private void cbTimer_TextChanged(object sender, EventArgs e)
        {
            if(inProgress == true)
            {
                timer2.Stop();
                timerTick.Text = "";
                startStopbtn.BackgroundImage = Properties.Resources.start;
                inProgress = false;
            }
        }
        private void cbTempStove_TextChanged(object sender, EventArgs e)
        {
            lblTemp.Text = cbTempStove.Text;
        }

        //-------------------------     Kraj bloka      -------------------------//
        //----------------------------------------------------------------------//

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            timerTick.Text = "";
            UpdateTable();
            Instance.Hide();
            MessageBox.Show("Device was properly disconnected.");
            PanelFunction.activePnl = false;
            Device.favorit = false;
        }
    }
}
