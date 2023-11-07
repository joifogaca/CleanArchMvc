using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
                CreateMap<CategoryDTO, Category >().ReverseMap();
                CreateMap<ProductDTO, Product>().ReverseMap();
        }
    }
}
