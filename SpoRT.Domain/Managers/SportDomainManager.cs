using SpoRT.Domain.Models;
using SpoRT.Persistence.Managers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpoRT.Domain.Managers
{
    public class SportDomainManager : ISportDomainManager
    {
        //private readonly ISportPersistenceManager _sportPersistenceManger;

        //public SportDomainManager(ISportPersistenceManager sportPersistenceManger)
        //{
        //    _sportPersistenceManger = sportPersistenceManger;
        //}

        //public async Task<IEnumerable<Sport>> GetAll()
        //{
        //    return (await _sportPersistenceManger.GetAll()).Select(x => new Sport { Id = x.Id, Name = x.Name });
        //}
    }
}