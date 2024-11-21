using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceGamma.Infrastructure.Models;

[Table("Hellos")]
public class HelloDbModel
{
    [Required()]
    public DateTime CreatedAt { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    [Required()]
    public DateTime UpdatedAt { get; set; }
}
