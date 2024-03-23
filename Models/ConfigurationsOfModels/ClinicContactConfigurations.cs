using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.Models.ConfigurationsOfModels;

public class ClinicContactConfigurations : IEntityTypeConfiguration<ClinicContactModel>
{
    public void Configure(EntityTypeBuilder<ClinicContactModel> builder)
    {
        builder.HasOne<ClinicModel>(e => e.Clinic)
               .WithMany(s => s.Contacts)
               .HasForeignKey(e => e.ClinicId)
               .HasPrincipalKey(s => s.Id);
    }
}
