using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Playground.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(PlaygroundHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class PlaygroundConsoleApiClientModule : AbpModule
    {
        
    }
}
