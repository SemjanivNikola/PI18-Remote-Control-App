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
            private set { }
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

            if (!MainPanel.Controls.Contains(ImpPropPanel.Instance))
            {
                ImpPropPanel.Instance.SendToBack();
                ImpPropPanel.Instance.Hide();
            }

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
            ButtonControl.InactiveB(lastActive);
            ButtonControl.ActiveB(ImportButton);
            lastActive = ImportButton;

            lastPnl = ImpDevPanel.Instance;
            listPanel.Add(lastPnl);
            index++;
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            ProgressBarLoad();

            if (!MainPanel.Controls.Contains(ListDevPanel.Instance))
            {
                ListDevPanel.Instance.SendToBack();
                ListDevPanel.Instance.Hide();
            }

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
            ButtonControl.InactiveB(lastActive);
            ButtonControl.ActiveB(DelButton);
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
            ButtonControl.InactiveB(lastActive);
            ButtonControl.ActiveB(ConnButton);
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
            ButtonControl.InactiveB(lastActive);
            ButtonControl.ActiveB(ListButton);
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
            {
                ProgressBarLoad();
                listPanel[--index].BringToFront();
            }
            if (listPanel[index] == ImpDevPanel.Instance)   //uzima trenutni index i provjerava koji je panel aktivan za promjenu buttona
            {                                               //trebat ce jos napravit za kontrole kad se povezu
                ButtonControl.InactiveB(lastActive);
                ButtonControl.ActiveB(ImportButton);
                lastActive = ImportButton;
            }
            else if (listPanel[index] == DelDevPanel.Instance)
            {
                ButtonControl.InactiveB(lastActive);
                ButtonControl.ActiveB(DelButton);
                lastActive = DelButton;
            }
            else if (listPanel[index] == ConnDevPanel.Instance)
            {
                ButtonControl.InactiveB(lastActive);
                ButtonControl.ActiveB(ConnButton);
                lastActive = ConnButton;
            }
            else if (listPanel[index] == ListDevPanel.Instance)
            {
                ButtonControl.InactiveB(lastActive);
                ButtonControl.ActiveB(ListButton);
                lastActive = ListButton;
            }
        }

        //  FORRWARD button
        private void ForrwardTool_Click(object sender, EventArgs e)
        {
            if (lastPnl == null)
                return;
            else if (index < listPanel.Count - 1)
            {
                ProgressBarLoad();
                listPanel[++index].BringToFront();
            }
            if (listPanel[index] == ImpDevPanel.Instance)
            {
                ButtonControl.InactiveB(lastActive);
                ButtonControl.ActiveB(ImportButton);
                lastActive = ImportButton;
            }
            else if (listPanel[index] == DelDevPanel.Instance)
            {
                ButtonControl.InactiveB(lastActive);
                ButtonControl.ActiveB(DelButton);
                lastActive = DelButton;
            }
            else if (listPanel[index] == ConnDevPanel.Instance)
            {
                ButtonControl.InactiveB(lastActive);
                ButtonControl.ActiveB(ConnButton);
                lastActive = ConnButton;
            }
            else if (listPanel[index] == ListDevPanel.Instance)
            {
                ButtonControl.InactiveB(lastActive);
                ButtonControl.ActiveB(ListButton);
                lastActive = ListButton;
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
            ButtonControl.InactiveB(lastActive);
            ButtonControl.ActiveB(ImportButton);
            lastActive = ImportButton;
            // Stavljanje u listu
            lastPnl = ImpDevPanel.Instance;
            listPanel.Add(lastPnl);
            index++;
        
            ImpDevPanel.QuickBtfPanel();   //funkcija koja poziva import panel s otkljucanim typeom
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
            ButtonControl.InactiveB(lastActive);
            ButtonControl.ActiveB(ImportButton);
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            Instance = this;
            PanelFunction.loadFavourites();
            DataAccess.ConnectionClose();
            ToolStripFavItems();
        }

        //  Projerava i postavlja uredaj kao favorit ako vec nije
        private void favouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PanelFunction.activePnl == true)
            {
                bool check = false;
                check = PanelFunction.searchFavourites(Device.serialNum);
                if (check == true)
                {
                    PanelFunction.deleteFavourite(Device.Naziv, 
                        Device.serialNum);
                    ToolStripItem remove = new ToolStripMenuItem
                    {
                        Text = Device.Naziv
                    };
                    favouriteMenuItem.DropDownItems.Remove(remove);
                    MessageBox.Show("Device is removed from Favourites.");
                }
                else
                {
                    PanelFunction.addPnlToList(Device.serialNum);
                    ToolStripItem newItem = new ToolStripMenuItem
                    {
                        Text = Device.Naziv
                    };
                    favouriteMenuItem.DropDownItems.Add(newItem);
                    MessageBox.Show("Device is added as Favourite.");
                }
            }
            else
            {
                MessageBox.Show("You are not connected at the moment.");
                return;
            }
        }

        private void ToolStripFavItems()
        {
            int i = 0;
            foreach (var element in PanelFunction.devFavName)
            {
                ToolStripItem newItem = new ToolStripMenuItem
                {
                    Text = PanelFunction.devFavName[i]
                };
                favouriteMenuItem.DropDownItems.Add(newItem);
                i++;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshTool_Click(object sender, EventArgs e)
        {
            ListDevPanel.Instance.listTable.Refresh();
            MessageBox.Show("List Panel Table has been refreshed.\nAll currently inserted devices are listed.");
        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Remote Control App\nVersion 1.0.0\nApplication for managing home devices. Making things easier :)");
        }

        private void developersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We are small students from Pula, Croatia, but seeking for big things.\n\nTeam leader: Nikola Semjaniv\nRight hand: Sinoma Jurić\nMost valuable developer: Vladimir Parat\nAdministration manager: Marko Mraović\n");
        }
    }
}
