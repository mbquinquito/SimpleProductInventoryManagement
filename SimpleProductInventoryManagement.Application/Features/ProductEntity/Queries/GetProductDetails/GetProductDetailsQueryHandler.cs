using AutoMapper;
using MediatR;
using SimpleProductInventoryManagement.Application.Contracts.Persistence;
using SimpleProductInventoryManagement.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductInventoryManagement.Application.Features.ProductEntity.Queries.GetProductDetails
{
    public class GetProductDetailsQueryHandler : IRequestHandler<GetProductDetailsQuery, ProductDetailsDto>
    {
        private readonly IMapper _mapper;
        private readonly IProductEntityRepository _productEntityRepository;

        public GetProductDetailsQueryHandler(IMapper mapper, IProductEntityRepository productEntityRepository)
        {
            _mapper = mapper;
            _productEntityRepository = productEntityRepository;
        }
        public async Task<ProductDetailsDto> Handle(GetProductDetailsQuery request, CancellationToken cancellationToken)
        {
            var productEntity = await _productEntityRepository.GetByIdAsync(request.Id);

            if (productEntity == null)
            {
                throw new NotFoundExceptions(nameof(productEntity), request.Id);
            }

            var data = _mapper.Map<ProductDetailsDto>(productEntity);

            return data;
        }
    }
}
