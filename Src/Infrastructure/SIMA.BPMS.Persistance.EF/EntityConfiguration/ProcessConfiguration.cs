using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SIMA.BPMS.Persistance.EF.EntityConfiguration;

public class ProcessConfiguration : IEntityTypeConfiguration<Domain.Models.Processes.Entities.Process>
{
    public void Configure(EntityTypeBuilder<Domain.Models.Processes.Entities.Process> entity)
    {
        entity.ToTable("Process", "Workflow");
        entity.Property(e => e.Id).ValueGeneratedNever();

        entity.HasOne(d => d.SourceRef).WithMany(p => p.ProcessSources)
               .HasForeignKey(d => d.SourceRefId)
               .OnDelete(DeleteBehavior.ClientSetNull);


        entity.HasOne(d => d.TargetRef).WithMany(p => p.ProcessTargets)
               .HasForeignKey(d => d.TargetRefId)
               .OnDelete(DeleteBehavior.ClientSetNull);
       

    }
}
