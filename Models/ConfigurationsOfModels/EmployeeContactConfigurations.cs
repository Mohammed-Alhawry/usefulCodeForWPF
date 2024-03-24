using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.Models.ConfigurationsOfModels;

public class EmployeeContactConfigurations : IEntityTypeConfiguration<EmployeeContactModel>
{
    public void Configure(EntityTypeBuilder<EmployeeContactModel> builder)
    {
        builder.HasOne<EmployeeModel>(e => e.Employee)
               .WithMany(s => s.Contacts)
               .HasForeignKey(e => e.EmployeeId)
               .HasPrincipalKey(s => s.Id);
        
    }
}
