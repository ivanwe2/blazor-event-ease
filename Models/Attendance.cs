namespace EventEase.Models;

public class Attendance
{
    public Guid Id { get; set; }
    public Guid EventId { get; set; }
    public string UserName { get; set; }
    public DateTime Timestamp { get; set; }
}