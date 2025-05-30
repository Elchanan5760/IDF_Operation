using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.models;

public class Knife : IWeapon
{
    public int GetWeaponRank()
    {
        return 1;
    }
}
