using FluentValidation;
using SimpleProductInventoryManagement.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductInventoryManagement.Application.Features.ProductEntity.Commands.UpdateProductEntity;
public class UpdateProductEntityCommandValidator : AbstractValidator<UpdateProductEntityCommand>
{
    private readonly IProductEntityRepository _productEntityRepository;

    public UpdateProductEntityCommandValidator(IProductEntityRepository productEntityRepository)
    {
        RuleFor(x => x.Id)
            .NotNull()
            .MustAsync(ProductEntityMustExist);
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");
        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(500).WithMessage("{PropertyName} must not exceed 500 characters.");
        RuleFor(x => x.Price)
            .GreaterThan(0).WithMessage("{PropertyName} must be greater than zero.")
            .NotNull();

        _productEntityRepository = productEntityRepository;
    }

    private async Task<bool> ProductEntityMustExist(int id, CancellationToken token)
    {
        var productEntity = await _productEntityRepository.GetByIdAsync(id);
        return productEntity != null;
    }

}

