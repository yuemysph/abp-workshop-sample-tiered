using Playground.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Playground.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class PlaygroundController : AbpController
    {
        protected PlaygroundController()
        {
            LocalizationResource = typeof(PlaygroundResource);
        }
    }
}