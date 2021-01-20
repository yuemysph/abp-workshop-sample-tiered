using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Playground.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class PlaygroundMigrationsDbContextFactory : IDesignTimeDbContextFactory<PlaygroundMigrationsDbContext>
    {
        public PlaygroundMigrationsDbContext CreateDbContext(string[] args)
        {
            PlaygroundEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<PlaygroundMigrationsDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"));

            return new PlaygroundMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Playground.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
