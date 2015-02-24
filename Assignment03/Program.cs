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
            Console.WriteLine(Saturno.ToString());

            TerrestrialPlanet Tierra = new TerrestrialPlanet("TIERRA", 12742, 59721900000000,true);
            Console.WriteLine(Tierra.ToString());      
        }
    }
}
