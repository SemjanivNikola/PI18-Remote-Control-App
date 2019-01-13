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
        public DateTime OnTimer { get; set; }
        public DateTime OffTimer { get; set; }

        public int FanPov()
        {
            return FanSpeed++;
        }

        public int FanSma()
        {
            return FanSpeed--;
        }

        public bool TimerOn()
        {
            if (OnTimer == DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TimerOff()
        {
            if (OffTimer == DateTime.Now)
            {
                return false;
            }
            else
            {
                return false;
            }
        } 
            

    }
}
