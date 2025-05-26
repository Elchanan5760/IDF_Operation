using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;

namespace IDF_Operation.models
{
    public class Aircraft : IStrikePuttern
    {
        public string UniqueName()
        {
            return "F16 Fighter Jet";
        }

        public int AmmunitionCapacity { get; set; }

        public double LiterOfFuelSupply { get; set; }

        public string Against()
        {
            return "Building";
        }
        public string OpeatedBy()
        {
            return "Operated by pilot";
        }
    }
}
