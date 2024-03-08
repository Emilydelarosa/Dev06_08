using System.ComponentModel.DataAnnotations;

namespace Okane.Application;

public class CreateExpenseRequest
{
    [Required]
    [Range(1, 1_000_000)]
    public int Amount { get; set; }
    
    [Required]
    [MaxLength(80)]
    public required string Category { get; set; }
    
    [MaxLength(250)]
    public string? Description { get; set; }
}