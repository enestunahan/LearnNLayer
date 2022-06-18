using AutoMapper;
using LearnNLayer.Core.DTOs;
using LearnNLayer.Core.IUnitOfWork;
using LearnNLayer.Core.Models;
using LearnNLayer.Core.Repositories;
using LearnNLayer.Core.Services;
using System.Threading.Tasks;

namespace LearnNLayer.Service.Services
{
    public class CategoryService : Service<Category> ,ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository) : base(repository, unitOfWork)
        {
            _mapper= mapper;
            _categoryRepository= categoryRepository;
        }

        public async Task<CustomResponseDto<CategoryWithProductsDto>> GetCategoryByIdWithProducts(int id)
        {
            var categories =  await _categoryRepository.GetCategoryByIdWithProducts(id);
            var categoriesDto = _mapper.Map<CategoryWithProductsDto>(categories);
            return CustomResponseDto<CategoryWithProductsDto>.Success(200, categoriesDto);
        }
    }
}
