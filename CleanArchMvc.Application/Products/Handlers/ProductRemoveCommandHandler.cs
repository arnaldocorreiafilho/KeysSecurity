using CleanArchMvc.Application.Products.Commands;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Products.Handlers
{
    public class ProductRemoveCommandHandler
    {
        private readonly IProductRepository productRepository;
        public ProductRemoveCommandHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<Product> Handle(ProductDeleteCommand request,
           CancellationToken cancellationToken)
        {
            var product = await productRepository.GetproductAsyncId(request.Id);

            if (product == null)
            {
                throw new ApplicationException($"Entity could not be found.");
            }
            else
            {
                var result = await this.productRepository.DeleteAsync(product);
                return result;
            }
        }

    }
}
