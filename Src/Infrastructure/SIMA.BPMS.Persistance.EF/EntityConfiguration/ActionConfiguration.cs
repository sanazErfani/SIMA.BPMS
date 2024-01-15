using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIMA.BPMS.Domain.Models.ActionTypes.Entities;

namespace SIMA.BPMS.Persistance.EF.EntityConfiguration;

public class ActionConfiguration : IEntityTypeConfiguration<Domain.Models.Actions.Entities.Action>
{
    public void Configure(EntityTypeBuilder<Domain.Models.Actions.Entities.Action> entity)
    {
        entity.ToTable("Action", "Workflow");
        entity.Property(e => e.Id).ValueGeneratedNever();

        //entity.HasOne(d => d.Workflow).WithMany(p => p.Actions)
        //       .HasForeignKey(d => d.WorkflowId);

        //entity.HasOne(d => d.ActionType).WithMany(p => p.Actions)
        //       .HasForeignKey(d => d.ActionTypeId);
        //1-1
        //entity.HasOne(a => a.ActionType)
        //     .WithOne(aa => aa.Action)
        //     .HasForeignKey<ActionType>(course => course.Id);

    }
}
