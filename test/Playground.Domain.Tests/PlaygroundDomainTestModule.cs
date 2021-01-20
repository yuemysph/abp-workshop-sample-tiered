using Playground.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Playground
{
    [DependsOn(
        typeof(PlaygroundEntityFrameworkCoreTestModule)
        )]
    public class PlaygroundDomainTestModule : AbpModule
    {

    }
}