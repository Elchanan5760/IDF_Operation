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

        static public string TheMostInformation(Dictionary<Terrorist, List<string>> dict)
        {
            int big = 0;
            string name = "";
            //Dictionary<string, List<string>> name = new Dictionary<string, List<string>>();
            foreach (var item in dict)
            {
                if (item.Value.Count > big)
                {
                    big = item.Value.Count;
                    name = item.Key.Name;
                }



            }

            //Console.WriteLine(name);

            //Console.WriteLine(big);
            return name;

        }
        public static String RiskTerrorist(Dictionary<Terrorist, List<string>> dict1)
        {
            string terroristName = null;
            int risk = 0;
            foreach (var item in dict1)
            {
                int temp = RankAcount(item.Key);
                if (temp > risk)
                {
                    risk = temp;
                    terroristName = item.Key.Name;


                }
                
            }
            return terroristName;



        }




        public static int RankAcount(Terrorist terr)
        {
            int riskWoepon = 0;

            //foreach (var item in dict2)

            {
                if (terr.Arms == "knife")
                {
                    riskWoepon = 1;
                }
                else if (terr.Arms == "gun")
                {
                    riskWoepon = 2;
                }
                else if (terr.Arms == "m16" || terr.Arms == "ak 47")
                {
                    riskWoepon = 3;
                }
            }
            return riskWoepon;

            //"m16", "knife", "gun","ak 47"

        }
    }
}