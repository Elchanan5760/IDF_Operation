using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.models
{
    internal class trrorist
    {
        public string Name;
        public int Rank;
        public string Status;
        public string Arms;

        public trrorist(string name, int rank, string status, string arms)
        {
            Name = name;
            Rank = rank;
            Status = status;
            Arms = arms;
        }
     

    }

}