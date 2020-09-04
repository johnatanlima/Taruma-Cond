using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;
using Taruma.BLL.Models;

namespace Taruma.DAL.Mappers
{
    public class MonthMap : IEntityTypeConfiguration<Month>
    {
        public void Configure(EntityTypeBuilder<Month> builder)
        {

            builder.HasKey(x => x.MonthId);
            builder.Property(x => x.MonthId).ValueGeneratedNever();
           
            builder.HasIndex(x => x.Name).IsUnique();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(10);

            builder.HasMany(b => b.Rentals).WithOne(u => u.Month);
            builder.HasMany(b => b.Historics).WithOne(u => u.Month);

            builder.HasData(

                new Month
                {
                    MonthId = 1,
                    Name = "Janeiro"
                },
                new Month
                {
                    MonthId = 2,
                    Name = "Fevereiro"
                },
                new Month
                {
                    MonthId = 3,
                    Name = "Março"
                },
                new Month
                {
                    MonthId = 4,
                    Name = "Abril"
                },
                new Month
                {
                    MonthId = 5,
                    Name = "Maio"
                },
                new Month
                {
                    MonthId = 6,
                    Name = "Junho"
                },
                new Month
                {
                    MonthId = 7,
                    Name = "Julho"
                },
                new Month
                {
                    MonthId = 8,
                    Name = "Agosto"
                },
                new Month
                {
                    MonthId = 9,
                    Name = "Setembro"
                },
                new Month
                {
                    MonthId = 10,
                    Name = "Outubro"
                },
                new Month
                {
                    MonthId = 11,
                    Name = "Novembro"
                },
                new Month
                {
                    MonthId = 2,
                    Name = "Dezembro"
                }
                );

            builder.ToTable("Months");
        }


    }
}
