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
        public int Broj { get; set; }
        public string Lozinka { get; set; }
        public static string Model { get; set; }

        public DateTime Device_connected { get; set; }

        //public bool OnOff() {}


        //public int RegTemp() {  }

        //public int RegVre() {  }

    }
}
