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



        public void Target(Hamas hamas)
        {
            List<string> names = new List<string>()
            {
                "Mohammed", "Ahmed", "Ali", "Omar", "Hassan", "Hussein", "Abdullah",
                "Khalid", "Ibrahim", "Tariq", "Samir", "Faisal", "Nabil", "Ziad",
                "Mustafa", "Majed", "Anas", "Salem", "Rami", "Basel", "Youssef",
                "Karim", "Adel", "Tamer", "Wael"
            };

            List<string> weapons = new List<string>() { "m16", "knife", "gun" };
            string[] status = new string[] { "dead", "alive" };
            Random rand = new Random();

            for (int i = 0; i <= 5; i++)
            {
                hamas.ListTrrorist.Add(new trrorist(
                    names[rand.Next(names.Count)],
                    i,
                    status[rand.Next(status.Length)],
                    weapons[rand.Next(weapons.Count)]));
            }

            hamas.TerrorisPrinter(hamas.ListTrrorist);





        }
        public void MessageTerrorist(List<trrorist> list)
        {
            Random rand = new Random();
            List<string> status = new List<string>()
                {"outside","vehicle","building"};
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            foreach (trrorist t in list)
            {
                DateTime now = DateTime.Now;
                dict[t.Name] = new List<string>() { status[rand.Next(status.Count)], $"{now}" };
            }
            foreach (var i in dict)
            {
                Console.WriteLine(i.Key,i.Value.Count);
            }
        }
    }


}