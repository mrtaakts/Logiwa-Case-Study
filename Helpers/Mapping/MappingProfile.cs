using AutoMapper;
using Logiwa_Case_Study.Models;
using Logiwa_Case_Study.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // productDto.Category = product.category.name 
            CreateMap<Product, ProductToReturnDto>().ForMember(model=> model.Category, opts=> opts.MapFrom(src=>src.category.Name)).ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();

        }
    }
}
