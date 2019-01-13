using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Finisar.SQLite;
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

        public static void ConnectionClose()
        {
            Connection.Close();
        }

        /*public static DataView GetDataTableView(string sql)
        {
            DataSet ds = GetDataView(sql);
            DataView dv = new DataView(ds.Tables[0]);

            return dv;
        }*/

        public static DataSet GetDataSet(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);
            SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            Connection.Close();

            cmd.Dispose();
            adp.Dispose();

            return ds;
        }

        public static DataTable GetDataTable(string sql)
        {
            Console.WriteLine(sql);
            DataSet ds = GetDataSet(sql);

            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }

        /*public static DataTable GetDataView(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);
            SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
        
            adp.Fill(dt);
            Connection.Close();
            return dt;
        }*/

        public static int ExecuteSQL(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);
            return cmd.ExecuteNonQuery();
        }

        /*public static DataTable GetDataTableView(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, Connection);
            cmd.CommandText = String.Format(sql);

            SQLiteDataAdapter adp = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            try
            {
                ds.Tables.Add(dt);
                adp.Fill(dt);
                Connection.Close();
            }

            catch (Exception)
            {
                throw;
            }

            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }*/

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

            catch (Exception)
            {
                throw;
            }

            cmd.Dispose();
            reader.Dispose();

            return strSN;
        }
    }

}
