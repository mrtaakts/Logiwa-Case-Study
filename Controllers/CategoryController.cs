using AutoMapper;
using Logiwa_Case_Study.Models;
using Logiwa_Case_Study.Models.Dtos;
using Logiwa_Case_Study.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logiwa_Case_Study.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // DI
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }

        // api/category
        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = _categoryService.GetAll();
            return Ok(categories);
        }

        // api/category/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var response = await _categoryService.Delete(id);
            return Ok(response);
        }

        // api/category/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var category = await _categoryService.GetById(id);
            return Ok(category);
        }

        // api/category
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryCreateDto category)
        {
            var response = await _categoryService.Create(_mapper.Map<Category>(category));
            return Ok(response);
        }

        // api/category
        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            var response = _categoryService.UpdateCategory(_mapper.Map<Category>(category));
            return Ok(response);
        }

        
    }
}
