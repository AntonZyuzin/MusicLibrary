using Microsoft.EntityFrameworkCore;
using MusicLibrary.Models;

namespace MusicLibrary.Domain.Data
{
    public class MusicLibraryDbContext : DbContext
    {
        public MusicLibraryDbContext(DbContextOptions options) : base(options)
        {
        }

        public MusicLibraryDbContext()
        {
        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Singer> Singers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sqlServerConnectionStruing = "Server=(localdb)\\mssqllocaldb; Database=MusicLibraryDB; Trusted_Connection=True";
            optionsBuilder.UseSqlServer(sqlServerConnectionStruing);

        }
    }
}
