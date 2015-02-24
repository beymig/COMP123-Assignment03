﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    class GiantPlanet : Planet, IHasMoons, IHasRings 

    {
        
        ///Private Properties
        private string _type;
 
        //Constructor
        public GiantPlanet(string name, double diameter, double mass, string type) 
            : base(name, diameter, mass) 
        {
            this._type = type;
            Console.WriteLine("This giant planet type is: {0}",_type);
        }

            
        public bool HasMoons()
        {
            bool hasMoons;
            if (MoonCount > 0)
            {
                hasMoons = true;
                Console.WriteLine("This Giant Planet has moons");
            }
            else
            {
                hasMoons = false;
                Console.WriteLine("This Giant Planet does not has moons");
            }
            return hasMoons;
        }

        public bool HasRings()
        {
            bool hasRings;
            if (RingCount > 0)
            {
                hasRings = true;
                Console.WriteLine("This Giant Planet has rings");
            }
            else
            {
                hasRings = false;
                Console.WriteLine("This Giant Planet does not has rings");
            }
            return hasRings;
            
        }
  
    }
}
