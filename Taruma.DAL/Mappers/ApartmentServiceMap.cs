using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Taruma.BLL.Models;

namespace Taruma.DAL.Mappers
{
    public class ApartmentServiceMap : IEntityTypeConfiguration<ApartmentService>
    {
        public void Configure(EntityTypeBuilder<ApartmentService> builder)
        {

            builder.HasKey(s => s.ApartmentServiceId);
            builder.Property(s => s.ServiceId).IsRequired();
            builder.Property(s => s.DateExecution).IsRequired();

            builder.HasOne(s => s.Service).WithMany(s => s.ApartmentServices).HasForeignKey(sp => sp.ServiceId);

            builder.ToTable("ServiceApartments");

        }
    }
}
