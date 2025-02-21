using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EventEase.Services;

public class UserSessionService : AuthenticationStateProvider
{
    private User currentUser;
    
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var identity = currentUser != null
            ? new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, currentUser.Name.ToString()) }, "apiauth")
            : new ClaimsIdentity();

        var user = new ClaimsPrincipal(identity);
        return Task.FromResult(new AuthenticationState(user));
    }

    public void Login(User user)
    {
        currentUser = user;
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }

    public void Logout()
    {
        currentUser = null;
        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }
}