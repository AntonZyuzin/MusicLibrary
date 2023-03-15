using MusicLibrary.Models;

namespace MusicLibrary.Domain.IRepositories
{
    public interface IGenreRepository
    {
        public void Create(Genre genre);
        public void Delete(int id);
        public void Update(Genre editedGenre);
        public string GetNameById(int id);
        public Genre GetGenre(int id);
    }
}
