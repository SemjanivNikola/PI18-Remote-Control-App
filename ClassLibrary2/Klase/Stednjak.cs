using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Stednjak : Device
    {
        public int Temp { get; set; }
        public decimal Alarm { get; set; }

        public bool Timer()
        {
            return true;
        }
    }

    public class Ploca : Stednjak
    {
        public int IdPloce { get; set; }
        public int BrPloca { get; set; }
        public int TemperaturaPloce { get; set; }

        public int TemperaturaPlus()
        {
            return TemperaturaPloce++;
        }

        public int TemperaturaMin()
        {
            return TemperaturaPloce--;
        }
    }

    public class Pecnica : Stednjak
    {
        
    }
}
