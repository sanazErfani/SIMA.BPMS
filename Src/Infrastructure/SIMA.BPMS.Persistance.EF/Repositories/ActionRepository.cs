using SIMA.BPMS.Domain.Models.Actions.Interfaces;
using SIMA.BPMS.Persistance.EF.Persistence;
using SIMA.Framework.Infrastructure.Data;

namespace SIMA.BPMS.Persistance.EF.Repositories;

public class ActionRepository : Repository<Domain.Models.Actions.Entities.Action>, IActionRepository
{
    private readonly BPMSContext _context;

    public ActionRepository(BPMSContext context) : base(context)
    {
        _context = context;
    }
}
