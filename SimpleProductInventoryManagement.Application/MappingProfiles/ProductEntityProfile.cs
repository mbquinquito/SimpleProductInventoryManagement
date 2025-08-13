using AutoMapper;
using SimpleProductInventoryManagement.Application.Features.ProductEntity.Commands.CreateProductEntity;
using SimpleProductInventoryManagement.Application.Features.ProductEntity.Commands.UpdateProductEntity;
using SimpleProductInventoryManagement.Application.Features.ProductEntity.Queries.GetAllProductEntities;
using SimpleProductInventoryManagement.Application.Features.ProductEntity.Queries.GetProductDetails;
using SimpleProductInventoryManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductInventoryManagement.Application.MappingProfiles
{
    public class ProductEntityProfile : Profile
    {
        public ProductEntityProfile()
        {
            CreateMap<ProductEntityDto, ProductEntity>().ReverseMap();
            CreateMap<ProductEntity, ProductDetailsDto>();
            CreateMap<CreateProductEntityCommand, ProductEntity>();
            CreateMap<UpdateProductEntityCommand, ProductEntity>();
        }
    }
}
