using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Klima : Device
    {
        public int FanSpeed { get; set;}
        public int Temp { get; set; }

        public int FanPov()
        {
            return FanSpeed++;
        }

        public int FanSma()
        {
            return FanSpeed--;
        }
    }
}
