using SIMA.BPMS.Domain.Models.Actions.Interfaces;
using SIMA.BPMS.Domain.Models.ActorActions.Entities;
using SIMA.BPMS.Domain.Models.ActorActions.Interfaces;
using SIMA.BPMS.Persistance.EF.Persistence;
using SIMA.Framework.Infrastructure.Data;

namespace SIMA.BPMS.Persistance.EF.Repositories;

public class ActorActionRepository : Repository<ActorAction>, IActorActionRepository
{
    private readonly BPMSContext _context;

    public ActorActionRepository(BPMSContext context) : base(context)
    {
        _context = context;
    }
}
