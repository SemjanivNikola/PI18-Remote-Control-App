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
    public partial class DelDevPanel : UserControl
    {
        public static DelDevPanel _instance;
        public static DelDevPanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DelDevPanel();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }

        public DelDevPanel()
        {
            InitializeComponent();
        }
    }
}
