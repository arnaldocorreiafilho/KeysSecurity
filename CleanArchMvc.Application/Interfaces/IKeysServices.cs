using CleanArchMvc.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Interfaces
{
    public interface IKeysService
    {
        Task<IEnumerable<KeysDTO>> GetKeys();
        Task<KeysDTO> GetById(int? id);
        Task<KeysDTO> GetByKey(String key);

        Task<KeysDTO> Create(KeysDTO keysDTO);
        Task<KeysDTO> Update(KeysDTO keysDTO);
        Task<KeysDTO> Delete(int id);
    }
}
