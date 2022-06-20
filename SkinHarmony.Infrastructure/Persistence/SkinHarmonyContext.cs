using System;
using Microsoft.EntityFrameworkCore;
using SkinHarmony.Domain.Entity;

namespace SkinHarmony.Infrastructure.Persistence
{
	public class SkinHarmonyContext : DbContext
	{
		public DbSet<Routine> Routines {get; set;}
		public DbSet<Product> Products {get; set;}

		public SkinHarmonyContext(DbContextOptions<SkinHarmonyContext> options) :base(options)
		{
		}
	}
}

