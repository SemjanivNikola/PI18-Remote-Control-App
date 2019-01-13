using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_Control
{
    public partial class MainForm : Form
    {
        public static MainForm _instance;
        public static MainForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainForm();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }

        //  Za back i forrward button
        public List<UserControl> listPanel = new List<UserControl>();
        public UserControl lastPnl = null;
        public int index = -1; //Index za listu, mora se povecavat za 1 kod promjene panela
                                //-1 zato sto index liste pocinje od 0
        
        //  Potrebno za promjenu stanja buttona
        public Button lastActive = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ProgressBarLoad();
            if (!MainPanel.Controls.Contains(ImpDevPanel.Instance))
            {
                MainPanel.Controls.Add(ImpDevPanel.Instance);
                ImpDevPanel.Instance.Dock = DockStyle.Fill;
                ImpDevPanel.Instance.BringToFront();
            }
            else
            {
                ImpDevPanel.Instance.BringToFront();
            }
            ActiveButton.InactiveB(lastActive);
            ActiveButton.ActiveB(ImportButton);
            lastActive = ImportButton;

            lastPnl = ImpDevPanel.Instance;
            listPanel.Add(lastPnl);
            index++;

        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            ProgressBarLoad();
            if (!MainPanel.Controls.Contains(DelDevPanel.Instance))
            {
                MainPanel.Controls.Add(DelDevPanel.Instance);
                DelDevPanel.Instance.Dock = DockStyle.Fill;
                DelDevPanel.Instance.BringToFront();
            }
            else
            {
                DelDevPanel.Instance.BringToFront();
            }
            ActiveButton.InactiveB(lastActive);
            ActiveButton.ActiveB(DelButton);
            lastActive = DelButton;

            lastPnl = DelDevPanel.Instance;
            listPanel.Add(lastPnl);
            index++;
            
        }

        private void ConnButton_Click(object sender, EventArgs e)
        {
            ProgressBarLoad();
            if (!MainPanel.Controls.Contains(ConnDevPanel.Instance))
            {
                MainPanel.Controls.Add(ConnDevPanel.Instance);
                ConnDevPanel.Instance.Dock = DockStyle.Fill;
                ConnDevPanel.Instance.BringToFront();
            }
            else
            {
                ConnDevPanel.Instance.BringToFront();
            }
            ActiveButton.InactiveB(lastActive);
            ActiveButton.ActiveB(ConnButton);
            lastActive = ConnButton;

            lastPnl = ConnDevPanel.Instance;
            listPanel.Add(lastPnl);
            index++;
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            ProgressBarLoad();
            if (!MainPanel.Controls.Contains(ListDevPanel.Instance))
            {
                MainPanel.Controls.Add(ListDevPanel.Instance);
                ListDevPanel.Instance.Dock = DockStyle.Fill;
                ListDevPanel.Instance.BringToFront();
            }
            else
            {
                ListDevPanel.Instance.BringToFront();
            }
            ActiveButton.InactiveB(lastActive);
            ActiveButton.ActiveB(ListButton);
            lastActive = ListButton;

            lastPnl = ListDevPanel.Instance;
            listPanel.Add(lastPnl);
            index++;
        }

        // BACK button
        private void BackTool_Click(object sender, EventArgs e)
        {
            if (lastPnl == null)
                return;
            else if (index > 0)
                listPanel[--index].BringToFront();

            if (listPanel[index] == ImpDevPanel.Instance)   //uzima trenutni index i provjerava koji je panel aktivan za promjenu buttona
            {                                               //trebat ce jos napravit za kontrole kad se povezu
                ActiveButton.InactiveB(lastActive);
                ActiveButton.ActiveB(ImportButton);
                lastActive = ImportButton;
            }
            else if(listPanel[index] == DelDevPanel.Instance)
            {
                ActiveButton.InactiveB(lastActive);
                ActiveButton.ActiveB(DelButton);
                lastActive = DelButton;   
            }
            else if (listPanel[index] == ConnDevPanel.Instance)
            {
                ActiveButton.InactiveB(lastActive);
                ActiveButton.ActiveB(ConnButton);
                lastActive = ConnButton;
            }
        }

        //  FORRWARD button
        private void ForrwardTool_Click(object sender, EventArgs e)
        {
            if (lastPnl == null)
                return;
            else if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();

            if (listPanel[index] == ImpDevPanel.Instance)
            {
                ActiveButton.InactiveB(lastActive);
                ActiveButton.ActiveB(ImportButton);
                lastActive = ImportButton;
            }
            else if (listPanel[index] == DelDevPanel.Instance)
            {
                ActiveButton.InactiveB(lastActive);
                ActiveButton.ActiveB(DelButton);
                lastActive = DelButton;
            }
            else if (listPanel[index] == ConnDevPanel.Instance)
            {
                ActiveButton.InactiveB(lastActive);
                ActiveButton.ActiveB(ConnButton);
                lastActive = ConnButton;
            }
        }

        private void quickImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(ImpDevPanel.Instance)) //Quick import
            {                                                       //poziva prvo glavni ImpDevPanel i odmah ImpProp na njega
                MainPanel.Controls.Add(ImpDevPanel.Instance);       
                ImpDevPanel.Instance.Dock = DockStyle.Fill;
                ImpDevPanel.Instance.BringToFront();
            }
            else
            {
                ImpDevPanel.Instance.BringToFront();
            }
            //  Promjena stanja buttona
            ActiveButton.InactiveB(lastActive);
            ActiveButton.ActiveB(ImportButton);
            lastActive = ImportButton;
            // Stavljanje u listu
            lastPnl = ImpDevPanel.Instance;
            listPanel.Add(lastPnl);
            index++;
        
            ImpDevPanel.QuickBtfPanel();   //funkcija koja poziva import panel s otkljucanim typeom
        }

        public static void current()
        {
            if(SwitchPanel.activePnl == true)
                Instance.CurrDevTool.Image = Properties.Resources.Current;
            else
                Instance.CurrDevTool.Image = Properties.Resources.CurrentGray;
        }

        private void selectDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(ImpDevPanel.Instance)) //isto kao i import button
            {
                MainPanel.Controls.Add(ImpDevPanel.Instance);
                ImpDevPanel.Instance.Dock = DockStyle.Fill;
                ImpDevPanel.Instance.BringToFront();
            }
            else
            {
                ImpDevPanel.Instance.BringToFront();
            }
            //  Promjena stanja buttona
            ActiveButton.InactiveB(lastActive);
            ActiveButton.ActiveB(ImportButton);
            lastActive = ImportButton;
            // Stavljanje u listu
            lastPnl = ImpDevPanel.Instance;
            listPanel.Add(lastPnl);
            index++;
        }

        void ProgressBarLoad()
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StatusLabel.Text = "Loading";
            ProgressBar.Step = 20;
            ProgressBar.PerformStep();
            Console.WriteLine(ProgressBar.Value);
            if (ProgressBar.Value == 300)
            {
                StatusLabel.Text = "Ready";
                ProgressBar.Value = 0;
                timer1.Stop();
            }
        }

        private void CurrDevTool_Click(object sender, EventArgs e)
        {
            if(SwitchPanel.activePnl == true)
            {
                SwitchPanel.ShowMe(Device.Naziv);
            }
        }
    }
}
