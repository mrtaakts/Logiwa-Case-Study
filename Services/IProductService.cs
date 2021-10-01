using Logiwa_Case_Study.Models;
using Logiwa_Case_Study.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Services
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> GetAllProductsWithCategory();
        Task<Product> GetProductWithCategoryById(int id);
        List<Product> GetProductByCondition(ProductCriterias productCriterias);
        ResponseDto UpdateProduct(Product product);

    }
}
