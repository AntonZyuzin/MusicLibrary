using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string? GenreName { get; set; }
        public virtual List<Song>? Songs { get; set; }
    }
}
