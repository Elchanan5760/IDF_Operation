using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.models
{
    public class Terrorist
    {
        public string Name;
        public int Rank;
        public string Status;
        public string Arms;

        public Terrorist(string name, int rank, string status, string arms)
        {
            Name = name;
            Rank = rank;
            Status = status;
            Arms = arms;
        }
     

    }

}