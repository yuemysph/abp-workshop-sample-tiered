using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Playground
{
    [Dependency(ReplaceServices = true)]
    public class PlaygroundBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Playground";
    }
}
