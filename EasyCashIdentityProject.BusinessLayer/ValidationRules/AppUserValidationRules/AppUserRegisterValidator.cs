using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Ad Alanı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Alanı Boş Geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Alanı Boş Geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı Boş Geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri girişi yapınız");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri girişi yapınız");
            RuleFor(x => x.Username).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter veri girişi yapınız");
            RuleFor(x => x.Username).MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri girişi yapınız");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalarınız eşleşmedi");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz");


        }
    }
}
