using SIMA.BPMS.Domain.Models.Actions.Interfaces;
using SIMA.BPMS.Domain.Models.Processes.Entities;
using SIMA.BPMS.Domain.Models.Processes.Interfaces;
using SIMA.BPMS.Domain.Models.Workflows.Interfaces;
using SIMA.BPMS.Persistance.EF.Persistence;
using SIMA.Framework.Infrastructure.Data;

namespace SIMA.BPMS.Persistance.EF.Repositories;

public class ProcessRepository : Repository<Process>, IProcessRepository
{
    private readonly BPMSContext _context;

    public ProcessRepository(BPMSContext context) : base(context)
    {
        _context = context;
    }
}
