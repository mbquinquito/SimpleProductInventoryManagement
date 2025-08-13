using MediatR;
using SimpleProductInventoryManagement.Application.Contracts.Persistence;
using SimpleProductInventoryManagement.Application.Exceptions;

namespace SimpleProductInventoryManagement.Application.Features.ProductEntity.Commands.DeleteProductEntity
{
    public class DeleteProductEntityCommandHandler : IRequestHandler<DeleteProductEntityCommand, Unit>
    {
        private readonly IProductEntityRepository _productEntityRepository;

        public DeleteProductEntityCommandHandler(IProductEntityRepository productEntityRepository)
        {
            _productEntityRepository = productEntityRepository;
        }

        public async Task<Unit> Handle(DeleteProductEntityCommand request, CancellationToken cancellationToken)
        {
            var productEntityToDelete = await _productEntityRepository.GetByIdAsync(request.Id);

            if(productEntityToDelete == null)
            {
                throw new NotFoundExceptions(nameof(ProductEntity), request.Id);
            }

            await _productEntityRepository.DeleteAsync(productEntityToDelete);
          
            return Unit.Value;
        }
    }
}
