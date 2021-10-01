using AutoMapper;
using Logiwa_Case_Study.Models;
using Logiwa_Case_Study.Models.Dtos;
using Logiwa_Case_Study.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // DI
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        // api/product
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productService.GetAllProductsWithCategory();

            return Ok(_mapper.Map<List<ProductToReturnDto>>(products));
        }

        // api/product/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var response = await _productService.Delete(id);
            return Ok(response);
        }

        // api/product/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productService.GetProductWithCategoryById(id);
            return Ok(_mapper.Map<ProductToReturnDto>(product));
        }

        // api/product
        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {

            var response = await _productService.Create(_mapper.Map<Product>(product));
            return Ok(response);

        }

        // api/product
        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            var response = _productService.UpdateProduct(product);
            return Ok(response);

        }

        // api/product/FilterProduct/?criterias  (Title, Description, CategoryName, minquantity, maxquantity)
        [HttpGet("[action]")]
        public IActionResult FilterProduct([FromQuery] ProductCriterias productCriterias)
        {
            var filteredProducts = _productService.GetProductByCondition(productCriterias);

            return Ok(_mapper.Map<List<ProductToReturnDto>>(filteredProducts));
        }
    }
}
