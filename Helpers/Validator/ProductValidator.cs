using FluentValidation;
using Logiwa_Case_Study.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Helpers
{
    public class ProductValidator : AbstractValidator<Product>
    {
        private readonly AppDbContext _context;

        public ProductValidator(AppDbContext context)
        {
            _context = context;
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz.").NotNull().WithMessage("Başlık boş bırakılamaz.").MaximumLength(200);

            RuleFor(x => x).Must(x => IsCategoryExist(x)).WithMessage(x => $"{x.CategoryId} nolu id'ye ait kategori bulunamadı.");

            RuleFor(x => x.StockQuantity)
                .GreaterThanOrEqualTo(x => x.category.MinimumStockQuantity)
                .When(m => IsCategoryExist(m) == true)
                .WithMessage(m => $"Ürün stok sayısı, kategorinin belirlediğinden düşük. Stok sayısı {m.category.MinimumStockQuantity} adet veya daha fazla olmalı");


            bool IsCategoryExist(Product p)
            {
                try
                {
                    var cat = _context.Categories.FirstOrDefault(m => m.Id == p.CategoryId);

                    if (cat != null)
                    {
                        p.category = cat;
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }
    }

}
