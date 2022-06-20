using System;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class SkinHarmonyContext : DbContext
    {
        public SkinHarmonyContext(){}
        public SkinHarmonyContext(DbContextOptions<SkinHarmonyContext> options) : base(options) { }
        public DbSet<SkincareProduct> SkinCareProducts { get; set; }
        public DbSet<SkincareRoutine> SkincareRoutines { get; set; }
    }
}

