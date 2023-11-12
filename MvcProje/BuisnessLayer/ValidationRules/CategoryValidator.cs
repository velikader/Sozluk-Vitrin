using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori ismi boş geçilemez!!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama satırı boş geçilemez!!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az üç karakter girişi yapınız");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("En fazla yirmi karakter girişi yapınız");

        }
    }
}
