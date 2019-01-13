using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TV : Device
    {
        public int Glasnoca { get; set; }
        public int TrenutniProgram { get; set; }
        public bool Mute { get; set; }
        public DateTime OnTimer { get; set; }
        public DateTime OffTimer { get; set; }

        public int PromjenaProgramaPlus()
        {
            return TrenutniProgram++;
        }

        public int PromjenaProgramaMin()
        {
            return TrenutniProgram--;
        }

        public int ReguliranjeGlasnocePlus()
        {
            return Glasnoca++;
        }

        public int ReguliranjeGlasnoceMin()
        {
            return Glasnoca--;
        }

        public bool MuteMet()
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
