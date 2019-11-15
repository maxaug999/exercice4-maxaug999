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
    public class MockSignatureRepository : IRepository<Signature>
    {
        public List<Signature> _signatures;
        
        public MockSignatureRepository()
        {
            _signatures = new List<Signature>()
            {
                new Signature()
                {
                    Id = 1,
                    Nom="Max",
                    Equipe = "Canadiens",
                    Salaire = 997885
                },
                new Signature()
                {
                    Id = 2,
                    Nom="Bob",
                    Equipe = "Nordic",
                    Salaire = 456456
                },
            };
        }

        public Task Add(Signature entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Signature entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<Signature>> GetAll()
        {
            IQueryable<Signature> list = _signatures.AsQueryable();
            return await Task.Run(() => list);
        }

        public Task<Signature> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Signature entity)
        {
            throw new NotImplementedException();
        }
    }
}
