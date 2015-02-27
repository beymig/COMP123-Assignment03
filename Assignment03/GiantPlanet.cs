using System;
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
            Console.WriteLine("****************************************");
            Console.WriteLine("This Giant planet type is: {0}",_type);
        }

            
        // Public method to check if the Giant Planet has moons
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

        // Public method to check if the Giant Planet has rings
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
