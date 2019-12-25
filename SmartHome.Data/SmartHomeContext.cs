using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SmartHome.Model.Entities;

namespace SmartHome.Data
{
    public class SmartHomeContext : DbContext
    {
        public const string LocalDbConnection = @"Data Source=.\SQLEXPRESS;initial catalog=CodeFirstDemo;Integrated Security=True; MultipleActiveResultSets=True";

        public SmartHomeContext() : base() {
            
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder) {

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;

                modelBuilder.Entity<Device>()
                    .Property(s=>s.LastUpdate)
                    .HasDefaultValue(DateTime.Now);
                
                modelBuilder.Entity<Home>()
                    .Property(s => s.LastUpdate)
                    .HasDefaultValue(DateTime.Now);

                modelBuilder.Entity<Room>()
                    .Property(s => s.LastUpdate)
                    .HasDefaultValue(DateTime.Now);

                modelBuilder.Entity<User>()
                    .Property(s => s.LastUpdate)
                    .HasDefaultValue(DateTime.Now);

                //relation ship

                modelBuilder.Entity<Device>()
                    .HasOne(a => a.User)
                    .WithMany(s => s.Devices);

                modelBuilder.Entity<Device>()
                    .HasOne(a => a.Home)
                    .WithMany(s => s.Devices);

                modelBuilder.Entity<Device>()
                    .HasOne(a => a.Room)
                    .WithMany(s => s.Devices);

                modelBuilder.Entity<Home>()
                    .HasMany(a => a.Users);
                modelBuilder.Entity<User>()
                    .HasMany(a => a.Homes);

            }


        }










        public DbSet<Device> Devices { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }



    }
}
