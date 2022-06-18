using AutoMapper;
using LearnNLayer.Core.DTOs;
using LearnNLayer.Core.IUnitOfWork;
using LearnNLayer.Core.Models;
using LearnNLayer.Core.Repositories;
using LearnNLayer.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnNLayer.Service.Services
{
    public class ProductService : Service<Product> , IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork,IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _repository = productRepository;
            _mapper = mapper;   
        }

        public async Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductWithCategory()
        {
            var products  = await _repository.GetProductWithCategory();
            var productsWithCategoryDto  = _mapper.Map<List<ProductWithCategoryDto>>(products);
            return CustomResponseDto<List<ProductWithCategoryDto>>.Success(200, productsWithCategoryDto);
        }
    }
}
