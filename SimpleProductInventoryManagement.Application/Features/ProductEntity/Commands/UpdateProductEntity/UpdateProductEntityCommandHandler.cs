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

namespace SimpleProductInventoryManagement.Application.Features.ProductEntity.Commands.UpdateProductEntity
{
    public class UpdateProductEntityCommandHandler : IRequestHandler<UpdateProductEntityCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly IProductEntityRepository _productEntityRepository;

        public UpdateProductEntityCommandHandler(IMapper mapper, IProductEntityRepository productEntityRepository)
        {
            _mapper = mapper;
            _productEntityRepository = productEntityRepository;
        }
        public async Task<Unit> Handle(UpdateProductEntityCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateProductEntityCommandValidator(_productEntityRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any()) {
                throw new BadRequestException("Invalid Product", validationResult);
            }

            var productEntityToUpdate = _mapper.Map<Domain.ProductEntity>(request);

            await _productEntityRepository.UpdateAsync(productEntityToUpdate);

            return Unit.Value;
        }
    }
}
