namespace EventEase.Services;

public interface IUserService
{
    Task SaveUserAsync(User newUser);
    Task<List<User>> GetUsersAsync();
}