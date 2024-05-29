using Microsoft.EntityFrameworkCore;
using Solid_Principle_Domain.Entity;

namespace Solid_Principle_Infrastructure.Context
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<Book> Books { get; set; }
	}
}
