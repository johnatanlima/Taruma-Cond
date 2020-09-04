using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Taruma.BLL.Models;

namespace Taruma.DAL.Mappers
{
    public class ApartmentMap : IEntityTypeConfiguration<Apartment>
    {
        public void Configure(EntityTypeBuilder<Apartment> builder)
        {

            builder.HasKey(a => a.ApartmentId);
            builder.Property(a => a.Number).IsRequired();
            builder.Property(a => a.Floor).IsRequired();
            builder.Property(a => a.Image).IsRequired();
            builder.Property(a => a.OwnerId).IsRequired();
            builder.Property(a => a.ResidentId).IsRequired(false);

            builder.HasOne(a => a.Owner).WithMany(a => a.OwnersApartment).HasForeignKey(a => a.OwnerId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(a => a.Resident).WithMany(a => a.Residents).HasForeignKey(a => a.ResidentId).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Apartments");

        }
    }
}
