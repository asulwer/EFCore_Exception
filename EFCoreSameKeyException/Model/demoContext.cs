using EFCoreSameKeyException;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System.Data.Common;
using TestModel.Models;
using TestModel.Models.Mapping;

namespace UnitTest.EFModel.Models
{
    public partial class demoContext : DbContext
    {        
        private static DbContextOptions<demoContext> dbContextOptions
        {
            get
            {
                DbContextOptionsBuilder<demoContext> options = new DbContextOptionsBuilder<demoContext>();
                options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=demo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                options.EnableSensitiveDataLogging();
                //options.UseLazyLoadingProxies();
                var loggerFactory = new LoggerFactory();
                loggerFactory.AddProvider(new MyLoggerProvider());
                options.UseLoggerFactory(loggerFactory);
                return options.Options;
            }
        }
        public demoContext() : base(dbContextOptions)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
        }

        public demoContext(DbContextOptions<demoContext> options) : base(options)
        {

        }

        public virtual DbSet<item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new itemMap());
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
