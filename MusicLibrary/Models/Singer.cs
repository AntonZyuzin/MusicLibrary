using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models
{
    public class Singer
    {
        [Key]
        public int SingerId { get; set; }
        public string? SingerName { get; set; }
        public virtual List<Song>? Songs { get; set; }
        public virtual List<Album>? Albums { get; set; }
    }
}
