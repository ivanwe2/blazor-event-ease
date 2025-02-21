namespace EventEase.Services;

public class EventService : IEventService
{
    private List<Event> events =
    [
        new Event{ Id = Guid.NewGuid(), Name = "Corporate Meeting", Date = DateTime.Now.AddDays(10), Location =  "New York" },
        new Event{ Id = Guid.NewGuid(), Name = "Social Gathering", Date = DateTime.Now.AddDays(20), Location = "Los Angeles" },
    ];

    public Task<List<Event>> GetEventsAsync()
    {
        return Task.FromResult(events);
    }

    public Task SaveEventAsync(Event newEvent)
    {
        events.Add(newEvent);
        return Task.CompletedTask;
    }

    public Task DeleteEventAsync(Guid eventId)
    {
        var eventToDelete = events.FirstOrDefault(e => e.Id == eventId);
        if (eventToDelete != null)
        {
            events.Remove(eventToDelete);
        }
        return Task.CompletedTask;
    }
}