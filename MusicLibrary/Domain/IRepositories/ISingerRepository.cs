using MusicLibrary.Models;

namespace MusicLibrary.Domain.IRepositories
{
    public interface ISingerRepository
    {
        public void Create(Singer singer);
        public void Delete(int id);
        public void Update(Singer editedSinger);

        public string GetNameById(int id);
        public Singer GetSinger(int id);
    }
}
