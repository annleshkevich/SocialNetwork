using Microsoft.EntityFrameworkCore;
public class ApplicationContext : DbContext
{
    public DbSet<SocialNetwork> SocialNetworks { get; set; } = null!;
    public DbSet<Browser> Browsers { get; set; } = null!;
    public DbSet<Profile> Profiles { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<City> Cities { get; set; } = null!;
    public DbSet<Album> Albums { get; set; } = null!;
    public DbSet<Community> Communities { get; set; } = null!;
    public DbSet<Chat> Chats { get; set; } = null!;
    public DbSet<Message> Messages { get; set; } = null!;
    public DbSet<Playlist> Playlists { get; set; } = null!;
    public DbSet<Music> Musics { get; set; } = null!;
    public DbSet<Publication> Publications { get; set; } = null!;
    public DbSet<Video> Videos { get; set; } = null!;
    public DbSet<Commentary> Comments { get; set; } = null!;
    public DbSet<Photo> Photos { get; set; } = null!;

    public DbSet<Country> Countries { get; set; } = null!;
    public DbSet<Performer> Performers { get; set; } = null!;
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        //Database.EnsureCreated();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //cascade removal
        modelBuilder.Entity<Commentary>()
            .HasOne(p => p.Publication)
            .WithMany(c => c.Comments)
            .OnDelete(DeleteBehavior.Cascade);

        //seed data
        modelBuilder.Entity<Country>().HasData(new Country { Id = 1, Name = "Belarus" });
        modelBuilder.Entity<Performer>().HasData(new Performer{ Id = 1, Name = "Hedgehog" });
    }

}

