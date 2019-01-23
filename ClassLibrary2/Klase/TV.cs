using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TV : Device
    {
        public static int currentState { get; set; }
        public static bool Mute { get; set; }

        
        public static bool MuteMet()
        {
            if(Mute == true)
            {
                return Mute = false;
            }
            else
            {
                return Mute = true;
            }
        }
    }
}
