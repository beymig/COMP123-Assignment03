using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet Saturno = new GiantPlanet("SATURNO",120536, 5683190000000000000,"Gas");
            Saturno.MoonCount = 31;
            Saturno.OrbitalPeriod = 30;
            Saturno.RingCount = 7;
            Saturno.RotationPeriod = 10.2;
            Saturno.HasMoons();
            Saturno.HasRings();
            Saturno.ToString();

            TerrestrialPlanet Tierra = new TerrestrialPlanet("TIERRA", 12742, 59721900000000,true);
            Tierra.MoonCount = 1;
            Tierra.OrbitalPeriod = 1;
            Tierra.RingCount = 0;
            Tierra.RotationPeriod = 1;
            Tierra.HasMoons();
            Tierra.Habitable();
            Tierra.ToString();
        }
    }
}
