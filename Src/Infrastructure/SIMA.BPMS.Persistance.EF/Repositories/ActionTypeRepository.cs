using SIMA.BPMS.Domain.Models.ActionTypes.Entities;
using SIMA.BPMS.Domain.Models.ActionTypes.Interfaces;
using SIMA.BPMS.Persistance.EF.Persistence;
using SIMA.Framework.Infrastructure.Data;

namespace SIMA.BPMS.Persistance.EF.Repositories;

public class ActionTypeRepository : Repository<ActionType>, IActionTypeRepository
{
    private readonly BPMSContext _context;

    public ActionTypeRepository(BPMSContext context) : base(context)
    {
        _context = context;
    }
}
