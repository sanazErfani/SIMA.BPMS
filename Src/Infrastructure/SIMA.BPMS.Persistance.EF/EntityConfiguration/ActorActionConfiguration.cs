using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIMA.BPMS.Domain.Models.ActorActions.Entities;

namespace SIMA.BPMS.Persistance.EF.EntityConfiguration;

public class ActorActionConfiguration : IEntityTypeConfiguration<ActorAction>
{
    public void Configure(EntityTypeBuilder<ActorAction> entity)
    {
        entity.ToTable("ActorAction", "Workflow");
        entity.Property(e => e.Id).ValueGeneratedNever();

        entity.HasOne(d => d.Actor).WithMany(p => p.ActorActions)
               .HasForeignKey(d => d.ActorId).OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.Action).WithMany(p => p.ActorActions)
               .HasForeignKey(d => d.ActionId)
                 .OnDelete(DeleteBehavior.ClientSetNull);

    }
}
