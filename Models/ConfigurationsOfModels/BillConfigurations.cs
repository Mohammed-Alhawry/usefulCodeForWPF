using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExperimentalThingsUsingWPF.Models.ConfigurationsOfModels;

public class BillConfigurations : IEntityTypeConfiguration<BillModel>
{
    public void Configure(EntityTypeBuilder<BillModel> builder)
    {
        builder.HasOne<RequestModel>(e => e.Request)
               .WithOne(s => s.Bill)
               .HasForeignKey<BillModel>(e => e.RequestId)
               .HasPrincipalKey<RequestModel>(s => s.Id);
    }
}
