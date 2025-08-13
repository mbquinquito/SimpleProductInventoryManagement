using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductInventoryManagement.Application.Features.ProductEntity.Queries.GetAllProductEntities
{
    public record GetProductEntitiesQuery : IRequest<List<ProductEntityDto>>
    {
        
    }
}

