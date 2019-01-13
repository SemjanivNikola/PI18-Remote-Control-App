using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Hladnjak : Device
    {
        public bool Led = false;
        public int Temperatura { get; set; }

        public bool Ice()
        {
            return Led = true;
        }

        public int TempPlus()
        {
            return Temperatura++;
        }
        public int TempMin()
        {
            return Temperatura++;
        }
    }
}
