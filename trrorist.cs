using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.models
{
    public class Terrorist
    {
        private string _name;
        private int _rank;
        private string _status;
        private IWeapon _arms;

        public Terrorist(string name, int rank, string status, IWeapon arms)
        {
            _name = name;
            _rank = rank;
            _status = status;
            _arms = arms;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetRank()
        {
            return _rank;
        }
        public IWeapon GetWeapon()
        {
            return _arms;
        }
    }

}