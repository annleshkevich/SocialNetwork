using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class City
{
    [Key]
    public int? Id { get; set; }
    public string Name { get; set; }
    [ForeignKey("CountryId")]
    public int? CountryId { get; set; }
    public Country Country { get; set; }
    public List<Profile> Profiles { get; set; } = new();

}

