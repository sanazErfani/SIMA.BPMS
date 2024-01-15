using SIMA.Framework.Core.Entities;

namespace SIMA.BPMS.Domain.Models.ActorSets.Args;

public class CreateActorSetArg
{
    public long Id { get; set; }
    public long BpmnId { get; set; }
    public long WorkflowId { get; set; }
    public DateTime CreatedAt { get; set; }
    public long CreatedBy { get; set; }
    public DateTime ModifiedAt { get; set; }
    public long ModifiedBy { get; set; }
}
