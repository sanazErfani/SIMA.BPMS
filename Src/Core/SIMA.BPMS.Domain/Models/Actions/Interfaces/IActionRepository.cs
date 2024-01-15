using SIMA.BPMS.Domain.Models.Actions.Entities;
using SIMA.Framework.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMA.BPMS.Domain.Models.Actions.Interfaces;

public interface IActionRepository : IRepository<Entities.Action>
{
}
