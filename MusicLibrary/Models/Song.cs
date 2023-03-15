using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }
        public string? SongName { get; set; }
        public int? SingerId { get; set; }
        public int? AlbumId { get; set; }
        public virtual List<Genre>? Genres { get; set; }
    }
}
