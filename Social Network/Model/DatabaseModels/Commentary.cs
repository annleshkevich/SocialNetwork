using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Commentary
{
    [Key]
    public int? Id { get; set; }
    public string Description { get; set; }
    [ForeignKey("UserId")]
    public int? UserId { get; set; }
    public User User { get; set; }
    [ForeignKey("PhotoId")]
    public int? PhotoId { get; set; }
    public Photo? Photo { get; set; }
    [ForeignKey("VideoId")]
    public int? VideoId { get; set; }
    public Video? Video { get; set; }
    [ForeignKey("PublicationId")]
    public int? PublicationId { get; set; }
    public Publication? Publication { get; set; }
    public DateTime CreationDate { get; set; }
}

