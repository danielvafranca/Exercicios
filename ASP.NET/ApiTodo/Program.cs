using Todo.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();// Adicionamos o serviço
builder.Services.AddDbContext<AppDbContext>();// Fechando automaticamente o banco,(cOMO SE FOSSE  O USING)

var app = builder.Build();

app.MapControllers();

app.Run();
