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

        private void GetOption()
        {
            Console.WriteLine("What information do you want:\n" +
                "For intelligence analysis press 1\n" +
                "For attack availability press 2\n" +
                "For target priority press 3\n" +
                "For carrying out an attack press 4\n" +
                "For exit press 5");
            _option = Console.ReadLine();

        }
        public void ChoosOptions()
        {
            Idf idf = new Idf();
            Aman aman = new Aman();
            Hamas hamas = new Hamas();
            ObjectsTerrorist objectsTerrorist = new ObjectsTerrorist();
            objectsTerrorist.FactoryTerrorist(hamas);

            bool cond = true;
            do
            {
                GetOption();

                
                
                switch (_option)
                {
                    case "1":
                        Console.WriteLine(aman.TheMostInformation(DaIntelligence.MessageTerrorist(hamas.ListTrrorist))+ " hes the most information with ");
                        break;
                    case "2":
                        
                        Console.WriteLine($"{idf.Aircraft().UniqueName()}: {idf.Aircraft().GetAmmunitionCapacity()}");
                        Console.WriteLine($"{idf.Artillery().UniqueName()}: {idf.Artillery().GetAmmunitionCapacity()}");
                        Console.WriteLine($"{idf.Drones().UniqueName()}: {idf.Drones().GetAmmunitionCapacity()}");
                        break;
                    case "3":
                        Console.WriteLine($"Name: " + aman.GetMostDangerousTerrorist(hamas).Item1.GetName());
                        Console.WriteLine($"Rank: " + aman.GetMostDangerousTerrorist(hamas).Item1.GetRank());
                        Console.WriteLine($"Qoality Score: " + aman.GetMostDangerousTerrorist(hamas).Item2);
                        Console.WriteLine($"Weapon Name: " + aman.GetMostDangerousTerrorist(hamas).Item1.GetWeapon().GetWeaponName());
                        Console.WriteLine($"Last location: " + aman.GetMostDangerousTerrorist(hamas).Item2);
                        break;
                    case "4":

                        break;
                    case "5":
                        cond = false;
                        break;
                    default:
                        Console.WriteLine("Your option doesn't exist please try again");
                        break;
                }


            //PrintMassage();
            //switch (_option)
            //{
            //    case "1":
                    

            //        break;

            //    case "2":
            //        Idf idf = new Idf();
            //        Console.WriteLine($"{idf.Aircraft().UniqueName()}: {idf.Aircraft().GetAmmunitionCapacity()}");
            //        Console.WriteLine($"{idf.Artillery().UniqueName()}: {idf.Artillery().GetAmmunitionCapacity()}");
            //        Console.WriteLine($"{idf.Drones().UniqueName()}: {idf.Drones().GetAmmunitionCapacity()}");
            //        break;
            //    case "3":
            //        Console.WriteLine(Aman.RiskTerrorist(DaIntelligence.MessageTerrorist(Hamas.ListTrrorist)));

            //        break;
            //    case "4":
            //        break;
            //    default:
            //        Console.WriteLine("Your option doesn't exist please try again");
            //        PrintMassage();
            //        break;

            }
            while (cond);
        }
    }
}

