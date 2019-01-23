using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Bojler : Device
    {
        public static int Plin { get; set; }
        public static int Co2 { get; set; }

        public  static decimal OcitavanjePlina() {
            Random rand = new Random();
            Plin = rand.Next(1, 30);
            return Plin;
        }
    }
}
