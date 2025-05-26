using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.models;

namespace IDF_Operation.models;


public class Hamas
{
    private int YearEstablishment { get; set; } = 1987;
    public string Commander = "sinuar";
    public List<trrorist> ListTrrorist = new List<trrorist>();


    public void TerrorisPrinter(List<trrorist> terrorists)
    {
        foreach (trrorist t in terrorists)
        {
            Console.WriteLine(t.Name);
        }

    }

    }




