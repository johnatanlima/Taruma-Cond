using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Taruma.BLL.Models;
using Taruma.DAL.Mappers;

namespace Taruma.DAL
{
    public class Context : IdentityDbContext<User, Level, string>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        
        public DbSet<Level> Levels { get; set; }

        public DbSet<Rental> Rentals { get; set; }
        
        public DbSet<Event> Events { get; set; }
        
        public DbSet <Apartment> Apartments { get; set; }
        
        public DbSet<Vehycle> Vehycles { get; set; }
        
        public DbSet<Month> Months { get; set; }
        
        public DbSet<RecourseHistoric> RecourseHistorics { get; set; }
        
        public DbSet<Payment> Payments { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<ApartmentService> ApartmentServices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RentalMap());
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new ApartmentServiceMap());
            builder.ApplyConfiguration(new VehycleMap());
            builder.ApplyConfiguration(new ServiceMap());
            builder.ApplyConfiguration(new ApartmentMap());
            builder.ApplyConfiguration(new MonthMap());
            builder.ApplyConfiguration(new EventMap());
            builder.ApplyConfiguration(new LevelMap());
            builder.ApplyConfiguration(new RecourseHistoricMap());

        }
    }
}
