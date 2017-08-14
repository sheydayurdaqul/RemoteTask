using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using Task.Web.Model;

namespace Task.Web.Validators
{
    public class UserValidator:AbstractValidator<UserCreditModel>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("isim boş geçilemez");
        }
    }
}