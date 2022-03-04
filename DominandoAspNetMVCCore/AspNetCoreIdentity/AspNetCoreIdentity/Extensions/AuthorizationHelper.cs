using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.Extensions
{
    public class PermissaoNecessaria : IAuthorizationRequirement
    {
        public string Permisao { get; set; }

        public PermissaoNecessaria(string permissao)
        {
            Permisao = permissao;
        }
    }

    public class PermissaoNecessariaHandler : AuthorizationHandler<PermissaoNecessaria>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissaoNecessaria requisito)
        {
            if (context.User.HasClaim(c => c.Type == "Permissao" && c.Value.Contains(requisito.Permisao)))
            {
                context.Succeed(requisito);
            }

            return Task.CompletedTask;
        }
    }
}
