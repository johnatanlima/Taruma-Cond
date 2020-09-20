using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Taruma.BLL.Models;

namespace Taruma.DAL.Mappers
{
    public class EventMap : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {

            builder.HasKey(e => e.EventId);
            builder.Property(e => e.Name).HasColumnType("varchar(45)");
            builder.Property(e => e.Date).IsRequired();
            builder.Property(e => e.UserId).IsRequired();

            builder.HasOne(e => e.User).WithMany(e => e.Events).HasForeignKey(e => e.UserId);

            builder.ToTable("Events");

        }
    }
}
