//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using IDF_Operation.models;

//namespace IDF_Operation
//{
//    public class Menu
//    {
//        public string option;
//        void PrintMassage()
//        {
//            Console.WriteLine("What information do you want:" +
//                "For intelligence analysis press 1" +
//                "For attack availability press 2" +
//                "For target priority press 3" +
//                "For carrying out an attack press 4");
//            option = Console.ReadLine();
//        }
//        public void ChoosOptions()
//        {
//            PrintMassage();
            
//            switch (option)
//            {
//                case "1":
//                    //Console.WriteLine(Aman.theMostInformation());
//                    break;
//                case "2":
//                    //Idf attackes = new ;
//                    break;
//                case "3":
//                    break;
//                case "4":
//                    break;
//                default:
//                    Console.WriteLine("Your option doesn't exist please try again");
//                    PrintMassage();
//                    break;
//            }
//        }
//        public string theMostInformation()
//        {

//            Dictionary<string, int> terroristNumLocations = new Dictionary<string, int>();
//            foreach (Aman location in IntelligenceAnalysis.locations)
//            {
//                if (terroristNumLocations.ContainsKey(location.Trrorist.Name))
//                {
//                    terroristNumLocations[location.Trrorist.Name] += 1;
//                }
//                else
//                {
//                    terroristNumLocations[location.Trrorist.Name] = 1;
//                }
//            }
//            int mostTimes = 0;
//            foreach (var item in terroristNumLocations)
//            {
//                if (item.Value > mostTimes)
//                {
//                    mostTimes = item.Value;
//                    Trrorist = item.Key;
//                }
//            }
//            return Trrorist.Name;
//        }
//    }
//}
