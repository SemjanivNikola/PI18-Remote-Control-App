using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_Control
{
    public class ButtonControl : Button
    {
        public static void ActiveB(Button currButton)
        {
            var posY = 0;
            int index = 0;
            posY = currButton.Location.Y;
            index = currButton.TabIndex;

            currButton.BackColor = Color.White;
            currButton.ForeColor = Color.Black;
            currButton.Size = new Size(139, 44);
            currButton.Location = new Point(-2, posY);

            switch(index)
            {
                case 0:
                    currButton.Image = Properties.Resources.Add;
                    break;
                case 1:
                    currButton.Image = Properties.Resources.Delete;
                    break;
                case 2:
                    currButton.Image = Properties.Resources.Connect;
                    break;
                case 3:
                    currButton.Image = Properties.Resources.List;
                    break;
                default:    break;
            }
        }

        public static void InactiveB(Button button)
        {
            var posY = 0;
            int index = 0;

            if (button == null) return;
            else
            {
                index = button.TabIndex;
                posY = button.Location.Y;

                button.BackColor = Color.LightGray;
                button.ForeColor = Color.DarkGray;
                button.Size = new Size(135, 44);
                button.Location = new Point(0, posY);

                switch (index)
                {
                    case 0:
                        button.Image = Properties.Resources.AddGray;
                        break;
                    case 1:
                        button.Image = Properties.Resources.DeleteGray;
                        break;
                    case 2:
                        button.Image = Properties.Resources.ConnectGray;
                        break;
                    case 3:
                        button.Image = Properties.Resources.ListGray;
                        break;
                    default: break;
                }
            }
        }
    }
}
