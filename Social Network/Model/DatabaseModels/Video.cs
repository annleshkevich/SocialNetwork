using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Video
{
    [Key]
    public int? Id { get; set; }
    public string Name { get; set; }
    public List<Commentary>? Comments { get; set; }
    [ForeignKey("UserId")]
    public int? UserId { get; set; }
    public User? User { get; set; }
    [ForeignKey("PublicationId")]
    public int? PublicationId { get; set; }
    public Publication? Publication { get; set; }
    [ForeignKey("CommunityId")]
    public int? CommunityId { get; set; }
    public Community? Community { get; set; }
}
