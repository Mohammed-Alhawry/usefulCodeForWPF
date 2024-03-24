using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.Models.ConfigurationsOfModels;

public class DoctorContactConfigurations : IEntityTypeConfiguration<DoctorContactModel>
{
    public void Configure(EntityTypeBuilder<DoctorContactModel> builder)
    {
        builder.HasOne<DoctorModel>(e => e.Doctor)
               .WithMany(s => s.Contacts)
               .HasForeignKey(e => e.DoctorId)
               .HasPrincipalKey(s => s.Id);
               
               
    }
}
