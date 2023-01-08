using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(p => p.nameTr).MinimumLength(100);
            RuleFor(p => p.nameTr).NotEmpty();
            RuleFor(p => p.nameEng).MinimumLength(100);
            RuleFor(p => p.nameEng).NotEmpty();
            //RuleFor(p => p.nameTr).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı"); --> custom rule
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
