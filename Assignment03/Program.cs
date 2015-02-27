/* Author's Name: Beymig Munoz
 * Date Last Modified: 27 Feb 2015
 * Program Description: A program that creates two planets, one Giant and one Terrestrial.
 * Revision History:
 * - Created classes and private and public properties in abstrac class. (Feb 23)
 * - Created constructor method and overrided the inherited method. (Feb 23)
 * - Created GiantPlanet class speciifications. (Feb 23)
 * - Created TerrestrialPlanet class speciifications. (Feb 23)
 * - Created the interfaces. (Feb 23)
 * - Created new planets. (Feb 23)
 * - Implemented interfaces. (Feb 24)
 * - Finished Program Documentation. (Feb 27)
 */

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
            //New Giant Planet Object 
            GiantPlanet Saturno = new GiantPlanet("SATURNO",120536, 5683190000000000000,"Gas");
            Saturno.MoonCount = 31;
            Saturno.OrbitalPeriod = 30;
            Saturno.RingCount = 7;
            Saturno.RotationPeriod = 10.2;
            Saturno.HasMoons();
            Saturno.HasRings();
            Saturno.ToString();

            //New Giant Terrestrial Object
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
