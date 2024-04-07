using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Command //Kjo klase identifikon commanden
    {
        public string Name { get; set; }// emri komandes
        public Dictionary<string, string> Parameters { get; set; } //parametrat e commandes
    }
}

