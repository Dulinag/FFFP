using System.ComponentModel.DataAnnotations;

namespace FFFP.Models
{
    public class Albums
    {
        [Key]
        public int AlbumId { get; set; }
        public string? AlbumName { get; set; }
        public int ReleaseYear { get; set; }
        public int? SingerId { get; set; }

    }
}
