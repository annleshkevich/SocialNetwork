public class Browser
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public List<SocialNetwork> SocialNetworks { get; set; } = new();
}

