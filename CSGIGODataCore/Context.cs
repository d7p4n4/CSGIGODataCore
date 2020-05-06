
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;


namespace CSGIGODataCore
{
    public class Context : DbContext
    {
        public Context() : base()
        {
            //Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Migrations.Configuration>());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=89.46.75.137;Database=UserTeszt;Trusted_Connection=False;uid=SA;pwd=Sycompla9999*;");
        }

        public DbSet<User> Userek { get; set; }
    }
}
