using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Domain.IRepositories;

namespace MusicLibrary.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreRepository _genreRepository;

        public GenreController(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
