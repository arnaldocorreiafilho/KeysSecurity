using CleanArchMvc.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetproductsAsync();
        Task<ProductDTO> GetproductAsync(int? id);

        Task<ProductDTO> CreateAsync(ProductDTO product);
        Task<ProductDTO> UpdateAsync(ProductDTO product);
        Task<ProductDTO> DeleteAsync(ProductDTO product);
        Task<ProductDTO> GetProductCategoryAsync(int? id);
    }
}
