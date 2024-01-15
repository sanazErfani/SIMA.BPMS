using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIMA.BPMS.Domain.Models.ActionTypes.Entities;
using SIMA.Framework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMA.BPMS.Persistance.EF.EntityConfiguration;

public class ActionTypeConfiguration : IEntityTypeConfiguration<ActionType>
{
    public void Configure(EntityTypeBuilder<ActionType> entity)
    {
        entity.ToTable("ActionType", "Workflow");
        entity.Property(e => e.Id).ValueGeneratedNever();

    }
}
