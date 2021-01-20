using Volo.Abp.Modularity;

namespace Playground
{
    [DependsOn(
        typeof(PlaygroundApplicationModule),
        typeof(PlaygroundDomainTestModule)
        )]
    public class PlaygroundApplicationTestModule : AbpModule
    {

    }
}