using System.Threading.Tasks;

namespace RSwitch.AMBS.DAL.Repositories.Interface
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();
    }
}