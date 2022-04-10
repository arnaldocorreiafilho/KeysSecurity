using Xunit;
using CleanArchMvc.Domain.Entities;
using FluentAssertions;
using System;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {

        
        [Fact(DisplayName = "Create Product with validState")]
        public void CreateProduct_WithValidParamenter_ResultValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m,
              99, "product image");
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }
    }
}
