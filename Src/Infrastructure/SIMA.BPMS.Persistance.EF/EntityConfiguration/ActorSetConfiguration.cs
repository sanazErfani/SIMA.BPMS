using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIMA.BPMS.Domain.Models.ActorSets.Entities;

namespace SIMA.BPMS.Persistance.EF.EntityConfiguration;

public class ActorSetConfiguration : IEntityTypeConfiguration<ActorSet>
{
    public void Configure(EntityTypeBuilder<ActorSet> entity)
    {
        entity.ToTable("ActorSet", "Workflow");
        entity.Property(e => e.Id).ValueGeneratedNever();

        entity.HasOne(d => d.Workflow).WithMany(p => p.ActorSets)
                    .HasForeignKey(d => d.WorkflowId)
                      .OnDelete(DeleteBehavior.ClientSetNull);
    }
}

