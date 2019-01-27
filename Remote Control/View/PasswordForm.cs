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
    public partial class PasswordForm : Form
    {
        static string devName = null;
        public PasswordForm()
        {
            InitializeComponent();
        }

        static bool check = false;

        public static void PassCall(string str)
        {
            devName = str;
        }
         
        private void btnConn_Click(object sender, EventArgs e)
        {
            if (check)
            {
                ConnDevPanel.Instance.LoadData();
                PanelFunction.ShowMe(devName);
                ConnDevPanel.Instance.serialNum = null;
                Hide();
                tbPassVal.Text = "";
                check = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            tbPassVal.Text = "";
        }

        private void tbPassVal_TextChanged(object sender, EventArgs e)
        {
            if (Device.Lozinka.Equals(tbPassVal.Text))
            {
                pbVal.Image = Properties.Resources.correct;
                check = true;
            }
            else
            {
                pbVal.Image = Properties.Resources.wrong;
                check = false;
            }
        }
    }
}
