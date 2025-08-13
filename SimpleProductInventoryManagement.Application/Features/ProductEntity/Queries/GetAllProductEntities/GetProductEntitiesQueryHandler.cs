using AutoMapper;
using MediatR;
using SimpleProductInventoryManagement.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductInventoryManagement.Application.Features.ProductEntity.Queries.GetAllProductEntities
{
    public class GetProductEntitiesQueryHandler :IRequestHandler<GetProductEntitiesQuery, List<ProductEntityDto>>
    {
        private readonly IMapper _mapper;
        private readonly IProductEntityRepository _productEntityRepository;

        public GetProductEntitiesQueryHandler(IMapper mapper, IProductEntityRepository productEntityRepository)
        {
            _mapper = mapper;
            _productEntityRepository = productEntityRepository;
        }

        public async Task<List<ProductEntityDto>> Handle(GetProductEntitiesQuery request, CancellationToken cancellationToken)
        {
            var productEntities = await _productEntityRepository.GetAllAsync();
        
            var data = _mapper.Map<List<ProductEntityDto>>(productEntities);

            return data;
        }
    }
}
