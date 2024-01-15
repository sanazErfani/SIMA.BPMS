using SIMA.BPMS.Domain.Models.ActorActions.Entities;
using SIMA.BPMS.Domain.Models.Actors.Args;
using SIMA.BPMS.Domain.Models.ActorSets.Args;
using SIMA.BPMS.Domain.Models.ActorSets.Entities;
using SIMA.BPMS.Domain.Models.Workflows.Entities;
using SIMA.Framework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMA.BPMS.Domain.Models.Actors.Entities;

public class Actor:Entity,IAggregateRoot
{
    private Actor()
    {
            
    }

    public Actor(CreateActorArg arg)
    {
        Id = arg.Id;
        BpmnId = arg.BpmnId;
        WorkflowId = arg.WorkflowId;
        ActorSetId = arg.ActorSetId;
        Name = arg.Name;
    }

    public static async Task<Actor> Create(CreateActorArg arg)
    {
        return new Actor(arg);
    }
    public long Id { get; private set; }
    public long BpmnId { get; private set; }
    public long WorkflowId { get; private set; }
    public long ActorSetId { get; private set; }
    public string Name { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public long CreatedBy { get; private set; }
    public DateTime ModifiedAt { get; private set; }
    public long ModifiedBy { get; private set; }
    public virtual ActorSet ActorSet { get; private set; }
    public virtual Workflow Workflow { get; private set; }


    private List<ActorAction> _actorActions = new();
    public virtual ICollection<ActorAction> ActorActions => _actorActions;
}
