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
    public partial class RefrigeratorPanel : UserControl
    {
        public static RefrigeratorPanel _instance;
        public static RefrigeratorPanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RefrigeratorPanel();
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

        public RefrigeratorPanel()
        {
            InitializeComponent();
        }
        public void RefriPanel_Load(object sender, EventArgs e)
        {
            TempValue.Text = TableFill.temp;
            nameRefri.Text = TableFill.name;
            modelRefri.Text = TableFill.model;
            DevConnected.Text = TableFill.inUse;
            serialNum = TableFill.sn;

            PanelFunction.activePnl = true;
            Device.Naziv = nameRefri.Text;
        }

        //------------------------------------------------------//
        //------------  Update DB on disconnecting ------------//
        void UpdateTable()
        {
            string sn = serialNum;
            string sqlQuery = "UPDATE Refrigerator SET temp = '" + TempValue.Text + "' WHERE sn = '" + Device.serialNum + "' ";
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

        //------------------------------------------//
        //----------------  Event   ---------------//
        private void Rtb_TextChanged(object sender, EventArgs e)
        {
            Rtb.SelectionStart = Rtb.Text.Length;
            Rtb.ScrollToCaret();
        }

        //----------------------------------------------------//
        //---------------    Buttons     --------------------//

        private void Minus_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                int Temperature = Int32.Parse(TempValue.Text);
                if (Temperature > -10)
                {
                    Temperature--;
                    TempValue.Text = Convert.ToString(Temperature);
                }
            }
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                int Temperature = Int32.Parse(TempValue.Text);
                if (Temperature < 10)
                {
                    Temperature++;
                    TempValue.Text = Convert.ToString(Temperature);
                }
            }
        }
        private void DispenseIce_Click(object sender, EventArgs e)
        {
            if (Device.CheckOnOff() == true)
            {
                if (CubedIce.Checked || CrushedIce.Checked)
                {
                    Rtb.Text = "Ice dispensed";
                    CubedIce.Checked = false;
                    CrushedIce.Checked = false;
                }
            }
        }
        private void DispenceWater_Click(object sender, EventArgs e)
        {
            if(Device.CheckOnOff() == true)
                Rtb.Text = "Water is dispenced.";
        }

        //-------------------------     Kraj bloka      -------------------------//
        //----------------------------------------------------------------------//

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
