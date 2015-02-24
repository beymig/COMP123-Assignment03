using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
         ///Private Properties
        private bool _oxygen;
 
        //Constructor
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) 
            : base(name, diameter, mass) 
        {
            this._oxygen = oxygen;
        }

        public bool HasMoons()
        {
            bool hasMoons;
            if (MoonCount > 0)
            {
                hasMoons = true;
                Console.WriteLine("This Terrestrial Planet has rings");
            }
            else
            {
                hasMoons = false;
                Console.WriteLine("This Giant Planet does not has moons");
            }
            return hasMoons;
        }

        public  bool Habitable()
        {

            if (_oxygen == true)
            { 
                Console.WriteLine("This Terrestrial Planet is Habitable");
            }
            if (_oxygen == false)
            {
                Console.WriteLine("This Terrestrial Planet is not Habitable");
            }
            return _oxygen;
        }
    }
}
