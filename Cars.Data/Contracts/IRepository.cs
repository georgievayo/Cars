using System.Linq;

namespace Cars.Data.Contracts
{
    public interface IRepository<T>
        where T : class
        {
            IQueryable<T> All { get; }
        }
}
