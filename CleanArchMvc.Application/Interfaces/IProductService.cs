﻿using CleanArchMvc.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProductsAsync();
        Task<ProductDTO> GetProductCategoryAsync(int? id);
        Task AddAsync(ProductDTO productDTO);
        Task UpdateAsync(ProductDTO productDTO);
        Task RemoveAsync(int id);

    }
}
