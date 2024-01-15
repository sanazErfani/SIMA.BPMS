using SIMA.BPMS.Domain.Models.Actors.Entities;
using SIMA.BPMS.Domain.Models.ActorSets.Args;
using SIMA.BPMS.Domain.Models.Workflows.Entities;
using SIMA.Framework.Core.Entities;

namespace SIMA.BPMS.Domain.Models.ActorSets.Entities;

public class ActorSet : Entity, IAggregateRoot
{
    private ActorSet()
    {

    }

    public ActorSet(CreateActorSetArg arg)
    {
        Id = arg.Id;
        BpmnId = arg.BpmnId;
        WorkflowId = arg.WorkflowId;
    }

    public static async Task<ActorSet> Create(CreateActorSetArg arg)
    {
        return new ActorSet(arg);
    }
    public long Id { get; private set; }
    public long BpmnId { get; private set; }
    public long WorkflowId { get; private set; }
    public virtual Workflow Workflow{ get;private set; }
    public DateTime CreatedAt { get; private set; }
    public long CreatedBy { get; private set; }
    public DateTime ModifiedAt { get; private set; }
    public long ModifiedBy { get; private set; }

    private List<Actor> _actors = new();
    public virtual ICollection<Actor> Actors => _actors;


}
