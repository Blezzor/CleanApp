using System.Security.Claims;

namespace CleanApp.Application.Common.Interfaces
{
    public interface IAuthorizationService
    {
        ClaimsPrincipal CurrentUser { get; }
        int UserId { get; }
        string Name { get; }
    }
}
