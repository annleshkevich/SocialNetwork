using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Photo
{
    [Key]
    public int? Id { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
    public List<Commentary> Commentaries { get; set; } = new();
    [ForeignKey("AlbumId")]
    public int? AlbumId { get; set; }
    public Album Album { get; set; }
    [ForeignKey("PublicationId")]
    public int? PublicationId { get; set; }
    public Publication Publication { get; set; } = new();
}
