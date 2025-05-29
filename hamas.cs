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

    string Commander = "sinuar";
    public List<Terrorist> ListTrrorist = new List<Terrorist>();



    public void TerrorisPrinter(List<Terrorist> terrorists)
    {
        foreach (Terrorist t in terrorists)
        {
            Console.WriteLine(t.Name);
        }

    }


}



