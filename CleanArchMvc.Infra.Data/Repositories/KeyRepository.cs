using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CleanArchMvc.Infra.Data.Repositories
{
    public class KeyRepository : IKeysRepository
    {
        private ApplicationDbContext applicationContext;

        public KeyRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationContext = applicationDbContext;
        }

        public async Task<Keys> Create(Keys keys)
        {
            this.applicationContext.Keys.Add(keys);
            await this.applicationContext.SaveChangesAsync();
            return keys;
        }

        public async Task<Keys> Delete(Keys keys)
        {
            this.applicationContext.Keys.Remove(keys);
            await this.applicationContext.SaveChangesAsync();
            return keys;
        }

        public async Task<Keys> GetById(int? id)
        {
            return await this.applicationContext.Keys.FindAsync(id);
        }

        public async Task<IEnumerable<Keys>> GetKeys()
        {
            return await this.applicationContext.Keys.ToListAsync();
        }

        public async Task<Keys> Update(Keys keys)
        {
            this.applicationContext.Keys.Update(keys);
            await this.applicationContext.SaveChangesAsync();
            return keys;
        }
    }
}
