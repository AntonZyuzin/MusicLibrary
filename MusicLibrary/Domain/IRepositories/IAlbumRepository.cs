using MusicLibrary.Models;

namespace MusicLibrary.Domain.IRepositories
{
    public interface IAlbumRepository
    {
        public void Create(Album album);
        public void Delete(int id);
        public void Update(Album editedAlbum);
        public string GetNameById(int id);
        public Album GetAlbum(int id);
    }
}
