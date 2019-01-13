﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using ClassLibrary;

namespace Remote_Control
{
    public partial class ConnDevPanel : UserControl
    {
        public static ConnDevPanel _instance;
        public static ConnDevPanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ConnDevPanel();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }
        
        //  Konekcija na bazu
        SQLiteConnection conString = new SQLiteConnection(@"Data Source=rcaDB.db;Version=3;New=False;Compress=True");

        PictureBox lastPic = new PictureBox();

        //  Left i Right buttoni za mjenjanje panela s ikonicama
        int index = 0;
        List<Panel> panels = new List<Panel>();

        //  Varijable potrebne za odredivanje na koji uredaj cemo se spojiti i koje podatke iz baze cemo povuci
        string serialNum = null;
        string devName = null;
        string selected = null;

        public ConnDevPanel()
        {
            InitializeComponent();
        }

        private void ConnDevPanel_Load(object sender, EventArgs e)
        {
            panels.Add(ConnDevPanel.Instance.Pnl1);
            panels.Add(ConnDevPanel.Instance.Pnl2);
            panels[index].BringToFront();
        }

        //  Ispisivanje viewa iz baze za odredenje uredaje
        private void LoadTable(PictureBox textName)
        {
            string sqlQuery = " SELECT * FROM '"+ textName.Name +"_view'";
            SQLiteCommand cmd = new SQLiteCommand(sqlQuery, conString);
            SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            try
            {
                conString.Open();
                ds.Tables.Add(dt);
                adp.Fill(dt);
                conString.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connTable.DataSource = ds.Tables[0];
        }

        private void LoadData()
        {
            string sqlQuery = "SELECT * FROM '"+ devName +"' WHERE sn = '"+ serialNum +"'";
            TableFill.GetProperties(devName, sqlQuery);
        }

        //  Mjenjanje panela s ikonicama
        private void RightArrowPicBox_Click(object sender, EventArgs e)
        {
            if (index < panels.Count - 1)
            {
                panels[++index].BringToFront();
                RightArrowPicBox.Image = Properties.Resources.rightGray;
                LeftArrowPicBox.Image = Properties.Resources.left;
            }
        }

        //  Mjenjanje panela s ikonicama
        private void LeftArrowPicBox_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                panels[--index].BringToFront();
                LeftArrowPicBox.Image = Properties.Resources.leftGray;
                RightArrowPicBox.Image = Properties.Resources.right;
            }
        }

        private void Lights_Click(object sender, EventArgs e)
        {
            lastPic.BackColor = Color.Transparent;
            Lights.BackColor = Color.LightSteelBlue;
            devName = Lights.Name;
            
            LoadTable(Lights);
            lastPic = Lights;
        }
        
        private void TV_Click(object sender, EventArgs e)
        {
            lastPic.BackColor = Color.Transparent;
            TV.BackColor = Color.LightSteelBlue;
            devName = TV.Name;
            LoadTable(TV);
            lastPic = TV;
        }

        private void AirCon_Click(object sender, EventArgs e)
        {
            lastPic.BackColor = Color.Transparent;
            AirCon.BackColor = Color.LightSteelBlue;
            devName = AirCon.Name;
            LoadTable(AirCon);
            lastPic = AirCon;
        }

        private void WtrHtr_Click(object sender, EventArgs e)
        {
            lastPic.BackColor = Color.Transparent;
            WtrHtr.BackColor = Color.LightSteelBlue;
            devName = WtrHtr.Name;
            LoadTable(WtrHtr);
            lastPic = WtrHtr;
        }

        private void WasMachine_Click(object sender, EventArgs e)
        {
            lastPic.BackColor = Color.Transparent;
            WasMachine.BackColor = Color.LightSteelBlue;
            devName = WasMachine.Name;
            LoadTable(WasMachine);
            lastPic = WasMachine;
        }

        private void DisWasher_Click(object sender, EventArgs e)
        {
            lastPic.BackColor = Color.Transparent;
            DisWasher.BackColor = Color.LightSteelBlue;
            devName = DisWasher.Name;
            LoadTable(DisWasher);
            lastPic = DisWasher;
        }

        private void Stove_Click(object sender, EventArgs e)
        {
            lastPic.BackColor = Color.Transparent;
            Stove.BackColor = Color.LightSteelBlue;
            devName = Stove.Name;
            LoadTable(Stove);
            lastPic = Stove;
        }

        private void Refrigerator_Click(object sender, EventArgs e)
        {
            lastPic.BackColor = Color.Transparent;
            Refri.BackColor = Color.LightSteelBlue;
            devName = Refri.Name;
            LoadTable(Refri);
            lastPic = Refri;
        }

        private void connTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selected != null)
                MessageBox.Show(selected);
            else
            {
                int position = connTable.CurrentCell.RowIndex;
                string str = "SELECT Serial_Number FROM '" + devName + "_view'";
                serialNum = DataAccess.GetSN(str, position);
                Device.serialNum = serialNum;
                selected = "Device is selected!";
                MessageBox.Show(selected);
                selected = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            if (devName == null || serialNum == null)
            {
                string ex = "Not all parameters have been choosen.\nClick on table and try again.";
                MessageBox.Show(ex);
            }
            else
            {
                LoadData();
                SwitchPanel.ShowMe(devName);
                MainForm.current();
            }
        }

        /*private void Btf2()
        {
            SwitchPanel.StrBuilder(devName);
           
            tempPanel._instance = StovePanel._instance;
            if (!Instance.Controls.Contains(tempPanel.Instance))
            {
                Instance.Controls.Add(StovePanel.Instance);
                StovePanel.Instance.Dock = DockStyle.Fill;
                StovePanel.Instance.BringToFront();
            }
            else
            {
                StovePanel.Instance.BringToFront();
                StovePanel.Instance.Show();
            }
            MainForm.Instance.listPanel.Add(MainForm.Instance.lastPnl);
        }*/

        
    }
}