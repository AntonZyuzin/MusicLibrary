namespace MusicLibrary.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string? AlbumName { get; set; }
        public int? SingerId { get; set; }
        public virtual List<Song>? Songs { get; set; }
    }
}
