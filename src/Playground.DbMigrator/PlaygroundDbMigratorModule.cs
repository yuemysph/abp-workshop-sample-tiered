using Playground.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Playground.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(PlaygroundEntityFrameworkCoreDbMigrationsModule),
        typeof(PlaygroundApplicationContractsModule)
        )]
    public class PlaygroundDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
