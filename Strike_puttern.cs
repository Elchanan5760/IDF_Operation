using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.models
{
    public interface IStrikePuttern
    {
        public string UniqueName();

        public int GetAmmunitionCapacity();

        public double GetLiterOfFuelSupply();

        public string Against();

        public void InitializeAmmunitionCapacity();

        public void InitializeLiterOfFuelSupply();
    }
}
