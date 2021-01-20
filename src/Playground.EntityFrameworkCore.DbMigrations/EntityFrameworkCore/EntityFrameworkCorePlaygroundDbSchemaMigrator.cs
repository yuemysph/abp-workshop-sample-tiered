using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Playground.Data;
using Volo.Abp.DependencyInjection;

namespace Playground.EntityFrameworkCore
{
    public class EntityFrameworkCorePlaygroundDbSchemaMigrator
        : IPlaygroundDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorePlaygroundDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the PlaygroundMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<PlaygroundMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}