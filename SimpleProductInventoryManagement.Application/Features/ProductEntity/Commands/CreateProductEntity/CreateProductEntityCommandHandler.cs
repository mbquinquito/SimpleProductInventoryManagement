using AutoMapper;
using MediatR;
using SimpleProductInventoryManagement.Application.Contracts.Persistence;
using SimpleProductInventoryManagement.Application.Exceptions;
using SimpleProductInventoryManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace SimpleProductInventoryManagement.Application.Features.ProductEntity.Commands.CreateProductEntity
{
    public class CreateProductEntityCommandHandler : IRequestHandler<CreateProductEntityCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IProductEntityRepository _productEntityRepository;

        public CreateProductEntityCommandHandler(IMapper mapper, IProductEntityRepository productEntityRepository)
        {
            _mapper = mapper;
            _productEntityRepository = productEntityRepository;
        }
        public async Task<int> Handle(CreateProductEntityCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateProductEntityCommandValidator(_productEntityRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any())
            {
                throw new BadRequestException("Invalid Product", validationResult);
            }

            var productEntityToCreate = _mapper.Map<Domain.ProductEntity>(request);

            await _productEntityRepository.CreateAsync(productEntityToCreate);

            return productEntityToCreate.Id;
        }
    }
}
