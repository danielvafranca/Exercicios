Na pasta Shared, criamosa um novo arquivo chamado _layout.cshtml

Esse layout, vai servir de base para outras paginas

Copiamos o layout do index, o codigo html e colamos no no _.cshtmllayout ex:
ex:

<!DOCTYPE html>
<html>
<head>
    <title>My Razor App</title>
</head>
<body>
    <header>
        <partial name="Shared/NavMenuPartial" />
    </header>
    <main>
        @RenderBody()// Vai renderizar o corpo
    </main>

</body>
</html>
</html>
Agora  é sor ir nas pagians home, login e sobre e colocar @{Layout = "Shared/_Layout"}

-----Multiplos layoutss
Posso criar vartiops layouts e escolher qual vou utilizar com

@{
    Layout = "Shared/_Layout";
}

@{
    Layout = null;
}
ou outros



BastA Fazer o  Layout e colocar o RenderBody()