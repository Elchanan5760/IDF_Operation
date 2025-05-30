using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;


namespace IDF_Operation.models
{
    public class DaIntelligence
    {

        static public Dictionary<Terrorist, List<string>> MessageTerrorist(List<Terrorist> list)
        {
            Random rand = new Random();

            List<string> status = new List<string>()
                {"outside","vehicle","building"};
            Dictionary<Terrorist, List<string>> dict = new Dictionary<Terrorist, List<string>>();
            for (int i = 0; i < 20; i++)
            {
                Terrorist t = list[rand.Next(list.Count)];
                {
                    DateTime now = DateTime.Now;
//<<<<<<< HEAD
//                    if (dict.ContainsKey(t.GetName()))
//                    {
//                        dict[t.GetName()].AddRange(new List<string>() { status[rand.Next(status.Count)], $"{now}" });
//                    }
//                    else
//                        dict[t.GetName()] = new List<string>() { status[rand.Next(status.Count)], $"{now}" };
//=======
                    if (dict.ContainsKey(t))
                    {
                        dict[t].AddRange(new List<string>() { status[rand.Next(status.Count)], $"{now}" });
                    }
                    else
                        dict[t] = new List<string>() { status[rand.Next(status.Count)], $"{now}" };


                }


            }
            //foreach (var t in dict) 
            {
                //Console.WriteLine(t.Key);
            }


            return dict;
        }

      
    }


}