using System;
using System.Collections.Generic;
using System.ComponentModel; //Dodano za Description
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Klase
{
    public class Enumeracija
    {
        public enum ProgramPranja { BijeloRublje, SarenoRublje, CrnoRublje, Vuna,  };
        public enum Dishes { Bestek, MetalnePosude, Tanjuri, Plastika };
        public enum TemperaturaPranja   //cita se description
        {
            [Description("40°C")] c40,
            [Description("50°C")] c50,
            [Description("60°C")] c60,
            [Description("70°C")] c70
        };
        public enum TemperaturaPecnica
        {
            [Description("30°C")] c30,
            [Description("60°C")] c60,
            [Description("120°C")] c120,
            [Description("180°C")] c180,
            [Description("220°C")] c220,
            [Description("300°C")] c300
        };
        public enum TimerPecnica
        {
            [Description("5 min")] m5,
            [Description("15 min")] m15,
            [Description("30 min")] m30,
            [Description("45 min")] m45,
            [Description("60 min")] m60,
            [Description("90 min")] m90,
            [Description("120 min")] m120
        };
        public enum ModeAC { Cold, Warm, Dry };
        public enum ModeWM { Start, Stop, Pause };
        public enum OnOff { On, Off };
        public enum Connected { Connected, Disconnected }
    }
}
