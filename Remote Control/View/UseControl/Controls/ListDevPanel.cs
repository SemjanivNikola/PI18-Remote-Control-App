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
    public partial class ListDevPanel : UserControl
    {

        public static ListDevPanel _instance;
        public static ListDevPanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListDevPanel();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }
        //  Brisanje uredaja
        bool selected = false;
        bool check = false;
        string serialNum = null;
        string type = null;
        string sqlQuery = null;

        public ListDevPanel()
        {
            InitializeComponent();
        }

        private void ListDevPanel_Load(object sender, EventArgs e)
        {
            sqlQuery = " SELECT * FROM device";
            DataSet ds = new DataSet();
            ds = DataAccess.GetDataSet(sqlQuery);
            listTable.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = cbType.Text;
            if (name == "Select Device")
            {
                MessageBox.Show("Please select device.");
                return;
            }
            else if (name == "Air Conditioner")
                name = "AirCon";
            else if (name == "Washing Machine")
                name = "WasMachine";
            else if (name == "Water Heater")
                name = "WtrHtr";
            
            sqlQuery = " SELECT * FROM '" + name + "_view'";
            listTable.DataSource = DataAccess.GetDataTableView(sqlQuery);

            check = true;
        }

        private void btnFav_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT * FROM device WHERE favourites = 1";
            listTable.DataSource = DataAccess.GetDataTableView(sqlQuery);
        }

        private void btwDel_Click(object sender, EventArgs e)
        {
            if (!selected)
                MessageBox.Show("Select device first please.");
            else
            {
                DataAccess.delDev(serialNum, type);
            }
        }

        private void listTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = true;
            int position = 0;
            string sqlQuery = null;
            type = cbType.Text;

            if (check)
            {
                if (type == "Air Conditioner")
                    type = "AirCon";
                else if (type == "Washing Machine")
                    type = "WasMachine";
                else if (type == "Water Heater")
                    type = "WtrHtr";

                position = listTable.CurrentCell.RowIndex;
                sqlQuery = "SELECT sn FROM '"+ type +"'";
                serialNum = DataAccess.GetSN(sqlQuery, position);
            }
            else
            {
                position = listTable.CurrentCell.RowIndex;
                sqlQuery = "SELECT sn FROM device";
                serialNum = DataAccess.GetSN(sqlQuery, position);
            }
            MessageBox.Show("Device is selected!");
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            sqlQuery = " SELECT * FROM device";
            DataSet ds = new DataSet();
            ds = DataAccess.GetDataSet(sqlQuery);
            listTable.DataSource = ds.Tables[0];
        }
    }
}
