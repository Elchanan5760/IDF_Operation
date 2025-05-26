using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;

namespace IDF_Operation.models
{
    public class Drones:IStrikePuttern
    {
        public string UniqueName()
        {
            return "Hermes 460 Drone";
        }

        public int AmmunitionCapacity { get; set; }

        public double LiterOfFuelSupply { set; get; }

        public string Against()
        {
            return "People Vehicles";
        }
    }
}
