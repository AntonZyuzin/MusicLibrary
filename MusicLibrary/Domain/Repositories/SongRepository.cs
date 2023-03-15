using MusicLibrary.Domain.Data;
using MusicLibrary.Domain.IRepositories;
using MusicLibrary.Models;
using System.Data.Entity;

namespace MusicLibrary.Domain.Repositories
{
    public class SongRepository : ISongRepository
    {

        private readonly MusicLibraryDbContext _dbContext;
        public SongRepository(MusicLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Song song)
        {
            _dbContext.Songs.Add(song);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var items = _dbContext.Songs.Where(item => item.SongId == id);
            _dbContext.Songs.RemoveRange(items);
            _dbContext.SaveChanges();
        }

        public void Update(Song editedSong)
        {
            _dbContext.Songs.Update(editedSong);
            _dbContext.SaveChanges();
        }

        public Song GetSong(int id)
        {
            var song = _dbContext.Songs.Include(_ => _.Genres).Where(s => s.SongId == id).First();
            _dbContext.Entry(song).Collection(_ => _.Genres).Load();
            return song;
        }

        public string GetNameById(int id)
        {
            throw new NotImplementedException();

        }
    }
}
