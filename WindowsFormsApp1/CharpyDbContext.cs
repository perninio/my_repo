using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Charpy.Model;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;

namespace AluCharpy
{
    public class CharpyDbContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<DecimalPropertyConvention>();
            modelBuilder.Conventions.Add(new DecimalPropertyConvention(12,6));
            //modelBuilder.Entity<ProbkaEF>().Property(x => x.PracaMlotaZuzyta).HasPrecision(12, 6);
            //modelBuilder.Entity<ProbkaEF>().Property(x => x.GruboscSciankiProfila).HasPrecision(12, 6);
            //modelBuilder.Entity<ProbkaEF>().Property(x => x.OdlegloscMiedzyKarbami).HasPrecision(12, 6);
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
