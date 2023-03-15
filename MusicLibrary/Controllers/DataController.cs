using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Domain.IRepositories;
using MusicLibrary.Models;

namespace MusicLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IGenreRepository _genreRepository;

        public DataController(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        [HttpPost]
        public List<Song> GetSongsByGenre(int id)
        {
            var songs = _genreRepository.GetGenre(id).Songs;
            return songs;
        }
    }
}
