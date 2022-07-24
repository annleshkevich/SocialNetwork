using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Album
{
    [Key]
    public int? Id { get; set; }
    public string Name { get; set; }
    public List<Photo> Photos { get; set; } = new();
    [ForeignKey("UserId")]
    public int? UserId { get; set; }
    public User? User { get; set; }
    [ForeignKey("CommunityId")]
    public int? CommunityId { get; set; }
    public Community? Community { get; set; }
}


