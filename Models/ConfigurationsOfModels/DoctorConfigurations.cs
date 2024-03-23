using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExperimentalThingsUsingWPF.Models.ConfigurationsOfModels;

public class DoctorConfigurations : IEntityTypeConfiguration<DoctorModel>
{
    public void Configure(EntityTypeBuilder<DoctorModel> builder)
    {
        throw new NotImplementedException();
    }
}
