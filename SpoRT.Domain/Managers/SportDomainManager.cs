using AutoMapper;
using SpoRT.Domain.Models;
using SpoRT.Persistence.Entities;
using SpoRT.Persistence.Managers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpoRT.Domain.Managers
{
    public class SportDomainManager : ISportDomainManager
    {
        private readonly ISportPersistenceManager _sportPersistenceManger;
        private readonly IMapper _mapper;

        public SportDomainManager(ISportPersistenceManager sportPersistenceManger, IMapper mapper)
        {
            _sportPersistenceManger = sportPersistenceManger;
            _mapper = mapper;
        }

        public async Task Save(Sport sport)
        {
            var sportEntity = _mapper.Map<SportEntity>(sport);
            await _sportPersistenceManger.Save(sportEntity);
        }

        public async Task<IEnumerable<Sport>> GetAll()
        {
            var sportEntities = await _sportPersistenceManger.GetAll();
            var sports = sportEntities.Select(sportEntity => _mapper.Map<Sport>(sportEntity));
            return sports;
        }
    }
}