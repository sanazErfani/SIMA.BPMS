using SIMA.BPMS.Domain.Models.Workflows.Entities;
using SIMA.Framework.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMA.BPMS.Domain.Models.Workflows.Interfaces;

public interface IWorkflowRepository : IRepository<Workflow>
{
}
