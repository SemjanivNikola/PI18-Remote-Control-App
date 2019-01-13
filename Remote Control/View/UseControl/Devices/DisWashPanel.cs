using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClassLibrary.Klase.Enumeracija;
using ClassLibrary;

namespace Remote_Control
{ 

    public partial class DisWasherPanel : UserControl
    {
        private int hours;
        private int minutes;
        private int seconds;
        private int trig = 0;

        public static DisWasherPanel _instance;
        public static DisWasherPanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DisWasherPanel();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }

        private string serialNum = null;

        //  Update DB on disconnecting
        void UpdateTable()
        {
            string sn = serialNum;
            string sqlQuery = "UPDATE Lights DisWasher delay_start = '" + numericUpDown1 + "' WHERE sn = '" + Device.serialNum + "' ";
            DataAccess.ExecuteSQL(sqlQuery);
            DataAccess.ConnectionClose();
        }

        public DisWasherPanel()
        {
            InitializeComponent();
        }

        private void DishWashPanel_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value.ToString(TableFill.delay_start);
            nameDW.Text = TableFill.name;
            modelDW.Text = TableFill.model;
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

      

        private void DishEPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SetTimerLabel_Click(object sender, EventArgs e)
        {

        }

        private void rbMetal_CheckedChanged(object sender, EventArgs e)
        {
            pbIspisStupnjeva.Image = Properties.Resources.eigdegree; 
        }

        private void rbKeramika_CheckedChanged(object sender, EventArgs e)
        {
            pbIspisStupnjeva.Image = Properties.Resources.sevdegree;

        }

        private void rbPlastika_CheckedChanged(object sender, EventArgs e)
        {
            pbIspisStupnjeva.Image = Properties.Resources.sixdegree;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
    

