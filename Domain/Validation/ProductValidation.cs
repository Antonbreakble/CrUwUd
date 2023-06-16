using Domain.Models;
using FluentValidation;

namespace Domain.Validation; 

public class ProductValidation : AbstractValidator<ProductModel> {
    public ProductValidation() {
        RuleFor(x => x.Name).NotEmpty().Length(3, 100);
        RuleFor(x => x.Receiptdate).NotEqual(new DateTime());
        RuleFor(x => x.Quantity).GreaterThan(0);
        RuleFor(x => x.Price).GreaterThan(0);
    }
}