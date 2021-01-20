using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Playground.EntityFrameworkCore
{
    [DependsOn(
        typeof(PlaygroundEntityFrameworkCoreModule)
        )]
    public class PlaygroundEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<PlaygroundMigrationsDbContext>();
        }
    }
}
