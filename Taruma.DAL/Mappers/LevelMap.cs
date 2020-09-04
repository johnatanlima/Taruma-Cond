using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Taruma.BLL.Models;

namespace Taruma.DAL.Mappers
{
    public class LevelMap : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(45);

            builder.HasData(
                new Level
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Resident", 
                    NormalizedName = "RESIDENT", 
                    Description = "Apartments Resident"
                },

                new Level
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Sindical",
                    NormalizedName = "SINDICAL",
                    Description = "Apartments Sindical"
                },
                
                new Level
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    Description = "Apartments Administrator"
                }

                );
        }


    }
}
