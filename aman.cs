using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;

namespace IDF_Operation.models
{
    
    public class Aman
    {
        private trrorist Trrorist { get; set; }
        private string LastLocatuon { get; set; }
        private string TimeInformation { get; set; }
        public Aman(trrorist trrorist, string lastLocatuon, string tiimeInformation)
        {
            Trrorist = trrorist;
            LastLocatuon = lastLocatuon;
            TimeInformation = tiimeInformation;
        }

        

        //public Aman Message()
        //{
        //    Console.WriteLine($"nameTrrorist:{NameTroorist}\nlastlocatuon:{LastLocatuon}\ntimeInformation:{TimeInformation}");
        //    return new Aman(NameTroorist,LastLocatuon,TimeInformation);
        //}
    }
}
