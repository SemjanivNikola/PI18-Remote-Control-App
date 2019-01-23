using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MrezaSijalica : Device     
    {
        public int Lux { get; set; }
        public int IdMreze { get; set; }

        public int ReguliranjeSvjetlinePlus()
        {
            return Lux++;
        }
        public int ReguliranjeSvjetlineMin()
        {
            return Lux--;
        }
    }
}
