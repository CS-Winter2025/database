using Microsoft.EntityFrameworkCore;
using DatabaseLayer.Models;

namespace DatabaseLayer
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

		// Resident and Personal Info Management
		public DbSet<ResidentPersonalInfo> ResidentPersonalInfos { get; set; }
		public DbSet<Resident> Residents { get; set; }

		// Employee Management
		public DbSet<Employee> Employees { get; set; }
		public DbSet<EmployeeManagement> EmployeeManagements { get; set; }
		public DbSet<EmployeeCertification> EmployeeCertifications { get; set; }

		// Asset Management
		public DbSet<AssetType> AssetTypes { get; set; }
		public DbSet<Asset> Assets { get; set; }
		public DbSet<ResidentAsset> ResidentAssets { get; set; }
		public DbSet<OccupancyHistory> OccupancyHistories { get; set; }
		public DbSet<RentHistory> RentHistories { get; set; }

		// Service Management
		public DbSet<ServiceType> ServiceTypes { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<ServiceSchedule> ServiceSchedules { get; set; }

		// Billing Management
		public DbSet<Invoice> Invoices { get; set; }
		public DbSet<InvoiceItem> InvoiceItems { get; set; }
		public DbSet<Payment> Payments { get; set; }

		// Maintenance
		public DbSet<AssetMaintenance> AssetMaintenances { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Resident and Personal Info Management Relationships
			modelBuilder.Entity<Resident>()
				.HasOne(r => r.ResidentPersonalInfo)
				.WithMany()
				.HasForeignKey(r => r.PersonalInfoId);

			// Employee Management Relationships
			modelBuilder.Entity<EmployeeManagement>()
				.HasOne(em => em.Employee)
				.WithMany()
				.HasForeignKey(em => em.EmployeeId);

			modelBuilder.Entity<EmployeeManagement>()
				.HasOne(em => em.Manager)
				.WithMany()
				.HasForeignKey(em => em.ManagerId);

			modelBuilder.Entity<EmployeeCertification>()
				.HasOne(ec => ec.Employee)
				.WithMany()
				.HasForeignKey(ec => ec.EmployeeId);

			// Asset Management Relationships
			modelBuilder.Entity<Asset>()
				.HasOne(a => a.AssetType)
				.WithMany()
				.HasForeignKey(a => a.AssetTypeId);

			modelBuilder.Entity<ResidentAsset>()
				.HasOne(ra => ra.Resident)
				.WithMany()
				.HasForeignKey(ra => ra.ResidentId);

			modelBuilder.Entity<ResidentAsset>()
				.HasOne(ra => ra.Asset)
				.WithMany()
				.HasForeignKey(ra => ra.AssetId);

			modelBuilder.Entity<OccupancyHistory>()
				.HasOne(oh => oh.Resident)
				.WithMany()
				.HasForeignKey(oh => oh.ResidentId);

			modelBuilder.Entity<OccupancyHistory>()
				.HasOne(oh => oh.Asset)
				.WithMany()
				.HasForeignKey(oh => oh.AssetId);

			modelBuilder.Entity<RentHistory>()
				.HasOne(rh => rh.Asset)
				.WithMany()
				.HasForeignKey(rh => rh.AssetId);

			// Service Management Relationships
			modelBuilder.Entity<Service>()
				.HasOne(s => s.ServiceType)
				.WithMany()
				.HasForeignKey(s => s.ServiceTypeId);

			modelBuilder.Entity<ServiceSchedule>()
				.HasOne(ss => ss.Service)
				.WithMany()
				.HasForeignKey(ss => ss.ServiceId);

			// Billing Management Relationships
			modelBuilder.Entity<Invoice>()
				.HasOne(i => i.Resident)
				.WithMany()
				.HasForeignKey(i => i.ResidentId);

			modelBuilder.Entity<InvoiceItem>()
				.HasOne(ii => ii.Invoice)
				.WithMany()
				.HasForeignKey(ii => ii.InvoiceId);

			modelBuilder.Entity<InvoiceItem>()
				.HasOne(ii => ii.ServiceSchedule)
				.WithMany()
				.HasForeignKey(ii => ii.ServiceScheduleId);

			modelBuilder.Entity<InvoiceItem>()
				.HasOne(ii => ii.OccupancyHistory)
				.WithMany()
				.HasForeignKey(ii => ii.OccupancyId);

			modelBuilder.Entity<Payment>()
				.HasOne(p => p.Invoice)
				.WithMany()
				.HasForeignKey(p => p.InvoiceId);

			// Maintenance Relationships
			modelBuilder.Entity<AssetMaintenance>()
				.HasOne(am => am.Asset)
				.WithMany()
				.HasForeignKey(am => am.AssetId);
		}
	}
}
