using System.Windows.Forms;
using Finisar.SQLite;
using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using SQLiteConnection = System.Data.SQLite.SQLiteConnection;
using SQLiteCommand = System.Data.SQLite.SQLiteCommand;
using System;
using SQLiteDataReader = System.Data.SQLite.SQLiteDataReader;
using System.Linq;
using System.Text.RegularExpressions;
using ClassLibrary;

namespace Remote_Control
{
    public partial class ImpPropPanel : UserControl
    {
        public static ImpPropPanel _instance;
        public static ImpPropPanel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ImpPropPanel();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }

        

        public ImpPropPanel()
        {
            InitializeComponent();
        }

        
        //  Izvlačenje podataka iz baze u tablicu
        private void lastSaveTable_Refresh()
        {
            string sqlQuery = "SELECT * FROM last_saved";
            DataSet ds = new DataSet();
            ds = DataAccess.GetDataSet(sqlQuery);
            lastSaveTable.DataSource = ds.Tables[0];
        }
        private void ImpPropPanel_Load(object sender, System.EventArgs e)
        {
            lastSaveTable_Refresh();
        }

        //  SAVE button 
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if(nameVal.Visible == true || modelVal.Visible == true || snVal.Visible == true || passVal.Visible == true )
            {
                MessageBox.Show("Please fill all required parameters to insert device and try again.");
                Rtb.Text += "\nError!";
            }
            else
            {
                string sqlQuery = "INSERT INTO device (type, name, model, sn, date, time, pass_tpe, pass, favourites) VALUES ('" + cbType.Text + "', '" + tbName.Text + "', '" + tbModel.Text + "', '" + tbSN.Text + "', '" + tbDate.Text + "', '" + tbTime.Text + "', '" + cbPass.Text + "' , '" + tbPass.Text + "', 0)";
                if (DataAccess.ExecuteSQL(sqlQuery) == 0)
                {
                    Rtb.Text += "\nError!";
                    return;
                }
                    
                Device.Type = cbType.Text;
                Device.Naziv = tbName.Text;
                Device.Model = tbModel.Text;
                Device.serialNum = tbSN.Text;

                try
                {
                    DataAccess.ConnectionClose();
                    TableFill.Trigger(Device.Type, Device.Naziv, Device.serialNum, Device.Model);
                    MessageBox.Show("Device saved!");
                    Rtb.Text = "Device is saved seccessfuly!";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Rtb.Text += "\nError!";
                }
                lastSaveTable_Refresh();
            }
        }

        //  CANCEL button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Instance.SendToBack();
            Instance.Hide();
        }

        private void tbName_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
        }

        private void tbModel_Click(object sender, EventArgs e)
        {
            tbModel.Clear();
            tbModel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
        }

        private void tbSN_Click(object sender, EventArgs e)
        {
            tbSN.Clear();
            tbSN.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
        }

        private void tbPass_Click(object sender, EventArgs e)
        {
            tbPass.Clear();
            tbPass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {
            tbDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void tbTime_TextChanged(object sender, EventArgs e)
        {
            tbTime. Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cbType_TextChanged(object sender, EventArgs e)
        {
            tbDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            tbTime. Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cbPass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPass.Text.Equals("NO"))
            {
                tbPass.Clear();
                tbPass.ReadOnly = true;
            }
            else
                tbPass.ReadOnly = false;
        }

        private void tbName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //  Provjera jel string ima nedopuštene znakove - https://stackoverflow.com/questions/336210
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            if (!regexItem.IsMatch(tbName.Text))
            {
                nameVal.Visible = true;
                Rtb.Text += "\nName of device is not valid. You are using inacceptable characters.";
            }
            else if (tbName.Text == "" || tbName.TextLength < 2)
            {
                nameVal.Visible = true;
                Rtb.Text += "\nName of device is not valid. Please try again! Name need to have at least 2 letters.";
            }
            else
            {
                nameVal.Visible = false;
            }
        }

        private void tbModel_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var regexItem = new Regex("^[a_zA-Z0-9 ]*$");
            if (!regexItem.IsMatch(tbModel.Text))
            {
                modelVal.Visible = true;
                Rtb.Text += "\nModel of device is not valid. You are using inacceptable characters.";
            }
            else if (tbModel.Text == "" || tbModel.TextLength < 6)
            {
                modelVal.Visible = true;
                Rtb.Text += "\nModel is not valid. Model of device need to have at least 4 letters or numbers. Please try again!";
            }
            else
            {
                modelVal.Visible = false;
            }
        }

        private void tbPass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbPass.Text.Equals("YES"))
            {
                var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
                if (!regexItem.IsMatch(tbPass.Text))
                {
                    modelVal.Visible = true;
                    Rtb.Text += "\nPassword is not valid. You are using inacceptable characters.";
                }
                else if (tbPass.Text == "" || tbPass.TextLength < 6)
                {
                    passVal.Visible = true;
                    Rtb.Text += "\nPassword need to have at least 6 letters or numbers. Please try again!";
                }
                else
                {
                    passVal.Visible = false;
                }
            }
            else
                passVal.Visible = false;
        }

        private void tbSN_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var regexItem = new Regex("^[0-9 ]*$");
            if (!regexItem.IsMatch(tbSN.Text))
            {
                snVal.Visible = true;
                Rtb.Text += "\nSerial Number of device is not valid. You are using inacceptable characters.";
            }
            else if (tbSN.Text == "" || tbSN.TextLength < 12 || tbSN.TextLength > 19)
            {
                snVal.Visible = true;
                Rtb.Text += "\nSerial Number need to have between 12 and 19 numbers. Please try again!";
            }
            else
            {
                snVal.Visible = false;
            }
        }

        private void Rtb_TextChanged(object sender, EventArgs e)
        {
            Rtb.SelectionStart = Rtb.Text.Length;
            Rtb.ScrollToCaret();
        }

        private void ImpPropPanel_VisibleChanged(object sender, EventArgs e)
        {
            Rtb.Clear();
            Rtb.Text = " . . .";
            nameVal.Hide();
            tbName.Text = " Type Name";
            tbName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            modelVal.Hide();
            tbModel.Text = " Type Model";
            tbModel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            snVal.Hide();
            tbSN.Text = " Type Serial Number";
            tbSN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            passVal.Hide();
            tbPass.Text = " Type Password";
            tbPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
        }
    }
}
