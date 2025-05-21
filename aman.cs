using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation
{
    public class Aman
    {
        public string NameTroorist;
        public string LastLocatuon;
        public string TimeInformation;
        public Haman(string nameTrrorist, string lastLocatuon, string tiimeInformation)
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
}
