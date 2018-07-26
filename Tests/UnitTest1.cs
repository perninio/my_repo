using System;
using Xunit;
using WindowsFormsApp1;
using AluCharpy;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Linq;
using Charpy.Model;

namespace Tests
{
    /// <summary>
    /// Testy polaczen BD z Aplikacja
    /// </summary>
    public class TestyBD
    {
        [Fact]
        public CharpyDbContext settingconnection()
        {
            var b = new SqlConnectionStringBuilder();
            b.DataSource = @"(local)\SQLEXPRESS";
            b.ApplicationIntent = System.Data.SqlClient.ApplicationIntent.ReadWrite;
            b.ApplicationName = "Charpy";
            b.InitialCatalog = "BDPrzemek";
            b.IntegratedSecurity = true;
            var ctx = new CharpyDbContext(b.ToString());
            Assert.NotNull(ctx);
            return ctx;
        }

        [Fact]
        public void slownikRodzPeknieciaPolaczenie()
        {
            var ctx = settingconnection();
            var slownik = ctx.Slownik.FirstOrDefault(s => s.RodzajPekniecia == "C");
            Assert.NotNull(slownik);
        }
        [Fact]
        public void probkaPolaczenie()
        {
            var b = new SqlConnectionStringBuilder();
            b.DataSource = @"(local)\SQLEXPRESS";
            b.ApplicationIntent = System.Data.SqlClient.ApplicationIntent.ReadWrite;
            b.ApplicationName = "Charpy";
            b.InitialCatalog = "BDPrzemek";
            b.IntegratedSecurity = true;
            var ctx = new CharpyDbContext(b.ToString());
            Assert.NotNull(ctx);
            var probka = ctx.Probki.FirstOrDefault(x=>x.IDProbki==1);
            Assert.NotNull(probka);
        }
        [Fact]
        public void addingNewProbka()
        {
            var ctx = settingconnection();
            Probka pr2 =new Probka();
            pr2.OdlegloscMiedzyKarbami = 3123.3121M;
            ProbkaEF pom = pr2;

            ctx.Probki.Add(pr2);

            ctx.SaveChanges();
        }
    }
}
