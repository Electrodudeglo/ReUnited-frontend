using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace ReUnited.frontend.Auth
{
    public class MyAuthStateProvider : AuthenticationStateProvider
    {
        private ClaimsPrincipal currentUser = new ClaimsPrincipal(new ClaimsIdentity());

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            return Task.FromResult(new AuthenticationState(currentUser));
        }

        public void MarkUserAsAuthenticated(IEnumerable<Claim> claims)
        {
            var identity = new ClaimsIdentity(claims, "jwt"); // or "supabase"
            currentUser = new ClaimsPrincipal(identity);

            // Notify all components (e.g., AuthorizeView) that the auth state changed
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(currentUser)));
        }
    }
}
