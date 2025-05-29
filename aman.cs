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

        static public string TheMostInformation(Dictionary<string, List<string>> dict)
        {
            int big = 0;
            string name = "";
            //Dictionary<string, List<string>> name = new Dictionary<string, List<string>>();
            foreach (var item in dict)
            {
                if (item.Value.Count > big)
                {
                    big = item.Value.Count;
                    name = item.Key;
                }



            }

            //Console.WriteLine(name);

            //Console.WriteLine(big);
            return name;

        }
    }



}
