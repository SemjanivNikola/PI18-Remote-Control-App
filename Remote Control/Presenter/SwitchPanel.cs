using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_Control
{
    class SwitchPanel
    {
        public static bool activePnl = false;

        public static void ShowMe(string uc)
        {
            if(activePnl == false)
                uc = StrBuilder(uc);

            switch (uc)
            {
                case "LightsPanel":
                    {
                        if (!ConnDevPanel.Instance.Controls.Contains(LightsPanel.Instance))
                        {
                            ConnDevPanel.Instance.Controls.Add(LightsPanel.Instance);
                            LightsPanel.Instance.Dock = DockStyle.Fill;
                            LightsPanel.Instance.BringToFront();
                            LightsPanel.Instance.Show();
                        }
                        else
                        {
                            if(activePnl == false)
                                LightsPanel.Instance.LightsPanel_Load(null, null);

                            LightsPanel.Instance.BringToFront();
                            LightsPanel.Instance.Show();
                        }
                        MainForm.Instance.listPanel.Add(MainForm.Instance.lastPnl);
                    }
                    break;
                /*case "TVPanel":
                    {
                        if (!ConnDevPanel.Instance.Controls.Contains(TVPanel.Instance))
                        {
                            ConnDevPanel.Instance.Controls.Add(LightsPanel.Instance);
                            TVPanel.Instance.Dock = DockStyle.Fill;
                            TVPanel.Instance.BringToFront();
                        }
                        else
                        {
                            TVPanel.Instance.BringToFront();
                            TVPanel.Instance.Show();
                        }
                        MainForm.Instance.listPanel.Add(MainForm.Instance.lastPnl);
                    }
                    break;
                case "AirConPanel":
                    {
                        if (!ConnDevPanel.Instance.Controls.Contains(AirConPanel.Instance))
                        {
                            ConnDevPanel.Instance.Controls.Add(AirConPanel.Instance);
                            AirConPanel.Instance.Dock = DockStyle.Fill;
                            AirConPanel.Instance.BringToFront();
                        }
                        else
                        {
                            AirConPanel.Instance.BringToFront();
                            AirConPanel.Instance.Show();
                        }
                        MainForm.Instance.listPanel.Add(MainForm.Instance.lastPnl);
                    }
                    break;*/
                case "WtrHtrPanel":
                    {
                        if (!ConnDevPanel.Instance.Controls.Contains(WtrHtrPanel.Instance))
                        {
                            ConnDevPanel.Instance.Controls.Add(WtrHtrPanel.Instance);
                            WtrHtrPanel.Instance.Dock = DockStyle.Fill;
                            WtrHtrPanel.Instance.BringToFront();
                        }
                        else
                        {
                            WtrHtrPanel.Instance.BringToFront();
                            WtrHtrPanel.Instance.Show();
                        }
                        MainForm.Instance.listPanel.Add(MainForm.Instance.lastPnl);
                    }
                    break;
                case "WasMachinePanel":
                    {
                        if (!ConnDevPanel.Instance.Controls.Contains(WasMachinePanel.Instance))
                        {
                            ConnDevPanel.Instance.Controls.Add(WasMachinePanel.Instance);
                            WasMachinePanel.Instance.Dock = DockStyle.Fill;
                            WasMachinePanel.Instance.BringToFront();
                        }
                        else
                        {
                            WasMachinePanel.Instance.BringToFront();
                            WasMachinePanel.Instance.Show();
                        }
                        MainForm.Instance.listPanel.Add(MainForm.Instance.lastPnl);
                    }
                    break;
                case "DisWasherPanel":
                    {
                        if (!ConnDevPanel.Instance.Controls.Contains(DisWasherPanel.Instance))
                        {
                            ConnDevPanel.Instance.Controls.Add(DisWasherPanel.Instance);
                            DisWasherPanel.Instance.Dock = DockStyle.Fill;
                            DisWasherPanel.Instance.BringToFront();
                        }
                        else
                        {
                            DisWasherPanel.Instance.BringToFront();
                            DisWasherPanel.Instance.Show();
                        }
                        MainForm.Instance.listPanel.Add(MainForm.Instance.lastPnl);
                    }
                    break;
                case "StovePanel":
                    {
                        if (!ConnDevPanel.Instance.Controls.Contains(StovePanel.Instance))
                        {
                            ConnDevPanel.Instance.Controls.Add(StovePanel.Instance);
                            StovePanel.Instance.Dock = DockStyle.Fill;
                            StovePanel.Instance.BringToFront();
                        }
                        else
                        {
                            StovePanel.Instance.BringToFront();
                            StovePanel.Instance.Show();
                        }
                        MainForm.Instance.listPanel.Add(MainForm.Instance.lastPnl);
                    }
                    break;
                case "RefriPanel":
                    {
                        if (!ConnDevPanel.Instance.Controls.Contains(RefriPanel.Instance))
                        {
                            ConnDevPanel.Instance.Controls.Add(RefriPanel.Instance);
                            RefriPanel.Instance.Dock = DockStyle.Fill;
                            RefriPanel.Instance.BringToFront();
                        }
                        else
                        {
                            RefriPanel.Instance.BringToFront();
                            RefriPanel.Instance.Show();
                        }
                        MainForm.Instance.listPanel.Add(MainForm.Instance.lastPnl);
                    }
                    break;
                default: break;
            }
        }

        private static string StrBuilder(string str)
        {
            StringBuilder ab = new StringBuilder();
            ab.Append(str);
            ab.Insert(str.Length, "Panel");
            str = ab.ToString();

            return str;
        }
    }
}
    



