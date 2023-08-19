using FluentValidation;
using Northwind.Business.Contants;
using Northwind.Entities.Dtos;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<ProductAddDto>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage(Messages.ProductNameIsNotEmpty);
            RuleFor(x => x.UnitPrice).GreaterThan(0).WithMessage(Messages.UnitPriceGreaterThanZero);
            RuleFor(x => x.QuantityPerUnit).NotEmpty().WithMessage(Messages.QuantityPerUnitIsNotEmpty);
        }
    }
}
