using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;

namespace IDF_Operation.models
{
    public class Artillery:IStrikePuttern
    {
        public int ammunitionCapcity = 40;
        public double literOfSupply = 100;
        public string UniqueName()
        {
            return "Hermes 460 Drone";
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
            return "People Vehicles";
        }
    }
}
