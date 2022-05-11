using System.Threading.Tasks;

namespace LearnNLayer.Core.IUnitOfWork
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
