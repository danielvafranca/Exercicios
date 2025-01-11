// dotnet new web -o MyRazorPage
1---------------------------------------------------

// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

builder.Services.AddRazorPages(); //1.1 Adicionando suoporte apra paginas razor!!
app.UseHttpsRedirection();
app.UseStaticFiles(); // Para criar a pasta wwwroot (2)

app.UseRouting(); //Auxiliam no Mapeamento das paginas
app.MapRazorPages();
// app.Run();


2 -----------------------------------------------------
2.1 Criar uma pasta wwwroot na raiz doprojeto
2.2 Criar o css dentro da pasta wwwroot