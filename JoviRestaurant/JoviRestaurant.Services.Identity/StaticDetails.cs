using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace JoviRestaurant.Services.Identity
{
    public static class StaticDetails
    {
        public const string Admin = "Admin";
        public const string Customer = "Customer";

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile()
            };
        //There are two types of scopes in Identity Server: Identity Scope and Resource scope
        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope> {
                new ApiScope("jovirestaurant","Jovi Restaurant Server"),
                new ApiScope(name: "read", displayName:"Read your data."),
                new ApiScope(name:"write", displayName:"Write your data"),
                new ApiScope(name:"delete", displayName:"Delete your data")
            };

        //Client

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "read", "profile", "write" }
                },
                new Client
                {
                    ClientId = "jovirestaurant",
                    ClientSecrets = { new Secret("secret".Sha256()) },
                    AllowedGrantTypes = GrantTypes.Code,
                    RedirectUris = { "https://localhost:44350/signin-oidc" },
                    PostLogoutRedirectUris={ "https://localhost:44350/signout-callback-oidc" },
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.Profile,
                        "jovirestaurant"
                    }
                }
            };
    }
}