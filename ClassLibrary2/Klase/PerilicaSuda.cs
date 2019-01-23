using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Klase
{
    public class PerilicaSuda : Device
    {
        public decimal StartTime { get; set; }
        public decimal WashTime { get; set; }
        public int Temp { get; set; }

        public Enumeracija.Dishes VrstaPosuda { get; set; }
    }
}
