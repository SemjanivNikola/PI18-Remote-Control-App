using Finisar.SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_Control
{
    class TableFill : DataAccess
    {

        static string sqlQuery = null;

        //-----   CLASS VARS   -----//
        //-----   LIGHTS   -----//
        public static string brightness = null;

        //-----   TV   -----//
        public static string vol = null;
        public static string program = null;

        //-----   AIR CONDITIONER   -----//
        public static string fan_speed = null;
        
        //-----   WATER HEATER   -----//
        public static string co2 = null;

        //-----   WASHING MACHINE   -----//
        //-----   DISHWASHER   -----//

        //-----   STOVE   -----//
        public static string stoveTemp = null;
        public static string p1Temp = null;
        public static string p2Temp = null;
        public static string p3Temp = null;
        public static string p4Temp = null;
        public static string p5Temp = null;

        //-----   REFIGERATOR   -----//




        //-----   UNIVERSAL VARS   -----//
        public static string inUse = null;
        public static string name = null;
        public static string model = null;
        public static string temp = null;
        public static string sn = null;


        public static void GetProperties(string devName, string sqlQuery)
        {
            SQLiteCommand cmd = new SQLiteCommand(sqlQuery, Connection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            try
            {
                switch (devName)
                {
                    case "Lights":
                        {
                            while (reader.Read())
                            {
                                brightness =(string) reader["brightness"];
                                Convert.ToInt32(brightness);
                                sn = reader["sn"].ToString();
                                inUse = (string) reader["in_use"];
                                name = (string) reader["name"];
                                model = (string) reader["model"];
                            }
                        }
                        break;
                    case "TV":
                        {
                            while (reader.Read())
                            {
                                vol = (string)reader["vol"];
                                program = (string)reader["program"];
                                sn = reader["sn"].ToString();
                                inUse = (string)reader["in_use"];
                                name = (string)reader["name"];
                                model = (string)reader["model"];
                            }
                        }
                        break;
                    case "AirCon":
                        {
                            while (reader.Read())
                            {
                                temp = (string)reader["temp"];
                                fan_speed = (string)reader["fan_speed"];
                                sn = reader["sn"].ToString();
                                inUse = (string)reader["in_use"];
                                name = (string)reader["name"];
                                model = (string)reader["model"];
                            }
                        }
                        break;
                    case "WtrHtr":
                        {
                            while (reader.Read())
                            {
                                temp = (string)reader["temp"];
                                co2 = (string)reader["co2"];
                                sn = reader["sn"].ToString();
                                inUse = (string)reader["in_use"];
                                name = (string)reader["name"];
                                model = (string)reader["model"];
                            }

                        }
                        break;
                    case "WasMachine":
                        {
                            while (reader.Read())
                            {
                                temp = (string)reader["temp"];
                                sn = reader["sn"].ToString();
                                inUse = (string)reader["in_use"];
                                name = (string)reader["name"];
                                model = (string)reader["model"];
                            }
                        }
                        break;
                    case "Dishwasher":
                        {
                            while (reader.Read())
                            {
                                sn = reader["sn"].ToString();
                                inUse = (string)reader["in_use"];
                                name = (string)reader["name"];
                                model = (string)reader["model"];
                            }
                        }
                        break;
                    case "Stove":
                        {
                            while (reader.Read())
                            {
                                p1Temp = reader["p1Temp"].ToString();
                                p2Temp = reader["p2Temp"].ToString();
                                p3Temp = reader["p3Temp"].ToString();
                                p4Temp = reader["p4Temp"].ToString();
                                p5Temp = reader["p5Temp"].ToString();
                                sn = reader["sn"].ToString();
                                inUse = (string)reader["in_use"];
                                name = (string)reader["name"];
                                model = (string)reader["model"];
                            }
                        }
                        break;
                    case "Refrigerator":
                        {
                            while (reader.Read())
                            {
                                temp = (string)reader["temp"];
                                sn = reader["sn"].ToString();
                                inUse = (string)reader["in_use"];
                                name = (string)reader["name"];
                                model = (string)reader["model"];
                            }
                        }
                        break;
                    default: break;
                }
                cmd.Dispose();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  Spremanje novog uredaja u bazu u njegovu tablicu
        public static void Trigger(string type, string name, string sn, string model)
        {
            try
            {
                switch (type)
                {
                    case "Lights":
                        {
                            sqlQuery = " INSERT INTO Lights (brightness, sn, in_use, name, model ) VALUES (0, '" + sn + "', 0, '" + name + "', '" + model + "') ";
                        }
                        break;
                    case "TV":
                        {
                            sqlQuery = " INSERT INTO TV (vol, program, off_timer, sn, in_use, name, model ) VALUES (0, 0, '" + sn + "', 0, '" + name + "', '" + model + "') ";
                        }
                        break;
                    case "Air Conditioner":
                        {
                            sqlQuery = " INSERT INTO AirCon (temp, fan_speed, sn, in_use, name, model ) VALUES (0, 0, '"+ sn + "', 0, '" + name + "', '" + model + "') ";
                        }
                        break;
                    case "Water Heater":
                        {
                            sqlQuery = " INSERT INTO WtrHtr (temp, co2, sn, in_use, name, model ) VALUES (0, 0, '" + sn + "', 0, '" + name + "', '" + model + "') ";
                        }
                        break;
                    case "Washing Machine":
                        {
                            sqlQuery = " INSERT INTO WasMachine (temp, sn, in_use, name, model ) VALUES (0, '" + sn + "', 0, '" + name + "', '" + model + "') ";
                        }
                        break;
                    case "Dishwasher":
                        {
                            sqlQuery = " INSERT INTO Dishwasher (sn, in_use, name, model ) VALUES ('" + sn + "', 0, '" + name + "', '" + model + "') ";
                        }
                        break;
                    case "Stove":
                        {
                            sqlQuery = " INSERT INTO Stove (stoveTemp, in_use, sn, name, model, p1Temp, p2Temp, p3Temp, p4Temp, p5Temp) VALUES (0, 0, '" + sn + "', '" + name + "', '" + model + "', 0, 0, 0, 0, 0) ";
                        }
                        break;
                    case "Refrigerator":
                        {
                            sqlQuery = " INSERT INTO Refrigerator (temp, sn, in_use, name, model ) VALUES (0, '" + sn + "', 0, '" + name + "', '" + model + "') ";
                        }
                        break;
                    default: break;
                }

                ExecuteSQL(sqlQuery);
                ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
