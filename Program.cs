using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using IDF_Operation.models;

namespace IDF
{
    public class Program
    {
        static void Main(string[] args)
        {
            Idf idf = new Idf("eyle_zamir");
            Hamas hamas = new Hamas();
            DaIntelligence analysis = new DaIntelligence();
            analysis.Target(hamas);
            analysis.MessageTerrorist(hamas.ListTrrorist);
        }

      
    }
}
