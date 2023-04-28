using Microsoft.EntityFrameworkCore;
using Cejudo_SportsStore.Models;

namespace Cejudo_SportsStore.Models
{
	public class StoreDbContext: DbContext
	{
		public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
		public DbSet<Product> Products => Set<Product>();
		public DbSet<Order> Orders => Set<Order>();
	}
}
