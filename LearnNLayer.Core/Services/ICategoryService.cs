using LearnNLayer.Core.DTOs;
using LearnNLayer.Core.Models;
using System.Threading.Tasks;

namespace LearnNLayer.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<CustomResponseDto<CategoryWithProductsDto>> GetCategoryByIdWithProducts(int id);
    }
}
