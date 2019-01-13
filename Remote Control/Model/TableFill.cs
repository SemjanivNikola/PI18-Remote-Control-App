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
        public static string off_timer = null;
        public static string temp = null;
        public static string delay_start = null;
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
                    /*case "TV":
                        {
                            vol = (string)reader["vol"];
                            program = (string)reader["program"];
                            sn = (string)reader["sn"];
                            inUse = (string)reader["in_use"];
                            name = (string)reader["name"];
                            model = (string)reader["model"];
                        }
                        break;*/
                    case "AirCon":
                        {
                            temp = (string)reader["temp"];
                            delay_start = (string)reader["delay_start"];
                            fan_speed = (string)reader["fan_speed"];
                            sn = (string)reader["sn"];
                            inUse = (string)reader["in_use"];
                            name = (string)reader["name"];
                            model = (string)reader["model"];
                        }
                        break;
                    case "WtrHtr":
                        {
                            temp = (string)reader["temp"];
                            co2 = (string)reader["co2"];
                            sn = (string)reader["sn"];
                            inUse = (string)reader["in_use"];
                            name = (string)reader["name"];
                            model = (string)reader["model"];
                        }
                        break;
                    case "WasMachine":
                        {
                            temp = (string)reader["temp"];
                            delay_start = (string)reader["delay_start"];
                            sn = (string)reader["sn"];
                            inUse = (string)reader["in_use"];
                            name = (string)reader["name"];
                            model = (string)reader["model"];
                        }
                        break;
                    case "DisWasher":
                        {
                            delay_start = (string)reader["delay_start"];
                            sn = (string)reader["sn"];
                            inUse = (string)reader["in_use"];
                            name = (string)reader["name"];
                            model = (string)reader["model"];
                        }
                        break;
                    case "Stove":
                        {
                            stoveTemp = (string)reader["stoveTemp"];
                            p1Temp = (string)reader["p1Temp"];
                            p2Temp = (string)reader["p2Temp"];
                            p3Temp = (string)reader["p3Temp"];
                            p4Temp = (string)reader["p4Temp"];
                            p5Temp = (string)reader["p5Temp"];
                            sn = (string)reader["sn"];
                            inUse = (string)reader["in_use"];
                            name = (string)reader["name"];
                            model = (string)reader["model"];
                        }
                        break;
                    case "Refri":
                        {
                            temp = (string)reader["temp"];
                            sn = (string)reader["sn"];
                            inUse = (string)reader["in_use"];
                            name = (string)reader["name"];
                            model = (string)reader["model"];
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
                            sqlQuery = " INSERT INTO TV (vol, program, off_timer, sn, in_use, name, model ) VALUES (0, 0, 0, '" + sn + "', 0, '" + name + "', '" + model + "') ";
                        }
                        break;
                    case "Air Conditioner":
                        {
                            sqlQuery = " INSERT INTO AirCon (delay_start, off_timer, temp, fan_speed, sn, in_use, name, model ) VALUES (0, 0, 0, 0, '"+ sn + "', 0, '" + name + "', '" + model + "') ";
                        }
                        break;
                    case "Water Heater":
                        {
                            sqlQuery = " INSERT INTO WtrHtr (temp, co2, sn, in_use, name, model ) VALUES (0, 0, '" + sn + "', 0, '" + name + "', '" + model + "') ";
                        }
                        break;
                    case "Washing Machine":
                        {
                            sqlQuery = " INSERT INTO WasMachine (delay_start, temp, sn, in_use, name, model ) VALUES (0, 0, '" + sn + "', 0, '" + name + "', '" + model + "') ";
                        }
                        break;
                    case "Dishwasher":
                        {
                            sqlQuery = " INSERT INTO DisWasher (delay_start, sn, in_use, name, model ) VALUES (0, '" + sn + "', 0, '" + name + "', '" + model + "') ";
                        }
                        break;
                    case "Stove":
                        {
                            sqlQuery = " INSERT INTO Stove (NumOfPlates, stoveTemp, PlateNum, in_use, sn, name, model, p1Temp, p2Temp, p3Temp, p4Temp, p5Temp) VALUES (0, 0, 0, 0, '" + sn + "', '" + name + "', '" + model + "', 0, 0, 0, 0, 0) ";
                        }
                        break;
                    case "Refrigirator":
                        {
                            sqlQuery = " INSERT INTO Refri (temp, sn, in_use, name, model ) VALUES (0, '" + sn + "', 0, '" + name + "', '" + model + "') ";
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
