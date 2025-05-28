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
                if (dict.Values.Count > big)
                {
                    big = dict.Values.Count;
                    name[item.Key] = item.Value;
                }
               


            }
            foreach (var item in name)
            { 
            Console.WriteLine(item.Value.Count +"jjjj");
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Value.Count);
            }
            return name;
        }
       
     
        
    }
}

 


   
