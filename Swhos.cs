using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;

namespace IDF_Operation.models
{
    public class Swhos
    {
         static public void FactoryTerrorist(Hamas hamas)
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

            for (int i = 0; i != 10; i++)
            {
                hamas.ListTrrorist.Add(new Terrorist(
                    names[rand.Next(names.Count)],
                    i,
                    status[rand.Next(status.Length)],
                    weapons[rand.Next(weapons.Count)]));
            }

            //hamas.TerrorisPrinter(hamas.ListTrrorist);





        }
        public Hamas hamas = new Hamas();

    }
}
