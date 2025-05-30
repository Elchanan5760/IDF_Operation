using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;

namespace IDF_Operation.models
{

    public class Aman
    {

        public string TheMostInformation(Dictionary<Terrorist, List<string>> dict)
        {
            int big = 0;
            string name = "";
            //Dictionary<string, List<string>> name = new Dictionary<string, List<string>>();
            foreach (var item in dict)
            {
                if (item.Value.Count > big)
                {
                    big = item.Value.Count;
                    name = item.Key.GetName();
                    
                }
                Console.WriteLine($"{name}: {item.Value.Count}");


            }

            //foreach (var item in dict)
            //{
            //    Console.WriteLine($"{name}: {item.Value.Count}");
            //}
            //foreach (var item in dict)
            //{
            //    Console.WriteLine(item.Value.Count);
            //}


            //Console.WriteLine(name);

            //Console.WriteLine(big);
            return name;

        }

        public (Terrorist, int) GetMostDangerousTerrorist(Hamas hamas)
        {
            //string terroristName = null;
            //int risk = 0;
            //foreach (var item in dict1)
            //{
            //    int temp = IWeapon.G;
            //    if (temp > risk)
            //    {
            //        risk = temp;
            //        terroristName = item.Key.GetName();
            //    }
            //}
            //return terroristName;
            int calculateMostDangerous = 0;
            Terrorist mostTerrorist = hamas.ListTrrorist[0];
            
            foreach (Terrorist terrorist in hamas.ListTrrorist)
            {
                if (terrorist.GetRank() * terrorist.GetWeapon().GetWeaponRank() > calculateMostDangerous)
                {
                    calculateMostDangerous = terrorist.GetRank() * terrorist.GetWeapon().GetWeaponRank();
                    mostTerrorist = terrorist;
                }
            }
            
            return ( mostTerrorist, calculateMostDangerous );
        }

    }
}





        //public Aman GetLocation()
        //{

        //}

        //public static String RiskTerrorist(Dictionary<Terrorist, List<string>> dict1)
        //{
        //    string terroristName = null;
        //    int risk = 0;
        //    foreach (var item in dict1)
        //    {
        //        int temp = RankAcount(item.Key);
        //        if (temp > risk)
        //        {
        //            risk = temp;
        //            terroristName = item.Key.Name;

    //}
                
            



    //    }




        //public static int RankAcount(Terrorist terr)
        //{
        //    int riskWoepon = 0;

        //    //foreach (var item in dict2)

        //    {
        //        if (terr.Arms == "knife")
        //        {
        //            riskWoepon = 1;
        //        }
        //        else if (terr.Arms == "gun")
        //        {
        //            riskWoepon = 2;
        //        }
        //        else if (terr.Arms == "m16" || terr.Arms == "ak 47")
        //        {
        //            riskWoepon = 3;
        //        }
        //    }
        //    return riskWoepon;

            //"m16", "knife", "gun","ak 47"

 