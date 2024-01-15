using SIMA.BPMS.Domain.Models.Actions.Interfaces;
using SIMA.BPMS.Domain.Models.ActorSets.Entities;
using SIMA.BPMS.Domain.Models.ActorSets.Interfaces;
using SIMA.BPMS.Persistance.EF.Persistence;
using SIMA.Framework.Infrastructure.Data;
namespace SIMA.BPMS.Persistance.EF.Repositories;

public class ActorSetRepository : Repository<ActorSet>, IActorSetRepository
{
    private readonly BPMSContext _context;

    public ActorSetRepository(BPMSContext context) : base(context)
    {
        _context = context;
    }
}
