using MusicLibrary.Domain.Data;
using MusicLibrary.Domain.IRepositories;
using MusicLibrary.Models;
using System.Data.Entity;

namespace MusicLibrary.Domain.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly MusicLibraryDbContext _dbContext;
        public GenreRepository(MusicLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(Genre genre)
        {
            _dbContext.Genres.Add(genre);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var items = _dbContext.Genres.Where(item => item.GenreId == id);
            _dbContext.Genres.RemoveRange(items);
            _dbContext.SaveChanges();
        }
        public void Update(Genre editedGenre)
        {
            _dbContext.Genres.Update(editedGenre);
            _dbContext.SaveChanges();
        }

        public Genre GetGenre(int id)
        {
            var genre = _dbContext.Genres.Include(_ => _.Songs).Where(s => s.GenreId == id).First();
            _dbContext.Entry(genre).Collection(_ => _.Songs).Load();
            return genre;
        }

        public string GetNameById(int id)
        {
            throw new NotImplementedException();
        }


    }
}
