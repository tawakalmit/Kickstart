using EPiServer.Web.Mvc;
using Kickstart.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace Kickstart.Controllers.Pages
{
    public class MainarticleController : PageController<MainArticle>
    {
        public IActionResult Index(MainArticle currentContent)
        {
            return View(currentContent);
        }
    }
}
