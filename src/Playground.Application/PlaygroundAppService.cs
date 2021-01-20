using System;
using System.Collections.Generic;
using System.Text;
using Playground.Books;
using Playground.Localization;
using Volo.Abp.Application.Services;

namespace Playground
{
    /* Inherit your application services from this class.
     */
    public abstract class PlaygroundAppService : ApplicationService
    {
        protected PlaygroundAppService()
        {
            LocalizationResource = typeof(PlaygroundResource);
        }

        
    }
}
