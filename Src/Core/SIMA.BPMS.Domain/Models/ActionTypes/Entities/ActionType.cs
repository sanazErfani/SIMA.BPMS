using SIMA.BPMS.Domain.Models.ActionTypes.Args;
using SIMA.BPMS.Domain.Models.Actors.Entities;
using SIMA.BPMS.Domain.Models.ActorSets.Args;
using SIMA.BPMS.Domain.Models.ActorSets.Entities;
using SIMA.Framework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMA.BPMS.Domain.Models.ActionTypes.Entities;

public class ActionType : Entity, IAggregateRoot
{
    private ActionType()
    {

    }

    public ActionType(CreateActionTypeArg arg)
    {
        Id = arg.Id;
        Name = arg.Name;
        EventTag = arg.EventTag;
        EventInternalTag = arg.EventInternalTag;
        MainType = arg.MainType;
    }

    public static async Task<ActionType> Create(CreateActionTypeArg arg)
    {
        return new ActionType(arg);
    }
    public long Id { get; private set; }
    public string Name { get; set; }
    public string EventTag { get; set; }
    public string EventInternalTag { get; set; }
    public string MainType { get; set; }

    private List<Actions.Entities.Action> _actions = new();
    public virtual ICollection<Actions.Entities.Action> Actions => _actions;
}
