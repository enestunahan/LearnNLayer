using LearnNLayer.Core.DTOs;
using LearnNLayer.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnNLayer.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductWithCategory();
    }
}
