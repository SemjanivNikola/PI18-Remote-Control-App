using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Device
    {
        public static string Naziv { get; set; }
        public static string serialNum { get; set; }
        public static  string Type { get; set; }
        public static bool On = false;
        public static string Lozinka { get; set; }
        public static string tipLozinke { get; set; }
        public static string Model { get; set; }
        public static bool favorit { get; set; }

        public DateTime Device_connected { get; set; }


        public static bool CheckOnOff()
        {
            if (On == true)
                return true;
            else
                return false;
        }
    }
}
