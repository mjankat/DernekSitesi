using DernekSitesi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DernekSitesi.Data
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Etkinlik> Etkinlikler { get; set; }
		public DbSet<Haber> Haberler { get; set; }
		public DbSet<Yonetim> Yonetimdekiler { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"server=(LocalDB)\MSSQLLocalDB;database=DernekSitesi;integrated security=True;MultipleActiveResultSets=True;");
			base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 1,
				Name = "Admin",
				Surname = "Admin",
				UserName = "admin",
				Email = "musistisaremeclisi@gmail.com",
				Password = "yc123456",
				IsActive = true,
				CreateDate = DateTime.Now
			});
			base.OnModelCreating(modelBuilder);
		}
	}
}
