//No Home Controller , antes de retornar algo oprecisamos primeiro verificar se existe essa chave requisição.
// 1 - criamos uma nova pasta chamada atributos e criamops uma uma nova classe chamada de ApiKeyAtributes " Para verificar se tem a chave na rteuqisição, verificar se existe essa chave, se tiver, permitimos ou não a passagem do usuário"
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Blog.Attributes;

[AttributeUsage(validOn: AttributeTargets.Class | AttributeTargets.Method)]// Premitir valido na classe ou no método
public class ApiKeyAttribute : Attribute, IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(
        ActionExecutingContext context,
        ActionExecutionDelegate next)
    {
        if (!context.HttpContext.Request.Query.TryGetValue(Configuration.ApiKeyName, out var extractedApiKey))
        {
            context.Result = new ContentResult()
            {
                StatusCode = 401,
                Content = "ApiKey não encontrada"
            };
            return;
        }

        if (!Configuration.ApiKey.Equals(extractedApiKey))
        {
            context.Result = new ContentResult()
            {
                StatusCode = 403,
                Content = "Acesso não autorizado"
            };
            return;
        }

        await next();
    }
}
//Posso chamar essa Api no home controller