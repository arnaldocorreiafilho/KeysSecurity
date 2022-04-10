using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Services
{
    public class ProductServiceDto : CleanArchMvc.Application.Interfaces.IProductService
    {
        private IProductRepository productRepository;
        private IMapper mapper;
        public ProductServiceDto(Domain.Interfaces.IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }
        public async Task<ProductDTO> CreateAsync(ProductDTO product)
        {
            var productEntity = this.mapper.Map<Product>(product);
            var productTemp = await this.productRepository.CreateAsync(productEntity);
            return this.mapper.Map<ProductDTO>(productTemp);
        }

        public async Task<ProductDTO> DeleteAsync(ProductDTO product)
        {
            var productEntity = this.mapper.Map<Product>(product);
            var productTemp = await this.productRepository.DeleteAsync(productEntity);
            return this.mapper.Map<ProductDTO>(productTemp);
        }

        public async Task<ProductDTO> GetproductAsync(int? id)
        {
            var productsEntity = await this.productRepository.GetproductAsyncId(id);
            return this.mapper.Map<ProductDTO>(productsEntity);
        }

        public async Task<ProductDTO> GetProductCategoryAsync(int? id)
        {
            var productEntity = await  this.productRepository.GetProductCategoryAsync(id);
            return this.mapper.Map<ProductDTO>(productEntity);
        }

        public async Task<IEnumerable<ProductDTO>> GetproductsAsync()
        {
            var productsEntities = await this.productRepository.GetproductsAsync();
            return this.mapper.Map <IEnumerable<ProductDTO>>(productsEntities);
        }

        public async Task<ProductDTO> UpdateAsync(ProductDTO product)
        {
            var productEntity = this.mapper.Map<Product>(product);
            var productTemp = await this.productRepository.UpdateAsync(productEntity);
            return this.mapper.Map<ProductDTO>(productTemp);
        }
    }
}
