Quero mudar o nome das paginas  ex:
@page "~/Sobre"
@model MyRazorApp.Pages.AboutModel      
<h1>Sobre</h1>
    
Basta colocar @page"~/nome da pagina"

Em vex de usar as rotas como href: 
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

    Utilizamos uma healtag ex:

    
    <ul>
        <li>
            <a asp-page="Home">Home</a>
        </li>
        <li>
            <a asp-page="About">Sobre</a>
        </li>
        <li>
            <a asp-page="Login">Login</a>
        </li>
    </ul>

    Dessa forma meu link nao quebra