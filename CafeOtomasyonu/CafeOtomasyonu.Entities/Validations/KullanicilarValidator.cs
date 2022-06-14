using CafeOtomasyonu.Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Validations
{
    public class KullanicilarValidator : AbstractValidator<Kullanicilar>
    {
        public KullanicilarValidator()
        {
            RuleFor(p => p.AdSoyad).NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez");
            RuleFor(p => p.KullaniciAdi).NotEmpty().WithMessage("Kullanıcı Adı alanı boş geçilemez");
            RuleFor(p => p.KullaniciAdi).MinimumLength(5).WithMessage("Kullanıcı Adı alanı en az 5 karakter");
            RuleFor(p => p.KullaniciAdi).MaximumLength(25).WithMessage("Kullanıcı Adı alanı en fazla 25 karakter");
            RuleFor(p => p.Parola).NotEmpty().WithMessage("Parola alanı boş geçilemez");
            RuleFor(p => p.Parola).MinimumLength(4).WithMessage("Parola alanı en az 4 karakter");
            RuleFor(p => p.Parola).MaximumLength(20).WithMessage("Parola alanı en fazla 20 karakter");
            RuleFor(p => p.Telefon).NotEmpty().WithMessage("Telefon alanı boş geçilemez");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Yanlış email adresi formatı");



        }
    }
}