using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_Control
{
    class PanelFunction
    {
        public static List<string> devFavName = new List<string>();
        public static List<string> devFavID = new List<string>();

        public static bool activePnl = false;

        public static void ShowMe(string uc)
        {
            if (activePnl == false)
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
                            if (activePnl == false)
                                LightsPanel.Instance.LightsPanel_Load(null, null);

                            LightsPanel.Instance.BringToFront();
                            LightsPanel.Instance.Show();
                        }
                        MainForm.Instance.listPanel.Add(MainForm.Instance.lastPnl);
                    }
                    break;
                case "TVPanel":
                    {
                        if (!ConnDevPanel.Instance.Controls.Contains(TVPanel.Instance))
                        {
                            ConnDevPanel.Instance.Controls.Add(TVPanel.Instance);
                            TVPanel.Instance.Dock = DockStyle.Fill;
                            TVPanel.Instance.BringToFront();
                        }
                        else
                        {
                            if (activePnl == false)
                                TVPanel.Instance.TVPanel_Load(null, null);
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
                            if (activePnl == false)
                                AirConPanel.Instance.AirCondPanel_Load(null, null);
                            AirConPanel.Instance.BringToFront();
                            AirConPanel.Instance.Show();
                        }
                        MainForm.Instance.listPanel.Add(MainForm.Instance.lastPnl);
                    }
                    break;
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
                            if (activePnl == false)
                                WtrHtrPanel.Instance.WaterHeaterPanel_Load(null, null);
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
                            if (activePnl == false)
                                WasMachinePanel.Instance.WasMachinePanel_Load(null, null);
                            WasMachinePanel.Instance.BringToFront();
                            WasMachinePanel.Instance.Show();
                        }
                        MainForm.Instance.listPanel.Add(MainForm.Instance.lastPnl);
                    }
                    break;
                case "DishwasherPanel":
                    {
                        if (!ConnDevPanel.Instance.Controls.Contains(DishwasherPanel.Instance))
                        {
                            ConnDevPanel.Instance.Controls.Add(DishwasherPanel.Instance);
                            DishwasherPanel.Instance.Dock = DockStyle.Fill;
                            DishwasherPanel.Instance.BringToFront();
                        }
                        else
                        {
                            if (activePnl == false)
                                DishwasherPanel.Instance.DishwasherPanel_Load(null, null);
                            DishwasherPanel.Instance.BringToFront();
                            DishwasherPanel.Instance.Show();
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
                            if (activePnl == false)
                                StovePanel.Instance.StovePanel_Load(null, null);
                            StovePanel.Instance.BringToFront();
                            StovePanel.Instance.Show();
                        }
                        MainForm.Instance.listPanel.Add(MainForm.Instance.lastPnl);
                    }
                    break;
                case "RefrigeratorPanel":
                    {
                        if (!ConnDevPanel.Instance.Controls.Contains(RefrigeratorPanel.Instance))
                        {
                            ConnDevPanel.Instance.Controls.Add(RefrigeratorPanel.Instance);
                            RefrigeratorPanel.Instance.Dock = DockStyle.Fill;
                            RefrigeratorPanel.Instance.BringToFront();
                        }
                        else
                        {
                            if (activePnl == false)
                                RefrigeratorPanel.Instance.RefriPanel_Load (null, null);
                            RefrigeratorPanel.Instance.BringToFront();
                            RefrigeratorPanel.Instance.Show();
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

        //  Updatea tablicu device za odredeni uredaj da je favorit
        public static void addPnlToList(string serialNum)
        {
            string sqlQery = "UPDATE device SET favourites = '1' WHERE sn = '" + serialNum + "'";
            DataAccess.ExecuteSQL(sqlQery);
            devFavID.Add(serialNum);
        }

        //  Loada favorite iz baze u program
        public static void loadFavourites()
        {
            int brojac = 0;
            brojac = DataAccess.loadFavourites(devFavID, devFavName);
        }

        //  Pretrazivanje liste Favorita preko serijskog broja
        public static bool searchFavourites(string serialNum)
        {
            int i = 0;
            string pom;
            bool check = false;
            foreach(var element in devFavID)
            {
                pom = devFavID[i];
                if (serialNum == pom)
                    check = true;
                i ++;
            }
            return check;
        }

        //  Brisanje favorita iz liste serijskih brojeva i naziva
        public static void deleteFavourite(string devName, string serialNum)
        {
            DataAccess.delFav(serialNum);
            devFavID.Remove(serialNum);
            devFavName.Remove(devName);
        }
    }
}
    



