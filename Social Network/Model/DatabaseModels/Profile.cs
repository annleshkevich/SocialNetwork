using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Profile
{
    [Key]
    public int? Id { get; set; }
    public string? SurName { get; set; }
    public string? Name { get; set; }
    public string? MaidenName { get; set; }
    public int? Age { get; set; }
    public string? Gender { get; set; }
    public string? Education { get; set; }
    public string? Work { get; set; }
    public string? Relationship { get; set; }
    public DateTime? DataOfBirth { get; set; }
    public int? Mobile { get; set; }
    [ForeignKey("CityId")]
    public int CityId { get; set; }
    public City City { get; set; }
    public List<Album> Albums { get; set; } = new();
    public List<Community> Communities { get; set; } = new();
    public List<User> Users { get; set; } = new();
    public List<Chat> Chats { get; set; } = new();
    public List<Playlist> Playlists { get; set; } = new();
    public List<Publication> Publications { get; set; } = new();
    public List<Video> Videos { get; set; } = new();
    public List<Commentary> Commentary { get; set; } = new();
    public List<Message> Messages { get; set; } = new();
}
