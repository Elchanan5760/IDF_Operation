using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.models;

public class AK47:IWeapon
{
    public int GetWeaponRank()
    {
        return 3;
    }
    public string GetWeaponName()
    {
        return "AK47";
    }
}
