using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolSaison2019.Models
{
    public class Signature : Entity
    {
        public string Nom { get; set; }
        public string Equipe { get; set; }
        public int Salaire { get; set; }
    }
}
