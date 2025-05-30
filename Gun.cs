using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.models;

public class Gun:IWeapon
{
    public int GetWeaponRank()
    {
        return 2;
    }
    public string GetWeaponName()
    {
        return "Gun";
    }
}
