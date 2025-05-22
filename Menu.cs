using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation
{
    public class Menu
    {
        public string option;
        void PrintMassage()
        {
            Console.WriteLine("What information do you want:" +
                "For intelligence analysis press 1" +
                "For attack availability press 2" +
                "For target priority press 3" +
                "For carrying out an attack press 4");
            option = Console.ReadLine();
        }
        public void ChoosOptions()
        {
            PrintMassage();
            
            switch (option)
            {
                case "1":

                    break;
                case "2":
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
