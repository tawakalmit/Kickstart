using EPiServer.Web.Mvc;
using Kickstart.Models.Pages;
using Microsoft.AspNetCore.Mvc;

namespace Kickstart.Controllers.Pages
{
    public class HomepageController : PageController<Homepage>
    {
        public IActionResult Index(Homepage currentContent)
        {
            return View(currentContent);
        }
    }
}
