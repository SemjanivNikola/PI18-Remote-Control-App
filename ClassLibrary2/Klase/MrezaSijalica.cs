using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MrezaSijalica : Device     //Za ovo jos treba vidit, ne znam kako ce mo ovo tocno implementirat
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

    public class Sijalica : MrezaSijalica
    {
        public int IdSijalice { get; set; }
    }
}
