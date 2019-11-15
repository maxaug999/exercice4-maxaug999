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
    public class RepositoryPattern<T> : IRepository<T> where T : Entity
    {
        private readonly IServiceScopeFactory scopeFactory;

        public RepositoryPattern(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }

        public Task Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<T>> GetAll()
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<PoolSaison2019Context>();
                var items = await dbContext.Set<T>().ToListAsync();
                return items.AsQueryable();
            }
        }

        public Task<T> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
