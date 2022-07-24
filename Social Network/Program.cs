using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;

//configuration creation
var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");
var config = builder.Build();
string connectionString = config.GetConnectionString("DefaultConnection");
var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
var options = optionsBuilder.UseSqlServer(connectionString).Options;

using (ApplicationContext db = new(options))
{
    //db.Database.EnsureDeleted();
    //db.Database.EnsureCreated();

    SocialNetwork vk = new() { Name = "VK" };
    db.SocialNetworks.Add(vk);
    Browser google = new() { Name = "Google" };
    db.Browsers.Add(google);
    City pinsk = new() { Name = "Pinsk" };
    db.Cities.Add(pinsk);
    User ira = new() { SurName = "Korzhik", Name = "Ira", Login = "iraK", Password = "123", SocialNetwork = vk, City = pinsk, Education = "Polessu" };
    User vova = new() { SurName = "Grech", Name = "Vova", Login = "vovaGr", Password = "321", SocialNetwork = vk, City = pinsk, Age = 16 };
    db.Users.AddRange(ira, vova);
    Album kittens = new() { Name = "Kittens", User = vova };
    db.Albums.Add(kittens);
    Community motorcycles = new() { Name = "Motorcycles" };
    db.Communities.Add(motorcycles);
    Chat chat = new();
    db.Chats.Add(chat);
    Message message = new() { Desctiption = "hello", Chat = chat, User = vova };
    db.Messages.Add(message);
    Playlist pop = new() { Name = "Pop", User = ira };
    Playlist rok = new() { Name = "Rok", User = vova };
    db.Playlists.AddRange(pop, rok);
    Music sleep = new() { Name = "Sleep", Playlist = pop };
    Music sea = new() { Name = "Sea", Playlist = rok };
    Music summer = new() { Name = "Summer", Playlist = rok };
    db.Musics.AddRange(summer, sea, sleep);
    Publication postMotorcycles = new() { Description = "rock sucks", Community = motorcycles };
    Publication postFromVova = new() { User = vova };
    db.Publications.AddRange(postFromVova, postMotorcycles);
    Photo kittenEats = new() { Description = "Kitten eats", Publication = postFromVova };
    db.Photos.Add(kittenEats);
    Video puppies = new() { Name = "Puppies", User = vova };
    db.Videos.Add(puppies);
    Commentary commentaryFromVova = new() { Description = "who also thinks so, write your address", User = vova, Publication = postMotorcycles };
    Commentary commentaryFromIra = new() { Description = "sweet", User = ira, Publication = postFromVova };
    db.Comments.AddRange(commentaryFromVova, commentaryFromIra);

    //the connection of the many to the many
    vk.Browsers.Add(google);
    ira.Communities.Add(motorcycles);
    ira.Chats.Add(chat);
    ira.Messages.Add(message);
    vova.Users.Add(ira);
    //db.SaveChanges();
    Console.WriteLine("saved");

    Console.WriteLine("\nlist of all comments:");
    var comments = db.Comments.ToList();
    foreach (var commentary in comments) Console.WriteLine(commentary.Description);
    var publ = db.Publications.FirstOrDefault();
    if (publ != null) db.Publications.Remove(publ);
    db.SaveChanges();
    Console.WriteLine("\nlist of comments after a publication is deleted:");
    comments = db.Comments.ToList();
    foreach (var commentary in comments) Console.WriteLine(commentary.Description);

    //stored procedure
    SqlParameter param = new("@SurName", "Korzhik");
    var users = db.Profiles.FromSqlRaw("All users @SurName", param).ToList();
    foreach (var u in users)
        Console.WriteLine($"{u.Name} {u.Education}");

    //view
    var productSuppliers = db.Profiles.ToList();
    foreach (var item in productSuppliers)
        Console.WriteLine($"{item.Name} {item.SurName} {item.Age} {item.Education}");

}
using (ApplicationContext db = new(options))
{
    //Include method
    Console.WriteLine("\nall music:");
    var musics = db.Musics
        .Include(p => p.Playlist)
        .ThenInclude(u => u.User)
        .ToList();
    foreach (var music in musics)
        Console.WriteLine($"{music.Name} - {music.Playlist.Name} - {music.Playlist.User.Name} {music.Playlist.User.SurName}");

}