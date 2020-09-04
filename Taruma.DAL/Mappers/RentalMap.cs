using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Taruma.BLL.Models;

namespace Taruma.DAL.Mappers
{
    public class RentalMap : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {

            builder.HasKey(a => a.RentalId);
            builder.Property(a => a.Value).IsRequired();
            builder.Property(a => a.MonthId).IsRequired();
            builder.Property(a => a.Year).IsRequired();

            builder.HasOne(a => a.Month).WithMany(a => a.Rentals).HasForeignKey(a => a.MonthId);
            builder.HasMany(a => a.Payments).WithOne(a => a.Rental);

            builder.ToTable("Rentals");

        }
    }
}
