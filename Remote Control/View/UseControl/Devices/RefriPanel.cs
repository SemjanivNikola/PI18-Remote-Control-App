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
    public partial class RefriPanel : UserControl
    {
        public static RefriPanel _instance;
        public static RefriPanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RefriPanel();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }

        public RefriPanel()
        {
            InitializeComponent();
        }

        private void RefriPanel_Load(object sender, EventArgs e)
        {
            TempValue.Text = TableFill.temp;
            nameRefri.Text = TableFill.name;
            modelRefri.Text = TableFill.model;
            DevConnected.Text = TableFill.inUse;
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

        private void Minus_Click(object sender, EventArgs e)
        {
            int Temperature = Int32.Parse(TempValue.Text);
            if (Temperature > -10)
            {
                Temperature--;
                TempValue.Text = Convert.ToString(Temperature);
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            int Temperature = Int32.Parse(TempValue.Text);
            if (Temperature < 10)
            {
                Temperature++;
                TempValue.Text = Convert.ToString(Temperature);
            }
        }

        private void DispenceIseLabel_Click(object sender, EventArgs e)
        {
            if (CubedIce.Checked || CrushedIce.Checked)
            {
                CubedIce.Checked = false;
                CrushedIce.Checked = false;
            }
        }

        private void DispenceWaterLabel_Click(object sender, EventArgs e)
        {
            //samo ispisati poruku na traci
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
