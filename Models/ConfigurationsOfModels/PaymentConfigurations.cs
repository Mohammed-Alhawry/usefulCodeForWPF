using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.Models.ConfigurationsOfModels;

public class PaymentConfigurations : IEntityTypeConfiguration<PaymentModel>
{
    public void Configure(EntityTypeBuilder<PaymentModel> builder)
    {
        builder.HasOne<BillModel>(e => e.Bill)
               .WithMany(s => s.Payments)
               .HasForeignKey(e => e.BillId)
               .HasPrincipalKey(s => s.Id);
    }
}
