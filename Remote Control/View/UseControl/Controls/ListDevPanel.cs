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

        public ListDevPanel()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListDevPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
