﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;


namespace IDF_Operation.models
{
    internal class IntelligenceAnalysis
    {
        static trrorist t1 = new trrorist("t1",2, "l", "m16");
        static trrorist t2 = new trrorist("t2", 2, "l", "m16");
        static trrorist t3 = new trrorist("t3", 1, "l", "m16");
        static trrorist t4 = new trrorist("t4", 5, "l", "m16");
        static trrorist t5 = new trrorist("t5", 3, "l", "m16");

        Idf idf = new Idf("eyle_zamir");

        Aman massage1 = new Aman(t1.Name,"car","as");
        Aman massage2 = new Aman(t2.Name,"car","as");
        Aman massage3 = new Aman(t1.Name,"car","as");
        Aman massage4 = new Aman(t1.Name,"car","as");
        Aman massage5 = new Aman(t3.Name,"car","as");
        Aman massage6 = new Aman(t4.Name,"car","as");
        Aman massage7 = new Aman(t1.Name,"car","as");
        Aman massage8 = new Aman(t1.Name,"car","as");
        Aman massage9 = new Aman(t5.Name,"car","as");
        Aman massage10 = new Aman(t2.Name,"car","as");


        
        

        
       
       

        

    }
}

