using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Music
{
    [Key]
    public int? Id { get; set; }
    public string Name { get; set; }
    [ForeignKey("PerformerId")]
    public int? PerformerId { get; set; }
    public Performer Performer { get; set; }
    [ForeignKey("PlaylistId")]
    public int? PlaylistId { get; set; }
    public Playlist? Playlist { get; set; }
    [ForeignKey("PublicationId")]
    public int? PublicationId { get; set; }
    public Publication? Publication { get; set; } 

}
