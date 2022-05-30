using LearnNLayer.Core.IUnitOfWork;
using System.Threading.Tasks;

namespace LearnNLayer.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
          await _context.SaveChangesAsync();
        }
    }
}
