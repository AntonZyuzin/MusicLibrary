using MusicLibrary.Domain.Data;
using MusicLibrary.Domain.IRepositories;
using MusicLibrary.Models;

namespace MusicLibrary.Domain.Repositories
{
    public class SingerRepository : ISingerRepository
    {
        private readonly MusicLibraryDbContext _dbContext;
        public SingerRepository(MusicLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(Singer singer)
        {
            _dbContext.Singers.Add(singer);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var items = _dbContext.Singers.Where(item => item.SingerId == id);
            _dbContext.Singers.RemoveRange(items);
            _dbContext.SaveChanges();
        }

        public void Update(Singer editedSinger)
        {
            _dbContext.Singers.Update(editedSinger);
            _dbContext.SaveChanges();
        }

        public Singer GetSinger(int id)
        {
            throw new NotImplementedException();
        }

        public string GetNameById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
