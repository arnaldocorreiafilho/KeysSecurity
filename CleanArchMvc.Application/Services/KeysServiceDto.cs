using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Services
{
    public class KeysServiceDto : IKeysService
    {
        private IKeysRepository KeysRepository;
        private IMapper mapper;
        public KeysServiceDto(IKeysRepository KeysRepository,IMapper mapper)
        {
                this.KeysRepository = KeysRepository;
                this.mapper = mapper;   
        }
        public async Task<KeysDTO> Create(KeysDTO keysDTO)
        {

            var keysEntity = this.mapper.Map<Keys>(keysDTO);
            keysEntity.GenerateHash();
            await this.KeysRepository.Create(keysEntity);
            var keysTemp = await this.KeysRepository.GetById(keysEntity.Id);
            return this.mapper.Map<KeysDTO>(keysTemp);

        }

        public async Task<KeysDTO> Delete(int id)
        {
            var keysEntity = this.KeysRepository.GetById(id).Result;
            var keysTemp = await this.KeysRepository.Delete(keysEntity);
            return this.mapper.Map<KeysDTO>(keysTemp);
        }

        public async Task<KeysDTO> GetById(int? id)
        {
            var keysEntity = await this.KeysRepository.GetById(id);
            return this.mapper.Map<KeysDTO>(keysEntity);
        }

        public async Task<KeysDTO> GetByKey(string key)
        {
            var keysEntity = await this.KeysRepository.GetByKey(key);
            return this.mapper.Map<KeysDTO>(keysEntity);
        }

        public async Task<IEnumerable<KeysDTO>> GetKeys()
        {
            var keysEntities = await this.KeysRepository.GetKeys();
            return this.mapper.Map<IEnumerable<KeysDTO>>(keysEntities);
        }

        public async Task<KeysDTO> Update(KeysDTO keys)
        {
            var keysEntity = this.mapper.Map<Keys>(keys);
            keysEntity.GenerateHash();
            var keysTemp = await this.KeysRepository.Update(keysEntity);
            return this.mapper.Map<KeysDTO>(keysTemp);
        }
    }
}
