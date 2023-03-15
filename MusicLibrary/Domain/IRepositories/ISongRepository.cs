using MusicLibrary.Models;

namespace MusicLibrary.Domain.IRepositories
{
    public interface ISongRepository
    {
        public void Create(Song song);
        public void Delete(int id);
        public void Update(Song editedSong);

        public string GetNameById(int id);
        public Song GetSong(int id);
    }
}
