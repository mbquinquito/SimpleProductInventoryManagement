using FluentValidation;
using SimpleProductInventoryManagement.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductInventoryManagement.Application.Features.ProductEntity.Commands.CreateProductEntity;
public class CreateProductEntityCommandValidator : AbstractValidator<CreateProductEntityCommand>
{
    private readonly IProductEntityRepository _productEntityRepository;

    public CreateProductEntityCommandValidator(IProductEntityRepository productEntityRepository)
    {
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

        RuleFor(q => q)
            .MustAsync(ProductEntityUnique)
            .WithMessage("Product already exists");

        _productEntityRepository = productEntityRepository;
    }
    

    private Task<bool> ProductEntityUnique(CreateProductEntityCommand command, CancellationToken cancellationToken)
    {
        return _productEntityRepository.IsProductNameUnique(command.Name);
    }
}

