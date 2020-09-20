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
            builder.Property(v => v.Name).IsRequired().HasColumnType("varchar(45)");
            builder.Property(v => v.Color).HasColumnType("varchar(45)");
            builder.Property(v => v.Brand).HasColumnType("varchar(45)");
            builder.Property(v => v.Plaque).HasColumnType("varchar(45)");
            builder.HasIndex(v => v.Plaque).IsUnique();

            //antigo caso não funcione - builder.Property(v => v.UserId).IsRequired();
            builder.Property(v => v.UserId);

            builder.HasOne(v => v.User).WithMany(v => v.Vehicles).HasForeignKey(v => v.UserId);

            builder.ToTable("Vehycles");
        }
    }
}
