using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.models

{
    public class Hamas
    {
        private int yearEstablishment { get; set; } = 1987;
        private string commander = "sinuar";
        private List<object> trrorists = new List<object>();

        public void SetNewCommander(string newName)
        {
            this.commander = newName;
        }
    } 
}
