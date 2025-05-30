using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation
{
    public interface IWeapon
    {
        public int GetWeaponRank();
        public string GetWeaponName();
    }
}
