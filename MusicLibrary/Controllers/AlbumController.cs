using Microsoft.AspNetCore.Mvc;

namespace MusicLibrary.Controllers
{
    public class AlbumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
