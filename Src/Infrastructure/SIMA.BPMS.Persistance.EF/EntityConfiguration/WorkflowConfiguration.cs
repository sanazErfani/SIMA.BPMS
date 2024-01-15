using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIMA.BPMS.Domain.Models.Workflows.Entities;
using SIMA.Framework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMA.BPMS.Persistance.EF.EntityConfiguration;

public class WorkflowConfiguration : IEntityTypeConfiguration<Workflow>
{
    public void Configure(EntityTypeBuilder<Workflow> entity)
    {
        entity.ToTable("Workflow", "Workflow");
        entity.Property(e => e.Id).ValueGeneratedNever();
    }
}
