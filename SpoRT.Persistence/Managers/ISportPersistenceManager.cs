using SpoRT.Persistence.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpoRT.Persistence.Managers
{
    public interface ISportPersistenceManager
    {
        Task Save(SportEntity sport);
        Task<IEnumerable<SportEntity>> GetAll();
    }
}