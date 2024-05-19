using Microsoft.EntityFrameworkCore;

namespace ShopSuey2042.Models
{
	public static class EnsureDatabase
	{
		public static void Migrate(ProductDbContext ctx)
		{
			if (ctx.Database.GetPendingMigrations().Any())
			{
				ctx.Database.Migrate();
			}
		}

	}
}
