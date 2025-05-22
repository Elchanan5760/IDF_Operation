using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.models
{
    public class Aman
    {
        public trrorist NameTroorist;
        public string LastLocatuon;
        public string TimeInformation;
        public Aman(trrorist nameTrrorist,string lastLocatuon, string tiimeInformation)
        {
            NameTroorist = nameTrrorist;
            LastLocatuon = lastLocatuon;
            TimeInformation = tiimeInformation;
        }

        public void Message()
        {
            Console.WriteLine($"nameTrrorist:{NameTroorist}\nlastlocatuon:{LastLocatuon}\ntimeInformation:{TimeInformation}");
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> origin/main
