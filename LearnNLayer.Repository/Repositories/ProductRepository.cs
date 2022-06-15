using LearnNLayer.Core.Models;
using LearnNLayer.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnNLayer.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public Task<List<Product>> GetProductWithCategory()
        {
            // burada ilk productlarımızı çekerken kategorilerimizi de çektiğimiz için eager loading diyoruz bu işleme
           return _appDbContext.Products.Include(x=> x.Category).ToListAsync();
        }
    }
}
