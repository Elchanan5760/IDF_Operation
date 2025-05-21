using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.Strike;

namespace IDF_Operation.Air
{
    public class Aircraft:StrikePuttern
    {
        public string UniqueName()
        {
            return "F16 Fighter Jet";
        }

        public int AmmunitionCapcity()
        {
            return 8;
        }

        public double LiterOfFuelSupply()
        {
            return 10000.0;
        }

        public string Against()
        {
            return "Building";
        }
        public void OpeatedBy()
        {
            Console.WriteLine("Operated by pilot");
        }
    }
}
