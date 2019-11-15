using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PoolSaison2019.Controllers;
using PoolSaison2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolSaison2019.Data
{
    public class MockJoueurRepository : IRepository<Joueur>
    {
        public readonly List<Joueur> _joueurs;
        
        public MockJoueurRepository()
        {
            _joueurs = new List<Joueur>()
            {
                new Joueur()
                {
                    Id = 1,
                    Nom="Max",
                    Equipe = "Canadiens",
                    Position = "Attaque",
                    Salaire = 8974651
                },
                new Joueur()
                {
                    Id = 2,
                    Nom="Bob",
                    Equipe = "Nordic",
                    Position = "Defense",
                    Salaire = 8974651
                },
                new Joueur()
                {
                    Id = 3,
                    Nom="Donald",
                    Equipe = "Vancouver",
                    Position = "Goal",
                    Salaire = 124
                },
                new Joueur()
                {
                    Id = 4,
                    Nom="Joe",
                    Equipe = "Ducks",
                    Position = "Defense",
                    Salaire = 88484
                },
            };
        }

        public Task Add(Joueur entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Joueur entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<Joueur>> GetAll()
        {
            IQueryable<Joueur> list = _joueurs.AsQueryable();
            return await Task.Run(() => list);
        }

        public async Task<Joueur> GetById(int? id) // ? = can be nullable
        {
            return await Task.Run(() => _joueurs.Find(i => i.Id == id));
        }

        public Task Update(Joueur entity)
        {
            throw new NotImplementedException();
        }
    }
}
