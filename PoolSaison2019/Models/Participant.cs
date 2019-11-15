using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolSaison2019.Models
{
    public class Participant : Entity
    {
        public string Nom { get; set; }
        public int Rang { get; set; }
        public int DernierRang { get; set; }
        public int Points { get; set; }
        public int Gains { get; set; }
    }
}