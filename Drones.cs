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
        private int _ammunitionCapacity;
        private double _literOfSupply;

        public string UniqueName()
        {
            return "Hermes 460 Drone";
        }

        public int GetAmmunitionCapacity()
        {
            return _ammunitionCapacity;
        }

        public double GetLiterOfFuelSupply()
        {
            return _literOfSupply;
        }

        public string Against()
        {
            return "People Vehicles";
        }
        public void InitializeAmmunitionCapacity()
        {
            _ammunitionCapacity = 3;
        }
        public void InitializeLiterOfFuelSupply()
        {
            _literOfSupply = 100;
        }
    }
}
