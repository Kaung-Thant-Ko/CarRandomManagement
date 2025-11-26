using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRandomManagement.Domain;
using CarRandomManagement.Configurations.Entities;
using Model = CarRandomManagement.Configurations.Entities.ModelSeed;
using Make = CarRandomManagement.Configurations.Entities.MakeSeed;

namespace CarRandomManagement.Data
{
    public class CarRandomManagementContext : DbContext
    {
        public CarRandomManagementContext (DbContextOptions<CarRandomManagementContext> options)
            : base(options)
        {
        }

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
