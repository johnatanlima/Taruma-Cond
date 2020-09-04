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
            builder.Property(x => x.CPF).IsRequired().HasMaxLength(11);
            builder.HasIndex(x => x.CPF).IsUnique();
            builder.Property(x => x.Photo).IsRequired();
            builder.Property(x => x.FirstAccess).IsRequired();
            builder.Property(x => x.Status).IsRequired();



        }


    }
}
