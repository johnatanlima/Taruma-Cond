using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Taruma.BLL.Models;

namespace Taruma.DAL.Mappers
{
    public class RecourseHistoricMap : IEntityTypeConfiguration<RecourseHistoric>
    {
        public void Configure(EntityTypeBuilder<RecourseHistoric> builder)
        {

            builder.HasKey(hr => hr.RecourceHistoricId);
            builder.Property(hr => hr.Value).IsRequired();
            builder.Property(hr => hr.Tips).IsRequired();
            builder.Property(hr => hr.Day).IsRequired();
            builder.Property(hr => hr.MonthId).IsRequired();
            builder.Property(hr => hr.Year).IsRequired();

            builder.HasOne(hr => hr.Month).WithMany(hr => hr.Historics).HasForeignKey(hr => hr.MonthId);

            builder.ToTable("Historics");
        }
    }
}
