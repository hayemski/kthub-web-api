namespace KtHub.Contracts.Authentication;

public record AuthenticationResponse(Guid Id, string Username, string Password, string Email, string Token);
