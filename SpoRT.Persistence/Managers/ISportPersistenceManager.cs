using SpoRT.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpoRT.Persistence.Managers
{
    public interface ISportPersistenceManager
    {
        Task<IEnumerable<SportEntity>> GetAll();
    }
}