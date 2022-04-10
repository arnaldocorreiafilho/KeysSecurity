using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Category: Entity
    {
        public string Name { get; private set; }
        public ICollection<Product> Products { get; set; }
        public Category(int id, string name)
        {
            Domain.Validation.DomainExceptionValidation.When(id < 0, "Invalid Id value.");
            ValidateDomain(name);
        }

        private void ValidateDomain(string name)
        {
            Domain.Validation.DomainExceptionValidation.When(string.IsNullOrEmpty(name),"The name is required.");
            this.Name = name;
        }

        public Category(String name)
        {
            ValidateDomain(name);
        }

        public void Update(String name) { 
            ValidateDomain(name);
        }


       
       
    }
}
