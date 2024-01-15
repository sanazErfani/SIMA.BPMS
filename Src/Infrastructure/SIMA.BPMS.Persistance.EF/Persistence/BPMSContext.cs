using Microsoft.EntityFrameworkCore;
using SIMA.BPMS.Domain.Models.Actions.Entities;
using SIMA.BPMS.Domain.Models.ActionTypes.Entities;
using SIMA.BPMS.Domain.Models.ActorActions.Entities;
using SIMA.BPMS.Domain.Models.Actors.Entities;
using SIMA.BPMS.Domain.Models.ActorSets.Entities;
using SIMA.BPMS.Domain.Models.Processes.Entities;
using SIMA.BPMS.Domain.Models.Workflows.Entities;
using SIMA.BPMS.Persistance.EF.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMA.BPMS.Persistance.EF.Persistence;

public class BPMSContext : DbContext
{
    public BPMSContext(DbContextOptions<BPMSContext> options) : base(options)
    {

    }
    public virtual DbSet<Domain.Models.Actions.Entities.Action> Actions { get; set; }
    public virtual DbSet<ActionType> ActionTypes { get; set; }
    public virtual DbSet<ActorAction> ActorActions { get; set; }
    public virtual DbSet<Actor> Actors { get; set; }
    public virtual DbSet<ActorSet> ActorSets { get; set; }
    public virtual DbSet<Process> Processes { get; set; }
    public virtual DbSet<Workflow> Workflows { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(WorkflowConfiguration).Assembly);
    }
}
