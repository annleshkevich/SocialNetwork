public class Community
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public List<Album> Albums { get; set; } = new();
    public List<Video> Videos { get; set; } = new();
    public List<Playlist> Playlists { get; set; } = new();
    public List<Publication> Publications { get; set; } = new();
    public List<User> Users { get; set; } = new();
}

