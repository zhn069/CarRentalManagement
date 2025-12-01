using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Components.Domain;
using CarRentalManagement.Configuration.Entities;

namespace CarRentalManagement.Data
{
    public class CarRentalManagementContext : DbContext
    {
        public CarRentalManagementContext (DbContextOptions<CarRentalManagementContext> options)
            : base(options)
        {
        }

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
