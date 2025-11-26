using CarRandomManagement.Configurations.Entities;
using CarRandomManagement.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRandomManagement.Data
{
    public class CarRandomManagementContext(DbContextOptions<CarRandomManagementContext> options) : IdentityDbContext<CarRandomManagementUser>(options)
    {
        public DbSet<CarRandomManagement.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRandomManagement.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRandomManagement.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRandomManagement.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRandomManagement.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<CarRandomManagement.Domain.Vehicle> Vehicle { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);

            Builder.ApplyConfiguration(new ColourSeed());
            Builder.ApplyConfiguration(new ModelSeed());
            Builder.ApplyConfiguration(new MakeSeed());

        }
    }
}

