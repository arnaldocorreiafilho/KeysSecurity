using Xunit;
using CleanArchMvc.Domain.Entities;
using FluentAssertions;
using System;
namespace CleanArchMvc.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName="Create Category with validState")]
        public void CreateCategory_WithValidParamenter_ResultValidState()
        {
            Action action = () => new Category(1, "Category Name ");
            action.Should()
                 .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Category with InvalidState")]
        public void CreateCategory_WithNegativeParamenter_ResultInValidState()
        {
            Action action = () => new Category(-1, "Category Name ");
            action.Should()
                 .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>().
                 WithMessage("Invalid Id Value.");
        }
        [Fact(DisplayName = "Create Category with Missing Name")]
        public void CreateCategory_WithMissingName_ResultInValidState()
        {
            Action action = () => new Category(1, "");
            action.Should()
                 .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>().
                 WithMessage("The name is required.");
        }
        [Fact(DisplayName = "Create Category with null Name")]
        public void CreateCategory_WithNullName_ResultInValidState()
        {
            Action action = () => new Category(1,null);
            action.Should()
                 .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>().
                 WithMessage("The name is required.");
        }
    }
}