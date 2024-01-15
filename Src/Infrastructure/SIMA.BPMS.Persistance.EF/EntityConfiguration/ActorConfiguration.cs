using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIMA.BPMS.Domain.Models.Actors.Entities;

namespace SIMA.BPMS.Persistance.EF.EntityConfiguration;

public class ActorConfiguration : IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> entity)
    {
        entity.ToTable("Actor", "Workflow");
        entity.Property(e => e.Id).ValueGeneratedNever();

        entity.HasOne(d => d.Workflow).WithMany(p => p.Actors)
                    .HasForeignKey(d => d.WorkflowId).OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.ActorSet).WithMany(p => p.Actors)
                    .HasForeignKey(d => d.ActorSetId).OnDelete(DeleteBehavior.ClientSetNull);
    }
}

