Quero carregar as categorias pra onde ?

public class IndexModel : PageModel
{
    public List<Category> Categories { get; set; = new();}
    public async Task<IActionResult> OnGet()
    {
        await Task.Delay(5000);
        
    }
    public void Onpost()
    {
    }
}

// public record Category
// (
//     int Id,
//     string Title,
//     decimal Price
// );

2------------------------
Basta criar a spaginas na pastas pages  e na rota colocar o /e a rota ex
pages> about :

@page
@model MyRazorApp.Pages.AboutModel
<html>
<head>
    <title></title>
</head>
<body>
    <div>
        <h1>Sobre</h1>
    </div>
</body>
</html>


https://localhost:44368/about

3-----------------------------------------
OBS Para referenciar uma imagem ou o css  utilize o ~/  ex:
 <ul>
     <li>
         <a href="~/css"></a>
     </li>
 </ul>
Criando menu para navegar
ex No index:

 <ul>
     <li>
         <a href="~/">Home</a>
     </li>
     <li>
         <a href="~/About">Sobre</a>
     </li>
     <li>
         <a href="~/Login">Login</a>
     </li>
 </ul>

4-----------------------------------------------
para reutilizar Com os view parcials Basta criar uma pasta chamada shered
e uma pagina normal chamada NavMenuPartial.cshtml

coloqcar o codigo do home
<ul>
     <li>
         <a href="~/">Home</a>
     </li>
     <li>
         <a href="~/About">Sobre</a>
     </li>
     <li>
         <a href="~/Login">Login</a>
     </li>
 </ul>
5-----------------------------------------------
 e para referenciar  em cada pagina coloque 
  @Html.RenderPartialAsync("Shared/NavMenuPartial")

  ou usar o taghelper
  no index.cshtml colocar:
// @page
// @model MyRazorApp.Pages.IndexModel
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers

e em vez de usar @ html.renderPartiaAsyns usa>>
<partial name="Shared/NavMenuPartial"/>
