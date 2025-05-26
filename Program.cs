using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using IDF_Operation.models;

namespace IDF
{
    public class Program
    {
        static void Main(string[] args)
        {
            Idf idf = new Idf("Eyle Zamir");
            Hamas hamas = new Hamas();

            Target(hamas);
        }

        static void Target(Hamas hamas)
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
    }
}
