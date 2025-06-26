using Kickstart.Models.Pages;
using Microsoft.AspNetCore.Mvc;
using EPiServer.Web.Mvc;

namespace Kickstart.Controllers.Pages
{
    public class GeneralpageController : PageController<GeneralContent>
    {
        public IActionResult Index(GeneralContent currentContent)
        {
            return View(currentContent);
        }
    }
}
