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
    public class ProductRepository : IProductRepository
    {
        ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            this._context.Products.Add(product);
            await this._context.SaveChangesAsync();
            return product;

        }

        public async Task<Product> DeleteAsync(Product product)
        {
            this._context.Products.Remove(product);
            await this._context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> GetproductAsyncId(int? id)
        {
            return await this._context.Products.FindAsync(id);
        }

        public async Task<Product> GetProductCategoryAsync(int? id)
        {
            return await this._context.Products.Include(c => c.Category).SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetproductsAsync()
        {
            return await this._context.Products.ToListAsync();
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            this._context.Products.Update(product);
            await this._context.SaveChangesAsync();
            return product;
        }
    }
}
