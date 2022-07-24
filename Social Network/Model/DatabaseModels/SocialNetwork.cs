public class SocialNetwork
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public List<User> Users { get; set; } = new();
    public List<Browser> Browsers { get; set; } = new();
}

