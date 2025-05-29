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
        private string _currentCommender { set; get; }

        //public Idf(string currentcommender)
        //{
        //    _currentCommender = currentcommender;
        //}

        public string DateOfEstablishment()
        {
            return "IDF established on 26/05/1948";
        }
        
        public string Commender()
        {
            return $"The commender of IDF is {_currentCommender}";
        }

        public Drones Drones()
        {
            
            Drones drones = new Drones();
            drones.InitializeAmmunitionCapacity();
            return drones;
        }

        public Artillery Artillery()
        {
            Artillery artillery = new Artillery();
            artillery.InitializeAmmunitionCapacity();
            return artillery;
        }

        public Aircraft Aircraft()
        {
            Aircraft aircraft = new Aircraft();
            aircraft.InitializeAmmunitionCapacity();
            return aircraft;
        }
        
    }
}
