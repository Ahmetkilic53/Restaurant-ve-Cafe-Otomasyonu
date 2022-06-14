using CafeOtomasyonu.Entities.Models;
using FluentValidation;

namespace CafeOtomasyonu.Entities.Validations
{
    public class SatislarValidator : AbstractValidator<Satislar>
    {
        public SatislarValidator()
        {
            RuleFor(p => p.SatisKodu).NotEmpty().WithMessage("Satış Kodu alanı boş geçilemez");
        }
    }
}