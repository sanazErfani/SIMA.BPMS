using SIMA.BPMS.Domain.Models.ActorActions.Args;
using SIMA.BPMS.Domain.Models.Actors.Entities;
using SIMA.BPMS.Domain.Models.ActorSets.Args;
using SIMA.BPMS.Domain.Models.ActorSets.Entities;
using SIMA.Framework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMA.BPMS.Domain.Models.ActorActions.Entities;

public class ActorAction : Entity, IAggregateRoot
{
    private ActorAction()
    {

    }

    public ActorAction(CreateActorActionArg arg)
    {
        Id = arg.Id;
        ActorId = arg.ActorId;
        ActionId = arg.ActionId;
    }

    public static async Task<ActorAction> Create(CreateActorActionArg arg)
    {
        return new ActorAction(arg);
    }
    public long Id { get; private set; }
    public long ActorId { get; private set; }
    public long ActionId { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public long CreatedBy { get; private set; }
    public DateTime ModifiedAt { get; private set; }
    public long ModifiedBy { get; private set; }

    public Actor Actor { get; private set; }
    public Actions.Entities.Action Action { get; private set; }
}
