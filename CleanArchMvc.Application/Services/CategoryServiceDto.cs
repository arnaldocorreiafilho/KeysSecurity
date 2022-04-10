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
    public class CategoryServiceDto : ICategoryService
    {
        private ICategoryRepository categoryRepository;
        private IMapper mapper;
        public CategoryServiceDto(ICategoryRepository categoryRepository,IMapper mapper)
        {
                this.categoryRepository = categoryRepository;
                this.mapper = mapper;   
        }
        public async Task<CategoryDTO> Create(CategoryDTO category)
        {
            var categoryEntity = this.mapper.Map<Category>(category);
            var categoryTemp = await this.categoryRepository.Create(categoryEntity);
            return this.mapper.Map<CategoryDTO>(categoryTemp);
            

        }

        public async Task<CategoryDTO> Delete(CategoryDTO category)
        {
            var categoryEntity = this.categoryRepository.GetById(category.Id).Result;
            var categoryTemp = await this.categoryRepository.Delete(categoryEntity);
            return this.mapper.Map<CategoryDTO>(categoryTemp);
        }

        public async Task<CategoryDTO> GetById(int? id)
        {
            var categoriesEntity = await this.categoryRepository.GetById(id);
            return this.mapper.Map<CategoryDTO>(categoriesEntity);
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            var categoriesEntities =  await this.categoryRepository.GetCategories();
            return this.mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntities);
        }

        public async Task<CategoryDTO> Update(CategoryDTO category)
        {
            var categoryEntity = this.mapper.Map<Category>(category);
            var categoryTemp = await this.categoryRepository.Update(categoryEntity);
            return this.mapper.Map<CategoryDTO>(categoryTemp);
        }
    }
}
