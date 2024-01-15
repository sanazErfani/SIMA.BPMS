using SIMA.Framework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMA.BPMS.Domain.Models.Processes.Args;

public class CreateProcessArg
{
    public long Id { get; set; }
    public long BpmnId { get; set; }
    public long BpmnEventId { get; set; }
    public long WorkflowId { get; set; }
    public long SourceRefId { get; set; }
    public string SourceRefBpmnId { get; set; }
    public long TargetRefId { get; set; }
    public string TargetRefBpmnId { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public long CreatedBy { get; set; }
    public DateTime ModifiedAt { get; set; }
    public long ModifiedBy { get; set; }
}
