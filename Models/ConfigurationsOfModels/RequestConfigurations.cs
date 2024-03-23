using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExperimentalThingsUsingWPF.Models.ConfigurationsOfModels;

public class RequestConfigurations : IEntityTypeConfiguration<RequestModel>
{
    public void Configure(EntityTypeBuilder<RequestModel> builder)
    {
        builder.HasOne<ClinicModel>(e => e.Clinic)
               .WithMany(s => s.Requests)
               .HasForeignKey(e => e.ClinicId)
               .HasPrincipalKey(s => s.Id);

        builder.HasOne<WorkTypeModel>(e => e.WorkType)
               .WithOne(s => s.Request)
               .HasForeignKey<RequestModel>(e => e.WorkTypeId)
               .HasPrincipalKey<WorkTypeModel>(s => s.Id);
    }
}
