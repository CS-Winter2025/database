using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<EventSchedule> EventSchedules { get; set; }
        public DbSet<Asset> Assets { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Employee-Manager Self-Referencing Relationship
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Manager)
                .WithMany()
                .HasForeignKey(e => e.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee Availability & HoursWorked: Storing as CSV
            modelBuilder.Entity<Employee>()
                .Property(e => e.Availability)
                .HasConversion(
                    v => string.Join(",", v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList()
                );

            modelBuilder.Entity<Employee>()
                .Property(e => e.HoursWorked)
                .HasConversion(
                    v => string.Join(",", v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList()
                );

            modelBuilder.Entity<Employee>()
                .Property(e => e.Certifications)
                .HasConversion(
                    v => string.Join(",", v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
                );

            modelBuilder.Entity<Employee>()
                .Property(e => e.DetailsJson)
                .HasColumnType("json");

            // Organization -> Employees Relationship
            modelBuilder.Entity<Organization>()
                .HasMany(o => o.Employees)
                .WithOne(e => e.Organization)
                .HasForeignKey(e => e.OrganizationId)
                .OnDelete(DeleteBehavior.Cascade);

            // EventSchedule Employee & Service Relationship
            modelBuilder.Entity<EventSchedule>()
                .HasOne(e => e.Employee)
                .WithMany()
                .HasForeignKey(e => e.EmployeeID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EventSchedule>()
                .HasOne(e => e.ServiceID)
                .WithMany()
                .HasForeignKey(e => e.ServiceID)
                .OnDelete(DeleteBehavior.Cascade);

            // Resident - Invoice Relationship
            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.ResidentID)
                .WithMany(r => r.Invoice)
                .HasForeignKey(i => i.ResidentID)
                .OnDelete(DeleteBehavior.Cascade);

            // Service Configuration
            modelBuilder.Entity<Service>()
                .Property(s => s.EmployeeId)
                .HasConversion(
                    v => string.Join(",", v.Split(',', StringSplitOptions.RemoveEmptyEntries)), // CSV String
                    v => v
                );

            modelBuilder.Entity<Service>()
                .Property(s => s.Requirements)
                .HasConversion(
                    v => string.Join(",", v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList()
                );

            // Asset Details in JSON
            modelBuilder.Entity<Asset>()
                .Property(a => a.DetailsJson)
                .HasColumnType("json");

            // Resident Details in JSON
            modelBuilder.Entity<Resident>()
                .Property(r => r.DetailsJson)
                .HasColumnType("json");
        }
    }
}
