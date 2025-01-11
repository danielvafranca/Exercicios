var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    return Results.Ok("Hello world");

});

// -Recebendo da url a info
app.MapGet("/{nome}", (string nome) => {
    return Results.Ok($"Hello {nome}");

});
app.MapGet("/banana", () => "Baninha");

app.MapPost("", (User user)=>
{
    return Results.Ok($"Hello {user}");

});
app.Run();
public class User{
    public int Id { get; set; }
    public string UserName { get; set; }
};


