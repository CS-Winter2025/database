using Microsoft.EntityFrameworkCore;
using DatabaseLayer.Models;

namespace DatabaseLayer
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
	}
}
