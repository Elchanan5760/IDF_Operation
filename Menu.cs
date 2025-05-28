using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;

namespace IDF_Operation
{
    public class Menu
    {
        private string _option;
        void PrintMassage()
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
                    
                    break;
                case "2":
                    Idf idf = new Idf();
                    Console.WriteLine($"{idf.Aircraft().UniqueName()}: {idf.Aircraft().GetAmmunitionCapacity()}");
                    Console.WriteLine($"{idf.Artillery().UniqueName()}: {idf.Artillery().GetAmmunitionCapacity()}");
                    Console.WriteLine($"{idf.Drones().UniqueName()}: {idf.Drones().GetAmmunitionCapacity()}");
                    break;
                case "3":

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
