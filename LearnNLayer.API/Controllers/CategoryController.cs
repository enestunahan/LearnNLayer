using LearnNLayer.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LearnNLayer.API.Controllers
{ 
    public class CategoryController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetCategoryByIdWithProducts(int id)
        {
            return CreateActionResult(await _categoryService.GetCategoryByIdWithProducts(id));
        }
    }
}
