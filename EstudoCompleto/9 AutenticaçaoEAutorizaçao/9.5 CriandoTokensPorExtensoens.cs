// Criar um model ode extensao na pasta extensions com nome de RoleClaimsExtension. "Pegamnos os roles do usuarios em uma lista de claims
using System.Security.Claims;
using Blog.Models;

namespace Blog.Extensions;

public static class RoleClaimsExtension
{
    public static IEnumerable<Claim> GetClaims(this User user)
    {
        var result = new List<Claim>
        {
            new(ClaimTypes.Name, user.Email)
        };
        result.AddRange(
            user.Roles.Select(role => new Claim(ClaimTypes.Role, role.Slug))
        );
        return result;
    }
}