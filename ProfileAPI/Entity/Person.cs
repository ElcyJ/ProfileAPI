using System.ComponentModel.DataAnnotations;

namespace ProfileAPI.Entity;

public class Person
{
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public string? Name { get; set; }
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    public string? Phone { get; set; }
}
