using Logiwa_Case_Study.Models;
using Logiwa_Case_Study.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Services
{
    public interface ICategoryService : IGenericService<Category>
    {
        ResponseDto UpdateCategory(Category category);
    }
}
