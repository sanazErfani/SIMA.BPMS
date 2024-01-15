using SIMA.BPMS.Domain.Models.Actions.Interfaces;
using SIMA.BPMS.Domain.Models.ActorActions.Entities;
using SIMA.BPMS.Domain.Models.Actors.Entities;
using SIMA.BPMS.Domain.Models.Actors.Interfaces;
using SIMA.BPMS.Persistance.EF.Persistence;
using SIMA.Framework.Infrastructure.Data;

namespace SIMA.BPMS.Persistance.EF.Repositories;

public class ActorRepository : Repository<Actor>, IActorRepository
{
    private readonly BPMSContext _context;

    public ActorRepository(BPMSContext context) : base(context)
    {
        _context = context;
    }
}
