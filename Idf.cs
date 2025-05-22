using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;


<<<<<<< HEAD
namespace IDF_Operation.idf
=======


namespace IDF_Operation.models

>>>>>>> origin/main
{
    public class Idf
    {
        public string CurrentCommender;
        public Aircraft aircraft;
        public Drones drones;
        public Artillery artillery;
<<<<<<< HEAD
        Idf(string currentcommender,IStrikePuttern drones,IStrikePuttern aircraft,IStrikePuttern artillery)
=======
        public Idf(string currentcommender)//,StrikePuttern drones,StrikePuttern aircraft,StrikePuttern artillery
>>>>>>> origin/main
        {
            CurrentCommender = currentcommender;
            aircraft = new Aircraft();
            drones = new Drones();
            artillery = new Artillery();
        }
        public void DateOfEstablishment()
        {
            Console.WriteLine("IDF established on 26/05/1948");
        }
        
        public void Commender()
        {
            Console.WriteLine($"The commender of IDF is {CurrentCommender}");
        }

        public void Strikes()
        {
            
        }
    }
}
