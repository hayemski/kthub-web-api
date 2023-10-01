using KtHub.Application.Models;

namespace KtHub.Application.Services;

public class AuthenticationService : IAuthenticationService
{ 

    public AuthenticationResult Login(string username, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), username, "email", "token" );
        
    }

    public AuthenticationResult Register(string username, string password, string email)
    {
        return new AuthenticationResult(Guid.NewGuid(), "username", "email" , "token"); 
    }
}

