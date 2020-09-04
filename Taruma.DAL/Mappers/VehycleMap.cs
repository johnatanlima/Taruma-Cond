using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Taruma.BLL.Models;

namespace Taruma.DAL.Mappers
{
    public class VehycleMap : IEntityTypeConfiguration<Vehycle>
    {
        public void Configure(EntityTypeBuilder<Vehycle> builder)
        {
            builder.HasKey(v => v.VehycleId);
            builder.Property(v => v.Name).IsRequired().HasMaxLength(45);
            builder.Property(v => v.Color).IsRequired().HasMaxLength(45);
            builder.Property(v => v.Brand).IsRequired().HasMaxLength(45);
            builder.Property(v => v.Plaque).IsRequired().HasMaxLength(10);
            builder.HasIndex(v => v.Plaque).IsUnique();
           
            builder.Property(v => v.UserId).IsRequired();

            builder.HasOne(v => v.User).WithMany(v => v.Vehicles).HasForeignKey(v => v.UserId);

            builder.ToTable("Vehycles");
        }
    }
}
