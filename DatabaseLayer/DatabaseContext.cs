using Microsoft.EntityFrameworkCore;
using DatabaseLayer.Models;

namespace DatabaseLayer
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

		public DbSet<AssetType> AssetTypes { get; set; }
		public DbSet<Asset> Assets { get; set; }
		public DbSet<ResidentAsset> ResidentAssets { get; set; }
		public DbSet<OccupancyHistory> OccupancyHistories { get; set; }
		public DbSet<RentHistory> RentHistories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Asset and AssetType Relationship
			modelBuilder.Entity<Asset>()
				.HasOne(a => a.AssetType)
				.WithMany()
				.HasForeignKey(a => a.AssetTypeId);

			// ResidentAsset Relationship
			modelBuilder.Entity<ResidentAsset>()
				.HasOne(ra => ra.Resident)
				.WithMany()
				.HasForeignKey(ra => ra.ResidentId);

			modelBuilder.Entity<ResidentAsset>()
				.HasOne(ra => ra.Asset)
				.WithMany()
				.HasForeignKey(ra => ra.AssetId);

			// OccupancyHistory Relationship
			modelBuilder.Entity<OccupancyHistory>()
				.HasOne(oh => oh.Resident)
				.WithMany()
				.HasForeignKey(oh => oh.ResidentId);

			modelBuilder.Entity<OccupancyHistory>()
				.HasOne(oh => oh.Asset)
				.WithMany()
				.HasForeignKey(oh => oh.AssetId);

			// RentHistory Relationship
			modelBuilder.Entity<RentHistory>()
				.HasOne(rh => rh.Asset)
				.WithMany()
				.HasForeignKey(rh => rh.AssetId);
		}
	}
}
