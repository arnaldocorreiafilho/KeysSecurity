using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IKeysRepository
    {
        Task<IEnumerable<Keys>> GetKeys();
        Task<Keys> GetById(int? id);
        Task<Keys> Create(Keys keys);
        Task<Keys> Update(Keys keys);
        Task<Keys> Delete(Keys keys);
    }
}
