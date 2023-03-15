using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Domain.IRepositories;

namespace MusicLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IGenreRepository _genreRepository;

        public TestController(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        [HttpGet]
        public string GetGenreName()
        {
            return _genreRepository.GetGenre(1).GenreName;
        }
    }
}
