﻿using Microsoft.EntityFrameworkCore;
using transport_business_project.Classes;

namespace transport_business_project.Data
{
    public class TransportContext : DbContext
    {
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Transport> Transports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=transport.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>().HasKey(d => d.Id);
            modelBuilder.Entity<Route>().HasKey(r => r.RouteID);
            modelBuilder.Entity<Transport>().HasKey(t => t.TransportID);
        }
    }
}
