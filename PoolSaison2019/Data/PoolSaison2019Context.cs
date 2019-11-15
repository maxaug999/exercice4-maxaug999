using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PoolSaison2019.Models;

namespace PoolSaison2019.Models
{
    public class PoolSaison2019Context : DbContext
    {
        public PoolSaison2019Context (DbContextOptions<PoolSaison2019Context> options)
            : base(options)
        {
        }

        public DbSet<PoolSaison2019.Models.Joueur> Joueur { get; set; }

        public DbSet<PoolSaison2019.Models.Participant> Participant { get; set; }

        public DbSet<PoolSaison2019.Models.Signature> Signature { get; set; }
    }
}
