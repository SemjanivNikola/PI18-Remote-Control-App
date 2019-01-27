using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Finisar.SQLite;
using System.Windows.Forms;
using ClassLibrary;
//using System.Data.SQLite;

namespace Remote_Control
{
    //////SQLite Edition
    class DataAccess
    {

        // Connection String for  SQlite Edition
        static readonly string _ConnectionString = @"Data Source=rcaDB.db;Version=3;New=False;Compress=True";
        //Data Source=rcaDB.db;Version=3;New=False;Compress=True;

        // Use for ..exe.config file 
        //   static string _ConnectionString = Sqtlie_project_tutorial.Properties.Settings.Default.SqliteDBtestConnectionString1;




        static SQLiteConnection _Connection = null;
        public static SQLiteConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    _Connection = new SQLiteConnection(_ConnectionString);
                    _Connection.Open();

                    return _Connection;
                }
                else if (_Connection.State != System.Data.ConnectionState.Open)
                {
                    _Connection.Open();

                    return _Connection;
                }
                else
                {
                    return _Connection;
                }
            }
        }

        //  Zatvaranje konekcije
        public static void ConnectionClose()
        {
            Connection.Close();
        }

        //  Data Set
        public static DataSet GetDataSet(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);
            SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);

            DataSet ds = new DataSet();
            try
            {
                adp.Fill(ds);
                Connection.Close();
            }
            catch
            {
                MessageBox.Show("Something went wrong. Please try again!");
            }
            cmd.Dispose();
            adp.Dispose();

            return ds;
        }

        //  Data Table
        public static DataTable GetDataTable(string sql)
        {
            Console.WriteLine(sql);
            DataSet ds = GetDataSet(sql);

            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }

        //  Izvrsavanje naredbe i otvaranje konekcije
        public static int ExecuteSQL(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
            return 0;
        }

        //  Data Table View
        public static DataTable GetDataTableView(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);
            SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            try
            {
                ds.Tables.Add(dt);
                adp.Fill(dt);
                Connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }

        public static void GetPass(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    Device.Lozinka = (string)reader["pass"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmd.Dispose();
            reader.Dispose();
        }
        
        public static void GetPT(string sql, int position)
        {
            int br = 0;
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read() && br <= position)
                {
                    Device.tipLozinke = (string)reader["Password_Type"];
                    br++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmd.Dispose();
            reader.Dispose();
        }

        //  Izvlačenje serijskog broja uređaja iz baze
        public static string GetSN(string sql, int position)
        {
            string strSN = null;
            int br = 0;
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read() && br <= position)
                {
                    strSN = reader.GetValue(0).ToString();
                    br++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmd.Dispose();
            reader.Dispose();
            
            return strSN;
        }

        //  Brisanje iz baze
        public static void delDev(string serialNum, string devType)
        {
            string sqlQuery = "DELETE FROM '"+ devType +"' WHERE sn = '"+ serialNum +"'";
            ExecuteSQL(sqlQuery);
            sqlQuery = "DELETE FROM device WHERE sn = '" + serialNum + "'";
            ExecuteSQL(sqlQuery);
        }

        //  Citanje favorita iz baze
        public static int loadFavourites(List<string> id, List<string> name)
        {
            int brojac = 0;
            string sqlQuery = "SELECT sn, name FROM device WHERE favourites = 1";
            SQLiteCommand cmd = new SQLiteCommand(sqlQuery, Connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    string serialNum = reader["sn"].ToString();
                    string favName = (string)reader["name"];
                    if (favName == null)
                        break;
                    id.Add(serialNum);
                    name.Add(favName);
                    brojac ++;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Dispose();
            reader.Dispose();

            return brojac;
        }

        //Brisanje favorita iz baze
        public static void delFav(string serialNum)
        {
            string sqlQuery = "UPDATE device SET favourites = 0 WHERE sn = '" + serialNum + "'";
            ExecuteSQL(sqlQuery);
            ConnectionClose();

        }
    }
}
