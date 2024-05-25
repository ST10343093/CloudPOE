using khumalocraft2._2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace khumalocraft2._2.Data
{
    
        public class KhumaloCraftDbContext : IdentityDbContext
        {
            public KhumaloCraftDbContext(DbContextOptions<KhumaloCraftDbContext> options) : base(options)

            {

            }
        public DbSet<Product> Product { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Transactions> Transactions { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    var decimalProps = modelBuilder.Model
        //    .GetEntityTypes()
        //    .SelectMany(t => t.GetProperties())
        //    .Where(p => (System.Nullable.GetUnderlyingType(p.ClrType) ?? p.ClrType) == typeof(decimal));

        //    foreach (var property in decimalProps)
        //    {
        //        property.SetPrecision(18);
        //        property.SetScale(2);
        //    }
        //}
    }
}
