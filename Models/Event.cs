using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Event
{
    public Guid Id { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [DateAfterToday(ErrorMessage = "Date must be after today.")]
    public DateTime Date { get; set; }

    [Required]
    [StringLength(200, MinimumLength = 5, ErrorMessage = "Location must be between 5 and 200 characters.")]
    public string Location { get; set; } = string.Empty;

    public List<string> Attendees { get; set; } = new List<string>();
}
