using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;

namespace IDF_Operation.models
{
    public class Aircraft:IStrikePuttern
    {
        public int ammunitionCapcity = 8;
        public double literOfSupply = 10000;
        public string UniqueName()
        {
            return "F16 Fighter Jet";
        }

        public int AmmunitionCapcity()
        {
            return ammunitionCapcity;
        }

        public double LiterOfFuelSupply()
        {
            return literOfSupply;
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
