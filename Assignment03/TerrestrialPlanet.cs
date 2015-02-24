using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class TerrestrialPlanet : Planet
    {
         ///Private Properties
        private bool _oxygen;
 
        //Constructor
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) 
            : base(name, diameter, mass) 
        {
            this._oxygen = oxygen;
        }

        public override bool HasMoons()
        {
            bool hasMoons;
            if (MoonCount > 0)
            {
                hasMoons = true;
            }
            else
            {
                hasMoons = false;
            }
            return hasMoons;
        }

        public override bool Habitable()
        {
            
            return _oxygen;
        }
    }
}
