using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.Extensions
{
    public class PermissaoNecessario : IAuthorizationRequirement
    {
        public string Permisao { get; set; }

        public PermissaoNecessario(string permissao)
        {
            Permisao = permissao;
        }
    }

    public class PermissaoNecessariaHandler : AuthorizationHandler<PermissaoNecessario>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissaoNecessario requisito)
        {
            if (context.User.HasClaim(c => c.Type == "Permissao" && c.Value.Contains(requisito.Permisao)))
            {
                context.Succeed(requisito);
            }

            return Task.CompletedTask;
        }
    }
}
