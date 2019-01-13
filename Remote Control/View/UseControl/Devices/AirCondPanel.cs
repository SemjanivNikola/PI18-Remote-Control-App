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
    public partial class AirCondPanel : UserControl
    {
        public static AirCondPanel _instance;
        public static AirCondPanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AirCondPanel();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }

        private int hours;
        private int minutes;
        private int seconds;
        private int trig = 0;
        private string serialNum = null;

        //  Update DB on disconnecting
        void UpdateTable()
        {
            string sn = serialNum;
            string sqlQuery = "UPDATE AirCon SET temp = '" + TemperatureValue.Text + "', delay_start = '" + numericUpDown1 + "', fan_speed = '" + FanValue.Text + "' WHERE sn = '" + Device.serialNum + "' ";
            DataAccess.ExecuteSQL(sqlQuery);
            DataAccess.ConnectionClose();
        }

        public AirCondPanel()
        {
            InitializeComponent();
        }

        private void AirCondPanel_Load(object sender, EventArgs e)
        {
            TemperatureValue.Text = TableFill.temp;
            numericUpDown1.Value.ToString(TableFill.delay_start);
            FanValue.Text = TableFill.fan_speed;
            nameAirCon.Text = TableFill.name;
            modelAirCon.Text = TableFill.model;
            DevConnected.Text = TableFill.inUse;
            serialNum = TableFill.sn;

            SwitchPanel.activePnl = true;
            Device.Naziv = Instance.Name;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            hours = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            minutes = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
            seconds = Convert.ToInt32(Math.Round(numericUpDown3.Value, 0));

            label1.Text = hours.ToString();
            label2.Text = minutes.ToString();
            label3.Text = seconds.ToString();
            if (trig == 0)
            {
                timer1 = new Timer();
                timer1.Tick += new EventHandler(Timer1_Tick);
                timer1.Interval = 1000; // 1 second
                trig = 1;
            }
            timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            hours = 0;
            minutes = 0;
            seconds = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds <= 0)
            {
                if (minutes > 0 || hours > 0)
                {
                    if (minutes == 0)
                    {
                        if (hours >= 0)
                        {
                            hours = hours - 1;
                            minutes = 60;
                            if (hours < 0)
                            {
                                hours = 0;
                            }
                        }
                    }
                    minutes = minutes - 1;
                    seconds = 59;
                    timer1 = new Timer();
                    timer1.Interval = 1000;
                    timer1.Start();
                    label1.Text = hours.ToString();
                    label2.Text = minutes.ToString();
                    label3.Text = seconds.ToString();
                    if (minutes < 0)
                    {
                        minutes = 0;
                    }

                }
                if (seconds < 0)
                {
                    seconds = 0;
                }

                timer1.Stop();
            }
            label1.Text = hours.ToString();
            label2.Text = minutes.ToString();
            label3.Text = seconds.ToString();
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
                LabelOnOff.BackColor = Color.FromArgb(255, 0, 192, 0);
                OnOff.BorderColor = Color.FromArgb(255, 0, 192, 0);
                OnOff.FillColor = Color.FromArgb(255, 0, 192, 0);
            }
        }

        private void Minus1_Click(object sender, EventArgs e)
        {
            int Temperature = Int32.Parse(TemperatureValue.Text);
            if (Temperature > 0)
            {
                Temperature--;
                TemperatureValue.Text = Convert.ToString(Temperature);
            }
        }

        private void Plus1_Click(object sender, EventArgs e)
        {
            int Temperature = Int32.Parse(TemperatureValue.Text);
            if (Temperature < 10)
            {
                Temperature++;
                TemperatureValue.Text = Convert.ToString(Temperature);
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
            if (Fan < 10)
            {
                Fan++;
                FanValue.Text = Convert.ToString(Fan);
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
