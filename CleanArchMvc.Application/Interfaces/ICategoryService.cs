﻿using CleanArchMvc.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategories();
        Task<CategoryDTO> GetById(int? id);
        Task<CategoryDTO> Create(CategoryDTO category);
        Task<CategoryDTO> Update(CategoryDTO category);
        Task<CategoryDTO> Delete(CategoryDTO category);
    }
}
