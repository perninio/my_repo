using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Charpy.Model;

namespace AluCharpy
{

    public class CharpyDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {           
            modelBuilder.Entity<Class>().Property(object => object.property).HasPrecision(12, 10);
            base.OnModelCreating(modelBuilder);
        }
        public CharpyDbContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<CharpyDbContext>(null);

        }
        public DbSet<Probka> Probki { get; set; }
        //public DbSet<WynikBadania> WynikiBadania { get; set; }
        public DbSet<SlownikRodzajPekniecia> Slownik { get; set; }
       
    }
}

