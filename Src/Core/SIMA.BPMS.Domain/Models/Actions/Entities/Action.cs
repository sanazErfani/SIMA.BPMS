using SIMA.BPMS.Domain.Models.Actions.Args;
using SIMA.BPMS.Domain.Models.ActionTypes.Entities;
using SIMA.BPMS.Domain.Models.ActorActions.Entities;
using SIMA.BPMS.Domain.Models.ActorSets.Args;
using SIMA.BPMS.Domain.Models.ActorSets.Entities;
using SIMA.BPMS.Domain.Models.Processes.Entities;
using SIMA.BPMS.Domain.Models.Workflows.Entities;
using SIMA.Framework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMA.BPMS.Domain.Models.Actions.Entities;

public class Action : Entity, IAggregateRoot
{
    private Action()
    {

    }

    public Action(CreateActionArg arg)
    {
        Id = arg.Id;
        BpmnEventId = arg.BpmnEventId;
        BpmnId = arg.BpmnId;
        WorkflowId = arg.WorkflowId;
        ActionTypeId = arg.ActionTypeId;
        Name = arg.Name;
    }

    public static async Task<Action> Create(CreateActionArg arg)
    {
        return new Action(arg);
    }
    public long Id { get; private set; }
    public long BpmnId { get; private set; }
    public long BpmnEventId { get; private set; }
    public long WorkflowId { get; private set; }
    public long ActionTypeId { get; private set; }
    public string Name { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public long CreatedBy { get; private set; }
    public DateTime ModifiedAt { get; private set; }
    public long ModifiedBy { get; private set; }

    public  Workflow Workflow { get; private set; }
    public  ActionType ActionType { get; private set; }

    private List<ActorAction> _actorActions = new();
    public virtual ICollection<ActorAction> ActorActions => _actorActions;

    private List<Processes.Entities.Process> _processSources = new();
    public virtual ICollection<Processes.Entities.Process> ProcessSources => _processSources;  
    
    private List<Processes.Entities.Process> _processTargets = new();
    public virtual ICollection<Processes.Entities.Process> ProcessTargets => _processTargets;  

 
}
