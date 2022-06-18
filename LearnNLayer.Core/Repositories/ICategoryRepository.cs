using LearnNLayer.Core.Models;
using System.Threading.Tasks;

namespace LearnNLayer.Core.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<Category> GetCategoryByIdWithProducts(int id);
    }
}
