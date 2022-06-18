using LearnNLayer.Core.Models;
using LearnNLayer.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LearnNLayer.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
        public async Task<Category> GetCategoryByIdWithProducts(int id)
        {
            return await _appDbContext.Categories.Include(x=>x.Products).Where(x=>x.Id == id).SingleOrDefaultAsync();
        }
    }
}
