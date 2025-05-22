using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.models
{
    public class Aman
    {
        public string NameTroorist;
        public string LastLocatuon;
        public string TimeInformation;
        public Aman(string nameTroorist, string lastLocatuon, string tiimeInformation)
        {
            NameTroorist = nameTroorist;
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
