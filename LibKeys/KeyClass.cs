using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;

namespace LibKeys
{

    public class KeyClass
    {
        private IKeysService keyService;
        // GET: ProductsController
        public KeyClass(IKeysService keyService)
        {
            this.keyService = keyService;
        }

        public async Task<KeysDTO> GetKey(string key)
        { 
            return await this.keyService.GetByKey(key);
        }  



    }
}