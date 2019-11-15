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
    public class MockParticipantRepository : IRepository<Participant>
    {
        public readonly List<Participant> _participants;
        
        public MockParticipantRepository()
        {
            _participants = new List<Participant>()
            {
                new Participant()
                {
                    Id = 1,
                    Nom="Max",
                    Rang = 1,
                    DernierRang = 10,
                    Points = 9,
                    Gains = 100
                },
                new Participant()
                {
                    Id = 2,
                    Nom="Bob",
                    Rang = 5,
                    DernierRang = 19,
                    Points = 20,
                    Gains = 50
                },
                 new Participant()
                {
                    Id = 3,
                    Nom="Donald",
                    Rang = 11,
                    DernierRang = 33,
                    Points = 10,
                    Gains = 40
                },
                  new Participant()
                {
                    Id = 4,
                    Nom="Joe",
                    Rang = 15,
                    DernierRang = 60,
                    Points = 5,
                    Gains = 11
                },
            };
        }

        public Task Add(Participant entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Participant entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<Participant>> GetAll()
        {
            IQueryable<Participant> list = _participants.AsQueryable();
            return await Task.Run(() => list);
        }

        public Task<Participant> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Participant entity)
        {
            throw new NotImplementedException();
        }
    }
}
