using System.ComponentModel.DataAnnotations.Schema;

[Table("Users")]
public class User : Profile
{
    public string Login { get; set; }
    public string Password { get; set; }
    public SocialNetwork SocialNetwork { get; set; } = new();
}

