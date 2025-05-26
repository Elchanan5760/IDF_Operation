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
        string CurrentCommender;

        public Idf(string currentcommender)
        {
            CurrentCommender = currentcommender;
        }

        public string DateOfEstablishment()
        {
            return "IDF established on 26/05/1948";
        }
        
        public string Commender()
        {
            return $"The commender of IDF is {CurrentCommender}";
        }

        public Drones Drones()
        {
            
            Drones drones = new Drones();
            return drones;
        }

        public Artillery Artillery()
        {
            Artillery artillery = new Artillery();
            return artillery;
        }

        public Aircraft Aircraft()
        {
            Aircraft aircraft = new Aircraft();
            return aircraft;
        }
        
    }
}
