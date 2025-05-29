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
        private int _ammunitionCapacity;
        private double _literOfSupply;
        public string UniqueName()
        {
            return "F16 Fighter Jet";
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
            return "Building";
        }
        public string OpeatedBy()
        {
            return "Operated by pilot";
        }
        public void InitializeAmmunitionCapacity()
        {
            _ammunitionCapacity = 8;
        }
        public void InitializeLiterOfFuelSupply()
        {
            _literOfSupply = 1000;
        }
    }
}
