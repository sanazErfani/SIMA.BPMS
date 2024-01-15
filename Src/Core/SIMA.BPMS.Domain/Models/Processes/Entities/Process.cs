using SIMA.BPMS.Domain.Models.Processes.Args;
using SIMA.BPMS.Domain.Models.Workflows.Entities;
using SIMA.Framework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMA.BPMS.Domain.Models.Processes.Entities;

public class Process : Entity, IAggregateRoot
{
    private Process()
    {

    }

    public Process(CreateProcessArg arg)
    {
        BpmnId = arg.BpmnId;
        WorkflowId = arg.WorkflowId;
        SourceRefBpmnId = arg.SourceRefBpmnId;
        SourceRefId = arg.SourceRefId;
        TargetRefBpmnId = arg.TargetRefBpmnId;
        TargetRefId = arg.TargetRefId;
        Name = arg.Name;
    }

    public static async Task<Process> Create(CreateProcessArg arg)
    {

        return new Process(arg);
    }
    public long Id { get; private set; }
    public long BpmnId { get; private set; }
    public long BpmnEventId { get; private set; }
    public long WorkflowId { get; private set; }
    public long SourceRefId { get; private set; }
    public string SourceRefBpmnId { get; private set; }
    public long TargetRefId { get; private set; }
    public string TargetRefBpmnId { get; private set; }
    public string Name { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public long CreatedBy { get; private set; }
    public DateTime ModifiedAt { get; private set; }
    public long ModifiedBy { get; private set; }


    public Workflow Workflow { get; private set; }
    public Actions.Entities.Action SourceRef { get; private set; }
    public Actions.Entities.Action TargetRef { get; private set; }


}
