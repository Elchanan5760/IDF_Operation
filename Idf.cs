using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;




namespace IDF_Operation.models

{
    public class Idf
    {
        public string CurrentCommender;
        public Aircraft aircraft;
        public Drones drones;
        public Artillery artillery;
        public Idf(string currentcommender)//,StrikePuttern drones,StrikePuttern aircraft,StrikePuttern artillery
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
            Console.WriteLine($"the commender of IDF is {CurrentCommender}");
        }

        public void Strikes()
        {
            Console.WriteLine(aircraft.UniqueName());
        }
    }
}
