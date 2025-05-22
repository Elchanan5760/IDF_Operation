using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;

namespace IDF_Operation.models
{
    public class Artillery:StrikePuttern
    {
        public string UniqueName()
        {
            return "Hermes 460 Drone";
        }

        public int AmmunitionCapcity()
        {
            return 3;
        }

        public double LiterOfFuelSupply()
        {
            return 100.0;
        }

        public string Against()
        {
            return "People Vehicles";
        }
    }
}
