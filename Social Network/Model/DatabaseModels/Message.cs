using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Message
{
    [Key]
    public int? Id { get; set; }
    public string Desctiption { get; set; }
    [ForeignKey("ChatId")]
    public int? ChatId { get; set; }
    public Chat Chat { get; set; }
    [ForeignKey("UserId")]
    public int? UserId { get; set; }
    public User User { get; set; }

}
