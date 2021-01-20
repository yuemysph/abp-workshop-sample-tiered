using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Playground.Web.Pages
{
    public class IndexModel : PlaygroundPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}