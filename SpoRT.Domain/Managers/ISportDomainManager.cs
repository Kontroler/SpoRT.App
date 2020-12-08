using SpoRT.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpoRT.Domain.Managers
{
    public interface ISportDomainManager
    {
        Task Save(Sport sport);
        Task<IEnumerable<Sport>> GetAll();
        
    }
}