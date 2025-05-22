using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation
{
    public class Haman
    {
        public string NameTroorist;
        public string LastLocatuon;
        public string TimeInformation;
        public Haman(string nameTrrorist, string lastLocatuon )
        {
            NameTroorist = nameTrrorist;
            LastLocatuon = lastLocatuon;
            DateTime TimeInformation = DateTime.Now; 
        }

        public void Message()
        {
            Console.WriteLine($"nameTrrorist:{NameTroorist}\nlastlocatuon:{LastLocatuon}\ntimeInformation:{TimeInformation}");
        }
    }
}