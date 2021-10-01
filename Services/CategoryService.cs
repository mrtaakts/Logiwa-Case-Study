using Logiwa_Case_Study.Models;
using Logiwa_Case_Study.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Services
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        public CategoryService(AppDbContext context) : base(context)
        {
        }

        public ResponseDto UpdateCategory(Category category)
        {
            //update
            _context.Categories.Update(category);
            var savestatus = _context.SaveChanges();
            return savestatus > 0 ? new ResponseDto { Message = "Başarıyla güncellendi.", Status = true } : new ResponseDto { Message = "Güncellenme İşlemi Gerçekleşmedi.", Status = false };

        }
    }
}
