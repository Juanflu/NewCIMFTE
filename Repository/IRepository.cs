using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewCIMFTE.Repository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAsync();
    }
}
