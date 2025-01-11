1 Criar uma nova pasta chamada de Pages na raiz do projeto
1.1 Dentro de pages cRIar um diretorio pagina razor. Serao criadas 2 pastas index.cshtml e index.cshtml.cs
index.cshtml.cs>
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet() // receber
        {
        }
        public void Onpost() // enviar
        {
        }
    }
}
1.3 dentro do index.cshtml consigo colocar html e csharp. para usar o c# basta colocar um @ na frente Ex:
@page
@model MyRazorApp.Pages.IndexModel
@{
    @for(var i = 0; i<= 10; i++)
    {
        <p> item @i </p>
    }
}


