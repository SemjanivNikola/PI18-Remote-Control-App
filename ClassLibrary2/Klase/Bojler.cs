using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Bojler : Device
    {
        public int Plin { get; set; }
        public int Co2 { get; set; }

        public decimal OcitavanjePlina() {
            Random rand = new Random();
            Plin = rand.Next(1, 30);
            return Plin;
        }

     //   public decimal OmjerCo2() { } visak jer je isto
    }
}
