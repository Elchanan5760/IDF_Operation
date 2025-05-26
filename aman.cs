using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;

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
        //public void Message()
        //{
        //    foreach()
        //    return ($"nameTrrorist:{ham}\nlastlocatuon:{LastLocatuon}\ntimeInformation:{TimeInformation}");
        //}
    }
}

 