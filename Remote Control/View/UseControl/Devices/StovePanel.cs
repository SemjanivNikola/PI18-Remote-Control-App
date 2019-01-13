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
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,value
                }).OrderBy(item => item.value).ToList();
            // Stove Combo Box
            cbStove.DisplayMember = "Description";
            cbStove.ValueMember = "Value";
            cbStove.DataSource = Enum.GetValues(typeof(ClassLibrary.Klase.Enumeracija.TemperaturaPecnica))
                .Cast<Enum>().Select(
                    value => new
                    {
                        (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                        value
                    }).OrderBy(item => item.value).ToList();
        }

        private void StovePanel_Load(object sender, EventArgs e)
        {
            Plate1.Text = TableFill.p1Temp;
            Plate2.Text = TableFill.p2Temp;
            Plate3.Text = TableFill.p3Temp;
            Plate4.Text = TableFill.p4Temp;
            Plate5.Text = TableFill.p5Temp;
            nameStove.Text = TableFill.name;
            modelStove.Text = TableFill.model;
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

        private void Minus1_Click(object sender, EventArgs e)
        {
            int Plate1= Int32.Parse(PlateValue1.Text);
            if (Plate1 > 0)
            {
                Plate1--;
                PlateValue1.Text = Convert.ToString(Plate1);
            }
        }

        private void Plus1_Click(object sender, EventArgs e)
        {
            int Plate1 = Int32.Parse(PlateValue1.Text);
            if (Plate1 < 10)
            {
                Plate1++;
                PlateValue1.Text = Convert.ToString(Plate1);
            }
        }

        private void Minus2_Click(object sender, EventArgs e)
        {
            int Plate2 = Int32.Parse(PlateValue2.Text);
            if (Plate2 > 0)
            {
                Plate2--;
                PlateValue2.Text = Convert.ToString(Plate2);
            }
        }

        private void Plus2_Click(object sender, EventArgs e)
        {
            int Plate2 = Int32.Parse(PlateValue2.Text);
            if (Plate2 < 10)
            {
                Plate2++;
                PlateValue2.Text = Convert.ToString(Plate2);
            }
        }

        private void Minus3_Click(object sender, EventArgs e)
        {
            int Plate3 = Int32.Parse(PlateValue3.Text);
            if (Plate3 > 0)
            {
                Plate3--;
                PlateValue3.Text = Convert.ToString(Plate3);
            }
        }

        private void Plus3_Click(object sender, EventArgs e)
        {
            int Plate3 = Int32.Parse(PlateValue3.Text);
            if (Plate3 < 10)
            {
                Plate3++;
                PlateValue3.Text = Convert.ToString(Plate3);
            }
        }

        private void Minus4_Click(object sender, EventArgs e)
        {
            int Plate4 = Int32.Parse(PlateValue4.Text);
            if (Plate4 > 0)
            {
                Plate4--;
                PlateValue4.Text = Convert.ToString(Plate4);
            }
        }

        private void Plus4_Click(object sender, EventArgs e)
        {
            int Plate4 = Int32.Parse(PlateValue4.Text);
            if (Plate4 < 10)
            {
                Plate4++;
                PlateValue4.Text = Convert.ToString(Plate4);
            }
        }

        private void Minus5_Click(object sender, EventArgs e)
        {
            int Plate5 = Int32.Parse(PlateValue5.Text);
            if (Plate5 > 0)
            {
                Plate5--;
                PlateValue5.Text = Convert.ToString(Plate5);
            }
        }

        private void Plus5_Click(object sender, EventArgs e)
        {
            int Plate5 = Int32.Parse(PlateValue5.Text);
            if (Plate5 < 10)
            {
                Plate5++;
                PlateValue5.Text = Convert.ToString(Plate5);
            }
        }

        private void TimerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
