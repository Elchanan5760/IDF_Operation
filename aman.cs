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


        static public Dictionary<string, List<string>> TheMostInformation(Dictionary<string, List<string>> dict)
        {
            int big = 0;
            Dictionary<string, List<string>> name = new Dictionary<string, List<string>>();
            foreach (var item in dict)
            {
                if (item.Value.Count > big)
                {
                    big = item.Value.Count;
                    name[item.Key] = item.Value;
                }
               


            }
            Console.WriteLine(big);
            foreach (var item in dict)
            {
                Console.WriteLine(item.Value.Count);
            }
            return name;

        }

        
    }
}

 


   
