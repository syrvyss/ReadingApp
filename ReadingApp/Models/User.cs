using Postgrest.Attributes;
using Postgrest.Models;

namespace ReadingApp.Models;

[Table("user")]
public class User : BaseModel
{
    [PrimaryKey("id", false)] public long Id { get; set; }

    [Column("email")] public string Email { get; set; }
}