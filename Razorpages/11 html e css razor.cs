wwwroot>css>site.css

// <!DOCTYPE html>
// <html>
// <head>
//     <title>@ViewData["Title"] - My Razor App</title>
    <link href="~/css/site.css" rel="stylesheet" asp-append-version="true" />
// </head>
// <body>
//     <header>
//         <partial name="Shared/NavMenuPartial" />
//     </header>
//     <main>
//         @RenderBody()
//     </main>

// </body>
// </html>

Mas posso criar um css para cada pagina ex:

Abaout.cshtml.css
h1{
    color:red;
}
Ir no layout  e colocar o  <link rel="stylesheet" href="~/MyRazorPage.styles.css"/>

@RenderSection() Cria uma section e renderiza os itens dentro de uma seçao  e eu posso  escolher onde colocar