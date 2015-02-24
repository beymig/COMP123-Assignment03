using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class GiantPlanet : Planet
    {
        ///Private Properties
        private string _type;
 
        //Constructor
        public GiantPlanet(string name, double diameter, double mass, string type) 
            : base(name, diameter, mass) 
        {
            this._type = type;
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

        public override bool HasRings()
        {
            bool hasRings;
            if (RingCount > 0)
            {
                hasRings = true;
            }
            else
            {
                hasRings = false;
            }
            return hasRings;
        }
  
    }
}
