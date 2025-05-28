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

      

        private Terrorist Trrorist { get; set; }
        private string LastLocatuon { get; set; }
        private string TimeInformation { get; set; }
        public Aman(Terrorist trrorist, string lastLocatuon, string tiimeInformation)

        {
            Trrorist = trrorist;
            LastLocatuon = lastLocatuon;
            TimeInformation = tiimeInformation;
        }
        
        //public Aman GetLocation()
        //{
            
        //}

        //public string theMostInformation()
        //{

        //    Dictionary<string, int> terroristNumLocations = new Dictionary<string, int>();
        //    foreach (Aman location in .locations)
        //    {
        //        if (terroristNumLocations.ContainsKey(location.Trrorist.Name))
        //        {
        //            terroristNumLocations[location.Trrorist.Name] += 1;
        //        }
        //        else
        //        {
        //            terroristNumLocations[location.Trrorist.Name] = 1;
        //        }
        //    }
        //    int mostTimes = 0;
        //    foreach (var item in terroristNumLocations)
        //    {
        //        if (item.Value > mostTimes)
        //        {
        //            mostTimes = item.Value;
        //            Trrorist = item.Key;
        //        }
        //    }
        //    return Trrorist.Name;
        //}
    }
}