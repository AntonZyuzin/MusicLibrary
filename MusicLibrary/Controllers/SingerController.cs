using Microsoft.AspNetCore.Mvc;

namespace MusicLibrary.Controllers
{
    public class SingerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
