using AngularAppAuth.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularAppAuth.Server.Context

{
	public class AppDbcontext : DbContext
	{


        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)

        {
              
        }

        public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().ToTable("users");
		}
	}
}
