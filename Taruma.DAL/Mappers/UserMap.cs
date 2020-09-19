using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;
using Taruma.BLL.Models;

namespace Taruma.DAL.Mappers
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CPF).IsRequired().HasMaxLength(20);
            builder.HasIndex(x => x.CPF).IsUnique();
            builder.Property(x => x.Photo).IsRequired();
            builder.Property(x => x.FirstAccess).IsRequired();
            builder.Property(x => x.Status).IsRequired();

            builder.HasMany(x => x.OwnersApartment).WithOne(x => x.Owner);
            builder.HasMany(x => x.Residents).WithOne(x => x.Resident);
            builder.HasMany(x => x.Vehicles).WithOne(x => x.User);
            builder.HasMany(x => x.Events).WithOne(x => x.User);
            builder.HasMany(x => x.Payments).WithOne(x => x.User);
            builder.HasMany(x => x.Services).WithOne(x => x.User);

            builder.ToTable("Users");

        }


    }
}
