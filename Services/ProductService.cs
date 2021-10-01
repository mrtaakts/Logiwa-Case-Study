using Logiwa_Case_Study.Models;
using Logiwa_Case_Study.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Services
{
    public class ProductService : GenericService<Product>, IProductService
    {

        public ProductService(AppDbContext context) : base(context)
        {
        }


        public List<Product> GetAllProductsWithCategory()
        {
            //including category
            return _context.Products.Include(m => m.category).ToList();
        }

        public List<Product> GetProductByCondition(ProductCriterias productCriterias)
        {
            // gets product list by criterias including category
            return _context.Products.Include(m => m.category)
                .Where(m => m.Title.ToLower().Contains(productCriterias.Title.ToLower())
                && m.Description.ToLower().Contains(productCriterias.Description.ToLower())
                && m.category.Name.ToLower().Contains(productCriterias.CategoryName.ToLower()) && m.StockQuantity >= productCriterias.minquantity && m.StockQuantity <= productCriterias.maxquantity)
                .OrderBy(m=> m.Id).ToList();
        }

        public async Task<Product> GetProductWithCategoryById(int id)
        {
            // gets product by id including category
            return await _context.Products.Include(m => m.category).FirstOrDefaultAsync(m => m.Id == id);
        }

        public ResponseDto UpdateProduct(Product product)
        {
            // update
            _context.Products.Update(product);
            var savestatus = _context.SaveChanges();
            return savestatus > 0 ? new ResponseDto { Message = "Başarıyla güncellendi.", Status = true } : new ResponseDto { Message = "Güncellenme İşlemi Gerçekleşmedi.", Status = false };

        }
    }
}
