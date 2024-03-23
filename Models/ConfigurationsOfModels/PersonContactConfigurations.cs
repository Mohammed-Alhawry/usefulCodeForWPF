using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.Models.ConfigurationsOfModels;

public class PersonContactConfigurations : IEntityTypeConfiguration<PersonContactModel>
{
    public void Configure(EntityTypeBuilder<PersonContactModel> builder)
    {
        builder.HasOne<PersonModel>(e => e.Person)
               .WithMany(s => s.Contacts)
               .HasForeignKey(e => e.PersonId)
               .HasPrincipalKey(s => s.Id);
        
    }
}
