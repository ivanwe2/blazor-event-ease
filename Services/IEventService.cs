namespace EventEase.Services
{
    public interface IEventService
    {
        Task<List<Event>> GetEventsAsync();
        Task SaveEventAsync(Event newEvent);
        Task DeleteEventAsync(Guid eventId);
    }
}