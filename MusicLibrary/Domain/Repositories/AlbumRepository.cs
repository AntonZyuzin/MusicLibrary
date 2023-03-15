using MusicLibrary.Domain.Data;
using MusicLibrary.Domain.IRepositories;
using MusicLibrary.Models;

namespace MusicLibrary.Domain.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly MusicLibraryDbContext _dbContext;
        public AlbumRepository(MusicLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(Album album)
        {
            _dbContext.Albums.Add(album);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var items = _dbContext.Albums.Where(item => item.AlbumId == id);
            _dbContext.Albums.RemoveRange(items);
            _dbContext.SaveChanges();
        }

        public void Update(Album editedAlbum)
        {
            _dbContext.Albums.Update(editedAlbum);
            _dbContext.SaveChanges();
        }

        public Album GetAlbum(int id)
        {
            throw new NotImplementedException();
        }

        public string GetNameById(int id)
        {
            throw new NotImplementedException();
        }


    }
}
