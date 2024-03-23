using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.Models.ConfigurationsOfModels;

public class AttendanceConfigurations : IEntityTypeConfiguration<AttendanceModel>
{
    public void Configure(EntityTypeBuilder<AttendanceModel> builder)
    {
        builder.HasOne<EmployeeModel>(e => e.Employee)
               .WithMany(s => s.Attendances)
               .HasForeignKey(e => e.EmployeeId)
               .HasPrincipalKey(s => s.Id);

        /// i have some thoughts about .HasPrincipalKey in this case
    }
}
