using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;



namespace IDF_Operation.models
{
    public class Menu
    {


        private string _option;
        private void PrintMassage()
        {
            Console.WriteLine("What information do you want:\n" +
                "For intelligence analysis press 1\n" +
                "For attack availability press 2\n" +
                "For target priority press 3\n" +
                "For carrying out an attack press 4");
            _option = Console.ReadLine();

        }
        public void ChoosOptions()

        {

            PrintMassage();
            switch (_option)
            {
                case "1":
                    Aman aman = new Aman();
                    Swhos swhos = new Swhos();
                    Hamas hamas = new Hamas();
                    Swhos.FactoryTerrorist(hamas);

                   Console.WriteLine(Aman.TheMostInformation(DaIntelligence.MessageTerrorist(Hamas.ListTrrorist)));
                    break;

                case "2":
                    Idf idf = new Idf();
                    Console.WriteLine($"{idf.Aircraft().UniqueName()}: {idf.Aircraft().GetAmmunitionCapacity()}");
                    Console.WriteLine($"{idf.Artillery().UniqueName()}: {idf.Artillery().GetAmmunitionCapacity()}");
                    Console.WriteLine($"{idf.Drones().UniqueName()}: {idf.Drones().GetAmmunitionCapacity()}");
                    break;
                case "3":
                    Console.WriteLine(Aman.RiskTerrorist(DaIntelligence.MessageTerrorist(Hamas.ListTrrorist)));

                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Your option doesn't exist please try again");
                    PrintMassage();
                    break;
            }
        }
    }
}

