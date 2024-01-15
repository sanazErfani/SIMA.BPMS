using SIMA.Framework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMA.BPMS.Domain.Models.ActionTypes.Args;

public class CreateActionTypeArg 
{
    public long Id { get; private set; }
    public string Name { get; set; }
    public string EventTag { get; set; }
    public string EventInternalTag { get; set; }
    public string MainType { get; set; }
}
