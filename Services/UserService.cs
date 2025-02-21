namespace EventEase.Services;

public class UserService : IUserService
{
    private List<User> users = new List<User>();

    public Task SaveUserAsync(User newUser)
    {
        users.Add(newUser);
        return Task.CompletedTask;
    }

    public Task<List<User>> GetUsersAsync()
    {
        return Task.FromResult(users);
    }
}