using FluentValidation;
using KayraCQRSMediator.Features.Mediator.Commands.ProductCommands;

namespace KayraCQRSMediator.Validations.ProductValidatiors
{
    public class UpdateProductValidator: AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün Adı Boş Bırakılamaz.")
                .MinimumLength(3).WithMessage("Ürün Adı En Az 3 Karakter Olmalıdır.").
                MaximumLength(100).WithMessage("Ürün Adı En Fazla 300 Karakter Olabilir.");
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("Ürün Fiyatı Boş Bırakılamaz.");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori Boş Geçilemez.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Ürün Resmi Boş Geçilemez.");
        }
    }
}
