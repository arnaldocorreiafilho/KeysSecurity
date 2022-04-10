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
    public class CategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext applicationContext;
        public  CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationContext = applicationDbContext;
        }


        public async Task<Category> Create(Category category)
        {
            this.applicationContext.Categories.Add(category);
            await this.applicationContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> Delete(Category category)
        {
            this.applicationContext.Categories.Remove(category);
            await this.applicationContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> GetById(int? id)
        {
            return await this.applicationContext.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await this.applicationContext.Categories.ToListAsync();
        }

        public async Task<Category> Update(Category category)
        {
            this.applicationContext.Categories.Update(category);
            await this.applicationContext.SaveChangesAsync();
            return category;
        }
    }
}
