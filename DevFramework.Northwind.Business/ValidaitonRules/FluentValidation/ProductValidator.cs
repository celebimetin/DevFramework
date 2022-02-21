using DevFramework.Northwind.Entities.Concrete;
using FluentValidation;

namespace DevFramework.Northwind.Business.ValidaitonRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.ProductName).Length(3, 20).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
        }
    }
}