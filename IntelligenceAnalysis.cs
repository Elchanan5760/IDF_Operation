using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;


namespace IDF_Operation.models
{
    internal class IntelligenceAnalysis
    {
        trrorist t1 = new trrorist("t1",2, "l", "m16");
        trrorist t2 = new trrorist("t2", 5, "l", "m16");
        trrorist t3 = new trrorist("t3", 1, "l", "m16");
        trrorist t4 = new trrorist("t4", 5, "l", "m16");
        trrorist t5 = new trrorist("t5", 3, "l", "m16");

        Idf idf = new Idf("eyle_zamir");

        Aman massage = new Aman(t1.Name,"car","as");

       
       

        

    }
}
