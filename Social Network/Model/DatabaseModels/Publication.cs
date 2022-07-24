using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Publication
{
    [Key]
    public int? Id { get; set; }
    public string? Description { get; set; }
    public string? Name { get; set; }
    [ForeignKey("CommunityId")]
    public int? CommunityId { get; set; }
    public Community? Community { get; set; }
    [ForeignKey("UserId")]
    public int? UserId { get; set; }
    public User? User { get; set; }
    public List<Photo> Photos { get; set; } = new();
    public List<Video> Videos { get; set; } = new();
    public List<Music> Musics { get; set; } = new();
    public List<Commentary> Comments { get; set; } = new();
}
