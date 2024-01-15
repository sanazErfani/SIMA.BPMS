using SIMA.BPMS.Domain.Models.Actions.Entities;
using SIMA.BPMS.Domain.Models.Actors.Entities;
using SIMA.BPMS.Domain.Models.ActorSets.Entities;
using SIMA.BPMS.Domain.Models.Workflows.Args;
using SIMA.Framework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMA.BPMS.Domain.Models.Workflows.Entities;

public class Workflow : Entity, IAggregateRoot
{
    private Workflow()
    {

    }

    public Workflow(CreateWorkflowArg arg)
    {
        Id = arg.Id;
        FileContent = arg.FileContent;
        BpmnId = arg.BpmnId;
    }

    public static async Task<Workflow> Create(CreateWorkflowArg arg)
    {
        return new Workflow(arg);
    }
    public long Id { get; private set; }
    public long BpmnId { get; private set; }
    public string FileContent { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public long CreatedBy { get; private set; }
    public DateTime ModifiedAt { get; private set; }
    public long ModifiedBy { get; private set; }


    private List<ActorSet> _actorSets = new();
    public  ICollection<ActorSet> ActorSets => _actorSets;

    private List<Actor> _actors = new();
    public  ICollection<Actor> Actors => _actors;

    private List<Actions.Entities.Action> _actionss = new();
    public  ICollection<Actions.Entities.Action> Actions => _actionss;

    private List<Processes.Entities.Process> _processes = new();
    public  ICollection<Processes.Entities.Process> Processes => _processes;
}
