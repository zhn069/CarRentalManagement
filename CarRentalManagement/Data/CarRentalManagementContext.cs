using CarRentalManagement.Configuration.Entities;
using CarRentalManagement.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Data
{
    public class CarRentalManagementContext(DbContextOptions<CarRentalManagementContext> options) : IdentityDbContext<CarRentalManagementUser>(options)
    {
        public DbSet<CarRentalManagement.Components.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagement.Components.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagement.Components.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagement.Components.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManagement.Components.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagement.Components.Domain.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);

            Builder.ApplyConfiguration(new ColourSeed());

            base.OnModelCreating(Builder);

            Builder.ApplyConfiguration(new ModelSeed());

            base.OnModelCreating(Builder);

            Builder.ApplyConfiguration(new MakeSeed());
        }
    }
}
