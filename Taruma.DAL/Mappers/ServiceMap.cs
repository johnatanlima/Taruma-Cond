using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Taruma.BLL.Models;

namespace Taruma.DAL.Mappers
{
    public class ServiceMap : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(s => s.ServiceId);
            builder.Property(s => s.Name).IsRequired().HasMaxLength(45);
            builder.Property(s => s.Cust).IsRequired();
            builder.Property(s => s.Status).IsRequired();
            builder.Property(s => s.UserId).IsRequired();

            builder.HasOne(s => s.User).WithMany(s => s.Services).HasForeignKey(s => s.UserId);
            builder.HasMany(s => s.ApartmentServices).WithOne(s => s.Service);

            builder.ToTable("Services");

        }
    }
}
